namespace management_system
{
    partial class ManageCustomers
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernsme = new System.Windows.Forms.Label();
            this.CusName = new System.Windows.Forms.TextBox();
            this.CusPhone = new System.Windows.Forms.TextBox();
            this.CusID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(800, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "x";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 439);
            this.dataGridView1.TabIndex = 56;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(197, 316);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 37);
            this.Delete.TabIndex = 55;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(102, 316);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 37);
            this.Update.TabIndex = 54;
            this.Update.Text = "UPDATE";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(9, 316);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 37);
            this.Add.TabIndex = 53;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "CUSTOMER CONTACT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "CUSTOMER NAME";
            // 
            // usernsme
            // 
            this.usernsme.AutoSize = true;
            this.usernsme.Location = new System.Drawing.Point(6, 100);
            this.usernsme.Name = "usernsme";
            this.usernsme.Size = new System.Drawing.Size(82, 13);
            this.usernsme.TabIndex = 50;
            this.usernsme.Text = "CUSTOMER ID";
            // 
            // CusName
            // 
            this.CusName.Location = new System.Drawing.Point(127, 154);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(165, 20);
            this.CusName.TabIndex = 49;
            // 
            // CusPhone
            // 
            this.CusPhone.Location = new System.Drawing.Point(127, 212);
            this.CusPhone.Name = "CusPhone";
            this.CusPhone.Size = new System.Drawing.Size(165, 20);
            this.CusPhone.TabIndex = 48;
            // 
            // CusID
            // 
            this.CusID.Location = new System.Drawing.Point(127, 97);
            this.CusID.Name = "CusID";
            this.CusID.Size = new System.Drawing.Size(165, 20);
            this.CusID.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "MANAGE CUSTOMERS";
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(816, 545);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernsme);
            this.Controls.Add(this.CusName);
            this.Controls.Add(this.CusPhone);
            this.Controls.Add(this.CusID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomers";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Button Update;
        public System.Windows.Forms.Button Add;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label usernsme;
        public System.Windows.Forms.TextBox CusName;
        public System.Windows.Forms.TextBox CusPhone;
        public System.Windows.Forms.TextBox CusID;
        private System.Windows.Forms.Label label1;
    }
}