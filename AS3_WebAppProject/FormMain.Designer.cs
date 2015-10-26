namespace AS3_WebAppProject
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonTechnicianMaintenance = new System.Windows.Forms.Button();
            this.buttonProductMaintenance = new System.Windows.Forms.Button();
            this.buttonCustomerIncidents = new System.Windows.Forms.Button();
            this.buttonAddIncident = new System.Windows.Forms.Button();
            this.buttonAddRegistration = new System.Windows.Forms.Button();
            this.buttonUserAccountMaintenance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(77, 12);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(155, 20);
            this.textBoxUserID.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(77, 38);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(155, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(157, 64);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "&Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(157, 306);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonTechnicianMaintenance
            // 
            this.buttonTechnicianMaintenance.Location = new System.Drawing.Point(22, 93);
            this.buttonTechnicianMaintenance.Name = "buttonTechnicianMaintenance";
            this.buttonTechnicianMaintenance.Size = new System.Drawing.Size(200, 23);
            this.buttonTechnicianMaintenance.TabIndex = 6;
            this.buttonTechnicianMaintenance.Text = "Technician Maintenance";
            this.buttonTechnicianMaintenance.UseVisualStyleBackColor = true;
            this.buttonTechnicianMaintenance.Click += new System.EventHandler(this.buttonTechnicianMaintenance_Click);
            // 
            // buttonProductMaintenance
            // 
            this.buttonProductMaintenance.Location = new System.Drawing.Point(22, 122);
            this.buttonProductMaintenance.Name = "buttonProductMaintenance";
            this.buttonProductMaintenance.Size = new System.Drawing.Size(200, 23);
            this.buttonProductMaintenance.TabIndex = 7;
            this.buttonProductMaintenance.Text = "Product Maintenance";
            this.buttonProductMaintenance.UseVisualStyleBackColor = true;
            this.buttonProductMaintenance.Click += new System.EventHandler(this.buttonProductMaintenance_Click);
            // 
            // buttonCustomerIncidents
            // 
            this.buttonCustomerIncidents.Location = new System.Drawing.Point(22, 151);
            this.buttonCustomerIncidents.Name = "buttonCustomerIncidents";
            this.buttonCustomerIncidents.Size = new System.Drawing.Size(200, 23);
            this.buttonCustomerIncidents.TabIndex = 8;
            this.buttonCustomerIncidents.Text = "Customer Incidents";
            this.buttonCustomerIncidents.UseVisualStyleBackColor = true;
            this.buttonCustomerIncidents.Click += new System.EventHandler(this.buttonCustomerIncidents_Click);
            // 
            // buttonAddIncident
            // 
            this.buttonAddIncident.Location = new System.Drawing.Point(22, 180);
            this.buttonAddIncident.Name = "buttonAddIncident";
            this.buttonAddIncident.Size = new System.Drawing.Size(200, 23);
            this.buttonAddIncident.TabIndex = 9;
            this.buttonAddIncident.Text = "Add Incident";
            this.buttonAddIncident.UseVisualStyleBackColor = true;
            this.buttonAddIncident.Click += new System.EventHandler(this.buttonAddIncident_Click);
            // 
            // buttonAddRegistration
            // 
            this.buttonAddRegistration.Location = new System.Drawing.Point(22, 209);
            this.buttonAddRegistration.Name = "buttonAddRegistration";
            this.buttonAddRegistration.Size = new System.Drawing.Size(200, 23);
            this.buttonAddRegistration.TabIndex = 10;
            this.buttonAddRegistration.Text = "Add Registration";
            this.buttonAddRegistration.UseVisualStyleBackColor = true;
            this.buttonAddRegistration.Click += new System.EventHandler(this.buttonAddRegistration_Click);
            // 
            // buttonUserAccountMaintenance
            // 
            this.buttonUserAccountMaintenance.Location = new System.Drawing.Point(22, 238);
            this.buttonUserAccountMaintenance.Name = "buttonUserAccountMaintenance";
            this.buttonUserAccountMaintenance.Size = new System.Drawing.Size(200, 23);
            this.buttonUserAccountMaintenance.TabIndex = 11;
            this.buttonUserAccountMaintenance.Text = "User Account Maintenance";
            this.buttonUserAccountMaintenance.UseVisualStyleBackColor = true;
            this.buttonUserAccountMaintenance.Click += new System.EventHandler(this.buttonUserAccountMaintenance_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(244, 341);
            this.Controls.Add(this.buttonUserAccountMaintenance);
            this.Controls.Add(this.buttonAddRegistration);
            this.Controls.Add(this.buttonAddIncident);
            this.Controls.Add(this.buttonCustomerIncidents);
            this.Controls.Add(this.buttonProductMaintenance);
            this.Controls.Add(this.buttonTechnicianMaintenance);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Tech Support";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonTechnicianMaintenance;
        private System.Windows.Forms.Button buttonProductMaintenance;
        private System.Windows.Forms.Button buttonCustomerIncidents;
        private System.Windows.Forms.Button buttonAddIncident;
        private System.Windows.Forms.Button buttonAddRegistration;
        private System.Windows.Forms.Button buttonUserAccountMaintenance;
    }
}

