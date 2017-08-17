using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows;

namespace snakeGame__2_8_2015_
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            Thread thread = new Thread(new ThreadStart(SplashScreen));
            thread.Start();
            Thread.Sleep(4000);
            thread.Abort();
            InitializeComponent();
        }
        private void SplashScreen()
        {
            try
            {
                Application.Run(new frmSplash());
            }
            catch (Exception)
            {

                throw;
            }
           
        }

       

        private void pbBtnPlay_MouseEnter(object sender, EventArgs e)
        {
            pbBtnPlay.Image = snakeGame__2_8_2015_.Properties.Resources.btnPlaynewPressed;
        }

        private void pbBtnPlay_MouseLeave(object sender, EventArgs e)
        {
            pbBtnPlay.Image = snakeGame__2_8_2015_.Properties.Resources.btnPlaynew;
        }

        private void pbBtnHighScore_MouseEnter(object sender, EventArgs e)
        {
            pbBtnHighScore.Image = snakeGame__2_8_2015_.Properties.Resources.btnHighScorenewPressed;
        }

        private void pbBtnHighScore_MouseLeave(object sender, EventArgs e)
        {
            pbBtnHighScore.Image = snakeGame__2_8_2015_.Properties.Resources.btnHighScorenew;
        }

        private void pbBtnComputerPlay_MouseEnter(object sender, EventArgs e)
        {
            pbBtnComputerPlay.Image = snakeGame__2_8_2015_.Properties.Resources.btnComptuterTestPressed;
        }

        private void pbBtnComputerPlay_MouseLeave(object sender, EventArgs e)
        {
            pbBtnComputerPlay.Image = snakeGame__2_8_2015_.Properties.Resources.btnComptuterTest;
        }

        private void pbBtnInstructions_MouseEnter(object sender, EventArgs e)
        {
            pbBtnInstructions.Image = snakeGame__2_8_2015_.Properties.Resources.btnInstructionsnewPressed;
        }

        private void pbBtnInstructions_MouseLeave(object sender, EventArgs e)
        {
            pbBtnInstructions.Image = snakeGame__2_8_2015_.Properties.Resources.btnInstructionsnew;
        }

        private void pbBtnPlay_Click(object sender, EventArgs e)
        {
            frmGamePlay gamePlay = new frmGamePlay();
            gamePlay.Show();
            this.Hide();
           // play();
        }
        public void play()
        {
            pbBtnComputerPlay.Visible = false;
            pbBtnHighScore.Visible = false;
            pbBtnInstructions.Visible = false;
            pbBtnPlay.Visible = false;
            pbMainMenu.Image = snakeGame__2_8_2015_.Properties.Resources.gameBg;
        }

      
    }
}
