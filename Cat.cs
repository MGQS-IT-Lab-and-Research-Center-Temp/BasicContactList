namespace BasicContactList
{
    public class Cat : Animal
    {
        public string Breed { get; set; } = default!;

        public override string GetDetails()
        {
            return $"Name: {Name}\nAge: {Age}\nNo of Legs: {NoOfLegs}\nBreed: {Breed}";
        }

        public override string MakeSound()
        {
            return "Meaow! Meaow!!";
        }

        public override string Movement()
        {
            return "Gliding";
        }
    }
}