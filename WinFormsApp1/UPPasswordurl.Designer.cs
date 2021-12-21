
namespace StationMachine
{
    partial class UPPasswordurl
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
            this.btnExist = new System.Windows.Forms.Button();
            this.tbxHttpAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(86, 78);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 1;
            this.btnSure.Tag = "1";
            this.btnSure.Text = "确认";
            this.btnSure.UseVisualStyleBackColor = true;
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(350, 78);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(75, 23);
            this.btnExist.TabIndex = 2;
            this.btnExist.Tag = "2";
            this.btnExist.Text = "取消";
            this.btnExist.UseVisualStyleBackColor = true;
            // 
            // tbxHttpAdress
            // 
            this.tbxHttpAdress.Location = new System.Drawing.Point(86, 25);
            this.tbxHttpAdress.Name = "tbxHttpAdress";
            this.tbxHttpAdress.Size = new System.Drawing.Size(339, 23);
            this.tbxHttpAdress.TabIndex = 0;
            this.tbxHttpAdress.Tag = "0";
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
            // UPPasswordurl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxHttpAdress);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnSure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UPPasswordurl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPPassWordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxHttpAdress;
        private System.Windows.Forms.Button btnExist;
    }
}