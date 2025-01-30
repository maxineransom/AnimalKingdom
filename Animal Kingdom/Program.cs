public class Animal
{
    //public and private varibles
    public string Name {get; set;}
    public int Age {get; set;}

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} makes a sound");
    }

}



class Program{
    static void Main(string[] args)
    {
Bird parrot = new Bird("Parrot", 5);
Fish goldfish = new Fish("Goldfish", 1);

parrot.MakeSound();
goldfish.MakeSound();

Console.WriteLine(parrot.Name);
Console.WriteLine(goldfish.Age);

    }
}