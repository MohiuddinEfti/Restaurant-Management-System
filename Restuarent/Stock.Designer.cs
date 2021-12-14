namespace Restuarent
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ChickenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddStockButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.icon_restore = new System.Windows.Forms.PictureBox();
            this.icon_minimize = new System.Windows.Forms.PictureBox();
            this.icon_maximize = new System.Windows.Forms.PictureBox();
            this.icon_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_close)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(309, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(511, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ChickenTextBox
            // 
            this.ChickenTextBox.ForeColor = System.Drawing.Color.Black;
            this.ChickenTextBox.Location = new System.Drawing.Point(18, 164);
            this.ChickenTextBox.Name = "ChickenTextBox";
            this.ChickenTextBox.Size = new System.Drawing.Size(115, 22);
            this.ChickenTextBox.TabIndex = 1;
            this.ChickenTextBox.TextChanged += new System.EventHandler(this.ChickenTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item Weight";
            // 
            // AddStockButton
            // 
            this.AddStockButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddStockButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStockButton.Location = new System.Drawing.Point(407, 516);
            this.AddStockButton.Name = "AddStockButton";
            this.AddStockButton.Size = new System.Drawing.Size(137, 38);
            this.AddStockButton.TabIndex = 19;
            this.AddStockButton.Text = "Add Stock";
            this.AddStockButton.UseVisualStyleBackColor = false;
            this.AddStockButton.Click += new System.EventHandler(this.AddStockButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(570, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ChickenTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(835, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 293);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Item";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(18, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 22);
            this.textBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Item Name";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1178, 646);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(738, 516);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(137, 38);
            this.DeleteButton.TabIndex = 23;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // icon_restore
            // 
            this.icon_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_restore.BackColor = System.Drawing.Color.Transparent;
            this.icon_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_restore.Image = global::Restuarent.Properties.Resources.maximize_window_25px;
            this.icon_restore.Location = new System.Drawing.Point(1209, 0);
            this.icon_restore.Name = "icon_restore";
            this.icon_restore.Size = new System.Drawing.Size(25, 25);
            this.icon_restore.TabIndex = 27;
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
            this.icon_minimize.Location = new System.Drawing.Point(1178, 0);
            this.icon_minimize.Name = "icon_minimize";
            this.icon_minimize.Size = new System.Drawing.Size(25, 25);
            this.icon_minimize.TabIndex = 26;
            this.icon_minimize.TabStop = false;
            this.icon_minimize.Click += new System.EventHandler(this.icon_minimize_Click);
            // 
            // icon_maximize
            // 
            this.icon_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_maximize.BackColor = System.Drawing.Color.Transparent;
            this.icon_maximize.Location = new System.Drawing.Point(1211, -1);
            this.icon_maximize.Name = "icon_maximize";
            this.icon_maximize.Size = new System.Drawing.Size(25, 25);
            this.icon_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_maximize.TabIndex = 25;
            this.icon_maximize.TabStop = false;
            // 
            // icon_close
            // 
            this.icon_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_close.BackColor = System.Drawing.Color.Transparent;
            this.icon_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_close.Image = global::Restuarent.Properties.Resources.close_window_25px;
            this.icon_close.Location = new System.Drawing.Point(1240, 0);
            this.icon_close.Name = "icon_close";
            this.icon_close.Size = new System.Drawing.Size(25, 25);
            this.icon_close.TabIndex = 24;
            this.icon_close.TabStop = false;
            this.icon_close.Click += new System.EventHandler(this.icon_close_Click);
            // 
            // Stock
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
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddStockButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stock_FormClosing);
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ChickenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddStockButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox icon_restore;
        private System.Windows.Forms.PictureBox icon_minimize;
        private System.Windows.Forms.PictureBox icon_maximize;
        private System.Windows.Forms.PictureBox icon_close;
    }
}