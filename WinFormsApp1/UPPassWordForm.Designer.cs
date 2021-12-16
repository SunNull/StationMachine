
namespace StationMachine
{
    partial class UPPassWordForm
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
            this.btnSure = new System.Windows.Forms.Button();
            this.tbxOldPassWord = new System.Windows.Forms.TextBox();
            this.tbxNewPassWord = new System.Windows.Forms.TextBox();
            this.btnExist = new System.Windows.Forms.Button();
            this.tbxHttpAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(86, 140);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 2;
            this.btnSure.Tag = "2";
            this.btnSure.Text = "确认";
            this.btnSure.UseVisualStyleBackColor = true;
            // 
            // tbxOldPassWord
            // 
            this.tbxOldPassWord.Location = new System.Drawing.Point(86, 75);
            this.tbxOldPassWord.Name = "tbxOldPassWord";
            this.tbxOldPassWord.PasswordChar = '*';
            this.tbxOldPassWord.Size = new System.Drawing.Size(137, 23);
            this.tbxOldPassWord.TabIndex = 0;
            this.tbxOldPassWord.Tag = "0";
            // 
            // tbxNewPassWord
            // 
            this.tbxNewPassWord.Location = new System.Drawing.Point(285, 75);
            this.tbxNewPassWord.Name = "tbxNewPassWord";
            this.tbxNewPassWord.PasswordChar = '*';
            this.tbxNewPassWord.Size = new System.Drawing.Size(156, 23);
            this.tbxNewPassWord.TabIndex = 1;
            this.tbxNewPassWord.Tag = "1";
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(366, 140);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(75, 23);
            this.btnExist.TabIndex = 3;
            this.btnExist.Tag = "3";
            this.btnExist.Text = "退出";
            this.btnExist.UseVisualStyleBackColor = true;
            // 
            // tbxHttpAdress
            // 
            this.tbxHttpAdress.Location = new System.Drawing.Point(86, 25);
            this.tbxHttpAdress.Name = "tbxHttpAdress";
            this.tbxHttpAdress.Size = new System.Drawing.Size(355, 23);
            this.tbxHttpAdress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "网址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "旧密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "新密码";
            // 
            // UPPassWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 202);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNewPassWord);
            this.Controls.Add(this.tbxHttpAdress);
            this.Controls.Add(this.tbxOldPassWord);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnSure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UPPassWordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPPassWordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNewPassWord;
        private System.Windows.Forms.TextBox tbxOldPassWord;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxHttpAdress;
        private System.Windows.Forms.Button btnExist;
    }
}