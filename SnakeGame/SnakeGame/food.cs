using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
/*
 * food class, places randomly on screen
 * 
 * */
namespace WindowsFormsApplication1
{
    class food
    {
        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle foodRec;
        //constructor
        public food(Random randFood)
        {
            x = randFood.Next(0, 29) * 10;
            y = randFood.Next(0, 29) * 10;
            brush = new SolidBrush(Color.Black);
            width = 10;
            height = 10;
            foodRec = new Rectangle(x, y, width, height);
        }
        //move food
        public void foodLocation(Random randFood)
        {
            x = randFood.Next(0, 29) * 10;
            y = randFood.Next(0, 29) * 10;
        }
        //display food
        public void drawFood(Graphics paper)
        {
            foodRec.X = x;
            foodRec.Y = y;

            paper.FillRectangle(brush, foodRec);

        }
    }
}
