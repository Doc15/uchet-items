
namespace PR4
{
    partial class items
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
            this.Refresh = new System.Windows.Forms.Button();
            this.Add_item = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.list = new System.Windows.Forms.ListView();
            this.Prihod = new System.Windows.Forms.Button();
            this.Rashod = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Refresh.Location = new System.Drawing.Point(485, 16);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(108, 43);
            this.Refresh.TabIndex = 1;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // Add_item
            // 
            this.Add_item.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_item.Location = new System.Drawing.Point(485, 65);
            this.Add_item.Name = "Add_item";
            this.Add_item.Size = new System.Drawing.Size(108, 57);
            this.Add_item.TabIndex = 3;
            this.Add_item.Text = "Добавить товар";
            this.Add_item.UseVisualStyleBackColor = true;
            this.Add_item.Click += new System.EventHandler(this.Add_item_Click);
            // 
            // addUser
            // 
            this.addUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addUser.Location = new System.Drawing.Point(604, 12);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(138, 60);
            this.addUser.TabIndex = 7;
            this.addUser.Text = "Добавить пользователя";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(671, 356);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 30);
            this.button8.TabIndex = 9;
            this.button8.Text = "Выход";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Наименование";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Количество";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Стоимость";
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.list.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.list.GridLines = true;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(467, 262);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // Prihod
            // 
            this.Prihod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prihod.Location = new System.Drawing.Point(485, 128);
            this.Prihod.Name = "Prihod";
            this.Prihod.Size = new System.Drawing.Size(108, 43);
            this.Prihod.TabIndex = 10;
            this.Prihod.Text = "Приход";
            this.Prihod.UseVisualStyleBackColor = true;
            this.Prihod.Click += new System.EventHandler(this.Prihod_Click_1);
            // 
            // Rashod
            // 
            this.Rashod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rashod.Location = new System.Drawing.Point(485, 177);
            this.Rashod.Name = "Rashod";
            this.Rashod.Size = new System.Drawing.Size(108, 43);
            this.Rashod.TabIndex = 11;
            this.Rashod.Text = "Расход";
            this.Rashod.UseVisualStyleBackColor = true;
            this.Rashod.Click += new System.EventHandler(this.Rashod_Click_1);
            // 
            // Order
            // 
            this.Order.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Order.Location = new System.Drawing.Point(485, 226);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(108, 43);
            this.Order.TabIndex = 12;
            this.Order.Text = "Заказы";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.close.Location = new System.Drawing.Point(665, 244);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(81, 30);
            this.close.TabIndex = 13;
            this.close.Text = "Выход";
            this.close.UseVisualStyleBackColor = true;
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 281);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Rashod);
            this.Controls.Add(this.Prihod);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.Add_item);
            this.Controls.Add(this.list);
            this.Controls.Add(this.Refresh);
            this.Name = "items";
            this.Text = "items";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Add_item;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Button Prihod;
        private System.Windows.Forms.Button Rashod;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button close;
    }
}