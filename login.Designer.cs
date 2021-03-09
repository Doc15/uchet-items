
namespace PR4
{
    partial class login
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
            this.butLog = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // butLog
            // 
            this.butLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butLog.Location = new System.Drawing.Point(191, 149);
            this.butLog.Name = "butLog";
            this.butLog.Size = new System.Drawing.Size(92, 35);
            this.butLog.TabIndex = 2;
            this.butLog.Text = "Войти";
            this.butLog.UseVisualStyleBackColor = true;
            this.butLog.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // butClose
            // 
            this.butClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butClose.Location = new System.Drawing.Point(12, 149);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(92, 35);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "Выход";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logBox.Location = new System.Drawing.Point(103, 47);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(180, 26);
            this.logBox.TabIndex = 4;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passBox.Location = new System.Drawing.Point(103, 86);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(180, 26);
            this.passBox.TabIndex = 5;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 196);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butLog;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox passBox;
    }
}