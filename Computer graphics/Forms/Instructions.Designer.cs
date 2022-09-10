namespace Computer_graphics.Forms
{
    partial class canvas 
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 508);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(151, 431);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(439, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "To stop a rotation, click on the rotation animmation button again";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(0, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(878, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "If a button is pressed again the direction might change (a right down movement be" +
    "comes a right one only  if right is pressed again)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(163, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(454, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "If the movements are in opposite direction, only the last one is kept";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(14, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(781, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "when moving in one direction, if a different movement button is pressed the two m" +
    "ovement directions are combined";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(43, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(690, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "There are 4 buttons to move the selected shape: up, down, left, right plus a rota" +
    "tion and a pause button";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(70, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(632, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "When the selection is confirmed, only the selected shape is kept on the screen  t" +
    "o be animated";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(67, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(624, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Once a shape selected, the confirm button will be enabled allowing to confirm you" +
    "r selection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(143, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(474, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "To select a differen shape, simply click on the shape you want to select";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(182, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "When a shape is selected, its color on the screen turns red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(683, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Only three shapes can be created (rectangle, triangle or circle) and only one can" +
    " be selected at a time ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(657, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "By clicking on one of the three buttons at the top, shapes can be displayed on th" +
    "e screen (created)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(89, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(597, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First navigate to the create shape menu by clicking on the create shape button on" +
    " the left";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is an application for the creation and animation of three geometrical applic" +
    "ations";
            // 
            // canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.panel1);
            this.Name = "canvas";
            this.Text = "Instructions";
            this.Load += new System.EventHandler(this.SelectShape_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}