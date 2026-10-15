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
    public partial class AssembleBasketForm : Form
    {
        private List<Clothing> _basket = new List<Clothing>();
        public AssembleBasketForm()
        {
            InitializeComponent();

            ControlBox = false;
            UpdateBasket();
            UpdateCatalog();
            bAdd.Click += BAdd_Click;
            bRemove.Click += BRemove_Click;
            bOk.Click += BOk_Click;
            bCancel.Click += BCancel_Click;
            label7.Text = MainForm._balance.ToString();
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            cSize.DataSource = Enum.GetValues(typeof(ClothingSize));
            cSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cSize.SelectedIndexChanged += CSize_SelectedIndexChanged;
        }
        /// <summary>
        /// При изменении выбранного элемента обновляет таблицу каталог
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void CSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCatalog();
        }

        /// <summary>
        /// Делает видимым/невидимым checkBox1 и обновляет данные в таблице каталог
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                cSize.Visible = true;

            }
            else
            {
                cSize.Visible = false;
            }
            UpdateCatalog();
        }

        /// <summary>
        /// Проверяет корзину перед закрытием формы, удаляет объекты, если они есть в списке, а также закрывает форму
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void BCancel_Click(object sender, EventArgs e)
        {
            if(_basket.Count!=0)
            {
                for(int i=0; i< _basket.Count; i++)
                {
                    MainForm._store.AddClothing( _basket[i] );
                }
            }
            _basket.Clear();
            Close();
        }
        /// <summary>
        /// Проверяет, есть ли объекты в корзине, производит покупку, вычисляет баланс, добавляет покупки в историю покупок list, закрывает форму
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void BOk_Click(object sender, EventArgs e)
        {
            if(_basket.Count==0)
            {
                MessageBox.Show($"Добавьте товары в корзину!", "Корзина пуста", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MainForm._balance < CalculateTheTotal())
                {
                    MessageBox.Show($"Недостаточно средств!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult res = MessageBox.Show($"Сумма покупки составляет: {CalculateTheTotal()}\nОплатить?", "Завершение покупки", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        MainForm._balance-=CalculateTheTotal();
                        for(int i=0; i< _basket.Count;i++ )
                        {
                            MainForm._list.Add(_basket[i]);
                        }
                        _basket.Clear();
                        UpdateCatalog();
                        UpdateBasket();
                        Close();
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает из корзины в каталог последний добавленный объект 
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void BRemove_Click(object sender, EventArgs e)
        {
            UpdateBasket();
            UpdateCatalog();
            if (_basket.Count != 0)
            {
                MainForm._store.AddClothing(_basket.Last());
                _basket.Remove(_basket.Last());
            }
            else
            {
                MessageBox.Show("В корзине ничего нет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateBasket();
            UpdateCatalog();
            lTotal.Text = CalculateTheTotal().ToString();
        }
        /// <summary>
        /// Добавляет товар в корзину, обновляет итоговую сумму
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void BAdd_Click(object sender, EventArgs e)
        {
            if (dCatalog.CurrentRow != null)
            {
                object cellValue = dCatalog.CurrentRow.Cells[0].Value;

                if (cellValue != null)
                {
                    int selectedId = Convert.ToInt32(cellValue);
                    if (MainForm._store.GetClothingById(selectedId) != null)
                    {
                        Clothing newCl = MainForm._store.GetClothingById(selectedId);
                        MainForm._store.RemoveClothing(selectedId);
                        _basket.Add(newCl);
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

            UpdateBasket();
            UpdateCatalog();
            lTotal.Text = CalculateTheTotal().ToString();

        }
        /// <summary>
        /// Считает сумму покупки
        /// </summary>
        /// <returns>Возвращает сумму покупки</returns>
        private int CalculateTheTotal()
        {
            int count = 0;
            for(int i=0; i < _basket.Count; i++)
            {
                count += _basket[i].Price;
            }
            return count;
        }
        /// <summary>
        /// Обновляет данные в dataGridView dBasket
        /// </summary>
        private void UpdateBasket()
        {
            dBasket.DataSource = null;
            dBasket.DataSource = _basket;

            if(dBasket.Columns["Id"] != null)
                dBasket.Columns["Id"].HeaderText = "Артикул";
            if (dBasket.Columns["Name"] != null)
                dBasket.Columns["Name"].HeaderText = "Название";
            if (dBasket.Columns["Category"] != null)
                dBasket.Columns["Category"].HeaderText = "Категория";
            if (dBasket.Columns["Size"] != null)
                dBasket.Columns["Size"].HeaderText = "Размер";
            if (dBasket.Columns["Price"] != null)
                dBasket.Columns["Price"].HeaderText = "Цена (руб.)";
        }
        /// <summary>
        /// Обновляет данные в dataGridView dCatalog
        /// </summary>
        private void UpdateCatalog()
        {
            MainForm._store.ReturnList(out List<Clothing> clothing);
            dCatalog.DataSource = null;
            if(checkBox1.Checked)
            {
                List <Clothing> clothing_new = new List<Clothing>();
                for(int i=0; i < clothing.Count; i++ )
                {
                    if(clothing[i].Size==(ClothingSize)cSize.SelectedItem)
                    {
                        clothing_new.Add(clothing[i]);
                    }
                }
                dCatalog.DataSource = clothing_new;
            }
            else
            {
                dCatalog.DataSource = clothing;
            }

            if(dCatalog.Columns["Id"] != null)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AssembleBasketForm_Load(object sender, EventArgs e)
        {

        }
        // проверка связи
    }
}
