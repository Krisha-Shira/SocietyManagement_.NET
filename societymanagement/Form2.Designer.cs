namespace societymanagement
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notice = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Button();
            this.member = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label2.Location = new System.Drawing.Point(420, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dashboard";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MediumOrchid;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, -4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 525);
            this.label3.TabIndex = 2;
            this.label3.Text = "Society Mangement System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumOrchid;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(93, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // notice
            // 
            this.notice.BackColor = System.Drawing.Color.MediumOrchid;
            this.notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.notice.Location = new System.Drawing.Point(413, 201);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(146, 131);
            this.notice.TabIndex = 5;
            this.notice.Text = "Notice & Communication";
            this.notice.UseVisualStyleBackColor = false;
            this.notice.Click += new System.EventHandler(this.notice_Click);
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.MediumOrchid;
            this.main.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.main.Location = new System.Drawing.Point(604, 201);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(146, 131);
            this.main.TabIndex = 6;
            this.main.Text = "Maintenance &Billing";
            this.main.UseVisualStyleBackColor = false;
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.Color.MediumOrchid;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.account.Location = new System.Drawing.Point(413, 369);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(146, 131);
            this.account.TabIndex = 7;
            this.account.Text = "Accounting & Fiance";
            this.account.UseVisualStyleBackColor = false;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // member
            // 
            this.member.BackColor = System.Drawing.Color.MediumOrchid;
            this.member.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.member.Location = new System.Drawing.Point(604, 369);
            this.member.Name = "member";
            this.member.Size = new System.Drawing.Size(146, 131);
            this.member.TabIndex = 8;
            this.member.Text = "Member & Resident\r\n";
            this.member.UseVisualStyleBackColor = false;
            this.member.Click += new System.EventHandler(this.button4_Click);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.MediumOrchid;
            this.profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.profile.Location = new System.Drawing.Point(380, 27);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(85, 62);
            this.profile.TabIndex = 9;
            this.profile.Text = "profile";
            this.profile.UseVisualStyleBackColor = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label4.Location = new System.Drawing.Point(486, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 59);
            this.label4.TabIndex = 10;
            this.label4.Text = "krisha shira";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.member);
            this.Controls.Add(this.account);
            this.Controls.Add(this.main);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DashboardForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button notice;
        private System.Windows.Forms.Button main;
        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Button member;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Label label4;
    }
}


