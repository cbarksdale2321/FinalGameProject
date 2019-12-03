using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGame
{
    class Map
    {
        public int tileWidth;
        public int tileHeight;
        private int width;
        private int height;

        public Map(int ptileWidth, int ptileHeight, int pwidth, int pheight)
        {
            tileWidth = ptileWidth;
            tileHeight = ptileHeight;
            width = pwidth;
            height = pheight;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Vector2 tilePosition = Vector2.Zero;

            spriteBatch.Begin();

            for (int w = 0; w < width; w++ )
            {
                for (int h = 0; h < height; h++)
                {
                    spriteBatch.FillRectangle(tilePosition, new Size2(tileWidth, tileHeight), Color.Black);
                    spriteBatch.FillRectangle(tilePosition + new Vector2(3,1), new Size2(tileWidth - 2, tileHeight - 2), Color.White);
                    tilePosition.Y += tileHeight;
                }
                tilePosition.Y = 0;
                tilePosition.X += tileWidth;
            }
            spriteBatch.End();
        }

    }
}
