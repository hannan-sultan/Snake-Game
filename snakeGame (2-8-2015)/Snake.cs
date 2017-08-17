using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace snakeGame__2_8_2015_
{
    public class Snake : Form 
    {
        private Rectangle[] snakeRec;
       
        private SolidBrush brush;
        Form obj = new Form();
        //private Image snakeMouth = snakeGame__2_8_2015_.Properties.Resources.newSnakeMouth;
        // private SolidBrush Xbrush;
        Pen pen;
        private int x, y, width, height;

        public Rectangle[] SnakeRec
        {
            get { return snakeRec; }
        }

        private int snakePosX, snakePosY;

        public int SnakePosX
        {
            get { return snakeRec[0].X; }
            set { snakePosX = snakeRec[0].X; }
        }
        public int SnakePosY
        {
            get { return snakeRec[0].Y; }
            set { snakePosY = snakeRec[0].Y; }
        }

        public Snake()
        {
            pen = new Pen(Color.White, 3);

            snakeRec = new Rectangle[3];
            brush = new SolidBrush(Color.White);
            x = 100;
            y = 0;
            width = 40;
            height = 40;


            for (int i = 0; i < snakeRec.Length; i++)
            {
                //SnakeRec[0] = new Rectangle(snakeMouth,);
                snakeRec[i] = new Rectangle(x, y, width, height);
                x -= 50;
            }
        }
        public void drawSnake(Graphics paper)
        {
            Image img2 = snakeGame__2_8_2015_.Properties.Resources.newSnakeMouth;
            Image img3 = snakeGame__2_8_2015_.Properties.Resources.newSnakeTale;

            paper.DrawImage(img2, snakeRec[0]);
            int lenght = snakeRec.Length - 1;
            paper.DrawImage(img3, snakeRec[lenght]);


            for (int i = 1; i < snakeRec.Length - 1; i++)
            {


                //paper.FillRectangle(brush, rec);
                //paper.DrawImage(snakeMouth,paper.FillRectangle( pen.Brush,rec));
                //pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Left;
                //paper.DrawEllipse(pen, rec);
                Image img = snakeGame__2_8_2015_.Properties.Resources.newSnakeRec;

                paper.DrawImage(img, snakeRec[i]);
            }
        }
        public void drawSnake()
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)
            {

                snakeRec[i] = snakeRec[i - 1];
                //snakeRec[0] = new Rectangle(x, y, width, height);
            }
        }
        public void moveDown()
        {

            drawSnake();
            snakeRec[0].Y += 50;
        }
        public void moveDown(int foodY)
        {
            if (snakeRec[0].Y == foodY)
            {
                return;
            }
            drawSnake();
            snakeRec[0].Y += 50;
        }
        public void moveUp()
        {
            drawSnake();
            snakeRec[0].Y -= 50;
        }
        public void moveRight(int foodX)
        {
            if (snakeRec[0].X == foodX)
            {
                return;
            }
            drawSnake();
            snakeRec[0].X += 50;
        }
        public void moveRight()
        {
           
            drawSnake();
            snakeRec[0].X += 50;
        }
        public void moveLeft()
        {
            drawSnake();
            snakeRec[0].X -= 50;
        }

        public void growSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
            snakeRec = rec.ToArray();
        }
    }
}
