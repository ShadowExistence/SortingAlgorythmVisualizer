using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Algorithm_visualizer.Content
{
    public class MySprite
    {
        static Vector2 WorldOrigin = new Vector2(0, 480);

        public Texture2D Texture { get; set; }
        public Vector2 Origin { get; set; }

        public MySprite(Texture2D texture)
        {
            Texture = texture;
            
        }

        public void SetTexture(Texture2D texture)
        {
            Texture = texture;
        }

        public void Draw(Vector2 position, SpriteBatch spriteBatch, Rectangle rectangle)
        {
            Origin = new Vector2(0, rectangle.Height);
            spriteBatch.Draw(Texture, WorldOrigin + position - Origin, rectangle, Color.White);
        }
    }
}
