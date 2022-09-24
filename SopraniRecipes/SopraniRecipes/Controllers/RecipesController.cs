using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SopraniRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]

        public string[] GetDishes()
        {
            string[] dishes = { "Picanha ao Forno", "Feijoada", "Sukiake" };
            return dishes;
        }
    }
}
