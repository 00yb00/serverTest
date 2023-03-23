using Microsoft.AspNetCore.Mvc;
using Model;
using Entities;
namespace WebApiXnes.Controllers
{
    [ApiController]
    [Route("api/AllItems")]
    public class ItemController : ControllerBase
    {
        public ItemController()
        {
        }
        [HttpGet("GetAllItems")]
        public JsonResult getAllItems()
        {
            List<Item> itemstList = new List<Item>();
            ItemEntities ItemEntities = new ItemEntities();
            itemstList = ItemEntities.GetItemsEntities();
            return new JsonResult(itemstList);
        }
        [HttpGet("GetAllItemsAfterSum")]
        public JsonResult getAllItemsAfterSum()
        {
            List<Item> itemstList = new List<Item>();
            ItemEntities ItemEntities = new ItemEntities();
            itemstList = ItemEntities.GetItemsSumEntities();
            return new JsonResult(itemstList);
        }

    }
}
