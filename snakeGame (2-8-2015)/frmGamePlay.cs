using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakeGame__2_8_2015_
{
    public partial class frmGamePlay : Form
    {
        Random randFood = new Random();
        Graphics paper;
        Snake snake = new Snake();
        Food food;
        int xPos;
        List<int> xPosChange = new List<int>();

        int snakeX, snakeY, foodX, foodY;
        int foodXposX, posY;
        Int64 score = 0;

        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;

        public frmGamePlay()
        {
            InitializeComponent();
            food = new Food(randFood);
        }

        private void frmGamePlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                timer_SnakeMovement.Enabled = true;
                pbSpaceBar.Visible = false;
                down = false;
                up = false;
                right = true;
                left = false;
            }
            if (e.KeyData == Keys.Down && up == false)
            {
                down = true;
                up = false;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Up && down == false)
            {
                down = false;
                up = true;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Left && right == false)
            {
                down = false;
                up = false;
                left = true;
                right = false;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                down = false;
                up = false;
                left = false;
                right = true;
            }
            if (e.KeyData == Keys.Up && e.KeyData == Keys.Right)
            {
                // do nothing
            }
            if (e.KeyData == Keys.Up && e.KeyData == Keys.Left)
            {
                // do nothing
            }
            if (e.KeyData == Keys.Down && e.KeyData == Keys.Left)
            {
                // do nothing
            }
            if (e.KeyData == Keys.Down && e.KeyData == Keys.Right)
            {
                // do nothing
            }

        }

        private void frmGamePlay_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            snake.drawSnake(paper);
            food.drawFood(paper);
        }

        private void timer_SnakeMovement_Tick(object sender, EventArgs e)
        {
            if (up) { snake.moveUp();  }
            if (down) { snake.moveDown(); }
            if (left) { snake.moveLeft(); }
            if (right) { snake.moveRight(); }

            for (int i = 0; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[i].IntersectsWith(food.foodRec))
                {
                    score += 10;
                    lblScore.Text = score.ToString();
                    snake.growSnake();
                    food.foodLocation(randFood);
                }
            }
            collision();
            this.Invalidate();

        }
        public void collision()
        {
            // To detect snake collide with itself 
            for (int i = 1; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i]))
                {
                    restart();
                }
            }

            // going out of bound loccation kill him :P
            if (snake.SnakeRec[0].X < 0 || snake.SnakeRec[0].X > 878)
            {
                restart();
            }
            if (snake.SnakeRec[0].Y < 0 || snake.SnakeRec[0].Y > 566)
            {
                restart();
            }
        }
        public void restart()
        {
            // On restart what to do ????
            timer_SnakeMovement.Enabled = false;
            MessageBox.Show("Snak is dead, Your score is "+ lblScore.Text);
           lblScore.Text = "0";
            score = 0;
            // lblSpaceBar.Text = "Press Space Bar To Begin";
            pbSpaceBar.Visible = true;
            snake = new Snake();
        }
    }
}
