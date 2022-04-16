using System;
using System.Collections.Generic;
using System.Text;

using MultiGames.Project.Menu;

namespace MultiGames.Project
{
    class GameManager
    {
        MainMenu menu;

        public GameManager()
        {
            menu = new MainMenu();
        }

        public void Load()
        {
            FontManager.AddFont("Default", "Default");


            menu.Load();
        }

        public void Update()
        {
            menu.Update();
        }

        public void Draw()
        {
            menu.Draw();
        }
    }
}
