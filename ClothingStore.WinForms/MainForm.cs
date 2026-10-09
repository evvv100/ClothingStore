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
    public partial class MainForm : Form
    {
        public static Logic _store = new Logic();
        public static Random rnd = new Random();
        public static List<Clothing> _list = new List<Clothing>();
        public static int _balance = rnd.Next(10000, 20001);
        public MainForm()
        {
            InitializeComponent();

            SeedInitialData();

            bSearch.Click += bSearch_Click;
            bAssemble.Click += bAssemble_Click;
            bHistory.Click += BHistory_Click;
            bBack.Click += BBack_Click;
        }
        /// <summary>
        /// Закрывает приложение
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void BBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Заполняет данными каталог одежды
        /// </summary>
        private void SeedInitialData()
        {
            _store.AddClothing(new Clothing(rnd.Next(100, 1000), "Белая футболка", ClothingCategory.TShirt, ClothingSize.M, 1500));
            _store.AddClothing(new Clothing(rnd.Next(100, 1000), "Черная футболка", ClothingCategory.TShirt, ClothingSize.L, 1800));
            _store.AddClothing(new Clothing(rnd.Next(100, 1000), "Синие джинсы", ClothingCategory.Jeans, ClothingSize.XL, 4500));
            _store.AddClothing(new Clothing(rnd.Next(100, 1000), "Черные джинсы", ClothingCategory.Jeans, ClothingSize.S, 4200));
            _store.AddClothing(new Clothing(rnd.Next(100, 1000), "Джинсовая куртка", ClothingCategory.Jacket, ClothingSize.M, 6500));
            _store.AddClothing(new Clothing(rnd.Next(100, 1000), "Зимний пуховик", ClothingCategory.Jacket, ClothingSize.XL, 12000));
            _store.AddClothing(new Clothing(rnd.Next(100, 1000), "Шорты белые", ClothingCategory.Shorts, ClothingSize.M, 350));
            _store.AddClothing(new Clothing(rnd.Next(100, 1000), "Шорты с принтом", ClothingCategory.Shorts, ClothingSize.S, 400));
            _store.AddClothing(new Clothing(rnd.Next(100, 1000), "Черное платье", ClothingCategory.Dress, ClothingSize.M, 5500));
            _store.AddClothing(new Clothing(rnd.Next(100, 1000), "Летнее платье", ClothingCategory.Dress, ClothingSize.XS, 3800));
        }
        /// <summary>
        /// Создает форму Истории покупок, блокирует и скрывает главную форму
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void BHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            Hide();
            historyForm.ShowDialog();
            Show();
        }
        /// <summary>
        /// Создает форму Каталога, где можно посмотреть, добавить или удалить одежду, блокирует и скрывает главную форму
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void bSearch_Click(object sender, EventArgs e)
        {
            SearchByIDForm searchByIDForm = new SearchByIDForm();
            Hide();
            searchByIDForm.ShowDialog();
            Show();
        }
        /// <summary>
        /// Создает форму Сборки корзины, блокирует и скрывает главную форму
        /// </summary>
        /// <param name="sender">Объект-отправитель события</param>
        /// <param name="e">Аргумент данных события</param>
        private void bAssemble_Click(object sender, EventArgs e)
        {
            AssembleBasketForm assembleBasketForm = new AssembleBasketForm();
            Hide();
            assembleBasketForm.ShowDialog();
            Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
