using GroceryApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Service
{
    public class GroceryService
    {
        private readonly Guid _userId;

        public GroceryService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateGroceryStore(GroceryCreate model)
        {
            var entity = new GroceryStores()
            {
                Name = model.Name,
                Address = model.Address,
                Website = model.Website,
                PhoneNumber = model.PhoneNumber,
                App = model.App,
                Hours = model.Hours
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.GroceryStores.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public GroceryDetail GetGroceryStoreyById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .GroceryStores
                    .Single(e => e.GroceryStoreID == id);
                return new GroceryDetail
                {
                    GroceryStoreId = entity.GroceryStoreID,
                    Name = entity.Name,
                    Address = entity.Address,
                    Website = entity.Website,
                    PhoneNumber = entity.PhoneNumber,
                    AppContext = entity.App,
                    Hours = entity.Hours
                };
            }
        }


    }
}
