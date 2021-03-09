
namespace PR4
{
    partial class register
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
            this.getNew = new System.Windows.Forms.Button();
            this.loginBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getNew
            // 
            this.getNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getNew.Location = new System.Drawing.Point(64, 146);
            this.getNew.Name = "getNew";
            this.getNew.Size = new System.Drawing.Size(92, 35);
            this.getNew.TabIndex = 9;
            this.getNew.Text = "Обновить";
            this.getNew.UseVisualStyleBackColor = true;
            this.getNew.Click += new System.EventHandler(this.getNew_Click);
            // 
            // loginBut
            // 
            this.loginBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBut.Location = new System.Drawing.Point(243, 146);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(92, 35);
            this.loginBut.TabIndex = 8;
            this.loginBut.Text = "Добавить";
            this.loginBut.UseVisualStyleBackColor = true;
            this.loginBut.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(218, 51);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(53, 21);
            this.login.TabIndex = 10;
            this.login.Text = "label3";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(218, 91);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 21);
            this.password.TabIndex = 11;
            this.password.Text = "label4";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 202);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.getNew);
            this.Controls.Add(this.loginBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getNew;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
    }
}