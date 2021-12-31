
namespace StationMachine
{
    partial class MessageForm
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
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnUppass = new System.Windows.Forms.Button();
            this.btnupdateurl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(202, 97);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(66, 26);
            this.btnok.TabIndex = 1;
            this.btnok.Tag = "1";
            this.btnok.Text = "确  认";
            this.btnok.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(274, 97);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(66, 26);
            this.btncancel.TabIndex = 2;
            this.btncancel.Tag = "2";
            this.btncancel.Text = "取  消";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(103, 34);
            this.tbx.Name = "tbx";
            this.tbx.PasswordChar = '*';
            this.tbx.Size = new System.Drawing.Size(237, 23);
            this.tbx.TabIndex = 0;
            this.tbx.Tag = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "授权码：";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(148, 63);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(120, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "请输入正确的授权码!";
            // 
            // btnUppass
            // 
            this.btnUppass.Location = new System.Drawing.Point(41, 97);
            this.btnUppass.Name = "btnUppass";
            this.btnUppass.Size = new System.Drawing.Size(66, 26);
            this.btnUppass.TabIndex = 2;
            this.btnUppass.Tag = "2";
            this.btnUppass.Text = "修改密码";
            this.btnUppass.UseVisualStyleBackColor = true;
            // 
            // btnupdateurl
            // 
            this.btnupdateurl.Location = new System.Drawing.Point(113, 97);
            this.btnupdateurl.Name = "btnupdateurl";
            this.btnupdateurl.Size = new System.Drawing.Size(66, 26);
            this.btnupdateurl.TabIndex = 2;
            this.btnupdateurl.Tag = "2";
            this.btnupdateurl.Text = "修改网址";
            this.btnupdateurl.UseVisualStyleBackColor = true;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 156);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.btnupdateurl);
            this.Controls.Add(this.btnUppass);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnUppass;
        private System.Windows.Forms.Button btnupdateurl;
    }
}