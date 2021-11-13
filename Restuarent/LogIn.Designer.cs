
namespace Restuarent
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.Namebox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Signinbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbl_nav = new System.Windows.Forms.Panel();
            this.icon_restore = new System.Windows.Forms.PictureBox();
            this.icon_minimize = new System.Windows.Forms.PictureBox();
            this.icon_maximize = new System.Windows.Forms.PictureBox();
            this.icon_close = new System.Windows.Forms.PictureBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Namebox
            // 
            this.Namebox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Namebox.Location = new System.Drawing.Point(832, 395);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(264, 27);
            this.Namebox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PasswordBox.Location = new System.Drawing.Point(832, 446);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(264, 27);
            this.PasswordBox.TabIndex = 1;
            // 
            // Signinbutton
            // 
            this.Signinbutton.BackColor = System.Drawing.Color.Coral;
            this.Signinbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Signinbutton.Location = new System.Drawing.Point(832, 497);
            this.Signinbutton.Name = "Signinbutton";
            this.Signinbutton.Size = new System.Drawing.Size(264, 48);
            this.Signinbutton.TabIndex = 2;
            this.Signinbutton.Text = "Login";
            this.Signinbutton.UseVisualStyleBackColor = false;
            this.Signinbutton.Click += new System.EventHandler(this.Signinbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1063, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbl_nav
            // 
            this.pbl_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(77)))));
            this.pbl_nav.Controls.Add(this.icon_restore);
            this.pbl_nav.Controls.Add(this.icon_minimize);
            this.pbl_nav.Controls.Add(this.icon_maximize);
            this.pbl_nav.Controls.Add(this.icon_close);
            this.pbl_nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbl_nav.Location = new System.Drawing.Point(0, 0);
            this.pbl_nav.Name = "pbl_nav";
            this.pbl_nav.Size = new System.Drawing.Size(1241, 70);
            this.pbl_nav.TabIndex = 8;
            this.pbl_nav.Paint += new System.Windows.Forms.PaintEventHandler(this.pbl_nav_Paint);
            // 
            // icon_restore
            // 
            this.icon_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_restore.Image = global::Restuarent.Properties.Resources.maximize_window_25px;
            this.icon_restore.Location = new System.Drawing.Point(1173, 19);
            this.icon_restore.Name = "icon_restore";
            this.icon_restore.Size = new System.Drawing.Size(25, 25);
            this.icon_restore.TabIndex = 3;
            this.icon_restore.TabStop = false;
            this.icon_restore.Visible = false;
            this.icon_restore.Click += new System.EventHandler(this.icon_restore_Click);
            // 
            // icon_minimize
            // 
            this.icon_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_minimize.Image = global::Restuarent.Properties.Resources.minimize_window_25px;
            this.icon_minimize.Location = new System.Drawing.Point(1142, 19);
            this.icon_minimize.Name = "icon_minimize";
            this.icon_minimize.Size = new System.Drawing.Size(25, 25);
            this.icon_minimize.TabIndex = 2;
            this.icon_minimize.TabStop = false;
            this.icon_minimize.Click += new System.EventHandler(this.icon_minimize_Click);
            // 
            // icon_maximize
            // 
            this.icon_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_maximize.Location = new System.Drawing.Point(1173, 19);
            this.icon_maximize.Name = "icon_maximize";
            this.icon_maximize.Size = new System.Drawing.Size(25, 25);
            this.icon_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_maximize.TabIndex = 1;
            this.icon_maximize.TabStop = false;
            // 
            // icon_close
            // 
            this.icon_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_close.Image = global::Restuarent.Properties.Resources.close_window_25px;
            this.icon_close.Location = new System.Drawing.Point(1204, 19);
            this.icon_close.Name = "icon_close";
            this.icon_close.Size = new System.Drawing.Size(25, 25);
            this.icon_close.TabIndex = 0;
            this.icon_close.TabStop = false;
            this.icon_close.Click += new System.EventHandler(this.icon_close_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(831, 424);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(82, 19);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(830, 365);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(87, 19);
            this.lbl_username.TabIndex = 14;
            this.lbl_username.Text = "username";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(828, 334);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(275, 19);
            this.lbl_info.TabIndex = 12;
            this.lbl_info.Text = "Please login to start your seesion";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Restuarent.Properties.Resources.undraw_profile_pic_ic5t;
            this.pictureBox2.Location = new System.Drawing.Point(866, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restuarent.Properties.Resources.food;
            this.pictureBox1.Location = new System.Drawing.Point(2, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 604);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1241, 715);
            this.Controls.Add(this.pbl_nav);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Signinbutton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.Namebox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogIn_FormClosed);
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.pbl_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button Signinbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pbl_nav;
        private System.Windows.Forms.PictureBox icon_restore;
        private System.Windows.Forms.PictureBox icon_minimize;
        private System.Windows.Forms.PictureBox icon_maximize;
        private System.Windows.Forms.PictureBox icon_close;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}