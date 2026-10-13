using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionEnum1
{
    public enum Permission
    {
        ViewCatalog,           // Просмотр каталога, поиск и фильтры
        CreateOrder,           // Корзина и оформление заказа
        ViewOwnOrders,         // Свои заказы и статус выполнения
        CancelOwnOrder,        // Отмена своего заказа (до отправки)
        RequestReturn,         // Возврат товара: запрос
        ProcessReturn,         // Возврат товара: обработка
        ManageCatalog,         // Добавление, изменение, удаление товара
        ManageStock,           // Склад: приёмка, списание
        ChangeOrderStatus,     // Смена статуса заказа
        ViewAllOrders,         // Все заказы всех покупателей
        ViewReports,           // Отчёты (выручка, топ товаров)
        ManageUsers,           // Управление пользователями
        ViewAuditLog           // Журнал операций
    }
}
