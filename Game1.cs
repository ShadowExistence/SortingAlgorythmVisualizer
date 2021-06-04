using Algorithm_visualizer.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;
using System.Threading;

namespace Algorithm_visualizer
{
    class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Texture2D rectangleBackground;
        private MySprite sprite;
        private SortingAlgo sortingalgo;
        int[] MainArray;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            MainArray = new int[] { 20,30,10,5,50,32,25,19,32,5,46 };

            

            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            rectangleBackground = Content.Load<Texture2D>("rectangleBackground");

            sprite = new MySprite(rectangleBackground);
            sortingalgo = new SortingAlgo(spriteBatch, sprite, graphics, MainArray);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.Enter))
            {
                Debug.WriteLine("The key works");
                int temp;
                for (int j = 0; j <= MainArray.Length - 2; j++)
                {
                    for (int i = 0; i <= MainArray.Length - 2; i++)
                    {
                        if (MainArray[i] > MainArray[i + 1])
                        {
                            temp = MainArray[i + 1];
                            MainArray[i + 1] = MainArray[i];
                            MainArray[i] = temp;

                            Draw(gameTime);
                            EndDraw();
                            Thread.Sleep(100);
                        }
                    }
                }

            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            sortingalgo.VisualizeArray(MainArray);
            spriteBatch.End();

            // TODO: Add your drawing code here
            
            base.Draw(gameTime);
        }
    }
}
