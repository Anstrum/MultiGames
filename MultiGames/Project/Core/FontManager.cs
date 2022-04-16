using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework.Graphics;

namespace MultiGames.Project
{
    static class FontManager
    {
        private static List<Font> FontList = new List<Font>();
        private const string FONTPATH = "Fonts/";
        public static void AddFont(string _fileName, string _fontName)
        {
            SpriteFont font = GeneralFunctions.content.Load<SpriteFont>(FONTPATH + _fileName);
            FontList.Add(new Font(_fontName, font));
        }

        public static Font GetFont(string _fontName)
        {
            foreach(Font font in FontList)
            {
                if(font.name == _fontName)
                {
                    return font;
                }
            }
            return FontList[0];
        }
    }
}
