
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
            this.SuspendLayout();
            // 
            // Namebox
            // 
            this.Namebox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namebox.Location = new System.Drawing.Point(679, 263);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(328, 26);
            this.Namebox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(681, 314);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(328, 26);
            this.PasswordBox.TabIndex = 1;
            // 
            // Signinbutton
            // 
            this.Signinbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Signinbutton.BackColor = System.Drawing.Color.Coral;
            this.Signinbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Signinbutton.Location = new System.Drawing.Point(732, 388);
            this.Signinbutton.Name = "Signinbutton";
            this.Signinbutton.Size = new System.Drawing.Size(231, 48);
            this.Signinbutton.TabIndex = 2;
            this.Signinbutton.Text = "Login";
            this.Signinbutton.UseVisualStyleBackColor = false;
            this.Signinbutton.Click += new System.EventHandler(this.Signinbutton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(977, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1241, 715);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Signinbutton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.Namebox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogIn_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button Signinbutton;
        private System.Windows.Forms.Button button1;
    }
}