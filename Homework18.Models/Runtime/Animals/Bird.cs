using Homework18.Models.Interfaces.Animals;

namespace Homework18.Models.Runtime.Animals
{
    public class Bird : IAnimal
    {
        public int Id { get; set; }
        public string Domain { get; set; } = string.Empty;
        public string Kingdom { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Squad { get; set; } = string.Empty;
        public string Family { get; set; } = string.Empty;
        public string Genus { get; set; } = string.Empty;
    }
}
