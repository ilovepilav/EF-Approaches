
namespace _3_CodeFirst_Lab_PhoneBook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.gbAddUpdateDelete = new System.Windows.Forms.GroupBox();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.txtSearchEntry = new System.Windows.Forms.TextBox();
            this.btnSearchEntry = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.L = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRegPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtRegFirstName = new System.Windows.Forms.TextBox();
            this.txtRegLastName = new System.Windows.Forms.TextBox();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAdminDeleteUser = new System.Windows.Forms.Button();
            this.btnAdminDeleteEntry = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbLogin.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbAddUpdateDelete.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(940, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.linkRegister);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtLoginUsername);
            this.gbLogin.Controls.Add(this.mskPassword);
            this.gbLogin.Controls.Add(this.label4);
            this.gbLogin.Controls.Add(this.label3);
            this.gbLogin.Location = new System.Drawing.Point(13, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(310, 111);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSearchEntry);
            this.gbSearch.Controls.Add(this.txtSearchEntry);
            this.gbSearch.Location = new System.Drawing.Point(367, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(141, 111);
            this.gbSearch.TabIndex = 2;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // gbAddUpdateDelete
            // 
            this.gbAddUpdateDelete.Controls.Add(this.btnDelete);
            this.gbAddUpdateDelete.Controls.Add(this.btnUpdate);
            this.gbAddUpdateDelete.Controls.Add(this.btnAdd);
            this.gbAddUpdateDelete.Controls.Add(this.textBox7);
            this.gbAddUpdateDelete.Controls.Add(this.textBox5);
            this.gbAddUpdateDelete.Controls.Add(this.textBox6);
            this.gbAddUpdateDelete.Controls.Add(this.textBox4);
            this.gbAddUpdateDelete.Controls.Add(this.textBox3);
            this.gbAddUpdateDelete.Controls.Add(this.label13);
            this.gbAddUpdateDelete.Controls.Add(this.label6);
            this.gbAddUpdateDelete.Controls.Add(this.label2);
            this.gbAddUpdateDelete.Controls.Add(this.label5);
            this.gbAddUpdateDelete.Controls.Add(this.label1);
            this.gbAddUpdateDelete.Location = new System.Drawing.Point(13, 136);
            this.gbAddUpdateDelete.Name = "gbAddUpdateDelete";
            this.gbAddUpdateDelete.Size = new System.Drawing.Size(495, 143);
            this.gbAddUpdateDelete.TabIndex = 3;
            this.gbAddUpdateDelete.TabStop = false;
            this.gbAddUpdateDelete.Text = "Add/Update/Delete";
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.btnAdminDeleteEntry);
            this.gbAdmin.Controls.Add(this.btnAdminDeleteUser);
            this.gbAdmin.Controls.Add(this.textBox2);
            this.gbAdmin.Controls.Add(this.textBox1);
            this.gbAdmin.Controls.Add(this.label8);
            this.gbAdmin.Controls.Add(this.label7);
            this.gbAdmin.Location = new System.Drawing.Point(373, 326);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(300, 267);
            this.gbAdmin.TabIndex = 4;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "AdminPanel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search User";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Search Entry";
            // 
            // mskPassword
            // 
            this.mskPassword.Location = new System.Drawing.Point(119, 54);
            this.mskPassword.Name = "mskPassword";
            this.mskPassword.PasswordChar = '*';
            this.mskPassword.Size = new System.Drawing.Size(100, 20);
            this.mskPassword.TabIndex = 1;
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(119, 19);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(100, 20);
            this.txtLoginUsername.TabIndex = 2;
            // 
            // txtSearchEntry
            // 
            this.txtSearchEntry.Location = new System.Drawing.Point(22, 26);
            this.txtSearchEntry.Name = "txtSearchEntry";
            this.txtSearchEntry.Size = new System.Drawing.Size(100, 20);
            this.txtSearchEntry.TabIndex = 2;
            // 
            // btnSearchEntry
            // 
            this.btnSearchEntry.Location = new System.Drawing.Point(22, 54);
            this.btnSearchEntry.Name = "btnSearchEntry";
            this.btnSearchEntry.Size = new System.Drawing.Size(100, 23);
            this.btnSearchEntry.TabIndex = 3;
            this.btnSearchEntry.Text = "Search";
            this.btnSearchEntry.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(119, 82);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gbRegister
            // 
            this.gbRegister.Controls.Add(this.btnRegister);
            this.gbRegister.Controls.Add(this.txtRegUsername);
            this.gbRegister.Controls.Add(this.txtRegEmail);
            this.gbRegister.Controls.Add(this.txtRegLastName);
            this.gbRegister.Controls.Add(this.txtRegFirstName);
            this.gbRegister.Controls.Add(this.txtRegPassword);
            this.gbRegister.Controls.Add(this.label12);
            this.gbRegister.Controls.Add(this.label10);
            this.gbRegister.Controls.Add(this.label9);
            this.gbRegister.Controls.Add(this.L);
            this.gbRegister.Controls.Add(this.label11);
            this.gbRegister.Location = new System.Drawing.Point(598, 12);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(300, 267);
            this.gbRegister.TabIndex = 4;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "Registration";
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Location = new System.Drawing.Point(22, 64);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(58, 13);
            this.L.TabIndex = 0;
            this.L.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "E-Mail";
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(99, 170);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '*';
            this.txtRegPassword.Size = new System.Drawing.Size(100, 20);
            this.txtRegPassword.TabIndex = 1;
            // 
            // txtRegFirstName
            // 
            this.txtRegFirstName.Location = new System.Drawing.Point(99, 26);
            this.txtRegFirstName.Name = "txtRegFirstName";
            this.txtRegFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtRegFirstName.TabIndex = 2;
            // 
            // txtRegLastName
            // 
            this.txtRegLastName.Location = new System.Drawing.Point(99, 61);
            this.txtRegLastName.Name = "txtRegLastName";
            this.txtRegLastName.Size = new System.Drawing.Size(100, 20);
            this.txtRegLastName.TabIndex = 2;
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Location = new System.Drawing.Point(99, 95);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(100, 20);
            this.txtRegEmail.TabIndex = 2;
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Location = new System.Drawing.Point(99, 134);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(100, 20);
            this.txtRegUsername.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(99, 208);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // btnAdminDeleteUser
            // 
            this.btnAdminDeleteUser.Location = new System.Drawing.Point(25, 100);
            this.btnAdminDeleteUser.Name = "btnAdminDeleteUser";
            this.btnAdminDeleteUser.Size = new System.Drawing.Size(91, 23);
            this.btnAdminDeleteUser.TabIndex = 2;
            this.btnAdminDeleteUser.Text = "Delete User";
            this.btnAdminDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnAdminDeleteEntry
            // 
            this.btnAdminDeleteEntry.Location = new System.Drawing.Point(130, 100);
            this.btnAdminDeleteEntry.Name = "btnAdminDeleteEntry";
            this.btnAdminDeleteEntry.Size = new System.Drawing.Size(75, 23);
            this.btnAdminDeleteEntry.TabIndex = 2;
            this.btnAdminDeleteEntry.Text = "Delete Entry";
            this.btnAdminDeleteEntry.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Phone";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(80, 105);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(274, 30);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 52);
            this.textBox6.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(274, 98);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(394, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(394, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(394, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Location = new System.Drawing.Point(236, 19);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(46, 13);
            this.linkRegister.TabIndex = 4;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Register";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 710);
            this.Controls.Add(this.gbRegister);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.gbAddUpdateDelete);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbAddUpdateDelete.ResumeLayout(false);
            this.gbAddUpdateDelete.PerformLayout();
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.MaskedTextBox mskPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSearchEntry;
        private System.Windows.Forms.TextBox txtSearchEntry;
        private System.Windows.Forms.GroupBox gbAddUpdateDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Button btnAdminDeleteEntry;
        private System.Windows.Forms.Button btnAdminDeleteUser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.TextBox txtRegLastName;
        private System.Windows.Forms.TextBox txtRegFirstName;
        private System.Windows.Forms.MaskedTextBox txtRegPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
    }
}

