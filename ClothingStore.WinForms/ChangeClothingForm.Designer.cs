namespace ClothingStore.WinForms
{
    partial class ChangeClothingForm
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
            this.lName = new System.Windows.Forms.Label();
            this.lCategory = new System.Windows.Forms.Label();
            this.lSize = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.tPrice = new System.Windows.Forms.TextBox();
            this.bChange = new System.Windows.Forms.Button();
            this.cCategory = new System.Windows.Forms.ComboBox();
            this.cSize = new System.Windows.Forms.ComboBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lID = new System.Windows.Forms.Label();
            this.lIDcc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(204, 120);
            this.lName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(137, 29);
            this.lName.TabIndex = 2;
            this.lName.Text = "Название:";
            this.lName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCategory.Location = new System.Drawing.Point(204, 169);
            this.lCategory.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(150, 29);
            this.lCategory.TabIndex = 3;
            this.lCategory.Text = "Категория:";
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSize.Location = new System.Drawing.Point(204, 218);
            this.lSize.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(115, 29);
            this.lSize.TabIndex = 4;
            this.lSize.Text = "Размер:";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPrice.Location = new System.Drawing.Point(204, 267);
            this.lPrice.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(82, 29);
            this.lPrice.TabIndex = 5;
            this.lPrice.Text = "Цена:";
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tName.Location = new System.Drawing.Point(360, 117);
            this.tName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(240, 34);
            this.tName.TabIndex = 6;
            // 
            // tPrice
            // 
            this.tPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tPrice.Location = new System.Drawing.Point(450, 264);
            this.tPrice.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.tPrice.Name = "tPrice";
            this.tPrice.Size = new System.Drawing.Size(150, 34);
            this.tPrice.TabIndex = 9;
            // 
            // bChange
            // 
            this.bChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bChange.Location = new System.Drawing.Point(207, 342);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(165, 42);
            this.bChange.TabIndex = 10;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = true;
            // 
            // cCategory
            // 
            this.cCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cCategory.FormattingEnabled = true;
            this.cCategory.Location = new System.Drawing.Point(450, 166);
            this.cCategory.Name = "cCategory";
            this.cCategory.Size = new System.Drawing.Size(150, 37);
            this.cCategory.TabIndex = 11;
            // 
            // cSize
            // 
            this.cSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cSize.FormattingEnabled = true;
            this.cSize.Location = new System.Drawing.Point(450, 215);
            this.cSize.Name = "cSize";
            this.cSize.Size = new System.Drawing.Size(150, 37);
            this.cSize.TabIndex = 12;
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(433, 342);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(165, 42);
            this.bCancel.TabIndex = 13;
            this.bCancel.Text = "Назад";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(159, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "10000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ваш баланс: ";
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lID.Location = new System.Drawing.Point(461, 68);
            this.lID.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(137, 29);
            this.lID.TabIndex = 20;
            this.lID.Text = "Название:";
            // 
            // lIDcc
            // 
            this.lIDcc.AutoSize = true;
            this.lIDcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lIDcc.Location = new System.Drawing.Point(204, 71);
            this.lIDcc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lIDcc.Name = "lIDcc";
            this.lIDcc.Size = new System.Drawing.Size(137, 29);
            this.lIDcc.TabIndex = 21;
            this.lIDcc.Text = "Id товара:";
            // 
            // ChangeClothingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lIDcc);
            this.Controls.Add(this.lID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.cSize);
            this.Controls.Add(this.cCategory);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.tPrice);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.lCategory);
            this.Controls.Add(this.lName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ChangeClothingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение одежды";
            this.Load += new System.EventHandler(this.ChangeClothingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tPrice;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.ComboBox cCategory;
        private System.Windows.Forms.ComboBox cSize;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lIDcc;
    }
}