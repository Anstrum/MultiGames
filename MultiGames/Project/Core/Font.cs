using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework.Graphics;

namespace MultiGames.Project
{
    class Font
    {
        public string name { get; private set; }
        public SpriteFont font { get; private set; }
        public Font(string _name, SpriteFont _font)
        {
            name = _name;
            font = _font;
        }
    }
}
