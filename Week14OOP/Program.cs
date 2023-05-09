// Loome oma klassiobjekti ja ]petame teda midagi tegema, haugub ja liputab saba
Console.WriteLine("name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good girl");


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name ise {neighboursDog.Name}.");

myDog.Rename("Bad boy");
while (myDog.LevelOfHapiness != 5)
{
    myDog.bark();
}

myDog.WagTail();    
class Dog
{
    private string _name = "Koer"; // private - field
    private int _levelOfHapiness = 0;

    //constructor
    public Dog(string name)//name-lets the user name the dog
    {
        _name = name;
        _levelOfHapiness = 0;
    } 
    //getter
    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    //koera nime muutmine
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void bark()
    {
        Console.WriteLine("woof-woof!");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle");
    }
}