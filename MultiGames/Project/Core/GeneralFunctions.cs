using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;



namespace MultiGames.Project
{
    public static class GeneralFunctions
    {
        public static ContentManager content;
        public static SpriteBatch spriteBatch;
        public static GraphicsDeviceManager graphics;
        public static GraphicsDevice graphicsDevice;

        public static GameTime gameTime;
        public static Vector2 ScreenSize;

        public static void Update(GameTime _gameTime)
        {
            gameTime = _gameTime;
            ScreenSize = new Vector2(graphicsDevice.Viewport.Width, graphicsDevice.Viewport.Height);
        }


        public static void Init(ContentManager _content, SpriteBatch _spriteBatch, GraphicsDeviceManager _graphics, GraphicsDevice _graphicsDevice)
        {
            content = _content;
            spriteBatch = _spriteBatch;
            graphics = _graphics;
            graphicsDevice = _graphicsDevice;
        }
            
        public static void SetWindowSize(int _width, int _height)
        {
            graphics.PreferredBackBufferWidth = _width;
            graphics.PreferredBackBufferHeight = _height;
            graphics.ApplyChanges();
        }
    }
}
