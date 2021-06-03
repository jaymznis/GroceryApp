using GroceryApp.Models;
using GroceryApp.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GroceryApp.WebAPI.Controllers
{
    public class GroceryStoreController : ApiController
    {

        private GroceryService CreateGroceryService()
        {
            var groceryService = new GroceryService();
            return groceryService;
        }

        public IHttpActionResult Get()
        {
            GroceryService groceryService = CreateGroceryService();
            var store = groceryService.GetGroceryStores();
            return Ok(store);
        }
        public IHttpActionResult Post(GroceryStoreCreate store)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateGroceryService();

            if (!service.CreateGroceryStore(store))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get(int id)
        {
            GroceryService groceryService = CreateGroceryService();
            var store = groceryService.GetGroceryStoreyById(id);
            return Ok(store);
        }

        public IHttpActionResult Put(GroceryStoreEdit store)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateGroceryService();

            if (!service.UpdateGroceryStore(store))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateGroceryService();

            if (!service.DeleteGroceryStore(id))
                return InternalServerError();

            return Ok();
        }
    }
}
