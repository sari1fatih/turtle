﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turtle.Forms;
namespace Turtle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Game game = new Game();
            game.MdiParent = this;
            game.Show();
        }
    }
}
