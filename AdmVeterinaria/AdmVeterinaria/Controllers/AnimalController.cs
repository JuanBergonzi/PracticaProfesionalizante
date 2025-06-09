using AdmVeterinaria.Clases;
using AdmVeterinaria.Services;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc;

namespace AdmVeterinaria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> GetAnimales()  //ActionResul me devuelve un objeto especifico
        {
            return Ok(AnimalDataStore.Current.Animales);
        }


    }
}
