namespace Evaluation_Menager
{
    partial class Form1
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblYearOfBirth = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRoleSpecificAttribute = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtYearOfBirth = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtRoleSpecificAttribute = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(14, 67);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(74, 16);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name: ";
            this.lblFullName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblYearOfBirth
            // 
            this.lblYearOfBirth.AutoSize = true;
            this.lblYearOfBirth.Location = new System.Drawing.Point(14, 102);
            this.lblYearOfBirth.Name = "lblYearOfBirth";
            this.lblYearOfBirth.Size = new System.Drawing.Size(84, 16);
            this.lblYearOfBirth.TabIndex = 1;
            this.lblYearOfBirth.Text = "Year of birth: ";
            this.lblYearOfBirth.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(14, 135);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 16);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City: ";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(14, 171);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(56, 16);
            this.lblFaculty.TabIndex = 3;
            this.lblFaculty.Text = "Faculty: ";
            this.lblFaculty.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(14, 207);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 16);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role: ";
            this.lblRole.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblRoleSpecificAttribute
            // 
            this.lblRoleSpecificAttribute.AutoSize = true;
            this.lblRoleSpecificAttribute.Location = new System.Drawing.Point(14, 234);
            this.lblRoleSpecificAttribute.Name = "lblRoleSpecificAttribute";
            this.lblRoleSpecificAttribute.Size = new System.Drawing.Size(140, 16);
            this.lblRoleSpecificAttribute.TabIndex = 5;
            this.lblRoleSpecificAttribute.Text = "[role specific attribute]:";
            this.lblRoleSpecificAttribute.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(223, 67);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(197, 22);
            this.txtFullName.TabIndex = 6;
            this.txtFullName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtYearOfBirth
            // 
            this.txtYearOfBirth.Location = new System.Drawing.Point(223, 99);
            this.txtYearOfBirth.Name = "txtYearOfBirth";
            this.txtYearOfBirth.Size = new System.Drawing.Size(197, 22);
            this.txtYearOfBirth.TabIndex = 7;
            this.txtYearOfBirth.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(223, 135);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(197, 22);
            this.txtCity.TabIndex = 8;
            this.txtCity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(223, 168);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(197, 22);
            this.txtFaculty.TabIndex = 9;
            this.txtFaculty.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(223, 204);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(197, 22);
            this.txtRole.TabIndex = 10;
            this.txtRole.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtRoleSpecificAttribute
            // 
            this.txtRoleSpecificAttribute.Location = new System.Drawing.Point(223, 234);
            this.txtRoleSpecificAttribute.Name = "txtRoleSpecificAttribute";
            this.txtRoleSpecificAttribute.Size = new System.Drawing.Size(197, 22);
            this.txtRoleSpecificAttribute.TabIndex = 11;
            this.txtRoleSpecificAttribute.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(12, 22);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(137, 30);
            this.btnChooseFile.TabIndex = 12;
            this.btnChooseFile.Text = "Choose file...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 296);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.txtRoleSpecificAttribute);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtYearOfBirth);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblRoleSpecificAttribute);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblYearOfBirth);
            this.Controls.Add(this.lblFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Data Display";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblYearOfBirth;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblRoleSpecificAttribute;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtYearOfBirth;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtRoleSpecificAttribute;
        private System.Windows.Forms.Button btnChooseFile;
    }
}

