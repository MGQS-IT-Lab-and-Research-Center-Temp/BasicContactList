namespace BasicContactList
{
    public abstract class Animal
    {
        public string Name { get; private set; } = default!;
        public int Age { get; set; }
        public int NoOfLegs { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public virtual string GetDetails()
        {
            return $"Name: {Name}\nAge: {Age}\nNo of Legs: {NoOfLegs}";
        }

        public abstract string MakeSound();

        public abstract string Movement();
    }
}