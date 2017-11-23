using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoStringPractice
{
    public class SimpleString : DrawableGameComponent
    {
        private SpriteBatch spriteBatch;
        private SpriteFont font;
        private string message;
        private Vector2 position;
        private Color color;

        public SimpleString(Game game, SpriteBatch spriteBatch, SpriteFont font, string message, Vector2 position, Color color) : base(game)
        {
            this.spriteBatch = spriteBatch;
            this.font = font;
            this.message = message;
            this.position = position;
            this.color = color;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(font, message, position, color);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
