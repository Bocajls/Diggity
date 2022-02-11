using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Diggidy
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Dictionary<int, (string Name, Texture2D Texture)> _sprites;

        public Game()
        {
            _graphics = new GraphicsDeviceManager(this);
            _sprites = new Dictionary<int, (string Name, Texture2D Texture)>();
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            int _worldWidth = 2000; /* DELETE AGAIN - Example of world width */
            int _worldHeight = 500000;  /* DELETE AGAIN - Example of world height */
            var World = new byte[_worldWidth, _worldHeight];  /* DELETE AGAIN - Example of world */
            var Trail = new bool[_worldWidth, _worldHeight];  /* DELETE AGAIN - Example of trail */

            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: Add your content loading here

            _sprites.Add(0, ("Air", Content.Load<Texture2D>("Graphics/Blocks/M_AirBlock")));
        }

        protected override void Update(GameTime gameTime)
        {
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

            _spriteBatch.Draw(_sprites[0].Texture, new Vector2(0,0), Color.White); /* DELETE AGAIN - Example of drawing AirBlock */

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}