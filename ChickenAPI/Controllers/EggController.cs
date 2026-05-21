using ChickenAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChickenAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EggController:Controller
    {
    [HttpGet("/GetMeEggs")]
    public ActionResult GetEggs()

    {

    return Ok("Here are some eggs! :)");

    }


    
}
}