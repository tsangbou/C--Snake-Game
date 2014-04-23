using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class Snake
    {
        private Rectangle[] snakeRec;
        private SolidBrush brush;
        private int x, y, width, height;

        public Rectangle[] SnakeRec
        {
            get { return snakeRec; }
        }

        //constructor
        public Snake()
        {
            snakeRec = new Rectangle[3];
            brush = new SolidBrush(Color.Blue);

            x = 20;
            y = 0;
            width = 10;
            height = 10;

            for (int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }
        //display snake
        public void drawSnake(Graphics paper)
        {
            foreach (Rectangle rec in snakeRec)
            {
                paper.FillRectangle(brush, rec);
            }
        }
        //create the snake
        public void drawSnake()
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }
        //move down
        public void moveDown()
        {
            drawSnake();
            snakeRec[0].Y += 10;
        }
        //move up
        public void moveUp()
        {
            drawSnake();
            snakeRec[0].Y -= 10;
        }
        //move right
        public void moveRight()
        {
            drawSnake();
            snakeRec[0].X += 10;
        }
        //move left
        public void moveLeft()
        {
            drawSnake();
            snakeRec[0].X -= 10;
        }

        /*
         * function adds block to snake length
         * 
         * */
        public void growSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length-1].X,snakeRec[snakeRec.Length-1].Y,width,height));
            snakeRec = rec.ToArray();
        }

    }
}
