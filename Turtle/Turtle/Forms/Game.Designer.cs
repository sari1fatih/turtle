namespace Turtle.Forms
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.steteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brutalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grbControl = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowRoad = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRoadShow = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // steteToolStripMenuItem
            // 
            this.steteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.steteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.steteToolStripMenuItem.Name = "steteToolStripMenuItem";
            this.steteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.steteToolStripMenuItem.Text = "Game";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem1,
            this.mediumToolStripMenuItem1,
            this.hardToolStripMenuItem1,
            this.brutalToolStripMenuItem1});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // easyToolStripMenuItem1
            // 
            this.easyToolStripMenuItem1.Name = "easyToolStripMenuItem1";
            this.easyToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.easyToolStripMenuItem1.Text = "Easy";
            this.easyToolStripMenuItem1.Click += new System.EventHandler(this.easyToolStripMenuItem1_Click);
            // 
            // mediumToolStripMenuItem1
            // 
            this.mediumToolStripMenuItem1.Name = "mediumToolStripMenuItem1";
            this.mediumToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.mediumToolStripMenuItem1.Text = "Medium";
            this.mediumToolStripMenuItem1.Click += new System.EventHandler(this.mediumToolStripMenuItem1_Click);
            // 
            // hardToolStripMenuItem1
            // 
            this.hardToolStripMenuItem1.Name = "hardToolStripMenuItem1";
            this.hardToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.hardToolStripMenuItem1.Text = "Hard";
            this.hardToolStripMenuItem1.Click += new System.EventHandler(this.hardToolStripMenuItem1_Click);
            // 
            // brutalToolStripMenuItem1
            // 
            this.brutalToolStripMenuItem1.Name = "brutalToolStripMenuItem1";
            this.brutalToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.brutalToolStripMenuItem1.Text = "Brutal";
            this.brutalToolStripMenuItem1.Click += new System.EventHandler(this.brutalToolStripMenuItem1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 163);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(599, 332);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Visible = false;
            // 
            // grbControl
            // 
            this.grbControl.Controls.Add(this.button1);
            this.grbControl.Controls.Add(this.btnShowRoad);
            this.grbControl.Controls.Add(this.button2);
            this.grbControl.Controls.Add(this.btnRoadShow);
            this.grbControl.Controls.Add(this.button3);
            this.grbControl.Controls.Add(this.button4);
            this.grbControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbControl.Location = new System.Drawing.Point(32, 29);
            this.grbControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbControl.Name = "grbControl";
            this.grbControl.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbControl.Size = new System.Drawing.Size(600, 115);
            this.grbControl.TabIndex = 5;
            this.grbControl.TabStop = false;
            this.grbControl.Text = "Control Center";
            this.grbControl.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Turtle.Properties.Resources.Left;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(8, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 0;
            this.button1.Tag = "L";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TurtleDirection_Click);
            // 
            // btnShowRoad
            // 
            this.btnShowRoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowRoad.Image = global::Turtle.Properties.Resources.bomb32;
            this.btnShowRoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowRoad.Location = new System.Drawing.Point(332, 22);
            this.btnShowRoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowRoad.Name = "btnShowRoad";
            this.btnShowRoad.Size = new System.Drawing.Size(123, 61);
            this.btnShowRoad.TabIndex = 0;
            this.btnShowRoad.Text = "Show Bomb";
            this.btnShowRoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowRoad.UseVisualStyleBackColor = true;
            this.btnShowRoad.Click += new System.EventHandler(this.btnShowBomb_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Turtle.Properties.Resources.Up;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(116, 22);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 36);
            this.button2.TabIndex = 0;
            this.button2.Tag = "U";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.TurtleDirection_Click);
            // 
            // btnRoadShow
            // 
            this.btnRoadShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnRoadShow.Image = global::Turtle.Properties.Resources.teacher32;
            this.btnRoadShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRoadShow.Location = new System.Drawing.Point(463, 22);
            this.btnRoadShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRoadShow.Name = "btnRoadShow";
            this.btnRoadShow.Size = new System.Drawing.Size(123, 61);
            this.btnRoadShow.TabIndex = 0;
            this.btnRoadShow.Text = "Show Road";
            this.btnRoadShow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRoadShow.UseVisualStyleBackColor = true;
            this.btnRoadShow.Click += new System.EventHandler(this.btnRoadShow_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Turtle.Properties.Resources.down;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(116, 65);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 36);
            this.button3.TabIndex = 0;
            this.button3.Tag = "D";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.TurtleDirection_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Turtle.Properties.Resources.Right;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(224, 39);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 36);
            this.button4.TabIndex = 0;
            this.button4.Tag = "R";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.TurtleDirection_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 492);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.grbControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Game";
            this.Text = "Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem steteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brutalToolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowRoad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRoadShow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox grbControl;
    }
}