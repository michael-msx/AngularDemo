
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using AngularDemo.Models;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularDemo.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<DotaHero> Get()
        {
            HeroManager HM = new HeroManager();
            return HM.GetAll;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public DotaHero Get(int id)
        {
            HeroManager HM = new HeroManager();
            return HM.GetHeroByID(id);
        }

    }
}
