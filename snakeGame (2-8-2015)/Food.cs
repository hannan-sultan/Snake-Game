using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace snakeGame__2_8_2015_
{
    public class Food
    {
        public Rectangle foodRec;
        private string[] images;
        private SolidBrush brush;
        private int x, y, width, height;
        private int foodPosX, foodPosY;

        public int FoodPosX
        {

            set { foodPosX = x; }
            get { return x; }
        }
        public int FoodPosY
        {
            set { foodPosY = y; }
            get { return y; }

        }



        public Food(Random randFood)
        {
            x = randFood.Next(0, 80) * 10;
            y = randFood.Next(0, 50) * 10;

            brush = new SolidBrush(Color.White);
            width = 40;
            height = 40;
            foodRec = new Rectangle(x, y, width, height);
            images = new string[] { "snakeGame__2_8_2015_.Properties.Resources.apple", "snakeGame__2_8_2015_.Properties.Resources.orange", "snakeGame__2_8_2015_.Properties.Resources.papaya", "snakeGame__2_8_2015_.Properties.Resources.pear", "snakeGame__2_8_2015_.Properties.Resources.pine apple", "snakeGame__2_8_2015_.Properties.Resources.strawberry", "snakeGame__2_8_2015_.Properties.Resources.gauva", "snakeGame__2_8_2015_.Properties.Resources.grapes" };


        }
        public void foodLocation(Random randFood)
        {
            x = randFood.Next(0, 80) * 10;
            y = randFood.Next(0, 50) * 10;
        }
        public void drawFood(Graphics paper)
        {
            foodRec.X = x;
            foodRec.Y = y;
           // var rand = new Random();
           // string imageName = images[rand.Next(images.Length)];

            Image img = snakeGame__2_8_2015_.Properties.Resources.apple;

            paper.DrawImage(img, foodRec);
           // paper.FillEllipse(brush, foodRec);


        }



    }
}
