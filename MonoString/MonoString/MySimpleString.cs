using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
//the former 3 lines copy/pasted from game1

namespace MonoString
{
    //make it public
    //my simple string must inherit from drawablegamecomponent
    public class MySimpleString : DrawableGameComponent
    {
        //declare global vars
        private SpriteBatch spriteBatch;
        private SpriteFont font;
        private string message;
        private Vector2 position;
        private Color color;

        //call base class constructor :base(game)
        public MySimpleString(Game game, SpriteBatch spriteBatch, SpriteFont font, string message, Vector2 position, Color color) : base(game)
        {
            //save incoming parameters to local variables below
            this.spriteBatch = spriteBatch;
            this.font = font;
            this.message = message;
            this.position = position;
            this.color = color;

        }

        //if you have drawable game component, you always have to override update and draw
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        //you must do this with drawable game components
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(font, message, position, color);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
