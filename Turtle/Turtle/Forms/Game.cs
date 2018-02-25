using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turtle.Classes;
namespace Turtle.Forms
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        List<Bomb> bombs = new List<Bomb>();
        List<TheGreenMile> theGreenMile = new List<TheGreenMile>();
        Random rnd = new Random();
        int MineState = 1, TheGreenState = 1, TurtleStatusx = 0, TurtleStatusy = 0, maxx = 0, maxy = 0, ExitStatusx = 0, ExitStatusy = 0, level = 3;

        void CreateTile(int x, int y)
        {
            TurtleStatusx = 0; TurtleStatusy = 0;
            int theGreenMileId = 0, oldID = -1, nullcontrol = 0;
            maxx = x;
            maxy = y;
            flowLayoutPanel1.Controls.Clear();
            bombs.Clear();
            theGreenMile.Clear();


            flowLayoutPanel1.Width = x * 50;
            flowLayoutPanel1.Height = y * 50;

            TurtleStatusx = rnd.Next(0, x);
            TurtleStatusy = rnd.Next(0, y);
            theGreenMile.Add(new TheGreenMile { Id = 0, x = TurtleStatusx, y = TurtleStatusy });

            //We take the furthest distance according to the turtle.

            ExitStatusx = (TurtleStatusx >= x / 2) ? 0 : x - 1;
            ExitStatusy = (TurtleStatusy >= y / 2) ? 0 : y - 1;


            direction:
            //We take the last position of the turtle.
            var LastStatus = theGreenMile.Where(u => u.Id == theGreenMile.Distinct().Max(a => a.Id)).FirstOrDefault();
            if (!(LastStatus.x == ExitStatusx && LastStatus.y == ExitStatusy))
            {

                int direction = rnd.Next(0, 4);
                if (LastStatus.x == 0 && direction == 2)
                {
                    goto direction;
                    //can not go west
                }
                else if (LastStatus.x == x - 1 && direction == 3)
                {
                    goto direction;
                    //can not go east
                }
                else if (LastStatus.y == 0 && direction == 0)
                {
                    goto direction;
                    //can not go north
                }
                else if (LastStatus.y == y - 1 && direction == 1)
                {
                    goto direction;
                    //can not go south 
                }
                //To find the way out, we find the direction chosen randomly.
                int godirectionx = 0, godirectiony = 0;
                switch (direction)
                {
                    case 0:/*North*/godirectiony = LastStatus.y - 1; godirectionx = LastStatus.x; break;
                    case 1:/*South*/godirectiony = LastStatus.y + 1; godirectionx = LastStatus.x; break;
                    case 2:/*West*/godirectionx = LastStatus.x - 1; godirectiony = LastStatus.y; break;
                    case 3:/*East*/godirectionx = LastStatus.x + 1; godirectiony = LastStatus.y; break;
                }
                var v = theGreenMile.Where(u => u.x == godirectionx && u.y == godirectiony).FirstOrDefault();
                if (v != null)
                {
                    goto direction;
                }
                //If you are near the selected route, we delete the routes between that location and
                oldID = -1;
                try
                {
                    oldID = theGreenMile.Where(
                                       (u =>
                                       (!(u.x == LastStatus.x && u.y == LastStatus.y)) &&
                                       (
                                       (Math.Abs(u.x - godirectionx) == 1 && Math.Abs(u.y - godirectiony) == 0) ||
                                       (Math.Abs(u.x - godirectionx) == 0 && Math.Abs(u.y - godirectiony) == 1)
                                       )
                                       )).Min(u => u.Id);
                }
                catch (Exception)
                {

                }

                if (oldID != -1)
                {

                    theGreenMile.RemoveAll(u => u.Id > oldID);
                    theGreenMileId = Convert.ToInt32(oldID) + 1;
                }
                else
                {
                    theGreenMileId++;
                }
                theGreenMile.Add(new TheGreenMile { Id = theGreenMileId, x = godirectionx, y = godirectiony });


                goto direction;
            }

            //We assign the x and y coordinates to the buttons on the detailed tab.
            for (int yy = 0; yy < y; yy++)
            {
                for (int xx = 0; xx < x; xx++)
                {
                    nullcontrol = 1;
                    Button btn = new Button();
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Margin = new Padding(0);

                    //The location of the bombs will not be on the road
                    if ((xx % level == 0) && (theGreenMile.Where(u => (u.x == xx && u.y == yy)).Count() == 0))
                    {
                        bombs.Add(new Bomb { bombx = xx, bomby = yy });

                    }


                    if (0 != bombs.Where(u => u.bombx == xx && u.bomby == yy).Count())
                    {
                        btn.Tag = "B" + "*" + xx + "-" + yy;
                        nullcontrol = 0;

                    }
                    if (0 != theGreenMile.Where(u => u.x == xx && u.y == yy).Count())
                    {
                        btn.Tag = "R" + "*" + xx + "-" + yy;
                        nullcontrol = 0;

                    }

                    if (xx == TurtleStatusx && yy == TurtleStatusy)
                    {
                        btn.Tag = "T" + "*" + xx + "-" + yy;
                        //btn.Text = "T";
                        btn.BackgroundImage = Properties.Resources.turtle;
                        btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    }
                    else if (xx == ExitStatusx && yy == ExitStatusy)
                    {
                        btn.Tag = "E" + "*" + xx + "-" + yy;
                        //btn.Text = "E";
                        btn.BackgroundImage = Properties.Resources.exit;
                        btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    }
                    else if (nullcontrol == 1) //butona değer atanmadıysa tag null
                    {
                        btn.Tag = "N" + "*" + xx + "-" + yy;
                    }
                    btn.BackColor = SystemColors.Control;
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
        }
        private void TurtleDirection_Click(object sender, EventArgs e)
        {

            int newx = -3, newy = -3, statusx = TurtleStatusx, statusy = TurtleStatusy;
            Button btn;
            string tag = "";
            switch ((string)((Button)sender).Tag)
            {
                case "R": newx = TurtleStatusx + 1; break;
                case "L": newx = TurtleStatusx - 1; break;
                case "U": newy = TurtleStatusy - 1; break;
                case "D": newy = TurtleStatusy + 1; break;
            }

            //We find the end of the changing position.
            if (!(newx == -1 || newy == -1 || newx == maxx || newy == maxy))
            {
                //We find the unchanging x or y coordinate
                if (newx == -3)
                {
                    newx = TurtleStatusx;
                }
                else newy = TurtleStatusy;


                foreach (var item in flowLayoutPanel1.Controls)
                {
                    if ((item is Button))
                    {
                        btn = ((Button)item);
                        tag = (string)btn.Tag;

                        if ((Convert.ToInt32(tag.Substring(tag.IndexOf("*") + 1, tag.LastIndexOf("-") - tag.IndexOf("*") - 1)) == statusx) && (Convert.ToInt32(tag.Substring(tag.IndexOf("-") + 1, tag.Length - tag.IndexOf("-") - 1)) == statusy))
                        {
                            btn.BackgroundImage = null;
                        }
                        else if ((Convert.ToInt32(tag.Substring(tag.IndexOf("*") + 1, tag.LastIndexOf("-") - tag.IndexOf("*") - 1)) == newx) && (Convert.ToInt32(tag.Substring(tag.IndexOf("-") + 1, tag.Length - tag.IndexOf("-") - 1)) == newy))
                        {

                            if (tag.Substring(0, 1) == "B")
                            {
                                btn.BackgroundImage = Properties.Resources.bomb;
                                btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                                MineState = 1;
                                btnShowBomb_Click(sender, e);
                                DialogResult result = MessageBox.Show("You are dead but don't worry. Do you want to try again?", "New Startup!", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    CreateTile(maxx, maxy);
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("See You Later,Bro", "Don't Go :(");
                                    Environment.Exit(0);
                                }

                            }
                            else if (tag.Substring(0, 1) == "E")
                            {
                                btn.BackgroundImage = Properties.Resources.exit;
                                btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                                MessageBox.Show("Good Boy!");
                                CreateTile(maxx, maxy);
                                break;
                            }
                            else
                            {
                                btn.BackgroundImage = Properties.Resources.turtle;
                                btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                            }
                            TurtleStatusx = newx;
                            TurtleStatusy = newy;
                        }
                    }
                }
            }

        }


        //0 = hide , 1 = show
        private void btnShowBomb_Click(object sender, EventArgs e)
        {
            if (MineState == 1)
            {
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    if (item is Button)
                    {
                        Button bombShow = (Button)item;
                        if (((string)bombShow.Tag).Substring(0, 1) == "B")
                        {
                            bombShow.BackgroundImage = Properties.Resources.bomb;
                            bombShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                        }
                    }
                }
                MineState = 0;
                btnShowRoad.Text = "Hide Bomb";
            }
            else if (MineState == 0)
            {
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    if (item is Button)
                    {
                        Button bombShow = (Button)item;
                        if (((string)bombShow.Tag).Substring(0, 1) == "B")
                        {
                            bombShow.BackgroundImage = null;
                        }
                    }
                }
                MineState = 1;
                btnShowRoad.Text = "Show Bomb";
            }


        }
        //0 = hide , 1 = show
        private void btnRoadShow_Click(object sender, EventArgs e)
        {
            if (TheGreenState == 1)
            {
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    if (item is Button)
                    {
                        Button roadShow = (Button)item;
                        if (((string)roadShow.Tag).Substring(0, 1) == "R" || ((string)roadShow.Tag).Substring(0, 1) == "E" || ((string)roadShow.Tag).Substring(0, 1) == "T")
                        {
                            roadShow.BackColor = Color.Green;
                        }
                    }
                }
                TheGreenState = 0;
                btnRoadShow.Text = "Hide Road";
            }
            else if (TheGreenState == 0)
            {
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    if (item is Button)
                    {
                        Button roadShow = (Button)item;
                        if (((string)roadShow.Tag).Substring(0, 1) == "R" || ((string)roadShow.Tag).Substring(0, 1) == "E" || ((string)roadShow.Tag).Substring(0, 1) == "T")
                        {
                            roadShow.BackColor = SystemColors.Control;

                        }
                    }
                }
                TheGreenState = 1;
                btnRoadShow.Text = "Show Road";
            }
        }
        private void easyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateTile(5, 5);
            level = 3;
            grbControl.Visible = true;
            flowLayoutPanel1.Visible = true;
        }
        private void mediumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateTile(8, 8);
            level = 4;
            grbControl.Visible = true;
            flowLayoutPanel1.Visible = true;
        }
        private void hardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateTile(11, 11);
            level = 5;
            grbControl.Visible = true;
            flowLayoutPanel1.Visible = true;
        }
        private void brutalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateTile(13, 13);
            level = 6;
            grbControl.Visible = true;
            flowLayoutPanel1.Visible = true;
        }
    }
}
