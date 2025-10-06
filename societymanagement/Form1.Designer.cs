namespace societymanagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumOrchid;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 525);
            this.label1.TabIndex = 0;
            this.label1.Text = "Society Mangement System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumOrchid;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(104, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome !";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label3.Location = new System.Drawing.Point(518, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 60);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(577, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(577, 265);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label4.Location = new System.Drawing.Point(401, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label5.Location = new System.Drawing.Point(401, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.MediumOrchid;
            this.login.Location = new System.Drawing.Point(495, 355);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(135, 46);
            this.login.TabIndex = 8;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label8.Location = new System.Drawing.Point(393, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 33);
            this.label8.TabIndex = 25;
            this.label8.Text = "If you have not Account?";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.button1.Location = new System.Drawing.Point(622, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 39);
            this.button1.TabIndex = 26;
            this.button1.Text = "register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

