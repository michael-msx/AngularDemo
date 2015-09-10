using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularDemo.Models
{
    public class HeroManager
    {
        readonly List<DotaHero> _heros = new List<DotaHero> {
            new DotaHero { ID = 1 , Name = "Braistleback", Type="Strength" },
            new DotaHero { ID = 2 , Name = "Abbadon", Type="Strength" },
            new DotaHero { ID = 3 , Name = "Spectre", Type="Agility" },
            new DotaHero { ID = 4 , Name = "Juggernaut", Type="Agility" },
            new DotaHero { ID = 5 , Name = "Lion", Type="Intelligence" },
            new DotaHero { ID = 6 , Name = "Zues", Type="Intelligence" },
            new DotaHero { ID = 7 , Name = "Trent", Type="Strength" }
        };

        public IEnumerable<DotaHero> GetAll { get { return _heros; } }

        public List<DotaHero> GetHeroesByType(string type) {
            return _heros.Where(o => o.Type.ToLower().Equals(type.ToLower())).ToList();
        }

        public DotaHero GetHeroByID(int id) {
            return _heros.Find(o => o.ID == id);
        }
    }
}
