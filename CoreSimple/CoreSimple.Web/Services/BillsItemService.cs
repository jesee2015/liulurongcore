using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreSimple.Models;
using CoreSimple.Web.DataBase;

namespace CoreSimple.Web.Services
{
    public class BillsItemService : IBillsItemService
    {
        public BillsItemService(MyDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public MyDbContext DbContext { get; }

        public void AddAsync(BillsItem billsItem)
        {
             DbContext.BillsItems.AddAsync(billsItem);
            DbContext.SaveChangesAsync();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> EditAsync(BillsItem billsItem)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BillsItem>> GetBillsItemByDateAsync(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public Task<BillsItem> GetBillsItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
