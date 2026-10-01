using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothingStore.Core;

namespace ClothingStore.WinForms
{
    public partial class SearchByIDForm : Form
    {
        public SearchByIDForm()
        {
            InitializeComponent();
            bSearch.Click += BSearch_Click;
            bCancel.Click += BCancel_Click;
            bRemove.Hide();
            bRemove.Click += BRemove_Click;
            ControlBox = false;
            label2.Text = MainForm._balance.ToString();
        }
        /// <summary>
        /// Удаляет товар
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void BRemove_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tName.Text))
            {
                DialogResult res = MessageBox.Show("Вы действительно хотите удалить товар?", "Удаление товара", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    MainForm._store.RemoveClothing(int.Parse(tID.Text));
                    tName.Text = null;
                    tID.Text = null;
                    tCategory.Text = null;
                    tSize.Text = null;
                    tPrice.Text = null;
                    bRemove.Hide();
                }
            }
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
        /// Проверяет, правильно ли написан ID товара, выводит информацию о нем, показывает кнопку для удаления
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void BSearch_Click(object sender, EventArgs e)
        {
            tID.BackColor = System.Drawing.Color.White;

            bool hasError = false;
            string errorMessage = "Пожалуйста, заполните обязательное поле:\n";

            string idText = tID.Text.Trim();
            if (string.IsNullOrEmpty(idText))
            {
                tID.BackColor = System.Drawing.Color.LightCoral;
                errorMessage += "- ID\n";
                hasError = true;
            }
            else if (!int.TryParse(idText, out int parsedID) || parsedID <= 0)
            {
                tID.BackColor = System.Drawing.Color.LightCoral;
                errorMessage += "- ID(ID должен быть целым положительным числом)\n";
                hasError = true;
            }
            else
            {
                if (MainForm._store.GetClothingById(int.Parse(idText)) == null)
                {
                    tID.BackColor = System.Drawing.Color.LightCoral;
                    errorMessage += "- ID(Такого ID не существует)\n";
                    hasError = true;
                }
                else
                {
                    Clothing clothing = MainForm._store.GetClothingById(int.Parse(idText));
                    tName.Text = clothing.Name;
                    tCategory.Text = clothing.Category.ToString();
                    tSize.Text = clothing.Size.ToString();
                    tPrice.Text = clothing.Price.ToString();
                }
            }

            if (hasError)
            {
                MessageBox.Show(errorMessage, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bRemove.Hide();
                return;
            }
            bRemove.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchByIDForm_Load(object sender, EventArgs e)
        {

        }
    }
}
