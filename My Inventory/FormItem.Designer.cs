namespace My_Inventory
{
    partial class FormItem
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.labelSerial = new System.Windows.Forms.Label();
            this.textBoxDisc = new System.Windows.Forms.TextBox();
            this.labelDisc = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonAddVersion = new System.Windows.Forms.Button();
            this.buttonDelVersion = new System.Windows.Forms.Button();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.columnVerDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonChangeVersion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(14, 15);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(114, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Инвентарный номер:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(134, 12);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(150, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(134, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Наименование:";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(634, 222);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(715, 222);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(134, 64);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(150, 20);
            this.textBoxModel.TabIndex = 7;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(14, 67);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(49, 13);
            this.labelModel.TabIndex = 6;
            this.labelModel.Text = "Модель:";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Location = new System.Drawing.Point(134, 90);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(150, 20);
            this.textBoxSerial.TabIndex = 9;
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Location = new System.Drawing.Point(14, 93);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(96, 13);
            this.labelSerial.TabIndex = 8;
            this.labelSerial.Text = "Серийный номер:";
            // 
            // textBoxDisc
            // 
            this.textBoxDisc.Location = new System.Drawing.Point(134, 116);
            this.textBoxDisc.Name = "textBoxDisc";
            this.textBoxDisc.Size = new System.Drawing.Size(150, 20);
            this.textBoxDisc.TabIndex = 11;
            // 
            // labelDisc
            // 
            this.labelDisc.AutoSize = true;
            this.labelDisc.Location = new System.Drawing.Point(14, 119);
            this.labelDisc.Name = "labelDisc";
            this.labelDisc.Size = new System.Drawing.Size(73, 13);
            this.labelDisc.TabIndex = 10;
            this.labelDisc.Text = "Примечание:";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(134, 194);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.ReadOnly = true;
            this.textBoxPlace.Size = new System.Drawing.Size(150, 20);
            this.textBoxPlace.TabIndex = 15;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(14, 197);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(98, 13);
            this.labelPlace.TabIndex = 14;
            this.labelPlace.Text = "Местоположение:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(134, 168);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = true;
            this.textBoxUser.Size = new System.Drawing.Size(150, 20);
            this.textBoxUser.TabIndex = 13;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(14, 171);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(63, 13);
            this.labelUser.TabIndex = 12;
            this.labelUser.Text = "Сотрудник:";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(134, 142);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(150, 20);
            this.textBoxDate.TabIndex = 17;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(14, 145);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(76, 13);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "Дата выдачи:";
            // 
            // buttonAddVersion
            // 
            this.buttonAddVersion.Image = global::My_Inventory.Properties.Resources.add;
            this.buttonAddVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddVersion.Location = new System.Drawing.Point(290, 12);
            this.buttonAddVersion.Name = "buttonAddVersion";
            this.buttonAddVersion.Size = new System.Drawing.Size(80, 23);
            this.buttonAddVersion.TabIndex = 18;
            this.buttonAddVersion.Text = "Добавить";
            this.buttonAddVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddVersion.UseVisualStyleBackColor = true;
            this.buttonAddVersion.Click += new System.EventHandler(this.buttonAddVersion_Click);
            // 
            // buttonDelVersion
            // 
            this.buttonDelVersion.Enabled = false;
            this.buttonDelVersion.Location = new System.Drawing.Point(457, 12);
            this.buttonDelVersion.Name = "buttonDelVersion";
            this.buttonDelVersion.Size = new System.Drawing.Size(75, 23);
            this.buttonDelVersion.TabIndex = 20;
            this.buttonDelVersion.Text = "Удалить";
            this.buttonDelVersion.UseVisualStyleBackColor = true;
            // 
            // listViewHistory
            // 
            this.listViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnVerDate,
            this.columnUser,
            this.columnPlace,
            this.columnComment});
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.GridLines = true;
            this.listViewHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewHistory.HideSelection = false;
            this.listViewHistory.Location = new System.Drawing.Point(290, 41);
            this.listViewHistory.MultiSelect = false;
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(500, 175);
            this.listViewHistory.TabIndex = 21;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnVerDate
            // 
            this.columnVerDate.Text = "Дата";
            this.columnVerDate.Width = 70;
            // 
            // columnUser
            // 
            this.columnUser.Text = "Сотрудник";
            this.columnUser.Width = 100;
            // 
            // columnPlace
            // 
            this.columnPlace.Text = "Местоположение";
            this.columnPlace.Width = 100;
            // 
            // columnComment
            // 
            this.columnComment.Text = "Комментарий";
            this.columnComment.Width = 200;
            // 
            // buttonChangeVersion
            // 
            this.buttonChangeVersion.Enabled = false;
            this.buttonChangeVersion.Location = new System.Drawing.Point(376, 12);
            this.buttonChangeVersion.Name = "buttonChangeVersion";
            this.buttonChangeVersion.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeVersion.TabIndex = 19;
            this.buttonChangeVersion.Text = "Изменить";
            this.buttonChangeVersion.UseVisualStyleBackColor = true;
            // 
            // FormItem
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(802, 257);
            this.Controls.Add(this.buttonAddVersion);
            this.Controls.Add(this.buttonDelVersion);
            this.Controls.Add(this.listViewHistory);
            this.Controls.Add(this.buttonChangeVersion);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxDisc);
            this.Controls.Add(this.labelDisc);
            this.Controls.Add(this.textBoxSerial);
            this.Controls.Add(this.labelSerial);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Name = "FormItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый предмет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.TextBox textBoxDisc;
        private System.Windows.Forms.Label labelDisc;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAddVersion;
        private System.Windows.Forms.Button buttonDelVersion;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ColumnHeader columnVerDate;
        private System.Windows.Forms.ColumnHeader columnUser;
        private System.Windows.Forms.ColumnHeader columnPlace;
        private System.Windows.Forms.ColumnHeader columnComment;
        private System.Windows.Forms.Button buttonChangeVersion;
    }
}