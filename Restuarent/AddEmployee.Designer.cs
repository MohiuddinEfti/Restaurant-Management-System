﻿namespace Restuarent
{
    partial class AddEmployee
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
            this.SignUpGroupBox = new System.Windows.Forms.GroupBox();
            this.Phonetextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BloodGroupLabel = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Salarytextbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SignUpGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpGroupBox
            // 
            this.SignUpGroupBox.Controls.Add(this.Salarytextbox);
            this.SignUpGroupBox.Controls.Add(this.label2);
            this.SignUpGroupBox.Controls.Add(this.Phonetextbox);
            this.SignUpGroupBox.Controls.Add(this.label1);
            this.SignUpGroupBox.Controls.Add(this.comboBox1);
            this.SignUpGroupBox.Controls.Add(this.BloodGroupLabel);
            this.SignUpGroupBox.Controls.Add(this.radioButton2);
            this.SignUpGroupBox.Controls.Add(this.radioButton1);
            this.SignUpGroupBox.Controls.Add(this.GenderLabel);
            this.SignUpGroupBox.Controls.Add(this.dateTimePicker1);
            this.SignUpGroupBox.Controls.Add(this.DateOfBirthLabel);
            this.SignUpGroupBox.Controls.Add(this.EmailTextBox);
            this.SignUpGroupBox.Controls.Add(this.EmailLabel);
            this.SignUpGroupBox.Controls.Add(this.NameTextBox);
            this.SignUpGroupBox.Controls.Add(this.NameLabel);
            this.SignUpGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpGroupBox.Location = new System.Drawing.Point(12, 26);
            this.SignUpGroupBox.Name = "SignUpGroupBox";
            this.SignUpGroupBox.Size = new System.Drawing.Size(596, 412);
            this.SignUpGroupBox.TabIndex = 1;
            this.SignUpGroupBox.TabStop = false;
            this.SignUpGroupBox.Text = "To add an employee, fill in the spaces with the employee details";
            // 
            // Phonetextbox
            // 
            this.Phonetextbox.Location = new System.Drawing.Point(208, 162);
            this.Phonetextbox.Name = "Phonetextbox";
            this.Phonetextbox.Size = new System.Drawing.Size(188, 26);
            this.Phonetextbox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Phone Number";
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(709, 378);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(125, 60);
            this.AddEmployeeButton.TabIndex = 16;
            this.AddEmployeeButton.Text = "ADD EMPLOYEE";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "AB+",
            "AB-",
            "B+",
            "B-"});
            this.comboBox1.Location = new System.Drawing.Point(223, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 28);
            this.comboBox1.TabIndex = 14;
            // 
            // BloodGroupLabel
            // 
            this.BloodGroupLabel.AutoSize = true;
            this.BloodGroupLabel.Location = new System.Drawing.Point(86, 286);
            this.BloodGroupLabel.Name = "BloodGroupLabel";
            this.BloodGroupLabel.Size = new System.Drawing.Size(110, 20);
            this.BloodGroupLabel.TabIndex = 13;
            this.BloodGroupLabel.Text = "Blood Group";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(344, 244);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 24);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(223, 244);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 24);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(127, 248);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(69, 20);
            this.GenderLabel.TabIndex = 10;
            this.GenderLabel.Text = "Gender";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 201);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 1, 4, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(306, 26);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 18, 0, 0, 0, 0);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(74, 207);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(112, 20);
            this.DateOfBirthLabel.TabIndex = 8;
            this.DateOfBirthLabel.Text = "Date of Birth";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(208, 113);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(188, 26);
            this.EmailTextBox.TabIndex = 7;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(127, 119);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(53, 20);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(209, 64);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(188, 26);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(124, 65);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(55, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Salary";
            // 
            // Salarytextbox
            // 
            this.Salarytextbox.Location = new System.Drawing.Point(208, 341);
            this.Salarytextbox.Name = "Salarytextbox";
            this.Salarytextbox.Size = new System.Drawing.Size(189, 26);
            this.Salarytextbox.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(684, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(509, 206);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(684, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(888, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(847, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 60);
            this.button1.TabIndex = 22;
            this.button1.Text = "UPDATE EMPLOYEE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(987, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 60);
            this.button2.TabIndex = 23;
            this.button2.Text = "DELETE EMPLOYEE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 715);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SignUpGroupBox);
            this.Controls.Add(this.AddEmployeeButton);
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEmployee_FormClosing);
            this.SignUpGroupBox.ResumeLayout(false);
            this.SignUpGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SignUpGroupBox;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label BloodGroupLabel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox Phonetextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Salarytextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}