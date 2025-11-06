using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    public class CharacterService
    {
        private readonly AppDbContext db;

        public CharacterService()
        {
            db = new AppDbContext();
        }

        public void AddHero(Hero hero)
        {
            db.heroes.Add(hero);
            db.SaveChanges();
            Console.WriteLine("Hero was saved: "+ hero.Name);
        }
        public void AddVillain(Villain villain)
        {
            db.villains.Add(villain);
            db.SaveChanges();
            Console.WriteLine("Villain was hsaved" + villain.Name);
        }
        public List<Hero> ShowHeroes()
        {
            return db.heroes.ToList();
        }

        public List<Villain> ShowVillains()
        {
            return db.villains.ToList();
        }
    }
}
