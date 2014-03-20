using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame10
{
    class Mole
    {
        public Mole(Rectangle rectangle)
        {
            //field = rectangle;
            //rec = new Rectangle(field.X,field.Y+field.Height/7*6,field.Width/7,field.Height/7);
            field = new Rectangle(0,0,700,700);
            rec = new Rectangle(0, 780, 70, 70);
        }
        Texture2D mole_right;
        Texture2D mole_left;

        public Rectangle field;
        public Rectangle rec;
        public int posX=0;
        public int posY=6;
        public bool movingDown = false;
        public bool movingUp = false;
        public bool movingRight = false;
        public bool movingLeft = false;
        public bool moving = false;
        public bool left=false;
        public bool right=true;

       public  void Load(Texture2D mole_right, Texture2D mole_left)
        {
            this.mole_right = mole_right;
            this.mole_left = mole_left;
        }

       public void Draw(SpriteBatch spriteBatch)
       {
           spriteBatch.Begin();
           if (right)
               spriteBatch.Draw(mole_right, rec, Color.White);
           if (left)
               spriteBatch.Draw(mole_left, rec, Color.White);
           spriteBatch.End();
       }
       
        public void MoveDown()
        {
            //rec.Y += 4;
            rec.Y += field.Height / (7 * 25);
        }
        public void MoveUp()
        {
            //rec.Y -= 4;
            rec.Y -= field.Height / (7 * 25);
        }
        public void MoveRight()
        {
            //rec.X += 4;
            rec.X += field.Width / (7 * 25);
        }
        public void MoveLeft()
        {
            //rec.X -= 4;
            rec.X -= field.Width / (7 * 25);
        }
    }
}
