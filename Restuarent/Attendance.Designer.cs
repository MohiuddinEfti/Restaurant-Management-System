
namespace Restuarent
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.icon_restore = new System.Windows.Forms.PictureBox();
            this.icon_minimize = new System.Windows.Forms.PictureBox();
            this.icon_maximize = new System.Windows.Forms.PictureBox();
            this.icon_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_close)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(387, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(501, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Present";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(197, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(868, 405);
            this.dataGridView1.TabIndex = 24;
            // 
            // icon_restore
            // 
            this.icon_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_restore.BackColor = System.Drawing.Color.Transparent;
            this.icon_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_restore.Image = global::Restuarent.Properties.Resources.maximize_window_25px;
            this.icon_restore.Location = new System.Drawing.Point(1209, 3);
            this.icon_restore.Name = "icon_restore";
            this.icon_restore.Size = new System.Drawing.Size(25, 25);
            this.icon_restore.TabIndex = 52;
            this.icon_restore.TabStop = false;
            this.icon_restore.Visible = false;
            this.icon_restore.Click += new System.EventHandler(this.icon_restore_Click);
            // 
            // icon_minimize
            // 
            this.icon_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_minimize.BackColor = System.Drawing.Color.Transparent;
            this.icon_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_minimize.Image = global::Restuarent.Properties.Resources.minimize_window_25px;
            this.icon_minimize.Location = new System.Drawing.Point(1182, 3);
            this.icon_minimize.Name = "icon_minimize";
            this.icon_minimize.Size = new System.Drawing.Size(25, 25);
            this.icon_minimize.TabIndex = 51;
            this.icon_minimize.TabStop = false;
            this.icon_minimize.Click += new System.EventHandler(this.icon_minimize_Click);
            // 
            // icon_maximize
            // 
            this.icon_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_maximize.BackColor = System.Drawing.Color.Transparent;
            this.icon_maximize.Location = new System.Drawing.Point(1203, 1);
            this.icon_maximize.Name = "icon_maximize";
            this.icon_maximize.Size = new System.Drawing.Size(25, 25);
            this.icon_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_maximize.TabIndex = 50;
            this.icon_maximize.TabStop = false;
            // 
            // icon_close
            // 
            this.icon_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_close.BackColor = System.Drawing.Color.Transparent;
            this.icon_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_close.Image = global::Restuarent.Properties.Resources.close_window_25px;
            this.icon_close.Location = new System.Drawing.Point(1236, 3);
            this.icon_close.Name = "icon_close";
            this.icon_close.Size = new System.Drawing.Size(25, 25);
            this.icon_close.TabIndex = 49;
            this.icon_close.TabStop = false;
            this.icon_close.Click += new System.EventHandler(this.icon_close_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.icon_restore);
            this.Controls.Add(this.icon_minimize);
            this.Controls.Add(this.icon_maximize);
            this.Controls.Add(this.icon_close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Attendance_FormClosed);
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox icon_restore;
        private System.Windows.Forms.PictureBox icon_minimize;
        private System.Windows.Forms.PictureBox icon_maximize;
        private System.Windows.Forms.PictureBox icon_close;
    }
}