using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Makray_Robert_Lab12.Models;

namespace Makray_Robert_Lab12.Data
{
    internal interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
