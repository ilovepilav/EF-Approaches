
namespace _2_CodeFirst
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCategoryList = new System.Windows.Forms.DataGridView();
            this.cbTypeChoose = new System.Windows.Forms.ComboBox();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddType = new System.Windows.Forms.Label();
            this.gbModifyDelete = new System.Windows.Forms.GroupBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.cbCategoryPicker = new System.Windows.Forms.ComboBox();
            this.cbModifyCategoryPicker = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblModifyType = new System.Windows.Forms.Label();
            this.txtModifyName = new System.Windows.Forms.TextBox();
            this.txtModifyDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
            this.gbAdd.SuspendLayout();
            this.gbModifyDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCategoryList);
            this.groupBox2.Location = new System.Drawing.Point(31, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 239);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Categories";
            // 
            // dgvCategoryList
            // 
            this.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryList.Location = new System.Drawing.Point(7, 20);
            this.dgvCategoryList.Name = "dgvCategoryList";
            this.dgvCategoryList.Size = new System.Drawing.Size(716, 256);
            this.dgvCategoryList.TabIndex = 0;
            // 
            // cbTypeChoose
            // 
            this.cbTypeChoose.FormattingEnabled = true;
            this.cbTypeChoose.Location = new System.Drawing.Point(114, 19);
            this.cbTypeChoose.Name = "cbTypeChoose";
            this.cbTypeChoose.Size = new System.Drawing.Size(121, 21);
            this.cbTypeChoose.TabIndex = 6;
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Controls.Add(this.txtAddDescription);
            this.gbAdd.Controls.Add(this.txtAddName);
            this.gbAdd.Controls.Add(this.lblAddType);
            this.gbAdd.Controls.Add(this.label2);
            this.gbAdd.Controls.Add(this.label1);
            this.gbAdd.Controls.Add(this.cbCategoryPicker);
            this.gbAdd.Controls.Add(this.cbTypeChoose);
            this.gbAdd.Location = new System.Drawing.Point(38, 12);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(372, 190);
            this.gbAdd.TabIndex = 7;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name :";
            // 
            // lblAddType
            // 
            this.lblAddType.AutoSize = true;
            this.lblAddType.Location = new System.Drawing.Point(17, 85);
            this.lblAddType.Name = "lblAddType";
            this.lblAddType.Size = new System.Drawing.Size(66, 13);
            this.lblAddType.TabIndex = 7;
            this.lblAddType.Text = "Description :";
            // 
            // gbModifyDelete
            // 
            this.gbModifyDelete.Controls.Add(this.btnSubmit);
            this.gbModifyDelete.Controls.Add(this.txtModifyDescription);
            this.gbModifyDelete.Controls.Add(this.cbModifyCategoryPicker);
            this.gbModifyDelete.Controls.Add(this.txtModifyName);
            this.gbModifyDelete.Controls.Add(this.label3);
            this.gbModifyDelete.Controls.Add(this.lblModifyType);
            this.gbModifyDelete.Location = new System.Drawing.Point(416, 12);
            this.gbModifyDelete.Name = "gbModifyDelete";
            this.gbModifyDelete.Size = new System.Drawing.Size(353, 190);
            this.gbModifyDelete.TabIndex = 8;
            this.gbModifyDelete.TabStop = false;
            this.gbModifyDelete.Text = "Modify";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(114, 55);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(121, 20);
            this.txtAddName.TabIndex = 8;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(114, 85);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(240, 52);
            this.txtAddDescription.TabIndex = 8;
            // 
            // cbCategoryPicker
            // 
            this.cbCategoryPicker.FormattingEnabled = true;
            this.cbCategoryPicker.Location = new System.Drawing.Point(114, 85);
            this.cbCategoryPicker.Name = "cbCategoryPicker";
            this.cbCategoryPicker.Size = new System.Drawing.Size(121, 21);
            this.cbCategoryPicker.TabIndex = 6;
            // 
            // cbModifyCategoryPicker
            // 
            this.cbModifyCategoryPicker.FormattingEnabled = true;
            this.cbModifyCategoryPicker.Location = new System.Drawing.Point(112, 49);
            this.cbModifyCategoryPicker.Name = "cbModifyCategoryPicker";
            this.cbModifyCategoryPicker.Size = new System.Drawing.Size(121, 21);
            this.cbModifyCategoryPicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name :";
            // 
            // lblModifyType
            // 
            this.lblModifyType.AutoSize = true;
            this.lblModifyType.Location = new System.Drawing.Point(15, 52);
            this.lblModifyType.Name = "lblModifyType";
            this.lblModifyType.Size = new System.Drawing.Size(66, 13);
            this.lblModifyType.TabIndex = 7;
            this.lblModifyType.Text = "Description :";
            // 
            // txtModifyName
            // 
            this.txtModifyName.Location = new System.Drawing.Point(112, 22);
            this.txtModifyName.Name = "txtModifyName";
            this.txtModifyName.Size = new System.Drawing.Size(121, 20);
            this.txtModifyName.TabIndex = 8;
            // 
            // txtModifyDescription
            // 
            this.txtModifyDescription.Location = new System.Drawing.Point(112, 48);
            this.txtModifyDescription.Multiline = true;
            this.txtModifyDescription.Name = "txtModifyDescription";
            this.txtModifyDescription.Size = new System.Drawing.Size(201, 58);
            this.txtModifyDescription.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(114, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(112, 114);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbModifyDelete);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.gbModifyDelete.ResumeLayout(false);
            this.gbModifyDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCategoryList;
        private System.Windows.Forms.ComboBox cbTypeChoose;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label lblAddType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoryPicker;
        private System.Windows.Forms.GroupBox gbModifyDelete;
        private System.Windows.Forms.TextBox txtModifyDescription;
        private System.Windows.Forms.ComboBox cbModifyCategoryPicker;
        private System.Windows.Forms.TextBox txtModifyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblModifyType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubmit;
    }
}

