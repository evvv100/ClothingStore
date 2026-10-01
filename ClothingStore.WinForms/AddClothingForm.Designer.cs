namespace ClothingStore.WinForms
{
    partial class AddClothingForm
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
            this.tID = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.tPrice = new System.Windows.Forms.TextBox();
            this.lID = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lCategory = new System.Windows.Forms.Label();
            this.lSize = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.cCategory = new System.Windows.Forms.ComboBox();
            this.cSize = new System.Windows.Forms.ComboBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввведите данные новой вещи";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tID
            // 
            this.tID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tID.Location = new System.Drawing.Point(628, 162);
            this.tID.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.tID.Name = "tID";
            this.tID.ReadOnly = true;
            this.tID.Size = new System.Drawing.Size(308, 34);
            this.tID.TabIndex = 1;
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tName.Location = new System.Drawing.Point(522, 241);
            this.tName.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(415, 34);
            this.tName.TabIndex = 2;
            // 
            // tPrice
            // 
            this.tPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tPrice.Location = new System.Drawing.Point(628, 475);
            this.tPrice.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.tPrice.Name = "tPrice";
            this.tPrice.Size = new System.Drawing.Size(308, 34);
            this.tPrice.TabIndex = 5;
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lID.Location = new System.Drawing.Point(286, 167);
            this.lID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(45, 29);
            this.lID.TabIndex = 6;
            this.lID.Text = "ID:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(286, 245);
            this.lName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(137, 29);
            this.lName.TabIndex = 7;
            this.lName.Text = "Название:";
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCategory.Location = new System.Drawing.Point(286, 322);
            this.lCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(150, 29);
            this.lCategory.TabIndex = 8;
            this.lCategory.Text = "Категория:";
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSize.Location = new System.Drawing.Point(286, 402);
            this.lSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(115, 29);
            this.lSize.TabIndex = 9;
            this.lSize.Text = "Размер:";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPrice.Location = new System.Drawing.Point(286, 480);
            this.lPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(82, 29);
            this.lPrice.TabIndex = 10;
            this.lPrice.Text = "Цена:";
            // 
            // cCategory
            // 
            this.cCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cCategory.FormattingEnabled = true;
            this.cCategory.Location = new System.Drawing.Point(628, 317);
            this.cCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cCategory.Name = "cCategory";
            this.cCategory.Size = new System.Drawing.Size(308, 37);
            this.cCategory.TabIndex = 11;
            // 
            // cSize
            // 
            this.cSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cSize.FormattingEnabled = true;
            this.cSize.Location = new System.Drawing.Point(628, 397);
            this.cSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cSize.Name = "cSize";
            this.cSize.Size = new System.Drawing.Size(308, 37);
            this.cSize.TabIndex = 12;
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(291, 584);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(292, 72);
            this.bAdd.TabIndex = 13;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(645, 584);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(292, 72);
            this.bCancel.TabIndex = 14;
            this.bCancel.Text = "Назад";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(232, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "10000";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ваш баланс: ";
            // 
            // AddClothingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.cSize);
            this.Controls.Add(this.cCategory);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.lCategory);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lID);
            this.Controls.Add(this.tPrice);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1218, 750);
            this.MinimumSize = new System.Drawing.Size(1218, 750);
            this.Name = "AddClothingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление одежды";
            this.Load += new System.EventHandler(this.AddClothing_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tPrice;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.ComboBox cCategory;
        private System.Windows.Forms.ComboBox cSize;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}