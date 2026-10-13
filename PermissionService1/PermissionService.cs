using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoleEnum1;
using PermissionEnum1;

namespace PermissionService1
{
    public static class PermissionService
    {
        public static bool CanDo(Role role, Permission permission)
        {
            if (role == Role.Администратор)
            {
                return true;
            }
            else if (role == Role.Покупатель)
            {
                if (permission == Permission.ViewCatalog ||
                permission == Permission.CreateOrder ||
                permission == Permission.ViewOwnOrders ||
                permission == Permission.CancelOwnOrder ||
                permission == Permission.RequestReturn)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (role == Role.Продавец)
            {
                if (permission == Permission.ViewCatalog ||
                permission == Permission.ProcessReturn ||
                permission == Permission.ManageCatalog ||
                permission == Permission.ManageStock ||
                permission == Permission.ChangeOrderStatus ||
                permission == Permission.ViewAllOrders)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
