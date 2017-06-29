namespace My_Inventory
{
    partial class FormLogShrink
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonShrinkByDate = new System.Windows.Forms.Button();
            this.buttonShrinkByNum = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Очистить записи старше";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Оставить последние";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(153, 40);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // buttonShrinkByDate
            // 
            this.buttonShrinkByDate.Location = new System.Drawing.Point(281, 12);
            this.buttonShrinkByDate.Name = "buttonShrinkByDate";
            this.buttonShrinkByDate.Size = new System.Drawing.Size(75, 23);
            this.buttonShrinkByDate.TabIndex = 4;
            this.buttonShrinkByDate.Text = "Очистить";
            this.buttonShrinkByDate.UseVisualStyleBackColor = true;
            this.buttonShrinkByDate.Click += new System.EventHandler(this.buttonShrinkByDate_Click);
            // 
            // buttonShrinkByNum
            // 
            this.buttonShrinkByNum.Location = new System.Drawing.Point(281, 37);
            this.buttonShrinkByNum.Name = "buttonShrinkByNum";
            this.buttonShrinkByNum.Size = new System.Drawing.Size(75, 23);
            this.buttonShrinkByNum.TabIndex = 5;
            this.buttonShrinkByNum.Text = "Очистить";
            this.buttonShrinkByNum.UseVisualStyleBackColor = true;
            this.buttonShrinkByNum.Click += new System.EventHandler(this.buttonShrinkByNum_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.Location = new System.Drawing.Point(281, 78);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 6;
            this.Close.Text = "Отмена";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "строк";
            // 
            // FormLogShrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Close;
            this.ClientSize = new System.Drawing.Size(368, 113);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.buttonShrinkByNum);
            this.Controls.Add(this.buttonShrinkByDate);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogShrink";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Очистка журнала перемещений";
            this.Load += new System.EventHandler(this.FormLogShrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonShrinkByDate;
        private System.Windows.Forms.Button buttonShrinkByNum;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label3;
    }
}