
//FISH
public class Fish : Animal
{
    public Fish(string name, int age) : base(name, age)
    {
    }
    //attach animal to sound
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}, does not a make a noise");
    }
}
