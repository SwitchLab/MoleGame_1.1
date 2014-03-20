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
    class UpdateCases
    {
        static bool pressed = false;
        static int i;
        public static bool CaseDown(Mole mole)
        {
            if ((Keyboard.GetState().IsKeyDown(Keys.Down)) && !pressed && !mole.moving&&mole.posY<6)
            {
                mole.movingDown = true;
                mole.moving = true;
                pressed = true;
                i = 0;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Down) && pressed)
            {
                pressed = false;
            }
            if (mole.movingDown)
            {
                mole.MoveDown();
                i++;
                if (i==25)
                {
                    mole.movingDown = false;
                    mole.moving = false;
                    mole.posY++;
                    return true;
                }
                pressed = true;
            }
            return false;
        }

        public static bool CaseUp(Mole mole )
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up) && !pressed && !mole.moving && mole.posY > 0)
            {
                mole.movingUp = true;
                mole.moving = true;
                pressed = true;
                i = 0;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Up) && pressed)
            {
                pressed = false;
            }
            if (mole.movingUp)
            {
                mole.MoveUp();
                i++;
                if (i==25)
                {
                    mole.movingUp = false;
                    mole.moving = false;
                    mole.posY--;
                    return true;
                }
                pressed = true;
            }
            return false;
        }
        public static bool CaseRight(Mole mole)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right) && !pressed && !mole.moving&&mole.posX < 6)
            {
                mole.right = true;
                mole.left = false;
                mole.movingRight = true;
                mole.moving = true;
                pressed = true;
                i = 0;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Right) && pressed )
            {
                pressed = false;
            }
            if (mole.movingRight)
            {
                mole.MoveRight();
                i++;
                if (i==25)
                {
                    mole.movingRight = false;
                    mole.moving = false;
                    mole.posX++;
                    return true;
                }
                pressed = true;
            }
            return false;
        }
        public static bool CaseLeft(Mole mole)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left) && !pressed && !mole.moving && mole.posX > 0)
            {
                mole.right = false;
                mole.left = true;
                mole.movingLeft = true;
                mole.moving = true;
                pressed = true;
                i = 0;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Left) && pressed)
            {
                pressed = false;
            }
            if (mole.movingLeft)
            {
                mole.MoveLeft();
                i++;
                if (i==25)
                {
                    mole.movingLeft = false;
                    mole.moving = false;
                    mole.posX--;
                    return true;
                }
                pressed = true;
            }
            return false;
        }
    }
}
