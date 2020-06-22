namespace Winda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IN_1 = new System.Windows.Forms.CheckBox();
            this.IN_2 = new System.Windows.Forms.CheckBox();
            this.IN_3 = new System.Windows.Forms.CheckBox();
            this.IN_4 = new System.Windows.Forms.CheckBox();
            this.OUT_1 = new System.Windows.Forms.CheckBox();
            this.OUT_2 = new System.Windows.Forms.CheckBox();
            this.OUT_3 = new System.Windows.Forms.CheckBox();
            this.OUT_4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PEOPLE = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.WAIT_1 = new System.Windows.Forms.Button();
            this.WAIT_2 = new System.Windows.Forms.Button();
            this.WAIT_3 = new System.Windows.Forms.Button();
            this.WAIT_4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // IN_1
            // 
            this.IN_1.AutoSize = true;
            this.IN_1.Checked = true;
            this.IN_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IN_1.Location = new System.Drawing.Point(21, 314);
            this.IN_1.Name = "IN_1";
            this.IN_1.Size = new System.Drawing.Size(71, 19);
            this.IN_1.TabIndex = 0;
            this.IN_1.Text = "1st Floor";
            this.IN_1.UseVisualStyleBackColor = true;
            this.IN_1.CheckedChanged += new System.EventHandler(this.IN_1_CheckedChanged);
            // 
            // IN_2
            // 
            this.IN_2.AutoSize = true;
            this.IN_2.Location = new System.Drawing.Point(21, 239);
            this.IN_2.Name = "IN_2";
            this.IN_2.Size = new System.Drawing.Size(76, 19);
            this.IN_2.TabIndex = 0;
            this.IN_2.Text = "2nd Floor";
            this.IN_2.UseVisualStyleBackColor = true;
            this.IN_2.CheckedChanged += new System.EventHandler(this.IN_2_CheckedChanged);
            // 
            // IN_3
            // 
            this.IN_3.AutoSize = true;
            this.IN_3.Location = new System.Drawing.Point(21, 161);
            this.IN_3.Name = "IN_3";
            this.IN_3.Size = new System.Drawing.Size(73, 19);
            this.IN_3.TabIndex = 0;
            this.IN_3.Text = "3rd Floor";
            this.IN_3.UseVisualStyleBackColor = true;
            this.IN_3.CheckedChanged += new System.EventHandler(this.IN_3_CheckedChanged);
            // 
            // IN_4
            // 
            this.IN_4.AutoSize = true;
            this.IN_4.Location = new System.Drawing.Point(21, 91);
            this.IN_4.Name = "IN_4";
            this.IN_4.Size = new System.Drawing.Size(73, 19);
            this.IN_4.TabIndex = 0;
            this.IN_4.Text = "4th Floor";
            this.IN_4.UseVisualStyleBackColor = true;
            this.IN_4.CheckedChanged += new System.EventHandler(this.IN_4_CheckedChanged);
            // 
            // OUT_1
            // 
            this.OUT_1.AutoSize = true;
            this.OUT_1.Checked = true;
            this.OUT_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OUT_1.Location = new System.Drawing.Point(143, 314);
            this.OUT_1.Name = "OUT_1";
            this.OUT_1.Size = new System.Drawing.Size(71, 19);
            this.OUT_1.TabIndex = 0;
            this.OUT_1.Text = "1st Floor";
            this.OUT_1.UseVisualStyleBackColor = true;
            this.OUT_1.CheckedChanged += new System.EventHandler(this.OUT_1_CheckedChanged);
            // 
            // OUT_2
            // 
            this.OUT_2.AutoSize = true;
            this.OUT_2.Location = new System.Drawing.Point(143, 239);
            this.OUT_2.Name = "OUT_2";
            this.OUT_2.Size = new System.Drawing.Size(76, 19);
            this.OUT_2.TabIndex = 0;
            this.OUT_2.Text = "2nd Floor";
            this.OUT_2.UseVisualStyleBackColor = true;
            this.OUT_2.CheckedChanged += new System.EventHandler(this.OUT_2_CheckedChanged);
            // 
            // OUT_3
            // 
            this.OUT_3.AutoSize = true;
            this.OUT_3.Location = new System.Drawing.Point(143, 161);
            this.OUT_3.Name = "OUT_3";
            this.OUT_3.Size = new System.Drawing.Size(73, 19);
            this.OUT_3.TabIndex = 0;
            this.OUT_3.Text = "3rd Floor";
            this.OUT_3.UseVisualStyleBackColor = true;
            this.OUT_3.CheckedChanged += new System.EventHandler(this.OUT_3_CheckedChanged);
            // 
            // OUT_4
            // 
            this.OUT_4.AutoSize = true;
            this.OUT_4.Location = new System.Drawing.Point(143, 91);
            this.OUT_4.Name = "OUT_4";
            this.OUT_4.Size = new System.Drawing.Size(73, 19);
            this.OUT_4.TabIndex = 0;
            this.OUT_4.Text = "4th Floor";
            this.OUT_4.UseVisualStyleBackColor = true;
            this.OUT_4.CheckedChanged += new System.EventHandler(this.OUT_4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "IN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "OUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "People";
            // 
            // PEOPLE
            // 
            this.PEOPLE.Location = new System.Drawing.Point(21, 388);
            this.PEOPLE.Name = "PEOPLE";
            this.PEOPLE.Size = new System.Drawing.Size(100, 23);
            this.PEOPLE.TabIndex = 2;
            this.PEOPLE.TextChanged += new System.EventHandler(this.PEOPLE_TextChanged);
            this.PEOPLE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PEOPLE_KeyPress);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(143, 387);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // WAIT_1
            // 
            this.WAIT_1.Location = new System.Drawing.Point(341, 310);
            this.WAIT_1.Name = "WAIT_1";
            this.WAIT_1.Size = new System.Drawing.Size(75, 23);
            this.WAIT_1.TabIndex = 3;
            this.WAIT_1.Text = "^";
            this.WAIT_1.UseVisualStyleBackColor = true;
            this.WAIT_1.Click += new System.EventHandler(this.WAIT_1_Click);
            // 
            // WAIT_2
            // 
            this.WAIT_2.Location = new System.Drawing.Point(341, 235);
            this.WAIT_2.Name = "WAIT_2";
            this.WAIT_2.Size = new System.Drawing.Size(75, 23);
            this.WAIT_2.TabIndex = 3;
            this.WAIT_2.Text = "^";
            this.WAIT_2.UseVisualStyleBackColor = true;
            this.WAIT_2.Click += new System.EventHandler(this.WAIT_2_Click);
            // 
            // WAIT_3
            // 
            this.WAIT_3.Location = new System.Drawing.Point(341, 161);
            this.WAIT_3.Name = "WAIT_3";
            this.WAIT_3.Size = new System.Drawing.Size(75, 23);
            this.WAIT_3.TabIndex = 3;
            this.WAIT_3.Text = "^";
            this.WAIT_3.UseVisualStyleBackColor = true;
            this.WAIT_3.Click += new System.EventHandler(this.WAIT_3_Click);
            // 
            // WAIT_4
            // 
            this.WAIT_4.Location = new System.Drawing.Point(341, 88);
            this.WAIT_4.Name = "WAIT_4";
            this.WAIT_4.Size = new System.Drawing.Size(75, 23);
            this.WAIT_4.TabIndex = 3;
            this.WAIT_4.Text = "^";
            this.WAIT_4.UseVisualStyleBackColor = true;
            this.WAIT_4.Click += new System.EventHandler(this.WAIT_4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 427);
            this.Controls.Add(this.WAIT_4);
            this.Controls.Add(this.WAIT_3);
            this.Controls.Add(this.WAIT_2);
            this.Controls.Add(this.WAIT_1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PEOPLE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OUT_4);
            this.Controls.Add(this.OUT_3);
            this.Controls.Add(this.OUT_2);
            this.Controls.Add(this.OUT_1);
            this.Controls.Add(this.IN_4);
            this.Controls.Add(this.IN_3);
            this.Controls.Add(this.IN_2);
            this.Controls.Add(this.IN_1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LIFT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IN_1;
        private System.Windows.Forms.CheckBox IN_2;
        private System.Windows.Forms.CheckBox IN_3;
        private System.Windows.Forms.CheckBox IN_4;
        private System.Windows.Forms.CheckBox OUT_1;
        private System.Windows.Forms.CheckBox OUT_2;
        private System.Windows.Forms.CheckBox OUT_3;
        private System.Windows.Forms.CheckBox OUT_4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PEOPLE;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button WAIT_1;
        private System.Windows.Forms.Button WAIT_2;
        private System.Windows.Forms.Button WAIT_3;
        private System.Windows.Forms.Button WAIT_4;
        private System.Windows.Forms.Timer timer1;
    }
}

