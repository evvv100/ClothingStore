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
using ClothingCategory1;
using ClothingSize1;
using Logic1;

namespace ClothingStore.WinForms
{
    public partial class SearchByIDForm : Form
    {
        public SearchByIDForm()
        {
            InitializeComponent();
            bChange.Click += BChange_Click;
            bCancel.Click += BCancel_Click;
            bRemove.Click += BRemove_Click;
            bAdd.Click += BAdd_Click;
            ControlBox = false;
            bRemove.Visible = true;
            label2.Text = MainForm._balance.ToString();
            UpdateTableData();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            AddClothingForm addClothingForm = new AddClothingForm();
            addClothingForm.ShowDialog();
            UpdateTableData();
        }

        /// <summary>
        /// Удаляет товар
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void BRemove_Click(object sender, EventArgs e)
        {
            object tID = dCatalog.CurrentRow.Cells[0].Value;
            int idd = int.Parse(tID.ToString());
            if (MainForm._store.GetClothingById(idd)!=null)
            {
                MainForm._store.RemoveClothing(idd);
                MessageBox.Show("Товар удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Невозможно найти товар", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateTableData();
        }
        /// <summary>
        /// Обновляет данные в dataGridView dCatalog
        /// </summary>
        public void UpdateTableData()
        {
            MainForm._store.ReturnList(out List<Clothing> clothesList);
            dCatalog.DataSource = null;
            dCatalog.DataSource = clothesList;

            if (dCatalog.Columns["Id"] != null)
                dCatalog.Columns["Id"].HeaderText = "Артикул";
            if (dCatalog.Columns["Name"] != null)
                dCatalog.Columns["Name"].HeaderText = "Название";
            if (dCatalog.Columns["Category"] != null)
                dCatalog.Columns["Category"].HeaderText = "Категория";
            if (dCatalog.Columns["Size"] != null)
                dCatalog.Columns["Size"].HeaderText = "Размер";
            if (dCatalog.Columns["Price"] != null)
                dCatalog.Columns["Price"].HeaderText = "Цена (руб.)";
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
        /// Проверяет, правильно ли написан Id товара, выводит информацию о нем, показывает кнопку для удаления
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void BChange_Click(object sender, EventArgs e)
        {
            object cellValue = dCatalog.CurrentRow.Cells[0].Value;
            int selectedId = 0;

            if (cellValue != null)
            {
                selectedId = Convert.ToInt32(cellValue);
            }
            ChangeClothingForm changeClothingForm = new ChangeClothingForm(selectedId);
            changeClothingForm.ShowDialog();
            UpdateTableData();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchByIDForm_Load(object sender, EventArgs e)
        {

        }
    }
}
