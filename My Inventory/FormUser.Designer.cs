namespace My_Inventory
{
    partial class FormUser
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
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.comboBoxOrg = new System.Windows.Forms.ComboBox();
            this.labelOrg = new System.Windows.Forms.Label();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.labelDepartament = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Location = new System.Drawing.Point(112, 92);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPost.TabIndex = 19;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(35, 95);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(68, 13);
            this.labelPost.TabIndex = 24;
            this.labelPost.Text = "Должность:";
            // 
            // comboBoxOrg
            // 
            this.comboBoxOrg.FormattingEnabled = true;
            this.comboBoxOrg.Location = new System.Drawing.Point(112, 38);
            this.comboBoxOrg.Name = "comboBoxOrg";
            this.comboBoxOrg.Size = new System.Drawing.Size(200, 21);
            this.comboBoxOrg.TabIndex = 20;
            // 
            // labelOrg
            // 
            this.labelOrg.AutoSize = true;
            this.labelOrg.Location = new System.Drawing.Point(26, 41);
            this.labelOrg.Name = "labelOrg";
            this.labelOrg.Size = new System.Drawing.Size(77, 13);
            this.labelOrg.TabIndex = 23;
            this.labelOrg.Text = "Организация:";
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Location = new System.Drawing.Point(112, 65);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDep.TabIndex = 21;
            // 
            // labelDepartament
            // 
            this.labelDepartament.AutoSize = true;
            this.labelDepartament.Location = new System.Drawing.Point(13, 68);
            this.labelDepartament.Name = "labelDepartament";
            this.labelDepartament.Size = new System.Drawing.Size(90, 13);
            this.labelDepartament.TabIndex = 22;
            this.labelDepartament.Text = "Подразделение:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(112, 12);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(200, 20);
            this.textBoxUser.TabIndex = 18;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(51, 15);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(52, 13);
            this.labelUser.TabIndex = 17;
            this.labelUser.Text = "Ф. И. О.:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(237, 127);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(156, 127);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 25;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OK);
            // 
            // FormUser
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(324, 162);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxPost);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.comboBoxOrg);
            this.Controls.Add(this.labelOrg);
            this.Controls.Add(this.comboBoxDep);
            this.Controls.Add(this.labelDepartament);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый сотрудник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.ComboBox comboBoxOrg;
        private System.Windows.Forms.Label labelOrg;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.Label labelDepartament;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}