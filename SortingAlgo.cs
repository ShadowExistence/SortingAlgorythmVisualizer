using Algorithm_visualizer.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Threading;
using System.Diagnostics;

namespace Algorithm_visualizer
{
    class SortingAlgo : IDrawable
    {
        private SpriteBatch spriteBatch { get; set; }
        private GraphicsDeviceManager graphics { get; set; }
        public MySprite sprite { get; set; }
        private int[] MainArray { get; set; }
        public int DrawOrder => 1;

        public bool Visible => true;

        public SortingAlgo(SpriteBatch spriteBatch, MySprite sprite, GraphicsDeviceManager graphics)
        {
            this.spriteBatch = spriteBatch;
            this.sprite = sprite;
            this.graphics = graphics;
        }

        public event EventHandler<EventArgs> DrawOrderChanged;
        public event EventHandler<EventArgs> VisibleChanged;

        public void VisualizeArray(int[] MainArray)
        {

            for (int i = 0; i < MainArray.Length; i++)
            {
                sprite.Draw(new Vector2(i * 40 + 20, -10), spriteBatch, new Rectangle(i * 40 + 30, 0, 30, MainArray[i] * 8));
            }

        }

        public void Sorting(int[] MainArray, GameTime gameTime)
        {
            this.MainArray = MainArray;
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
                        graphics.BeginDraw(); // This bool has to be there other ways draw doesn't work lol
                        Draw(null);
                        graphics.EndDraw();
                        Thread.Sleep(100);
                    }
                }
            }
        }

        public void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            VisualizeArray(MainArray);
            spriteBatch.End();
        }
    }
}
