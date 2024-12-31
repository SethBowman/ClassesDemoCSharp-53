namespace ClassesDemoCSharp_53;

public class Program
{
    static void Main(string[] args)
    {
        //dot notation
        Person seth = new Person();
        seth._clothes = "t shirt and slacks";
        seth._wallet = 200.00;
        seth.Name = "Seth";
        seth.Age = 30;
        
        seth.Greet();
        
        //object initializer syntax
        var bill = new Person()
        {
            Name = "Bill",
            Age = 24,
            _clothes = "suit",
            _wallet = 300.00
        };
        
        bill.Greet();
        
        //using a custom constructor
        var bob = new Person(500.00, "blue suit", "Bob", 40);
    }
}
