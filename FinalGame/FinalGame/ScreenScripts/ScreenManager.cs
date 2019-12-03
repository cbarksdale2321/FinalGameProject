using FinalGame.ScreenScripts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGame
{
    class ScreenManager
    {
        private static ScreenManager instance;
        public ContentManager Content { get; private set; }

        public Vector2 dimensions { get;  private set; }

        GameScreen currentScreen;
        
        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScreenManager();
                return instance;
            }
            

        }

        public ScreenManager()
        {
            dimensions = new Vector2(640, 480);
            currentScreen = new IntroScreen();
        }
        
        public void LoadContent(ContentManager Content)
        {
            this.Content = new ContentManager(Content.ServiceProvider, "Content");

            currentScreen.LoadContent();


        }
        public void UnloadContent()
        {
            currentScreen.UnloadContent();
        }
        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);

        }

    }
}
