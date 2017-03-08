namespace DemoGetData
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDDiv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.dataResult = new System.Windows.Forms.RichTextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.radioId = new System.Windows.Forms.RadioButton();
            this.radioClass = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "getData";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(62, 23);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(202, 19);
            this.txtWeb.TabIndex = 1;
            this.txtWeb.Text = "https://www.microsoft.com/vi-vn/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "website";
            // 
            // txtIDDiv
            // 
            this.txtIDDiv.Location = new System.Drawing.Point(102, 77);
            this.txtIDDiv.Name = "txtIDDiv";
            this.txtIDDiv.Size = new System.Drawing.Size(112, 19);
            this.txtIDDiv.TabIndex = 4;
            this.txtIDDiv.Text = "slim_feature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tags";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(62, 52);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(202, 19);
            this.txtTag.TabIndex = 6;
            this.txtTag.Text = "section";
            // 
            // dataResult
            // 
            this.dataResult.Location = new System.Drawing.Point(62, 171);
            this.dataResult.Name = "dataResult";
            this.dataResult.Size = new System.Drawing.Size(361, 117);
            this.dataResult.TabIndex = 8;
            this.dataResult.Text = "";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(288, 77);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(135, 19);
            this.txtClass.TabIndex = 10;
            this.txtClass.Text = "box_hot_news";
            // 
            // radioId
            // 
            this.radioId.AutoSize = true;
            this.radioId.Checked = true;
            this.radioId.Location = new System.Drawing.Point(62, 80);
            this.radioId.Name = "radioId";
            this.radioId.Size = new System.Drawing.Size(34, 16);
            this.radioId.TabIndex = 11;
            this.radioId.TabStop = true;
            this.radioId.Text = "ID";
            this.radioId.UseVisualStyleBackColor = true;
            // 
            // radioClass
            // 
            this.radioClass.AutoSize = true;
            this.radioClass.Location = new System.Drawing.Point(230, 80);
            this.radioClass.Name = "radioClass";
            this.radioClass.Size = new System.Drawing.Size(52, 16);
            this.radioClass.TabIndex = 12;
            this.radioClass.TabStop = true;
            this.radioClass.Text = "Class";
            this.radioClass.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(62, 142);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(361, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 300);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.radioClass);
            this.Controls.Add(this.radioId);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.dataResult);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDDiv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDDiv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.RichTextBox dataResult;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.RadioButton radioId;
        private System.Windows.Forms.RadioButton radioClass;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

