using Diggity.Project.Concrete.StaticRepositories;
using Diggity.Project.Models.Abstract.Blocks;
using Diggity.Project.Models.Concrete;
using Diggity.Project.Models.Concrete.Blocks;
using Diggity.Project.Models.Concrete.PlayerShipComponents;
using Diggity.Project.Models.Concrete.StaticRepositories;
using Diggity.Project.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Diggity
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        private static readonly string GameTitle = "Diggity";
        private static readonly string GameVersion = "V0.02";

        private const int _pixels = 64; 
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private WorldInteractionsRepository _interactions;
        private WorldElementsRepository _blocks;
        private GameItemsRepository _items;

        private static World _world;

        // private ItemSpriteRepository _items;

        public Game()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _blocks = new WorldElementsRepository(Content);
            _items = new GameItemsRepository(Content);
            _interactions = new WorldInteractionsRepository();

            var _blocksWide = (GraphicsDevice.DisplayMode.Width - (GraphicsDevice.DisplayMode.Width % _pixels)) / _pixels;
            var _blocksHigh = (GraphicsDevice.DisplayMode.Height - (GraphicsDevice.DisplayMode.Height % _pixels)) / _pixels;

            _blocksWide -= _blocksWide % 2;
            _blocksHigh -= _blocksHigh % 2;

            Window.Title = $"{GameTitle} {GameVersion}";
            _graphics.PreferredBackBufferWidth = _blocksWide * _pixels;
            _graphics.PreferredBackBufferHeight = _blocksHigh * _pixels;
            _graphics.IsFullScreen = false;
            _graphics.ApplyChanges();

            var player = new Player()
            {
                Cash = 0,
                Drill = _items[2].type as Drill,
                Engine = null,
                FuelTank = null,
                Hull = null,
                Inventory = null,
                Thruster = null,
                Velocity = new Vector2(0, 0),
                Coordinates = new Vector2((float)Math.Floor(_blocksWide / 2.0d), (float)Math.Floor(_blocksHigh / 2.0d))
            };

            _world = new World(
                Player: player,                                  // ContextHandler.LoadPlayer();
                Buildings: null,                                 // ContextHandler.LoadBuildings();
                BlocksWide: _blocksWide,                         // Calculated
                BlocksHigh: _blocksHigh,                         // Calculated
                WorldRender: new Dictionary<Vector2, Vector2>(), // Dynamically generated
                WorldTrails: new Dictionary<Vector2, bool>()     // ContextHandler.LoadWorldTrails();
            );

            /* START OF DUMMY CODE */
            for (var x = 0; x <= _world.BlocksWide; x++)
                for (var y = 0; y <= _world.BlocksHigh; y++)
                    _world.WorldRender.Add(new Vector2(x, y), new Vector2(x, y));
            /* END OF DUMMY CODE */

            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            MouseState mouseState = Mouse.GetState();
            KeyboardState state = Keyboard.GetState();

            var location = _world.WorldRender[new Vector2(_world.Player.Coordinates.X, _world.Player.Coordinates.Y)];

            Vector2 direction = new Vector2(0,0);
            Vector2 nextBlock = new Vector2(0, 0);

            if (state.IsKeyDown(Keys.Up))
            {
                direction = new Vector2(0, -1);
                nextBlock = new Vector2(location.X, location.Y - 1);
            }
            else if (state.IsKeyDown(Keys.Down))
            {
                direction = new Vector2(0, 1);
                nextBlock = new Vector2(location.X, location.Y + 1);
            }
            else if (state.IsKeyDown(Keys.Left))
            {
                direction = new Vector2(-1, 0);
                nextBlock = new Vector2(location.X - 1, location.Y);
            }
            else if (state.IsKeyDown(Keys.Right))
            {
                direction = new Vector2(1, 0);
                nextBlock = new Vector2(location.X + 1, location.Y);
            }

            if (GetWorldBlock(nextBlock.X, nextBlock.Y).Value.Block.Ethereal || _world.WorldTrails.ContainsKey(nextBlock))
            {
                MoveScreen(direction.X, direction.Y);
            }
            else
            {
                DealDamageToBlock(nextBlock.X, nextBlock.Y);
            }


            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            
            _spriteBatch.Begin();

            DrawRenderedWorld();
            //DrawRenderedBuildings();
            DrawPlayerShip();
            DrawStatistics();

            _spriteBatch.End();

            base.Draw(gameTime);
        }

        private void DrawStatistics()
        {
            var font = Content.Load<SpriteFont>("Fonts/text");
            var first = _world.WorldRender.OrderBy(x => x.Key.X).OrderBy(x => x.Key.Y).FirstOrDefault();
            _spriteBatch.DrawString(font, $"Offset: X: {first.Value.X}, Y: {first.Value.Y}", new Vector2(5, 5), Color.Black);
        }
        private void DrawRenderedWorld()
        {
            foreach (var pair in _world.WorldRender)
            {
                var location = new Vector2(pair.Key.X * _pixels, pair.Key.Y * _pixels);

                if (_world.WorldTrails.ContainsKey(pair.Value))
                {
                    _spriteBatch.Draw(_blocks.Where(x => x.Key == -1).FirstOrDefault().Value.Texture, location, Color.White);
                }
                else
                {
                    _spriteBatch.Draw(GetWorldBlock(pair.Value.X, pair.Value.Y).Value.Texture, location, Color.White);
                }

                _spriteBatch.DrawString(Content.Load<SpriteFont>("Fonts/text"), $"{GetWorldBlock(pair.Value.X, pair.Value.Y).Value.Block.Ethereal}", location, Color.Black);
            }
        }
        private void DrawPlayerShip()
        {
            Vector2 PlayerPosition = new Vector2(
                GetCenterScreenCoordinates().X,
                GetCenterScreenCoordinates().Y
            );

            _spriteBatch.Draw(_items[1].Texture, PlayerPosition, Color.White);
        }

        private Vector2 GetCenterScreenCoordinates()
        {
            return new Vector2(
                (float)(_graphics.PreferredBackBufferWidth / 2.0),
                (float)(_graphics.PreferredBackBufferHeight / 2.0)
            );
        }

        private void DealDamageToBlock(float x, float y)
        {
            var vector = new Vector2(x, y);
            var block = GetWorldBlock(x, y).Value.Block as Block;

            if (_interactions.ContainsKey(vector) == false)
            {
                block.OnBlockDestroyed += (sender, e) => OnBlockDestroyed(sender as Block, e, vector);
                _interactions.Add(vector, block);
            }

            _interactions[vector].TakeDamage(_world.Player.Drill.Hardness);
        }

        private void OnBlockDestroyed(Block block, EventArgs e, Vector2 location)
        {
            _world.WorldTrails.Add(location, true);
        }

        private KeyValuePair<int, (string Name, Texture2D Texture, IBlock Block)> GetWorldBlock(float x, float y)
        {
            var simplex = (float)SimplexNoise.Singleton.Noise01(x, y) * 10.0f;

            foreach (var block in _blocks.OrderByDescending(x => x.Value.block.Info.MinimumDepth))
            {
                var info = block.Value.block.Info;

                if (y > info.MaximumDepth || y < info.MinimumDepth)
                {
                    continue;
                }

                if (simplex >= info.OccurrenceSpan.X && simplex <= info.OccurrenceSpan.Y)
                {
                    var copy = new KeyValuePair<int, (string Name, Texture2D Texture, IBlock Block)>(block.Key, (block.Value.Name, block.Value.Texture, ObjectExtensions.CreateDeepCopy<Block>(block.Value.block as Block)));
                    return block;
                }
            }

            return new KeyValuePair<int, (string Name, Texture2D Texture, IBlock Block)>(-1, (null, null, null));
        }

        private void MoveScreen(float x, float y)
        {
            var updated = new Dictionary<Vector2, Vector2>();

            foreach(var block in _world.WorldRender)
            {
                updated.Add(new Vector2(block.Key.X, block.Key.Y), new Vector2(block.Value.X + x, block.Value.Y + y));
            }

            _world.WorldRender = updated;
        }
    }
}