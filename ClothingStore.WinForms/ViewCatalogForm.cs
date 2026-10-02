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
    public partial class ViewCatalogForm : Form
    {
        public ViewCatalogForm()
        {
            InitializeComponent();
            bCancel.Click += BCancel_Click;
            UpdateTableData();
            ControlBox = false;
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
        /// Обновляет данные в dataGridView dCatalog
        /// </summary>
        public void UpdateTableData()
        {
            MainForm._store.ReturnList(out List<Clothing> clothesList);
            dCatalog.DataSource = null;
            dCatalog.DataSource = clothesList;

            if (dCatalog.Columns["ID"] != null)
                dCatalog.Columns["ID"].HeaderText = "Артикул";
            if (dCatalog.Columns["Name"] != null)
                dCatalog.Columns["Name"].HeaderText = "Название";
            if (dCatalog.Columns["Category"] != null)
                dCatalog.Columns["Category"].HeaderText = "Категория";
            if (dCatalog.Columns["Size"] != null)
                dCatalog.Columns["Size"].HeaderText = "Размер";
            if (dCatalog.Columns["Price"] != null)
                dCatalog.Columns["Price"].HeaderText = "Цена (руб.)";
        }
        private void ViewCatalogForm_Load(object sender, EventArgs e)
        {

        }

        private void dCatalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
