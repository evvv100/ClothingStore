using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.Core;
using ClothingCategory1;
using ClothingSize1;


namespace Logic1
{
    public class Logic
    {
        private List<Clothing> _allClothing = new List<Clothing>();

        public Logic() { }
        /// <summary>
        /// Добавляет одежду в каталог
        /// </summary>
        /// <param name="clothing">Одежда, которую надо добавить</param>
        public void AddClothing(Clothing clothing)
        {
            if (clothing != null)
            {
                _allClothing.Add(clothing);
            }
        }
        /// <summary>
        /// Удаляет одежду из каталога по ID
        /// </summary>
        /// <param name="id">ID одежды, которую нужно удалить из каталога</param>
        public void RemoveClothing(int id)
        {
            if (_allClothing.Any(c => c.ID == id))
            {
                _allClothing.Remove(_allClothing.Find(c => c.ID == id));
            }
        }
        /// <summary>
        /// Возвращает список - каталог товаров в логике
        /// </summary>
        /// <param name="clothing">Список товаров, который хранится в экзмепляре класса Logic</param>
        public void ReturnList(out List<Clothing> clothing)
        {
            clothing = new List<Clothing>(_allClothing);
        }
        /// <summary>
        /// Возвращает одежду по ID
        /// </summary>
        /// <param name="id">ID товара, который нужен</param>
        /// <returns>Возвращает объект Clothing по ID</returns>
        public Clothing GetClothingById(int id)
        {
            return _allClothing.FirstOrDefault(c => c.ID == id);
        }
        /// <summary>
        /// Изменяет конкретный товар по ID (ID сохраняется)
        /// </summary>
        /// <param name="clothing">Объект Clothing, который нужно изменить в каталоге</param>
        public void ChangeClothing(Clothing clothing)
        {
            if (clothing != null && _allClothing.Any(c => c.ID == clothing.ID))
            {
                Clothing cl = _allClothing.Find(c => c.ID == clothing.ID);
                cl.Name = clothing.Name;
                cl.Category = clothing.Category;
                cl.Size = clothing.Size;
                cl.Price = clothing.Price;
            }
        }
        /// <summary>
        /// Собирает корзину товаров, удаляет ее из каталога, считает сумму покупки
        /// </summary>
        /// <param name="id">Список ID товаров, которые нужно купить</param>
        /// <returns>Возвращает сумму покупки</returns>
        public int AssembleBasket(ref List<int> id)
        {
            int count = 0;
            for (int i = 0; i < id.Count; i++)
            {
                int idd = id[i];
                Clothing cl = _allClothing.Find(c => c.ID == idd);
                if (cl == null)
                    continue;
                count += cl.Price;
                _allClothing.Remove(cl);
            }
            return count;
        }
        /// <summary>
        /// Фильтрует список одежды по размеру
        /// </summary>
        /// <param name="clothing">Список одежды</param>
        /// <param name="size">Размер, по которому будем фильтровать</param>
        public void FilterSize(out List<Clothing> clothing, ClothingSize size)
        {
            clothing = new List<Clothing>(_allClothing.Where(c => c.Size == size));
        }
    }
}
