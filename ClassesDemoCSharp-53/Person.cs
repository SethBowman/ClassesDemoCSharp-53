namespace ClassesDemoCSharp_53;

public class Person
{
    //fields - a variable inside of a class (camelCase)
    public double _wallet = 0;
    public string _clothes;
    
    //properties - things that define the class (PascalCase)
    public string Name { get; set; }
    public int Age { get; set; } = 0;
    
    //methods (non static methods for now)
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}!");
    }
    
    //constructors
    
    //custom constructor
    public Person(double wallet, string clothes, string name, int age)
    {
        _wallet = wallet;
        _clothes = clothes;
        Name = name;
        Age = age;
    }
    
    //default constructor
    public Person()
    {
        
    }
}