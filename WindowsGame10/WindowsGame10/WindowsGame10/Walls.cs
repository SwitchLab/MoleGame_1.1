using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame10
{
    enum State
    {
        Empty,
        NotChange,
        Change,
        Come
    }

    class Wall
    {
        public State[] states;
        public Rectangle[] baseBelowRectangles, baseAboveRectangles;


        public Vector2 wallPosition;
       // Rectangle[] rectNow;
        static Random r = new Random();
        static int circleSize = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 62;

        public Wall(int width, int height, Vector2 pos, State[] st)
        {
            wallPosition = pos;
            states = st;
            int y,x;
            width -= circleSize;
            height -= circleSize;
            
            baseBelowRectangles = new Rectangle[7];
           // baseAboveRectangles = new Rectangle[5];
            for (int i = 0; i < baseBelowRectangles.Length; i++)
            {
                x = r.Next(width);
                y = r.Next(height);
                baseBelowRectangles[i] = new Rectangle((int)pos.X + x, (int)pos.Y+y, circleSize, circleSize);
           //     baseAboveRectangles[i] = new Rectangle((int)pos.X+x + 2,(int)pos.Y+ y + 2, 6, 6);
            }
        }

    }
}
