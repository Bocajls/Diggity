﻿using Diggity.Project.Concrete.StaticRepositories;
using Diggity.Project.Context;
using Diggity.Project.Models.Concrete;
using Diggity.Project.Models.Concrete.Blocks;
using Diggity.Project.Models.Concrete.Grids;
using Diggity.Project.Models.Concrete.PlayerShipComponents;
using Diggity.Project.Models.Concrete.StaticRepositories;
using Diggity.Project.Models.Enums;
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
        private static readonly int _pixels = 64; 

        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private WorldInteractionsRepository interactions;
        private WorldElementsRepository blocks;
        private GameItemsRepository items;
        private ContextHandler context;
        private World world;

        // private ItemSpriteRepository _items;

        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            blocks = new WorldElementsRepository(Content);
            items = new GameItemsRepository(Content);
            context = new ContextHandler();

            var _blocksWide = (GraphicsDevice.DisplayMode.Width - (GraphicsDevice.DisplayMode.Width % _pixels)) / _pixels;
            var _blocksHigh = (GraphicsDevice.DisplayMode.Height - (GraphicsDevice.DisplayMode.Height % _pixels)) / _pixels;

            _blocksWide -= _blocksWide % 2;
            _blocksHigh -= _blocksHigh % 2;

            Window.Title = $"{GameTitle} {GameVersion}";
            graphics.PreferredBackBufferWidth = _blocksWide * _pixels;
            graphics.PreferredBackBufferHeight = _blocksHigh * _pixels;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();

            interactions = new WorldInteractionsRepository();

            world = context.LoadWorld();

            if(world is null)
            {
                world = CreateNewWorld(_blocksWide, _blocksHigh);
            }

            // TODO: Add your initialization logic here

            base.Initialize();
        }

        private World CreateNewWorld(int _blocksWide, int _blocksHigh)
        {
            var player = new Player(
                Engine: new Engine(items[3].type as Engine),
                Hull: new Hull(items[1].type as Hull),
                Drill: new Drill(items[2].type as Drill),
                Inventory: new Inventory(ID: 100, new Grid(ID: 99, new Vector2(0, 0), new GridBox[3, 3]), SizeLimit: 576, Name: "Starter Inventory", Worth: 10, Weight: 0),
                Thruster: new Thruster(items[5].type as Thruster),
                FuelTank: new FuelTank(items[4].type as FuelTank)
            )
            {
                Coordinates = new Vector2((float)Math.Floor(_blocksWide / 2.0d), (float)Math.Floor(_blocksHigh / 2.0d))
            };

            var createdWorldRender = new Dictionary<Vector2, Vector2>();
            
            for (var x = 0; x <= _blocksWide; x++)
            {
                for (var y = 0; y <= _blocksHigh; y++)
                {
                    createdWorldRender.Add(new Vector2(x, y), new Vector2(x, y));
                }
            }

            return new World(
                Player: player,                                  // ContextHandler.LoadPlayer();
                Buildings: null,                                 // ContextHandler.LoadBuildings();
                BlocksWide: _blocksWide,                         // Calculated
                BlocksHigh: _blocksHigh,                         // Calculated
                WorldRender: createdWorldRender,                 // Dynamically updated
                WorldTrails: new Dictionary<Vector2, bool>()     // ContextHandler.LoadWorldTrails();
            );
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState state = Keyboard.GetState();

            var location = world.WorldRender[new Vector2(world.Player.Coordinates.X, world.Player.Coordinates.Y)];

            Vector2 direction = new Vector2(0, 0);
            if (state.IsKeyDown(Keys.Up))
            {
                direction = new Vector2(direction.X, -1);
            }
            else if (state.IsKeyDown(Keys.Down))
            {
                direction = new Vector2(direction.X, 1);
            }
            else if (state.IsKeyDown(Keys.Left))
            {
                direction = new Vector2(-1, direction.Y);
            }
            else if (state.IsKeyDown(Keys.Right))
            {
                direction = new Vector2(1, direction.Y);
            }
            world.Player.Direction = direction;

            Vector2 nextBlockVector = new Vector2(location.X + direction.X, location.Y + direction.Y);
            Block nextBlock         = GetWorldBlock(nextBlockVector.X, nextBlockVector.Y).Value.Block;

            world.Player.UpdateVelocity(direction);
            world.Player.UpdateOffset();

            float halfSize = _pixels / 2.0f;
            if(!Obstructed(nextBlock, nextBlockVector))
            {
                // Right
                if (world.Player.XOffset > halfSize)
                {
                    float xmoves = (float)Math.Floor(world.Player.XOffset / halfSize);
                    var offset = -1 * world.Player.XOffset % halfSize + halfSize;
                    world.Player.XOffset = -1 * offset + world.Player.XVelocity;

                    var counter = 0;
                    while (++counter < xmoves)
                    {
                        nextBlock = GetWorldBlock(location.X + counter, location.Y).Value.Block;
                        nextBlockVector = new Vector2(location.X + counter, location.Y);
                        if (Obstructed(nextBlock, nextBlockVector))
                        {
                            break;
                        }
                    }

                    MoveScreen(direction.X * counter, direction.Y);

                }
                // Left
                else if (world.Player.XOffset < -1 * halfSize)
                {
                    var absolute = Math.Abs((float)world.Player.XOffset);
                    float xmoves = (float)Math.Floor(absolute / halfSize);
                    var offset = 1 * world.Player.XOffset % halfSize;
                    world.Player.XOffset = +1 * offset + halfSize + world.Player.XVelocity;

                    var counter = 0;
                    while (++counter < xmoves)
                    {
                        nextBlock = GetWorldBlock(location.X - counter, location.Y).Value.Block;
                        nextBlockVector = new Vector2(location.X - counter, location.Y);
                        if (Obstructed(nextBlock, nextBlockVector))
                        {
                            break;
                        }
                    }

                    MoveScreen(direction.X * counter, direction.Y);
                }
                // Down 
                else if (world.Player.YOffset > halfSize)
                {
                    float ymoves = (float)Math.Floor(world.Player.YOffset / halfSize);
                    var offset = -1 * world.Player.YOffset % halfSize + halfSize;
                    world.Player.YOffset = -1 * offset + world.Player.YVelocity;

                    var counter = 0;
                    while (++counter < ymoves)
                    {
                        nextBlock = GetWorldBlock(location.X, location.Y + counter).Value.Block;
                        nextBlockVector = new Vector2(location.X, location.Y + counter);
                        if (Obstructed(nextBlock, nextBlockVector))
                        {
                            break;
                        }
                    }

                    MoveScreen(direction.X, direction.Y * counter);
                }
                // Up 
                else if (world.Player.YOffset < -1 * halfSize)
                {
                    var absolute = Math.Abs((float)world.Player.YOffset);
                    float ymoves = (float)Math.Floor(absolute / halfSize);
                    var offset = 1 * world.Player.YOffset % halfSize;
                    world.Player.YOffset = +1 * offset + halfSize + world.Player.YVelocity;

                    var counter = 0;
                    while (++counter < ymoves)
                    {
                        nextBlock = GetWorldBlock(location.X, location.Y - counter).Value.Block;
                        nextBlockVector = new Vector2(location.X, location.Y - counter);
                        if (Obstructed(nextBlock, nextBlockVector))
                        {
                            break;
                        }

                    }

                    MoveScreen(direction.X, direction.Y * counter);
                }
            }

            world.Player.Mining = false;
            if (Obstructed(nextBlock, nextBlockVector))
            {
                world.Player.Mining = true;
                world.Player.ResetOffset();
                //world.Player.ResetVelocity();
                DealDamageToBlock(nextBlockVector.X, nextBlockVector.Y);
                if(!Obstructed(nextBlock, nextBlockVector) && world.Player.MaximumActiveVelocity >= halfSize)
                {
                    MoveScreen(direction.X, direction.Y);
                }
            }

            if (state.IsKeyDown(Keys.LeftControl) && state.IsKeyDown(Keys.S))
            {
                context.SaveWorld(world);
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            spriteBatch.Begin();

            DrawRenderedWorld();
            //DrawRenderedBuildings();
            DrawPlayerShip();
            DrawStatistics();

            spriteBatch.End();

            base.Draw(gameTime);
        }

        private void DrawStatistics()
        {
            var font = Content.Load<SpriteFont>("Fonts/text");
            var first = world.WorldRender.OrderBy(x => x.Key.X).OrderBy(x => x.Key.Y).FirstOrDefault();
            spriteBatch.DrawString(font, $"Offset: X: {first.Value.X}, Y: {first.Value.Y}", new Vector2(5, 5), Color.Black);
        }

        private void DrawRenderedWorld()
        {
            foreach (var pair in world.WorldRender)
            {
                var XOffset = world.Player.XOffset;
                var YOffset = world.Player.YOffset;

                var location = new Vector2((pair.Key.X * _pixels) - (XOffset), (pair.Key.Y * _pixels) - (YOffset));

                if (world.WorldTrails.ContainsKey(pair.Value))
                {
                    spriteBatch.Draw(blocks.Where(x => x.Key == -1).FirstOrDefault().Value.Texture, location, Color.White);
                }
                else
                {
                    spriteBatch.Draw(GetWorldBlock(pair.Value.X, pair.Value.Y).Value.Texture, location, Color.White);
                }
            }
        }
        
        private void DrawPlayerShip()
        {
            Vector2 PlayerPosition = new Vector2(
                GetCenterScreenCoordinates().X,
                GetCenterScreenCoordinates().Y
            );

            var orientation = world.Player.Orientation;
            var mining = world.Player.Mining;
            var drill = items[world.Player.Drill.ID];
            var hull  = items[world.Player.Hull.ID];

            if (orientation.Equals(EOrientation.Base))
            {
                spriteBatch.Draw(hull.Textures[EOrientation.Base], PlayerPosition, Color.White);
            }
            else
            {
                if (mining)
                {
                    var drillPositionX = GetCenterScreenCoordinates().X + (world.Player.Direction.X * _pixels);
                    var drillPositionY = GetCenterScreenCoordinates().Y + (world.Player.Direction.Y * _pixels);
                    
                    spriteBatch.Draw(drill.Textures[orientation], new Vector2(drillPositionX, drillPositionY), Color.White);

                    spriteBatch.Draw(hull.Textures[orientation], PlayerPosition, Color.White);
                }
                else
                {
                    // draw thrusters
                    spriteBatch.Draw(hull.Textures[EOrientation.Base], PlayerPosition, Color.White);
                }
            }
        }

        private Vector2 GetCenterScreenCoordinates()
        {
            return new Vector2(
                (float)(graphics.PreferredBackBufferWidth / 2.0),
                (float)(graphics.PreferredBackBufferHeight / 2.0)
            );
        }

        private void DealDamageToBlock(float x, float y)
        {
            var vector = new Vector2(x, y);
            var block = GetWorldBlock(x, y).Value.Block as Block;

            if (interactions.ContainsKey(vector) == false)
            {
                block.OnBlockDestroyed += (sender, e) => OnBlockDestroyed(sender as Block, e, vector);
                interactions.Add(vector, block);
            }

            interactions[vector].TakeDamage(world.Player.Drill.Hardness);
        }

        private void OnBlockDestroyed(Block block, EventArgs e, Vector2 location)
        {
            world.WorldTrails.Add(location, true);
        }

        private KeyValuePair<int, (string Name, Texture2D Texture, Block Block)> GetWorldBlock(float x, float y)
        {
            var simplex = (float)SimplexNoise.Singleton.Noise01(x, y) * 100.0f;

            foreach (var block in blocks.OrderByDescending(x => x.Key))
            {
                var info = block.Value.block.Info;

                if (y > info.MaximumDepth || y < info.MinimumDepth)
                {
                    continue;
                }

                if (simplex >= info.OccurrenceSpan.X && simplex <= info.OccurrenceSpan.Y)
                {
                    return new KeyValuePair<int, (string Name, Texture2D Texture, Block Block)>
                        (
                            block.Key,
                            (
                                block.Value.Name,
                                block.Value.Texture,
                                new Block(block.Value.block)
                            )
                        );
                }
            }

            return new KeyValuePair<int, (string Name, Texture2D Texture, Block Block)>(-1, (null, null, null));
        }

        private bool Obstructed(Block block, Vector2 nextBlock)
        {
            if (block.Ethereal || world.WorldTrails.ContainsKey(nextBlock))
            {
                return false;
            }
            return true;
        }
        
        private void MoveScreen(float x, float y)
        {
            var updated = new Dictionary<Vector2, Vector2>();

            foreach(var block in world.WorldRender)
            {
                updated.Add(new Vector2(block.Key.X, block.Key.Y), new Vector2(block.Value.X + x, block.Value.Y + y));
            }

            world.WorldRender = updated;
        }
    }
}