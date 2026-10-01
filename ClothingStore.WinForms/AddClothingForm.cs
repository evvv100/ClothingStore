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

namespace ClothingStore.WinForms
{
    public partial class AddClothingForm : Form
    {
        private static Random rnd = new Random();
        public AddClothingForm()
        {
            InitializeComponent();

            ControlBox = false;
            this.Load += AddClothingForm_Load;
            bAdd.Click += Add_Click;
            bCancel.Click += BCancel_Click;

            tID.ReadOnly = true;
            label2.Text = MainForm._balance.ToString();
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
        /// Наполняет данными списки из перечислений ClothingCategory и ClothingSize
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void AddClothingForm_Load(object sender, EventArgs e)
        {
            cCategory.DataSource = Enum.GetValues(typeof(ClothingCategory));
            cSize.DataSource = Enum.GetValues(typeof(ClothingSize));

            cCategory.DropDownStyle = ComboBoxStyle.DropDownList; // только выбор из списка
            cSize.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        /// <summary>
        /// Проверяет, верно ли введены данные для добавления одежды, и добавляет новый экземпляр класса Clothing в список магазина
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void Add_Click(object sender, EventArgs e)
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

            while (true)
            {
                int r = rnd.Next(100, 1000);
                if (MainForm._store.GetClothingById(r) == null)
                {
                    tID.Text = rnd.Next(100, 1000).ToString();
                    break;
                }
            }
            int idText = int.Parse(tID.Text);

            if (hasError)
            {
                MessageBox.Show(errorMessage, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //---

            ClothingCategory categoryText = (ClothingCategory)cCategory.SelectedItem;
            ClothingSize sizeText = (ClothingSize)cSize.SelectedItem;

            Clothing newClothing = new Clothing(idText, nameText, categoryText, sizeText, int.Parse(priceText));
            MainForm._store.AddClothing(newClothing);

            MessageBox.Show("Товар успешно добавлен в ассортимент магазина!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void AddClothing_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddClothing_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
