namespace DBMS_Assignment
{
    partial class Employee
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
            this.pnEmInfo = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDateWork = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.DateWork = new System.Windows.Forms.DateTimePicker();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblChild = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.cbChild = new System.Windows.Forms.ComboBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.cbFamily = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.lblEmInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnEmInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 350);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1610, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // pnEmInfo
            // 
            this.pnEmInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnEmInfo.Controls.Add(this.btnDelete);
            this.pnEmInfo.Controls.Add(this.btnUpdate);
            this.pnEmInfo.Controls.Add(this.btnAdd);
            this.pnEmInfo.Controls.Add(this.btnReload);
            this.pnEmInfo.Controls.Add(this.btnUpload);
            this.pnEmInfo.Controls.Add(this.pictureBox1);
            this.pnEmInfo.Controls.Add(this.lblDateWork);
            this.pnEmInfo.Controls.Add(this.lblAddress);
            this.pnEmInfo.Controls.Add(this.lblPhone);
            this.pnEmInfo.Controls.Add(this.txtAddress);
            this.pnEmInfo.Controls.Add(this.txtPhone);
            this.pnEmInfo.Controls.Add(this.DateWork);
            this.pnEmInfo.Controls.Add(this.lblDepartment);
            this.pnEmInfo.Controls.Add(this.lblRole);
            this.pnEmInfo.Controls.Add(this.lblChild);
            this.pnEmInfo.Controls.Add(this.lblFamily);
            this.pnEmInfo.Controls.Add(this.cbChild);
            this.pnEmInfo.Controls.Add(this.cbRole);
            this.pnEmInfo.Controls.Add(this.cbDepartment);
            this.pnEmInfo.Controls.Add(this.cbFamily);
            this.pnEmInfo.Controls.Add(this.lblStatus);
            this.pnEmInfo.Controls.Add(this.lblDateBirth);
            this.pnEmInfo.Controls.Add(this.lblSex);
            this.pnEmInfo.Controls.Add(this.lblName);
            this.pnEmInfo.Controls.Add(this.cbStatus);
            this.pnEmInfo.Controls.Add(this.dateBirth);
            this.pnEmInfo.Controls.Add(this.cbSex);
            this.pnEmInfo.Controls.Add(this.txtEmployee);
            this.pnEmInfo.Controls.Add(this.lblEmInfo);
            this.pnEmInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEmInfo.Location = new System.Drawing.Point(0, 0);
            this.pnEmInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pnEmInfo.Name = "pnEmInfo";
            this.pnEmInfo.Size = new System.Drawing.Size(1610, 350);
            this.pnEmInfo.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(1415, 158);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 29);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(1415, 125);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 29);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(1415, 92);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 29);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReload.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReload.Location = new System.Drawing.Point(1415, 191);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(99, 29);
            this.btnReload.TabIndex = 33;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpload.Location = new System.Drawing.Point(1415, 59);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(99, 29);
            this.btnUpload.TabIndex = 32;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBMS_Assignment.Properties.Resources.photo_2023_08_09_10_12_55;
            this.pictureBox1.Location = new System.Drawing.Point(1270, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // lblDateWork
            // 
            this.lblDateWork.AutoSize = true;
            this.lblDateWork.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateWork.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDateWork.Location = new System.Drawing.Point(452, 164);
            this.lblDateWork.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateWork.Name = "lblDateWork";
            this.lblDateWork.Size = new System.Drawing.Size(108, 24);
            this.lblDateWork.TabIndex = 30;
            this.lblDateWork.Text = "ថ្ងៃខែឆ្នាំចូលធ្វើការ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAddress.Location = new System.Drawing.Point(959, 164);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 24);
            this.lblAddress.TabIndex = 29;
            this.lblAddress.Text = "អាស័យដ្ឋាន";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPhone.Location = new System.Drawing.Point(735, 164);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(75, 24);
            this.lblPhone.TabIndex = 28;
            this.lblPhone.Text = "លេខទូរស័ព្ទ";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Khmer OS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(963, 190);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(205, 30);
            this.txtAddress.TabIndex = 27;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Khmer OS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(739, 190);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(209, 30);
            this.txtPhone.TabIndex = 26;
            // 
            // DateWork
            // 
            this.DateWork.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateWork.Location = new System.Drawing.Point(456, 188);
            this.DateWork.Margin = new System.Windows.Forms.Padding(2);
            this.DateWork.Name = "DateWork";
            this.DateWork.Size = new System.Drawing.Size(267, 32);
            this.DateWork.TabIndex = 25;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDepartment.Location = new System.Drawing.Point(279, 164);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(33, 24);
            this.lblDepartment.TabIndex = 24;
            this.lblDepartment.Text = "ផ្នែក";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.Window;
            this.lblRole.Location = new System.Drawing.Point(88, 164);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 24);
            this.lblRole.TabIndex = 23;
            this.lblRole.Text = "តួនាទី";
            // 
            // lblChild
            // 
            this.lblChild.AutoSize = true;
            this.lblChild.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChild.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChild.Location = new System.Drawing.Point(1025, 33);
            this.lblChild.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(55, 24);
            this.lblChild.TabIndex = 22;
            this.lblChild.Text = "ចំនួនកូន";
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamily.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFamily.Location = new System.Drawing.Point(871, 33);
            this.lblFamily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(74, 24);
            this.lblFamily.TabIndex = 21;
            this.lblFamily.Text = "មានប្ដីប្រពន្ធ";
            // 
            // cbChild
            // 
            this.cbChild.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChild.FormattingEnabled = true;
            this.cbChild.Location = new System.Drawing.Point(1029, 59);
            this.cbChild.Margin = new System.Windows.Forms.Padding(2);
            this.cbChild.Name = "cbChild";
            this.cbChild.Size = new System.Drawing.Size(139, 32);
            this.cbChild.TabIndex = 20;
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(92, 188);
            this.cbRole.Margin = new System.Windows.Forms.Padding(2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(178, 32);
            this.cbRole.TabIndex = 19;
            // 
            // cbDepartment
            // 
            this.cbDepartment.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(283, 188);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(160, 32);
            this.cbDepartment.TabIndex = 18;
            // 
            // cbFamily
            // 
            this.cbFamily.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFamily.FormattingEnabled = true;
            this.cbFamily.Location = new System.Drawing.Point(875, 59);
            this.cbFamily.Margin = new System.Windows.Forms.Padding(2);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(140, 32);
            this.cbFamily.TabIndex = 16;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStatus.Location = new System.Drawing.Point(699, 32);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 24);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "ស្ថានភាព";
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBirth.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDateBirth.Location = new System.Drawing.Point(468, 33);
            this.lblDateBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(93, 24);
            this.lblDateBirth.TabIndex = 14;
            this.lblDateBirth.Text = "ថ្ងៃខែឆ្នាំកំណើត";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSex.Location = new System.Drawing.Point(332, 33);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(33, 24);
            this.lblSex.TabIndex = 13;
            this.lblSex.Text = "ភេទ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(88, 32);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 24);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "ឈ្មោះបុគ្គលិក";
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(703, 59);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(159, 32);
            this.cbStatus.TabIndex = 5;
            // 
            // dateBirth
            // 
            this.dateBirth.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirth.Location = new System.Drawing.Point(472, 59);
            this.dateBirth.Margin = new System.Windows.Forms.Padding(2);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(217, 32);
            this.dateBirth.TabIndex = 4;
            // 
            // cbSex
            // 
            this.cbSex.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(336, 59);
            this.cbSex.Margin = new System.Windows.Forms.Padding(2);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(123, 32);
            this.cbSex.TabIndex = 3;
            // 
            // txtEmployee
            // 
            this.txtEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployee.Font = new System.Drawing.Font("Khmer OS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee.Location = new System.Drawing.Point(92, 59);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(230, 30);
            this.txtEmployee.TabIndex = 2;
            // 
            // lblEmInfo
            // 
            this.lblEmInfo.AutoSize = true;
            this.lblEmInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmInfo.Location = new System.Drawing.Point(2, 0);
            this.lblEmInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmInfo.Name = "lblEmInfo";
            this.lblEmInfo.Size = new System.Drawing.Size(239, 25);
            this.lblEmInfo.TabIndex = 0;
            this.lblEmInfo.Text = "Employee Information";
            this.lblEmInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1610, 800);
            this.Controls.Add(this.pnEmInfo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnEmInfo.ResumeLayout(false);
            this.pnEmInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnEmInfo;
        private System.Windows.Forms.Label lblEmInfo;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbChild;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.ComboBox cbFamily;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker DateWork;
        private System.Windows.Forms.Label lblDateWork;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}