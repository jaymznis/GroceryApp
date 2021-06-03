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

            }
        }

    }
}
