using GroceryApp.Data;
using GroceryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Service
{
    public class GroceryService
    {
        public bool CreateGroceryStore(GroceryStoreCreate model)
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

        public IEnumerable<GroceryStoreListItem> GetGroceryStores()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .GroceryStores
                    .Select
                    (
                        e => new GroceryStoreListItem
                        {
                            GroceryStoreID = e.GroceryStoreID,
                            Name = e.Name,
                            Address = e.Address,
                            Website = e.Website,
                            PhoneNumber = e.PhoneNumber,
                            App = e.App,
                            Hours = e.Hours
                        }
                    );
                return query.ToArray();
            }
        }

        public GroceryStoreDetail GetGroceryStoreyById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .GroceryStores
                    .Single(e => e.GroceryStoreID == id);
                return new GroceryStoreDetail
                {
                    GroceryStoreID = entity.GroceryStoreID,
                    Name = entity.Name,
                    Address = entity.Address,
                    Website = entity.Website,
                    PhoneNumber = entity.PhoneNumber,
                    App = entity.App,
                    Hours = entity.Hours
                };
            }
        }

        public bool UpdateGroceryStore(GroceryStoreEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .GroceryStores
                    .Single(e => e.GroceryStoreID == model.GroceryStoreID);

                entity.Name = model.Name;
                entity.Address = model.Address;
                entity.Website = model.Website;
                entity.PhoneNumber = model.PhoneNumber;
                entity.App = model.App;
                entity.Hours = model.Hours;

                return ctx.SaveChanges() == 1;

            }
        }
        public bool DeleteGroceryStore(int groceryStoreId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                   ctx
                   .GroceryStores
                   .Single(e => e.GroceryStoreID == groceryStoreId);

                ctx.GroceryStores.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
