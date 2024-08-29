namespace Homework18.Models.Interfaces.Animals
{
    public interface IAnimal
    {
        public string Domain { get; set; } 
        public string Kingdom { get; set; } 
        public string Type { get; set; } 
        public string Squad { get; set; } 
        public string Family { get; set; } 
        public string Genus { get; set; } 
    }
}
