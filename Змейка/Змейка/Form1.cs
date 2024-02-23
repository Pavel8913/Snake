using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Змейка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            generate_fruit();
            generate_grad();
            this.Size = new Size(500, 480);
            
            game_timer.Interval = 180;

            this.Text = "Счёт:" + " " + score;

            for (int i = 0; i < scale * scale; i++)
            {
                snake[i] = new PictureBox();
                snake[i].Size = new Size(scale, scale);
                snake[i].BackColor = snake_color;
                snake[i].Tag = "snake";
            }
            snake[0].Tag = "snake1";
            snake[0].Location = new Point(200, 200);
            this.Controls.Add(snake[0]);
        }
        #region переменные
        bool goleft = true, goright = false, goup = false, godown = false;
        int scale = 20;
        int width = 500;
        int height = 400;
        int indent = 40;

        int dirX, dirY;

        PictureBox fruit = new PictureBox();
        PictureBox[] gradx = new PictureBox[21];
        PictureBox[] grady = new PictureBox[21];

        int score = 0;

        
        PictureBox[] snake = new PictureBox[400];

        Color snake_color = Color.Lime;
        Color fruit_color=Color.Red;


        #endregion;
    

        #region управление
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up )
            {
                goup = true;
                godown = false;
                goleft = false;
                goright = false;
            }
            if (e.KeyCode == Keys.Down )
            {
                goup = false;
                godown = true;
                goleft = false;
                goright = false;
            }
            if (e.KeyCode == Keys.Left )
            {
                goup = false;
                godown = false;
                goleft = true;
                goright = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goup = false;
                godown = false;
                goleft = false;
                goright = true;
            }
        }

        #endregion;

        private void _eatItself()
        {
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[0].Location == snake[_i].Location)
                {
                    //for (int _j = _i; _j <= score; _j++)
                    //    this.Controls.Remove(snake[_j]);
                    //score = score - (score - _i + 1);
                    this.Text = "Score: " + score;
                }
            }
        }

        private void _checkBorders()
        {
            if (snake[0].Location.X < 0)
            {
                game_timer.Stop();
                this.Text = "Вы вышли за границы";
            }
            if (snake[0].Location.X > this.Height)
            {
                game_timer.Stop();
                this.Text = "Вы вышли за границы";
            }
            if (snake[0].Location.Y < 0)
            {
                game_timer.Stop();
                this.Text = "Вы вышли за границы";
            }
            if (snake[0].Location.Y > this.Height)
            {
                game_timer.Stop();
                this.Text = "Вы вышли за границы";
            }
        }
        private void game_timer_Tick(object sender, EventArgs e)
        { 
            move_snake();
            intersect_fruit();            
            _checkBorders();
        }
        
        private void intersect_fruit()
        {
            if (snake[0].Bounds.IntersectsWith(fruit.Bounds))
            {
                //this.Controls.Remove(fruit);
                ////snake[score].Location = new Point(snake[score].Location.X + scale * dirX, snake[score].Location.Y - scale * dirY);
                //generate_fruit();
                //score++;

                //this.Controls.Add(snake[score]);
                //this.Text = "Счёт:" + " " + score;

               

                this.Text = "Score: " + score++;
                snake[score] = new PictureBox();
                snake[score].Location = new Point(snake[score -1].Location.X + 20 * dirX , snake[score - 1].Location.Y - 20 * dirY);
                snake[score].Size = new Size(scale - 1, scale - 1);
                snake[score].BackColor = Color.Green;
                this.Controls.Add(snake[score]);
                generate_fruit();

            }
        }

        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game_timer.Start();
        }

        private void паузаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game_timer.Stop();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void легкоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game_timer.Interval = 300;
        }

        private void среднеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game_timer.Interval = 200;
        }

        private void тяжелоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game_timer.Interval = 100;
        }

        private void холодныеЦветаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fruit_color = Color.Blue;
            for(int i=0;i<400;i++)
            {
                snake[i].BackColor = Color.Yellow;
            }
        }

        private void тёплыеЦветаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fruit_color = Color.Pink;
            for (int i = 0; i < 400; i++)
            {
                snake[i].BackColor = Color.Orange;                    ;
            }
        }

        private void чёрнобелыеЦветаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fruit_color = Color.Gray;
            for (int i = 0; i < 400; i++)
            {
                snake[i].BackColor = Color.Black; 
            }
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("•Игра змейка" +
                Environment.NewLine+ "•Управление стрелочками" +
                Environment.NewLine+ "•Змейка не может проходить через стенки" +
                Environment.NewLine+ "•Для начала игры можно нажать CTRL+N" +
                Environment.NewLine+ "•Приятной игры!", "Правила игры");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void generate_grad()
        {
            for (int i = 0; i <= scale; i++)
            {
                gradx[i] = new PictureBox();
                gradx[i].Location = new Point(0, i * scale + indent);
                gradx[i].Size = new Size(width, 1);
                gradx[i].BackColor = Color.DarkGray;
                this.Controls.Add(gradx[i]);
            }
        }


        private void generate_fruit()
        {
            Random random = new Random();
            int r1, r2;

            r1 = random.Next(0, scale);
            r2 = random.Next(0, scale);

            fruit.Location = new Point(r1 * scale, r2 * scale + indent);
            fruit.Size = new Size(scale, scale);
            fruit.BackColor = fruit_color;

            this.Controls.Add(fruit);
        }
        
        private void move_snake()
        {
            snake[0].Location = new Point(snake[0].Location.X + dirX * scale, snake[0].Location.Y + dirY * scale);
            //for (int i = score; i > 0; i--)
            //{
            //    snake[i].Location = new Point(snake[i - 1].Location.X, snake[i - 1].Location.Y);
            //}
            for (int i = score; i >= 1; i--)
            {
                snake[i].Location = snake[i - 1].Location;
            }
            if (goup)
            {
                dirY = -1;
                dirX = 0;
                

            }
            else if (godown)
            {
                dirY = 1;
                dirX = 0;
              
            }

            else if (goleft)
            {
                dirX = -1;
                dirY = 0;
               
            }

            else if (goright)
            {
                dirX = 1;
                dirY = 0;
             
            }

            _eatItself();

        }


    }
}