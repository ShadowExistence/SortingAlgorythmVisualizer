using Algorithm_visualizer.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Threading;

namespace Algorithm_visualizer
{
    class SortingAlgo 
    {
        private SpriteBatch spriteBatch { get; set; }
        private GraphicsDeviceManager graphics { get; set; }
        public MySprite sprite { get; set; }
        public int[] MainArray { get; set; }


        public SortingAlgo(SpriteBatch spriteBatch, MySprite sprite, GraphicsDeviceManager graphics, int[] MainArray )
        {
            this.spriteBatch = spriteBatch;
            this.sprite = sprite;
            this.graphics = graphics;
            this.MainArray = MainArray;
        }


        public void VisualizeArray(int[] MainArray)
        {

            for (int i = 0; i < MainArray.Length; i++)
            {
                sprite.Draw(new Vector2(i * 40 + 20, -10), spriteBatch, new Rectangle(i * 40 + 30, 0, 30, MainArray[i] * 8));
            }

        }

        public void Sorting( GameTime gameTime)
        {
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

                        //Draw(gameTime);
                        graphics.EndDraw();
                        Thread.Sleep(100);
                    }
                }
            }
        }

        //public override void Draw(GameTime gameTime)
        //{
        //    graphics.GraphicsDevice.Clear(Color.Black);
        //    spriteBatch.Begin();
        //    VisualizeArray(MainArray);
        //    spriteBatch.End();
        //}
    }
}
