using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGame.ScreenScripts
{
    class IntroScreen : GameScreen
    {
        Texture2D image;
        string path;
        public override void LoadContent()
        {
            base.LoadContent();
            path = "Intro Screen";
            //image = content.Load<Texture2D>(path);
        }
        public override void UnloadContent()
        {

        }
        public override void Update(GameTime gameTime)
        {


        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(image, Vector2.Zero, Color.White);

        }
    }
}
