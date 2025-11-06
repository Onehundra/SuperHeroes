namespace SuperHeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new CharacterService(); 


            //Hero hero = new Hero();
            //hero.Name = "Bruce Payne";
            //hero.SuperHeroName = "Batman";
            //hero.Age = 30;

            //service.AddHero(hero);

            //Villain villain = new Villain();
            //villain.Name = "Joker";
            //villain.PunchLine = "EHEHHAHEHAHEH";
            //villain.Age = 31;

            //service.AddVillain(villain);

            var heros = service.ShowHeroes();
            var villains = service.ShowVillains();

            foreach(var v in villains)
            {
                Console.WriteLine(v.Id + " " + v.Name);
            }
            foreach (var hero in heros)
            {
                Console.WriteLine(hero.Id + hero.Name);
            }

        }
    }
}
