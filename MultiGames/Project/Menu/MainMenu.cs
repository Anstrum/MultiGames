using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
namespace MultiGames.Project.Menu
{
    class MainMenu
    {



        public MainMenu()
        {

        }


        public void Load()
        {
            FontManager.AddFont("MenuTitle", "MenuTitle");
        }

        public void Update()
        {

        }

        public void Draw()
        {
            SpriteFont menuTitle = FontManager.GetFont("MenuTitle");
            Vector2 size = menuTitle.MeasureString("Multi Games");
            GeneralFunctions.spriteBatch.DrawString(menuTitle, "Multi Games", new Vector2(GeneralFunctions.ScreenSize.X / 2 - size.X / 2,size.Y), Color.CornflowerBlue);
        }
    }
}
