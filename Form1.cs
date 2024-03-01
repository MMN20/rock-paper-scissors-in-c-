using RockPaperScissor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        enum Choices { Rock,Paper,Scissor,None}

        enum Winner { Player1,  Computer , Draw }

        Choices Player1Choice;

        Choices Player2Choice;

        Winner WhoWonTheGame(Choices Player1Choice, Choices Player2Choice)
        {
            if(Player1Choice == Player2Choice)
            {
                return Winner.Draw;   
            }

            else  if (Player1Choice == Choices.Rock && Player2Choice == Choices.Scissor)
                return Winner.Player1;

            else if (Player1Choice == Choices.Paper && Player2Choice == Choices.Rock)
                return Winner.Player1;

            else if (Player1Choice == Choices.Scissor && Player2Choice == Choices.Paper)
                return Winner.Player1;

            else
                return Winner.Computer;
        }

        void SetImages()
        {

            switch (Player1Choice)
            {
                case Choices.Rock:
                    pb1.Image = Resources.Rock;
                    break;
                case Choices.Paper:
                    pb1.Image = Resources.Paper;
                    break;
                case Choices.Scissor:
                    pb1.Image = Resources.Scissor;
                    break;
              
            }

            switch (Player2Choice)
            {
                case Choices.Rock:
                    pb2.Image = Resources.Rock;
                    break;
                case Choices.Paper:
                    pb2.Image = Resources.Paper;
                    break;
                case Choices.Scissor:
                    pb2.Image = Resources.Scissor;
                    break;
             
            }


        }

        void EndGame()
        {
            Winner winner = WhoWonTheGame(Player1Choice, Player2Choice);
            SetImages();
            MessageBox.Show($"{winner.ToString()}","Winner!");
            Player1Choice = Choices.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                Button btn = (Button)sender;
                Player1Choice = (Choices)Convert.ToUInt32(btn.Tag);
                pb1.Image = null;
                if (chkComputer.Checked)
                {
                    Thread.Sleep(1000);
                    Random random = new Random();
                    int choice = random.Next(0, 3);
                    Player2Choice = (Choices)choice;
                    EndGame();
                }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Player1Choice != Choices.None)
            {
                Button btn = (Button)sender;
                Player2Choice = (Choices)Convert.ToUInt32(btn.Tag);
                EndGame();

            }
               
        }


        private void chkComputer_CheckedChanged(object sender, EventArgs e)
        {
            if(chkComputer.Checked)
            {
                btnPlayer2Paper.Enabled = false;
                btnPlayer2Rock.Enabled = false;
                btnPlayer2Scissor.Enabled = false;
            }
            else
            {
                btnPlayer2Paper.Enabled = true;
                btnPlayer2Rock.Enabled = true;
                btnPlayer2Scissor.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkComputer_CheckedChanged(sender, e);
        }
    }
}
