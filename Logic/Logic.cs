using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.Core;
using ClothingCategory1;
using ClothingSize1;
using DataAccessLayer;


namespace Logic1
{
    public class Logic
    {
        private readonly IRepository<Clothing> _repository;

        public Logic(IRepository<Clothing> repository) 
        {
            _repository = repository;
        }
        /// <summary>
        /// Добавляет одежду в каталог
        /// </summary>
        /// <param name="clothing">Одежда, которую надо добавить</param>
        public void AddClothing(Clothing clothing)
        {
            if (clothing != null)
            {
                _repository.Add(clothing);
            }
        }
        /// <summary>
        /// Удаляет одежду из каталога по Id
        /// </summary>
        /// <param name="id">Id одежды, которую нужно удалить из каталога</param>
        public void RemoveClothing(int id)
        {
            _repository.Delete(id);
        }
        /// <summary>
        /// Возвращает список - каталог товаров в логике
        /// </summary>
        /// <param name="clothing">Список товаров, который хранится в экзмепляре класса Logic</param>
        public void ReturnList(out List<Clothing> clothing)
        {
            clothing = _repository.ReadAll();
        }
        /// <summary>
        /// Возвращает одежду по Id
        /// </summary>
        /// <param name="id">Id товара, который нужен</param>
        /// <returns>Возвращает объект Clothing по Id</returns>
        public Clothing GetClothingById(int id)
        {
            return _repository.ReadById(id);
        }
        /// <summary>
        /// Изменяет конкретный товар по Id (Id сохраняется)
        /// </summary>
        /// <param name="clothing">Объект Clothing, который нужно изменить в каталоге</param>
        public void ChangeClothing(Clothing clothing)
        {
            if (clothing != null)
            {
                _repository.Update(clothing);
            }
        }
        
        //public void FilterSize(out List<Clothing> clothing, ClothingSize size)
        //{
        //    clothing = new List<Clothing>(_allClothing.Where(c => c.Size == size));
        //}
    }
}
