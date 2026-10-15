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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            bCancel.Click += BCancel_Click;
            bReturn.Click += BReturn_Click;
            ControlBox = false;
            label2.Text = MainForm._balance.ToString();
            UpdateData();

        }
        /// <summary>
        /// Возвращает купленный товар в магазин и деньги на счет
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void BReturn_Click(object sender, EventArgs e)
        {
            if(dList.CurrentRow!=null)
            {
                object cellValue = dList.CurrentRow.Cells[0].Value;
                if (cellValue != null)
                {
                    int selectedId = Convert.ToInt32(cellValue);
                    if (MainForm._list.Any(x=>x.Id== selectedId))
                    {
                        Clothing newCl = MainForm._list.Find( с=> с.Id == selectedId);
                        MainForm._balance += newCl.Price;
                        MainForm._list.Remove(newCl);
                        MainForm._store.AddClothing(newCl);
                        label2.Text=MainForm._balance.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Такого товара не существует!", "Неизвестный товар", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите товар!", "Товар не выбран", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите товар!", "Товар не выбран", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateData();
        }
        /// <summary>
        /// Обновляет данные в dataGridView dList
        /// </summary>
        private void UpdateData()
        {
            dList.DataSource = null;
            dList.DataSource = MainForm._list;

            if (dList.Columns["Id"] != null)
                dList.Columns["Id"].HeaderText = "Артикул";
            if (dList.Columns["Name"] != null)
                dList.Columns["Name"].HeaderText = "Название";
            if (dList.Columns["Category"] != null)
                dList.Columns["Category"].HeaderText = "Категория";
            if (dList.Columns["Size"] != null)
                dList.Columns["Size"].HeaderText = "Размер";
            if (dList.Columns["Price"] != null)
                dList.Columns["Price"].HeaderText = "Цена (руб.)";
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

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
