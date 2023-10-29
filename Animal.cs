namespace BasicContactList
{
    public abstract class Animal
    {
        public string Name { get; private set; } = default!;
        public int Age { get; set; }

        public int NoOfLegs { get; set; }

        public virtual string MakeSound()
        {
            return "Animal sound";
        }

        public abstract string Movement();

        public void SetName(string name)
        {
            Name = name;
        }
    }
}