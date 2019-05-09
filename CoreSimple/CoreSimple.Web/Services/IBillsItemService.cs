using CoreSimple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSimple.Web.Services
{
    public interface IBillsItemService
    {
        Task<IEnumerable<BillsItem>> GetBillsItemByDateAsync(DateTime dateTime);

        Task<BillsItem> GetBillsItemByIdAsync(int id);

        void AddAsync(BillsItem billsItem);
        Task<int> EditAsync(BillsItem billsItem);
        Task<int> DeleteAsync(int id);
    }
}
