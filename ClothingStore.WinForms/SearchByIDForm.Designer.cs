namespace ClothingStore.WinForms
{
    partial class SearchByIDForm
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
            this.bSearch = new System.Windows.Forms.Button();
            this.tPrice = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.lSize = new System.Windows.Forms.Label();
            this.lCategory = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.tCategory = new System.Windows.Forms.TextBox();
            this.tSize = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(256, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ID товара:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tID
            // 
            this.tID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tID.Location = new System.Drawing.Point(718, 58);
            this.tID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(164, 34);
            this.tID.TabIndex = 1;
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSearch.Location = new System.Drawing.Point(264, 520);
            this.bSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(248, 66);
            this.bSearch.TabIndex = 19;
            this.bSearch.Text = "Найти";
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // tPrice
            // 
            this.tPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tPrice.Location = new System.Drawing.Point(633, 411);
            this.tPrice.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.tPrice.Name = "tPrice";
            this.tPrice.ReadOnly = true;
            this.tPrice.Size = new System.Drawing.Size(288, 34);
            this.tPrice.TabIndex = 18;
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tName.Location = new System.Drawing.Point(471, 181);
            this.tName.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.tName.Name = "tName";
            this.tName.ReadOnly = true;
            this.tName.Size = new System.Drawing.Size(450, 34);
            this.tName.TabIndex = 17;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPrice.Location = new System.Drawing.Point(240, 416);
            this.lPrice.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(82, 29);
            this.lPrice.TabIndex = 16;
            this.lPrice.Text = "Цена:";
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSize.Location = new System.Drawing.Point(240, 339);
            this.lSize.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(115, 29);
            this.lSize.TabIndex = 15;
            this.lSize.Text = "Размер:";
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCategory.Location = new System.Drawing.Point(240, 262);
            this.lCategory.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(150, 29);
            this.lCategory.TabIndex = 14;
            this.lCategory.Text = "Категория:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(240, 186);
            this.lName.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(137, 29);
            this.lName.TabIndex = 13;
            this.lName.Text = "Название:";
            // 
            // tCategory
            // 
            this.tCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tCategory.Location = new System.Drawing.Point(633, 258);
            this.tCategory.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.tCategory.Name = "tCategory";
            this.tCategory.ReadOnly = true;
            this.tCategory.Size = new System.Drawing.Size(288, 34);
            this.tCategory.TabIndex = 20;
            // 
            // tSize
            // 
            this.tSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tSize.Location = new System.Drawing.Point(633, 334);
            this.tSize.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.tSize.Name = "tSize";
            this.tSize.ReadOnly = true;
            this.tSize.Size = new System.Drawing.Size(288, 34);
            this.tSize.TabIndex = 21;
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(638, 520);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(248, 66);
            this.bCancel.TabIndex = 22;
            this.bCancel.Text = "Назад";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bRemove
            // 
            this.bRemove.BackColor = System.Drawing.Color.IndianRed;
            this.bRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bRemove.Location = new System.Drawing.Point(450, 595);
            this.bRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(248, 66);
            this.bRemove.TabIndex = 23;
            this.bRemove.Text = "Удалить";
            this.bRemove.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(232, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "10000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ваш баланс: ";
            // 
            // SearchByIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tSize);
            this.Controls.Add(this.tCategory);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tPrice);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.lCategory);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1218, 750);
            this.MinimumSize = new System.Drawing.Size(1218, 750);
            this.Name = "SearchByIDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск по ID";
            this.Load += new System.EventHandler(this.SearchByIDForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tPrice;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tCategory;
        private System.Windows.Forms.TextBox tSize;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}