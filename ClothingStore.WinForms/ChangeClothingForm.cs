using ClothingStore.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothingCategory1;
using ClothingSize1;
using Logic1;

namespace ClothingStore.WinForms
{
    public partial class ChangeClothingForm : Form
    {
        public int ID { get; set; }
        public ChangeClothingForm(int id)
        {
            InitializeComponent();

            bChange.Click += BChange_Click;
            bCancel.Click += BCancel_Click;
            ControlBox = false;
            label2.Text = MainForm._balance.ToString();
            ID = id;
            lID.Text = ID.ToString();
        }
        /// <summary>
        /// Закрывает форму
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void BCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Проверяет, правильно ли заполнены поля, меняет данные о товаре, закрывает форму
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void BChange_Click(object sender, EventArgs e)
        {
            tName.BackColor = System.Drawing.Color.White;
            tPrice.BackColor = System.Drawing.Color.White;
            cCategory.BackColor = System.Drawing.Color.White;
            cSize.BackColor = System.Drawing.Color.White;

            bool hasError = false;
            string errorMessage = "Пожалуйста, заполните обязательные поля:\n";

            string nameText = tName.Text.Trim();
            if (string.IsNullOrEmpty(nameText))
            {
                tName.BackColor = System.Drawing.Color.LightCoral;
                errorMessage += "- Название вещи\n";
                hasError = true;
            }

            string priceText = tPrice.Text.Trim();
            if (string.IsNullOrEmpty(priceText))
            {
                tPrice.BackColor = System.Drawing.Color.LightCoral;
                errorMessage += "- Цена товара (поле не может быть пустым)\n";
                hasError = true;
            }
            else if (!int.TryParse(priceText, out int parsedPrice) || parsedPrice <= 0)
            {
                tPrice.BackColor = System.Drawing.Color.LightCoral;
                errorMessage += "- Цена товара (должна быть только положительным числом)\n";
                hasError = true;
            }

            if (cCategory.SelectedItem == null)
            {
                cCategory.BackColor = System.Drawing.Color.LightCoral;
                errorMessage += "- Категория товара\n";
                hasError = true;
            }

            if (cSize.SelectedItem == null)
            {
                cSize.BackColor = System.Drawing.Color.LightCoral;
                errorMessage += "- Размер товара\n";
                hasError = true;
            }

            if (hasError)
            {
                MessageBox.Show(errorMessage, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ///

            ClothingCategory categoryText = (ClothingCategory)cCategory.SelectedItem;
            ClothingSize sizeText = (ClothingSize)cSize.SelectedItem;

            Clothing newClothing = new Clothing(ID, nameText, categoryText, sizeText, int.Parse(priceText));
            MainForm._store.ChangeClothing(newClothing);

            MessageBox.Show("Товар успешно изменен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Заполняет данными выпадающие списки из перечислений ClothingSize и ClothingCategory
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void ChangeClothingForm_Load(object sender, EventArgs e)
        {
            cCategory.DataSource = Enum.GetValues(typeof(ClothingCategory));
            cSize.DataSource = Enum.GetValues(typeof(ClothingSize));

            cCategory.DropDownStyle = ComboBoxStyle.DropDownList; // только выбор из списка
            cSize.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
