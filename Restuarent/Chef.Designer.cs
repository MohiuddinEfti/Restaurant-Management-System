﻿namespace Restuarent
{
    partial class Chef
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FoodReadyButton = new System.Windows.Forms.Button();
            this.FoodRecievedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // FoodReadyButton
            // 
            this.FoodReadyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodReadyButton.Location = new System.Drawing.Point(201, 404);
            this.FoodReadyButton.Name = "FoodReadyButton";
            this.FoodReadyButton.Size = new System.Drawing.Size(168, 23);
            this.FoodReadyButton.TabIndex = 1;
            this.FoodReadyButton.Text = "Food is ready";
            this.FoodReadyButton.UseVisualStyleBackColor = true;
            // 
            // FoodRecievedButton
            // 
            this.FoodRecievedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodRecievedButton.Location = new System.Drawing.Point(410, 404);
            this.FoodRecievedButton.Name = "FoodRecievedButton";
            this.FoodRecievedButton.Size = new System.Drawing.Size(160, 23);
            this.FoodRecievedButton.TabIndex = 2;
            this.FoodRecievedButton.Text = "Food is recieved.";
            this.FoodRecievedButton.UseVisualStyleBackColor = true;
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FoodRecievedButton);
            this.Controls.Add(this.FoodReadyButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Chef";
            this.Text = "Chef";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FoodReadyButton;
        private System.Windows.Forms.Button FoodRecievedButton;
    }
}