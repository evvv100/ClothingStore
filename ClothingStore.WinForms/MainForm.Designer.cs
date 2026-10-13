namespace ClothingStore.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.bAssemble = new System.Windows.Forms.Button();
            this.bHistory = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1174, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в магазин одежды!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSearch.Location = new System.Drawing.Point(75, 280);
            this.bSearch.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(514, 75);
            this.bSearch.TabIndex = 4;
            this.bSearch.Text = "Каталог";
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // bAssemble
            // 
            this.bAssemble.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAssemble.Location = new System.Drawing.Point(598, 280);
            this.bAssemble.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.bAssemble.Name = "bAssemble";
            this.bAssemble.Size = new System.Drawing.Size(514, 75);
            this.bAssemble.TabIndex = 6;
            this.bAssemble.Text = "Собрать корзину";
            this.bAssemble.UseVisualStyleBackColor = true;
            // 
            // bHistory
            // 
            this.bHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bHistory.Location = new System.Drawing.Point(75, 386);
            this.bHistory.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.bHistory.Name = "bHistory";
            this.bHistory.Size = new System.Drawing.Size(514, 75);
            this.bHistory.TabIndex = 8;
            this.bHistory.Text = "История покупок";
            this.bHistory.UseVisualStyleBackColor = true;
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.LightCoral;
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.ForeColor = System.Drawing.SystemColors.Control;
            this.bBack.Location = new System.Drawing.Point(598, 386);
            this.bBack.Margin = new System.Windows.Forms.Padding(4, 16, 4, 16);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(514, 75);
            this.bBack.TabIndex = 9;
            this.bBack.Text = "Завершить покупки";
            this.bBack.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bHistory);
            this.Controls.Add(this.bAssemble);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1218, 750);
            this.MinimumSize = new System.Drawing.Size(1218, 750);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин одежды";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bAssemble;
        private System.Windows.Forms.Button bHistory;
        private System.Windows.Forms.Button bBack;
    }
}

