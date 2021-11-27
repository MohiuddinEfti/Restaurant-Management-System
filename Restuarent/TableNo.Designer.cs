
namespace Restuarent
{
    partial class TableNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableNo));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.icon_restore = new System.Windows.Forms.PictureBox();
            this.icon_minimize = new System.Windows.Forms.PictureBox();
            this.icon_maximize = new System.Windows.Forms.PictureBox();
            this.icon_close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon_restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_close)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(541, 298);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 27);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table Number:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(541, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // icon_restore
            // 
            this.icon_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_restore.BackColor = System.Drawing.Color.Black;
            this.icon_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_restore.Image = global::Restuarent.Properties.Resources.maximize_window_25px;
            this.icon_restore.Location = new System.Drawing.Point(1091, 12);
            this.icon_restore.Name = "icon_restore";
            this.icon_restore.Size = new System.Drawing.Size(25, 25);
            this.icon_restore.TabIndex = 7;
            this.icon_restore.TabStop = false;
            this.icon_restore.Visible = false;
            this.icon_restore.Click += new System.EventHandler(this.icon_restore_Click);
            // 
            // icon_minimize
            // 
            this.icon_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_minimize.BackColor = System.Drawing.Color.Black;
            this.icon_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_minimize.Image = global::Restuarent.Properties.Resources.minimize_window_25px;
            this.icon_minimize.Location = new System.Drawing.Point(1060, 12);
            this.icon_minimize.Name = "icon_minimize";
            this.icon_minimize.Size = new System.Drawing.Size(25, 25);
            this.icon_minimize.TabIndex = 6;
            this.icon_minimize.TabStop = false;
            this.icon_minimize.Click += new System.EventHandler(this.icon_minimize_Click);
            // 
            // icon_maximize
            // 
            this.icon_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_maximize.BackColor = System.Drawing.Color.Black;
            this.icon_maximize.Location = new System.Drawing.Point(1091, 12);
            this.icon_maximize.Name = "icon_maximize";
            this.icon_maximize.Size = new System.Drawing.Size(25, 25);
            this.icon_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_maximize.TabIndex = 5;
            this.icon_maximize.TabStop = false;
            // 
            // icon_close
            // 
            this.icon_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_close.BackColor = System.Drawing.Color.Black;
            this.icon_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_close.Image = global::Restuarent.Properties.Resources.close_window_25px;
            this.icon_close.Location = new System.Drawing.Point(1122, 12);
            this.icon_close.Name = "icon_close";
            this.icon_close.Size = new System.Drawing.Size(25, 25);
            this.icon_close.TabIndex = 4;
            this.icon_close.TabStop = false;
            this.icon_close.Click += new System.EventHandler(this.icon_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(544, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loading";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TableNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 676);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.icon_restore);
            this.Controls.Add(this.icon_minimize);
            this.Controls.Add(this.icon_maximize);
            this.Controls.Add(this.icon_close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableNo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TableNo_FormClosed);
            this.Load += new System.EventHandler(this.TableNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon_restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox icon_restore;
        private System.Windows.Forms.PictureBox icon_minimize;
        private System.Windows.Forms.PictureBox icon_maximize;
        private System.Windows.Forms.PictureBox icon_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}