using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MultiGames.Project;


namespace MultiGames
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private GameManager gameManager;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }


        protected override void Initialize()
        {
            gameManager = new GameManager();
            base.Initialize();
        }


        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            GeneralFunctions.Init(Content, _spriteBatch, _graphics, GraphicsDevice);
            gameManager.Load();
        }


        protected override void Update(GameTime gameTime)
        {
            GeneralFunctions.Update(gameTime);
            gameManager.Update();
            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();
            gameManager.Draw();
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
