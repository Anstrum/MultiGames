using System;
using System.Collections.Generic;
using System.Text;

using MultiGames.Project.Menu;

namespace MultiGames.Project
{
    class GameManager
    {
        MainMenu menu;
        GameState gameState;
        public GameManager()
        {
            gameState = GameState.Menu;
            menu = new MainMenu();
        }

        public void Load()
        {
            GeneralFunctions.SetWindowSize(1000, 800);
            FontManager.AddFont("Default", "Default");

            menu.Load();
        }

        public void Update()
        {
            switch(gameState)
            {
                case GameState.Menu:
                    menu.Update();
                    break;
                case GameState.Game:
                    break;
                case GameState.Options:
                    break;
                case GameState.Credits:
                    break;
                default:
                    throw new Exception("GameState is Broken");
            }
        }

        public void Draw()
        {
            switch (gameState)
            {
                case GameState.Menu:
                    menu.Draw();
                    break;
                case GameState.Game:
                    break;
                case GameState.Options:
                    break;
                case GameState.Credits:
                    break;
                default:
                    throw new Exception("GameState is Broken");
            }
        }
    }
}
