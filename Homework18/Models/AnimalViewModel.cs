using Homework18.Models.Runtime.Animals;

namespace Homework18.Models
{
    public class AnimalsViewModel
    {
        public List<Amphibian> Amphibians { get; set; } = [];
        public List<Bird> Birds { get; set; } = [];
        public List<Mammal> Mammals { get; set; } = [];
        public List<NullAnimal> Unknowns { get; set; } = [];

        public AnimalsViewModel(List<Amphibian> amphibians, List<Bird> birds, List<Mammal> mammals, List<NullAnimal> unknowns)
        {
            Amphibians = amphibians;
            Birds = birds;
            Mammals = mammals;
            Unknowns = unknowns;
        }
    }
}
