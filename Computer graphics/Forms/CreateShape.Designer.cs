namespace Computer_graphics.Forms
{
    partial class CreateShape
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
            this.components = new System.ComponentModel.Container();
            this.canvas = new System.Windows.Forms.Panel();
            this.stopBut = new System.Windows.Forms.Button();
            this.rotR = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.conf = new System.Windows.Forms.Button();
            this.clrBut = new System.Windows.Forms.Button();
            this.trigleBut = new System.Windows.Forms.Button();
            this.circBut = new System.Windows.Forms.Button();
            this.rctgleBut = new System.Windows.Forms.Button();
            this.tmrMoving = new System.Windows.Forms.Timer(this.components);
            this.canvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Info;
            this.canvas.Controls.Add(this.stopBut);
            this.canvas.Controls.Add(this.rotR);
            this.canvas.Controls.Add(this.up);
            this.canvas.Controls.Add(this.left);
            this.canvas.Controls.Add(this.right);
            this.canvas.Controls.Add(this.down);
            this.canvas.Controls.Add(this.conf);
            this.canvas.Controls.Add(this.clrBut);
            this.canvas.Controls.Add(this.trigleBut);
            this.canvas.Controls.Add(this.circBut);
            this.canvas.Controls.Add(this.rctgleBut);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 482);
            this.canvas.TabIndex = 0;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint_1);
            // 
            // stopBut
            // 
            this.stopBut.Location = new System.Drawing.Point(397, 449);
            this.stopBut.Name = "stopBut";
            this.stopBut.Size = new System.Drawing.Size(44, 23);
            this.stopBut.TabIndex = 10;
            this.stopBut.Text = "II";
            this.stopBut.UseVisualStyleBackColor = true;
            this.stopBut.Click += new System.EventHandler(this.stopBut_Click);
            // 
            // rotR
            // 
            this.rotR.Location = new System.Drawing.Point(456, 406);
            this.rotR.Name = "rotR";
            this.rotR.Size = new System.Drawing.Size(62, 29);
            this.rotR.TabIndex = 9;
            this.rotR.Text = "rotate right";
            this.rotR.UseVisualStyleBackColor = true;
            this.rotR.Click += new System.EventHandler(this.rotate_Click);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(388, 418);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(62, 29);
            this.up.TabIndex = 8;
            this.up.Text = "Up";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(320, 441);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(62, 29);
            this.left.TabIndex = 7;
            this.left.Text = "Left";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(456, 441);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(62, 29);
            this.right.TabIndex = 6;
            this.right.Text = "Right";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(388, 473);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(62, 29);
            this.down.TabIndex = 5;
            this.down.Text = "Down";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // conf
            // 
            this.conf.BackColor = System.Drawing.SystemColors.Info;
            this.conf.Location = new System.Drawing.Point(3, 442);
            this.conf.Name = "conf";
            this.conf.Size = new System.Drawing.Size(161, 29);
            this.conf.TabIndex = 4;
            this.conf.Text = "Confirm Selection";
            this.conf.UseVisualStyleBackColor = false;
            this.conf.Click += new System.EventHandler(this.confirmSelection_Click);
            // 
            // clrBut
            // 
            this.clrBut.BackColor = System.Drawing.SystemColors.Info;
            this.clrBut.Location = new System.Drawing.Point(682, 443);
            this.clrBut.Name = "clrBut";
            this.clrBut.Size = new System.Drawing.Size(115, 29);
            this.clrBut.TabIndex = 3;
            this.clrBut.Text = "Clear";
            this.clrBut.UseVisualStyleBackColor = false;
            this.clrBut.Click += new System.EventHandler(this.clear_Click);
            // 
            // trigleBut
            // 
            this.trigleBut.BackColor = System.Drawing.SystemColors.Info;
            this.trigleBut.Location = new System.Drawing.Point(371, 3);
            this.trigleBut.Name = "trigleBut";
            this.trigleBut.Size = new System.Drawing.Size(94, 29);
            this.trigleBut.TabIndex = 2;
            this.trigleBut.Text = "Triangle";
            this.trigleBut.UseVisualStyleBackColor = false;
            this.trigleBut.Click += new System.EventHandler(this.Create_Triangle_Click);
            // 
            // circBut
            // 
            this.circBut.BackColor = System.Drawing.SystemColors.Info;
            this.circBut.Location = new System.Drawing.Point(630, 3);
            this.circBut.Name = "circBut";
            this.circBut.Size = new System.Drawing.Size(94, 29);
            this.circBut.TabIndex = 1;
            this.circBut.Text = "Circle";
            this.circBut.UseVisualStyleBackColor = false;
            this.circBut.Click += new System.EventHandler(this.Create_Circle_Click);
            // 
            // rctgleBut
            // 
            this.rctgleBut.BackColor = System.Drawing.SystemColors.Info;
            this.rctgleBut.Location = new System.Drawing.Point(99, 5);
            this.rctgleBut.Name = "rctgleBut";
            this.rctgleBut.Size = new System.Drawing.Size(94, 29);
            this.rctgleBut.TabIndex = 0;
            this.rctgleBut.Text = "Rectangle";
            this.rctgleBut.UseVisualStyleBackColor = false;
            this.rctgleBut.Click += new System.EventHandler(this.Create_Rectangle_Click);
            // 
            // tmrMoving
            // 
            this.tmrMoving.Enabled = true;
            this.tmrMoving.Interval = 50;
            this.tmrMoving.Tick += new System.EventHandler(this.tmrMoving_Tick);
            // 
            // CreateShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.canvas);
            this.Name = "CreateShape";
            this.Text = "Create a shape";
            this.canvas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel canvas;
        private Button rctgleBut;
        private Button circBut;
        private Button trigleBut;
        private Button clrBut;
        private Button conf;
        private System.Windows.Forms.Timer tmrMoving;
        private Button up;
        private Button left;
        private Button right;
        private Button down;
        private Button rotR;
        private Button stopBut;
    }
}