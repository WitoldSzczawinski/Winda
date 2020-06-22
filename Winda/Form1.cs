using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Winda
{
    public partial class Form1 : Form
    {
        Image Lift;
        Image Buff;
        Image Environment;
        Image Warning;
        Image People_1;
        Image People_2;
        Image People_3;
        Image People_4;
        Image People_5;
        Image People_6;
        Image People_7;
        Image People_8;
        Rectangle rectangle_lift;
        Rectangle rectangle_environment;
        Queue myQ = new Queue();
        int people;
        PictureBox pb = new PictureBox();
        PictureBox pb_1 = new PictureBox();
        PictureBox pb_2 = new PictureBox();
        PictureBox pb_3 = new PictureBox();
        PictureBox pb_4 = new PictureBox();
        PictureBox pb_lift = new PictureBox();


        public Form1()
        {
            InitializeComponent();
            Lift = Winda.Properties.Resources.Winda;
            Environment = Winda.Properties.Resources.SZYB;
            Warning = Winda.Properties.Resources.warning;
            People_1 = Winda.Properties.Resources._1;
            People_2 = Winda.Properties.Resources._2;
            People_3 = Winda.Properties.Resources._3;
            People_4 = Winda.Properties.Resources._4;
            People_5 = Winda.Properties.Resources._5;
            People_6 = Winda.Properties.Resources._6;
            People_7 = Winda.Properties.Resources._7;
            People_8 = Winda.Properties.Resources._8;
            rectangle_environment = new Rectangle(228, 30, 100, 300);
            rectangle_lift = new Rectangle(228, 255, 50, 75);
            
            pb.Location = new Point(228, 370);
            pb.Size = new Size(100, 50);
            pb.Image = Warning;
            pb.Visible = false;
            this.Controls.Add(pb);
            pb_1.Location = new Point(278, 278);
            pb_1.Size = new Size(50, 50);
            pb_1.Image = People_8;
            pb_1.Visible = false;
            this.Controls.Add(pb_1);
            pb_2.Location = new Point(278, 203);
            pb_2.Size = new Size(50, 50);
            pb_2.Image = People_8;
            pb_2.Visible = false;
            this.Controls.Add(pb_2);
            pb_3.Location = new Point(278, 128);
            pb_3.Size = new Size(50, 50);
            pb_3.Image = People_8;
            pb_3.Visible = false;
            this.Controls.Add(pb_3);
            pb_4.Location = new Point(278, 53);
            pb_4.Size = new Size(50, 50);
            pb_4.Image = People_8;
            pb_4.Visible = false;
            this.Controls.Add(pb_4);
            pb_lift.Location = new Point(231, 285);
            pb_lift.Size = new Size(40, 40);
            pb_lift.Image = People_8;
            pb_lift.Visible = false;
            this.Controls.Add(pb_lift);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Environment, rectangle_environment);
            g.DrawImage(Lift, rectangle_lift);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (myQ.Count != 0 )
            {
                if((int)myQ.Peek() == 1)
                {
                    if (rectangle_lift.Y < 255)
                    {
                        rectangle_lift.Y += 1;
 
                    }
                    else
                    {
                        myQ.Dequeue();
                        System.Threading.Thread.Sleep(500);
                        if (pb_lift.Visible)
                        {
                            pb_lift.Visible = false;
                        }else if (!pb_lift.Visible && pb_1.Visible)
                        {
                            pb_lift.Image = pb_1.Image;
                            pb_lift.Visible = true;
                            pb_1.Visible = false;
                        }
                    }
                }
                else if ((int)myQ.Peek() == 2)
                {
                    if (rectangle_lift.Y < 180)
                    {
                        rectangle_lift.Y += 1;
                    }
                    else if(rectangle_lift.Y > 180)
                    {
                        rectangle_lift.Y -= 1;
                    }
                    else
                    {
                        myQ.Dequeue();
                        System.Threading.Thread.Sleep(500);
                        if (pb_lift.Visible)
                        {
                            pb_lift.Visible = false;
                        }
                        else if (!pb_lift.Visible && pb_2.Visible)
                        {
                            pb_lift.Image = pb_2.Image;
                            pb_lift.Visible = true;
                            pb_2.Visible = false;
                        }
                    }
                }
                else if ((int)myQ.Peek() == 3)
                {
                    if (rectangle_lift.Y < 105)
                    {
                        rectangle_lift.Y += 1;
                    }
                    else if (rectangle_lift.Y > 105)
                    {
                        rectangle_lift.Y -= 1;
                    }
                    else
                    {
                        myQ.Dequeue();
                        System.Threading.Thread.Sleep(500);
                        if (pb_lift.Visible)
                        {
                            pb_lift.Visible = false;
                        }
                        else if (!pb_lift.Visible && pb_3.Visible)
                        {
                            pb_lift.Image = pb_3.Image;
                            pb_lift.Visible = true;
                            pb_3.Visible = false;
                        }
                    }
                }
                else if ((int)myQ.Peek() == 4)
                {

                    if (rectangle_lift.Y > 30)
                    {
                        rectangle_lift.Y -= 1;
                    }
                    else
                    {
                        myQ.Dequeue();
                        System.Threading.Thread.Sleep(500);
                        if (pb_lift.Visible)
                        {
                            pb_lift.Visible = false;
                        }
                        else if (!pb_lift.Visible && pb_4.Visible)
                        {
                            pb_lift.Image = pb_4.Image;
                            pb_lift.Visible = true;
                            pb_4.Visible = false;
                        }
                    }
                }
                pb_lift.Location = new Point(231, rectangle_lift.Y + 30);
            }

            Invalidate();

        }

        private void WAIT_1_Click(object sender, EventArgs e)
        {
            myQ.Enqueue(1);
        }

        private void WAIT_2_Click(object sender, EventArgs e)
        {
            myQ.Enqueue(2);
        }

        private void WAIT_3_Click(object sender, EventArgs e)
        {
            myQ.Enqueue(3);
        }

        private void WAIT_4_Click(object sender, EventArgs e)
        {
            myQ.Enqueue(4);
        }

        private void IN_1_CheckedChanged(object sender, EventArgs e)
        {
            if(IN_1.Checked == true)
            {
                IN_1.Checked = true;
                IN_2.Checked = false;
                IN_3.Checked = false;
                IN_4.Checked = false;

            }
        }

        private void IN_2_CheckedChanged(object sender, EventArgs e)
        {
            if (IN_2.Checked == true)
            {
                IN_2.Checked = true;
                IN_1.Checked = false;
                IN_3.Checked = false;
                IN_4.Checked = false;

            }
        }

        private void IN_3_CheckedChanged(object sender, EventArgs e)
        {
            if (IN_3.Checked == true)
            {
                IN_3.Checked = true;
                IN_2.Checked = false;
                IN_1.Checked = false;
                IN_4.Checked = false;

            }
        }

        private void IN_4_CheckedChanged(object sender, EventArgs e)
        {
            if (IN_4.Checked == true)
            {
                IN_4.Checked = true;
                IN_2.Checked = false;
                IN_3.Checked = false;
                IN_1.Checked = false;

            }
        }

        private void OUT_4_CheckedChanged(object sender, EventArgs e)
        {
            if(OUT_4.Checked == true)
            {
                OUT_4.Checked = true;
                OUT_3.Checked = false;
                OUT_2.Checked = false;
                OUT_1.Checked = false;

            }
        }

        private void OUT_3_CheckedChanged(object sender, EventArgs e)
        {
            if (OUT_3.Checked == true)
            {
                OUT_3.Checked = true;
                OUT_4.Checked = false;
                OUT_2.Checked = false;
                OUT_1.Checked = false;

            }
        }

        private void OUT_2_CheckedChanged(object sender, EventArgs e)
        {
            if (OUT_2.Checked == true)
            {
                OUT_2.Checked = true;
                OUT_3.Checked = false;
                OUT_4.Checked = false;
                OUT_1.Checked = false;

            }
        }

        private void OUT_1_CheckedChanged(object sender, EventArgs e)
        {
            if (OUT_1.Checked == true)
            {
                OUT_1.Checked = true;
                OUT_3.Checked = false;
                OUT_2.Checked = false;
                OUT_4.Checked = false;

            }
        }

        private void OK_Click(object sender, EventArgs e)
        {

            if (PEOPLE.Text != "")
            {
                people = Convert.ToInt32(PEOPLE.Text);
                if (people == 1)
                {
                    Buff = People_1;
                }
                else if (people == 2)
                {
                    Buff = People_2;
                }
                else if (people == 3)
                {
                    Buff = People_3;
                }
                else if (people == 4)
                {
                    Buff = People_4;
                }
                else if (people == 5)
                {
                    Buff = People_5;
                }
                else if (people == 6)
                {
                    Buff = People_6;
                }
                else if (people == 7)
                {
                    Buff = People_7;
                }
                else if (people == 8)
                {
                    Buff = People_8;
                }

            }
            PEOPLE.Clear();
            if (people < 9 && people > 0)
            {
                if (IN_4.Checked == true)
                {
                    myQ.Enqueue(4);
                    pb_4.Image = Buff;
                    pb_4.Visible = true;
                    
                }
                else if (IN_3.Checked == true)
                {
                    myQ.Enqueue(3);
                    pb_3.Image = Buff;
                    pb_3.Visible = true;
                }
                else if (IN_2.Checked == true)
                {
                    myQ.Enqueue(2);
                    pb_2.Image = Buff;
                    pb_2.Visible = true;
                }
                else if (IN_1.Checked == true)
                {
                    myQ.Enqueue(1);
                    pb_1.Image = Buff;
                    pb_1.Visible = true;
                }
                if (OUT_4.Checked == true)
                {
                    myQ.Enqueue(4);
                }
                else if (OUT_3.Checked == true)
                {
                    myQ.Enqueue(3);
                }
                else if (OUT_2.Checked == true)
                {
                    myQ.Enqueue(2);
                }
                else if (OUT_1.Checked == true)
                {
                    myQ.Enqueue(1);
                }
                pb.Visible = false;
            }
            else
            {
                pb.Visible = true;
            }

        }

        private void PEOPLE_TextChanged(object sender, EventArgs e)
        {
            
        }
  

        private void PEOPLE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }
    }
}
