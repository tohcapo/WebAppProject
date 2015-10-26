namespace AS3_WebAppProject
{
    partial class FormCustomerIncidents
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
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOpened = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnDateClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textZip = new System.Windows.Forms.TextBox();
            this.textState = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textCustomerIDDisplay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGetCustomer = new System.Windows.Forms.Button();
            this.textCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.HeaderText = "Title";
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.ReadOnly = true;
            this.ColumnTitle.Width = 200;
            // 
            // ColumnDateOpened
            // 
            this.ColumnDateOpened.HeaderText = "Date Opened";
            this.ColumnDateOpened.Name = "ColumnDateOpened";
            this.ColumnDateOpened.ReadOnly = true;
            // 
            // ColumnProduct
            // 
            this.ColumnProduct.HeaderText = "Product";
            this.ColumnProduct.Name = "ColumnProduct";
            this.ColumnProduct.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProduct,
            this.ColumnDateOpened,
            this.ColumnDateClosed,
            this.ColumnTitle});
            this.dataGridView1.Location = new System.Drawing.Point(15, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(578, 150);
            this.dataGridView1.TabIndex = 35;
            // 
            // ColumnDateClosed
            // 
            this.ColumnDateClosed.HeaderText = "Date Closed";
            this.ColumnDateClosed.Name = "ColumnDateClosed";
            this.ColumnDateClosed.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "City. State. Zip:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Address:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(97, 167);
            this.textEmail.Name = "textEmail";
            this.textEmail.ReadOnly = true;
            this.textEmail.Size = new System.Drawing.Size(245, 20);
            this.textEmail.TabIndex = 30;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(97, 141);
            this.textPhone.Name = "textPhone";
            this.textPhone.ReadOnly = true;
            this.textPhone.Size = new System.Drawing.Size(100, 20);
            this.textPhone.TabIndex = 29;
            // 
            // textZip
            // 
            this.textZip.Location = new System.Drawing.Point(277, 115);
            this.textZip.Name = "textZip";
            this.textZip.ReadOnly = true;
            this.textZip.Size = new System.Drawing.Size(66, 20);
            this.textZip.TabIndex = 28;
            // 
            // textState
            // 
            this.textState.Location = new System.Drawing.Point(226, 115);
            this.textState.Name = "textState";
            this.textState.ReadOnly = true;
            this.textState.Size = new System.Drawing.Size(45, 20);
            this.textState.TabIndex = 27;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(97, 115);
            this.textCity.Name = "textCity";
            this.textCity.ReadOnly = true;
            this.textCity.Size = new System.Drawing.Size(121, 20);
            this.textCity.TabIndex = 26;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(97, 91);
            this.textAddress.Name = "textAddress";
            this.textAddress.ReadOnly = true;
            this.textAddress.Size = new System.Drawing.Size(246, 20);
            this.textAddress.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(98, 61);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(245, 20);
            this.textName.TabIndex = 23;
            // 
            // textCustomerIDDisplay
            // 
            this.textCustomerIDDisplay.Location = new System.Drawing.Point(98, 37);
            this.textCustomerIDDisplay.Name = "textCustomerIDDisplay";
            this.textCustomerIDDisplay.ReadOnly = true;
            this.textCustomerIDDisplay.Size = new System.Drawing.Size(100, 20);
            this.textCustomerIDDisplay.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Customer ID:";
            // 
            // buttonGetCustomer
            // 
            this.buttonGetCustomer.Location = new System.Drawing.Point(204, 7);
            this.buttonGetCustomer.Name = "buttonGetCustomer";
            this.buttonGetCustomer.Size = new System.Drawing.Size(88, 23);
            this.buttonGetCustomer.TabIndex = 20;
            this.buttonGetCustomer.Text = "Get Customer";
            this.buttonGetCustomer.UseVisualStyleBackColor = true;
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(98, 7);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textCustomerID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer ID:";
            // 
            // FormCustomerIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 362);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textZip);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textCustomerIDDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGetCustomer);
            this.Controls.Add(this.textCustomerID);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomerIncidents";
            this.Text = "FormCustomerIncidents";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOpened;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateClosed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textZip;
        private System.Windows.Forms.TextBox textState;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textCustomerIDDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGetCustomer;
        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.Label label1;
    }
}