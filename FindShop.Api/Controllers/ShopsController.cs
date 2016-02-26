using FindShop.Api.ViewModels;
using FindShop.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FindShop.Api.Controllers
{
    public class ShopsController : ApiController
    {
        // GET: api/Shops
        public async Task<IEnumerable<Shop>> Get()
        {
            using (var findShopContext = new FindShopContext())
            {
                return await findShopContext.Shops.ToArrayAsync();
            }
        }

        // GET: api/Shops/5
        public async Task<Shop> Get(Guid id)
        {
            using (var findShopContext = new FindShopContext())
            {
                return await findShopContext.Shops.SingleAsync(i => i.Id == id);
            }
        }

        // POST: api/Shops
        public async Task Post([FromBody]AddShopRequestViewModel addShopRequestViewModel)
        {
            using (var findShopContext = new FindShopContext())
            {
                findShopContext.Shops.Add(new Shop() { Name = addShopRequestViewModel.Name });

                await findShopContext.SaveChangesAsync();
            }
        }

        // PUT: api/Shops/5
        public async Task Put(Guid id, [FromBody]AddLocationRequestViewModel addLocationRequestViewModel)
        {
            using (var findShopContext = new FindShopContext())
            {
                findShopContext.Locations.Add(new Location()
                {
                    Address = addLocationRequestViewModel.Address,
                    Country = addLocationRequestViewModel.Country,
                    PostalCode = addLocationRequestViewModel.PostalCode,
                    Latitude = addLocationRequestViewModel.Latitude,
                    Longitude = addLocationRequestViewModel.Longitude,
                    Timestamp = DateTimeOffset.UtcNow,
                    ShopId = id
                });

                await findShopContext.SaveChangesAsync();
            }
        }

        // DELETE: api/Shops/5
        public async Task Delete(Guid id)
        {
            using (var findShopContext = new FindShopContext())
            {
                await findShopContext.Database.ExecuteSqlCommandAsync("DELETE FROM Shops WHERE Id = @p0", id);
            }
        }
    }
}
