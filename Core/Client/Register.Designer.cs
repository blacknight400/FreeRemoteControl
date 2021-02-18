
namespace Core
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.LeftWidget = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Tab1 = new System.Windows.Forms.TabPage();
            this.Tab1SubTitle = new System.Windows.Forms.Label();
            this.Tab1Title = new System.Windows.Forms.Label();
            this.Tab1RandomButton = new System.Windows.Forms.Button();
            this.Tab1RegisterButton = new System.Windows.Forms.Button();
            this.Tab1PasswordText = new System.Windows.Forms.TextBox();
            this.Tab2 = new System.Windows.Forms.TabPage();
            this.Tab2GithubButton = new System.Windows.Forms.Button();
            this.TabSubTitle = new System.Windows.Forms.Label();
            this.Tab2Title = new System.Windows.Forms.Label();
            this.Tab3 = new System.Windows.Forms.TabPage();
            this.Tab3Password = new System.Windows.Forms.Label();
            this.Tab3ID = new System.Windows.Forms.Label();
            this.Tab3RestartButton = new System.Windows.Forms.Button();
            this.Tab3Title = new System.Windows.Forms.Label();
            this.Tab3SubTitle = new System.Windows.Forms.Label();
            this.TabText = new System.Windows.Forms.Label();
            this.LeftWidget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.TabControl.SuspendLayout();
            this.Tab1.SuspendLayout();
            this.Tab2.SuspendLayout();
            this.Tab3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftWidget
            // 
            this.LeftWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.LeftWidget.Controls.Add(this.AboutButton);
            this.LeftWidget.Controls.Add(this.RegisterButton);
            this.LeftWidget.Controls.Add(this.Logo);
            this.LeftWidget.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftWidget.Location = new System.Drawing.Point(0, 0);
            this.LeftWidget.Margin = new System.Windows.Forms.Padding(4);
            this.LeftWidget.Name = "LeftWidget";
            this.LeftWidget.Size = new System.Drawing.Size(177, 521);
            this.LeftWidget.TabIndex = 0;
            this.LeftWidget.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftWidget_MouseMove);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Location = new System.Drawing.Point(-2, 253);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(4);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(180, 46);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(-2, 207);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(180, 46);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Core.Properties.Resources.icon;
            this.Logo.Location = new System.Drawing.Point(35, 28);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(104, 102);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // TabControl
            // 
            this.TabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControl.Controls.Add(this.Tab1);
            this.TabControl.Controls.Add(this.Tab2);
            this.TabControl.Controls.Add(this.Tab3);
            this.TabControl.Location = new System.Drawing.Point(151, -12);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 544);
            this.TabControl.TabIndex = 1;
            // 
            // Tab1
            // 
            this.Tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.Tab1.Controls.Add(this.Tab1SubTitle);
            this.Tab1.Controls.Add(this.Tab1Title);
            this.Tab1.Controls.Add(this.Tab1RandomButton);
            this.Tab1.Controls.Add(this.Tab1RegisterButton);
            this.Tab1.Controls.Add(this.Tab1PasswordText);
            this.Tab1.Location = new System.Drawing.Point(23, 4);
            this.Tab1.Name = "Tab1";
            this.Tab1.Padding = new System.Windows.Forms.Padding(3);
            this.Tab1.Size = new System.Drawing.Size(773, 536);
            this.Tab1.TabIndex = 0;
            this.Tab1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tab1_MouseMove);
            // 
            // Tab1SubTitle
            // 
            this.Tab1SubTitle.AutoSize = true;
            this.Tab1SubTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1SubTitle.ForeColor = System.Drawing.Color.White;
            this.Tab1SubTitle.Location = new System.Drawing.Point(236, 172);
            this.Tab1SubTitle.Name = "Tab1SubTitle";
            this.Tab1SubTitle.Size = new System.Drawing.Size(300, 19);
            this.Tab1SubTitle.TabIndex = 5;
            this.Tab1SubTitle.Text = "Random id will be given by the system";
            // 
            // Tab1Title
            // 
            this.Tab1Title.AutoSize = true;
            this.Tab1Title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1Title.ForeColor = System.Drawing.Color.White;
            this.Tab1Title.Location = new System.Drawing.Point(296, 135);
            this.Tab1Title.Name = "Tab1Title";
            this.Tab1Title.Size = new System.Drawing.Size(167, 37);
            this.Tab1Title.TabIndex = 4;
            this.Tab1Title.Text = "Password";
            // 
            // Tab1RandomButton
            // 
            this.Tab1RandomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.Tab1RandomButton.FlatAppearance.BorderSize = 0;
            this.Tab1RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab1RandomButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1RandomButton.ForeColor = System.Drawing.Color.White;
            this.Tab1RandomButton.Location = new System.Drawing.Point(262, 261);
            this.Tab1RandomButton.Margin = new System.Windows.Forms.Padding(4);
            this.Tab1RandomButton.Name = "Tab1RandomButton";
            this.Tab1RandomButton.Size = new System.Drawing.Size(119, 46);
            this.Tab1RandomButton.TabIndex = 3;
            this.Tab1RandomButton.Text = "Create Random Password";
            this.Tab1RandomButton.UseVisualStyleBackColor = false;
            this.Tab1RandomButton.Click += new System.EventHandler(this.Tab1RandomButton_Click);
            // 
            // Tab1RegisterButton
            // 
            this.Tab1RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.Tab1RegisterButton.FlatAppearance.BorderSize = 0;
            this.Tab1RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab1RegisterButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1RegisterButton.ForeColor = System.Drawing.Color.White;
            this.Tab1RegisterButton.Location = new System.Drawing.Point(389, 261);
            this.Tab1RegisterButton.Margin = new System.Windows.Forms.Padding(4);
            this.Tab1RegisterButton.Name = "Tab1RegisterButton";
            this.Tab1RegisterButton.Size = new System.Drawing.Size(119, 46);
            this.Tab1RegisterButton.TabIndex = 2;
            this.Tab1RegisterButton.Text = "Register";
            this.Tab1RegisterButton.UseVisualStyleBackColor = false;
            this.Tab1RegisterButton.Click += new System.EventHandler(this.Tab1RegisterButton_Click);
            // 
            // Tab1PasswordText
            // 
            this.Tab1PasswordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.Tab1PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab1PasswordText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1PasswordText.ForeColor = System.Drawing.Color.White;
            this.Tab1PasswordText.Location = new System.Drawing.Point(262, 217);
            this.Tab1PasswordText.Multiline = true;
            this.Tab1PasswordText.Name = "Tab1PasswordText";
            this.Tab1PasswordText.Size = new System.Drawing.Size(246, 27);
            this.Tab1PasswordText.TabIndex = 0;
            // 
            // Tab2
            // 
            this.Tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.Tab2.Controls.Add(this.Tab2GithubButton);
            this.Tab2.Controls.Add(this.TabSubTitle);
            this.Tab2.Controls.Add(this.Tab2Title);
            this.Tab2.Location = new System.Drawing.Point(23, 4);
            this.Tab2.Name = "Tab2";
            this.Tab2.Padding = new System.Windows.Forms.Padding(3);
            this.Tab2.Size = new System.Drawing.Size(773, 536);
            this.Tab2.TabIndex = 1;
            this.Tab2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tab2_MouseMove);
            // 
            // Tab2GithubButton
            // 
            this.Tab2GithubButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.Tab2GithubButton.FlatAppearance.BorderSize = 0;
            this.Tab2GithubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab2GithubButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2GithubButton.ForeColor = System.Drawing.Color.White;
            this.Tab2GithubButton.Location = new System.Drawing.Point(140, 181);
            this.Tab2GithubButton.Margin = new System.Windows.Forms.Padding(4);
            this.Tab2GithubButton.Name = "Tab2GithubButton";
            this.Tab2GithubButton.Size = new System.Drawing.Size(486, 46);
            this.Tab2GithubButton.TabIndex = 11;
            this.Tab2GithubButton.Text = "Github";
            this.Tab2GithubButton.UseVisualStyleBackColor = false;
            this.Tab2GithubButton.Click += new System.EventHandler(this.Tab2GithubButton_Click);
            // 
            // TabSubTitle
            // 
            this.TabSubTitle.AutoSize = true;
            this.TabSubTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabSubTitle.ForeColor = System.Drawing.Color.White;
            this.TabSubTitle.Location = new System.Drawing.Point(137, 142);
            this.TabSubTitle.Name = "TabSubTitle";
            this.TabSubTitle.Size = new System.Drawing.Size(490, 19);
            this.TabSubTitle.TabIndex = 10;
            this.TabSubTitle.Text = "This is free software that is shared as open source. Not for sale!";
            // 
            // Tab2Title
            // 
            this.Tab2Title.AutoSize = true;
            this.Tab2Title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2Title.ForeColor = System.Drawing.Color.White;
            this.Tab2Title.Location = new System.Drawing.Point(211, 105);
            this.Tab2Title.Name = "Tab2Title";
            this.Tab2Title.Size = new System.Drawing.Size(341, 37);
            this.Tab2Title.TabIndex = 9;
            this.Tab2Title.Text = "Developed by Majdev";
            // 
            // Tab3
            // 
            this.Tab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.Tab3.Controls.Add(this.Tab3Password);
            this.Tab3.Controls.Add(this.Tab3ID);
            this.Tab3.Controls.Add(this.Tab3RestartButton);
            this.Tab3.Controls.Add(this.Tab3Title);
            this.Tab3.Controls.Add(this.Tab3SubTitle);
            this.Tab3.Location = new System.Drawing.Point(23, 4);
            this.Tab3.Name = "Tab3";
            this.Tab3.Size = new System.Drawing.Size(773, 536);
            this.Tab3.TabIndex = 2;
            this.Tab3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tab3_MouseMove);
            // 
            // Tab3Password
            // 
            this.Tab3Password.AutoSize = true;
            this.Tab3Password.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3Password.ForeColor = System.Drawing.Color.White;
            this.Tab3Password.Location = new System.Drawing.Point(305, 191);
            this.Tab3Password.Name = "Tab3Password";
            this.Tab3Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tab3Password.Size = new System.Drawing.Size(0, 24);
            this.Tab3Password.TabIndex = 16;
            this.Tab3Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab3ID
            // 
            this.Tab3ID.AutoSize = true;
            this.Tab3ID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3ID.ForeColor = System.Drawing.Color.White;
            this.Tab3ID.Location = new System.Drawing.Point(340, 167);
            this.Tab3ID.Name = "Tab3ID";
            this.Tab3ID.Size = new System.Drawing.Size(0, 24);
            this.Tab3ID.TabIndex = 15;
            this.Tab3ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab3RestartButton
            // 
            this.Tab3RestartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.Tab3RestartButton.FlatAppearance.BorderSize = 0;
            this.Tab3RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab3RestartButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3RestartButton.ForeColor = System.Drawing.Color.White;
            this.Tab3RestartButton.Location = new System.Drawing.Point(233, 228);
            this.Tab3RestartButton.Margin = new System.Windows.Forms.Padding(4);
            this.Tab3RestartButton.Name = "Tab3RestartButton";
            this.Tab3RestartButton.Size = new System.Drawing.Size(306, 46);
            this.Tab3RestartButton.TabIndex = 14;
            this.Tab3RestartButton.Text = "Restart Application";
            this.Tab3RestartButton.UseVisualStyleBackColor = false;
            this.Tab3RestartButton.Click += new System.EventHandler(this.Tab3RestartButton_Click);
            // 
            // Tab3Title
            // 
            this.Tab3Title.AutoSize = true;
            this.Tab3Title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3Title.ForeColor = System.Drawing.Color.White;
            this.Tab3Title.Location = new System.Drawing.Point(296, 94);
            this.Tab3Title.Name = "Tab3Title";
            this.Tab3Title.Size = new System.Drawing.Size(197, 37);
            this.Tab3Title.TabIndex = 12;
            this.Tab3Title.Text = "Successful!";
            // 
            // Tab3SubTitle
            // 
            this.Tab3SubTitle.AutoSize = true;
            this.Tab3SubTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3SubTitle.ForeColor = System.Drawing.Color.White;
            this.Tab3SubTitle.Location = new System.Drawing.Point(40, 133);
            this.Tab3SubTitle.Name = "Tab3SubTitle";
            this.Tab3SubTitle.Size = new System.Drawing.Size(695, 19);
            this.Tab3SubTitle.TabIndex = 13;
            this.Tab3SubTitle.Text = "Installation is successful. Please restart the application then you can use the c" +
    "ontrol panel!";
            // 
            // TabText
            // 
            this.TabText.AutoSize = true;
            this.TabText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabText.ForeColor = System.Drawing.Color.White;
            this.TabText.Location = new System.Drawing.Point(188, 16);
            this.TabText.Name = "TabText";
            this.TabText.Size = new System.Drawing.Size(0, 29);
            this.TabText.TabIndex = 3;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(943, 521);
            this.Controls.Add(this.TabText);
            this.Controls.Add(this.LeftWidget);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            this.LeftWidget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.Tab1.ResumeLayout(false);
            this.Tab1.PerformLayout();
            this.Tab2.ResumeLayout(false);
            this.Tab2.PerformLayout();
            this.Tab3.ResumeLayout(false);
            this.Tab3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftWidget;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Tab1;
        private System.Windows.Forms.TabPage Tab2;
        private System.Windows.Forms.TextBox Tab1PasswordText;
        private System.Windows.Forms.Label TabText;
        private System.Windows.Forms.Button Tab1RegisterButton;
        private System.Windows.Forms.Button Tab1RandomButton;
        private System.Windows.Forms.Label Tab1SubTitle;
        private System.Windows.Forms.Label Tab1Title;
        private System.Windows.Forms.Button Tab2GithubButton;
        private System.Windows.Forms.Label TabSubTitle;
        private System.Windows.Forms.Label Tab2Title;
        private System.Windows.Forms.TabPage Tab3;
        private System.Windows.Forms.Label Tab3Password;
        private System.Windows.Forms.Label Tab3ID;
        private System.Windows.Forms.Button Tab3RestartButton;
        private System.Windows.Forms.Label Tab3Title;
        private System.Windows.Forms.Label Tab3SubTitle;
    }
}