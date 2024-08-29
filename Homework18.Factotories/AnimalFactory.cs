using Homework18.DataBase;
using Homework18.Models.Interfaces.Animals;
using Homework18.Models.Runtime.Animals;
using Homework18.Models.Runtime.ClientModels;

namespace Homework18.Factotories
{
    public static class AnimalFactory
    {
        public static async Task CreateNewAnimal(NewAnimal animal, DataBaseContext dbContext)
        {
            switch (animal.Class)
            {
                case "Amphibian":
                    Amphibian amphibian = new Amphibian()
                    {
                        Domain = animal.Domain,
                        Family = animal.Family,
                        Genus = animal.Genus,
                        Kingdom = animal.Kingdom,
                        Squad = animal.Squad,
                        Type = animal.Type,
                    };

                    dbContext.Amphibians.Add(amphibian);
                    await dbContext.SaveChangesAsync();

                    break;

                case "Bird":
                    Bird bird = new Bird()
                    {
                        Domain = animal.Domain,
                        Family = animal.Family,
                        Genus = animal.Genus,
                        Kingdom = animal.Kingdom,
                        Squad = animal.Squad,
                        Type = animal.Type,
                    };

                    dbContext.Birds.Add(bird);
                    await dbContext.SaveChangesAsync();

                    break;

                case "Mammal":
                    Mammal mammal = new Mammal()
                    {
                        Domain = animal.Domain,
                        Family = animal.Family,
                        Genus = animal.Genus,
                        Kingdom = animal.Kingdom,
                        Squad = animal.Squad,
                        Type = animal.Type,
                    };

                    dbContext.Mammals.Add(mammal);
                    await dbContext.SaveChangesAsync();

                    break;

                default:
                    NullAnimal nullAnimal = new NullAnimal()
                    {
                        Domain = animal.Domain,
                        Family = animal.Family,
                        Genus = animal.Genus,
                        Kingdom = animal.Kingdom,
                        Squad = animal.Squad,
                        Type = animal.Type,
                    };

                    dbContext.Unknowns.Add(nullAnimal);
                    await dbContext.SaveChangesAsync();

                    break;
            }



        }
    }
}
