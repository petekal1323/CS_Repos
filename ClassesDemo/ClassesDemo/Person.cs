namespace ClassesDemo;

public class Person
{
    //Fields - a variable inside of class (camel case)
    public int wallet;
    public string clothes;
    
    
    //Properties - things that define the class (Pascal case)
    public string Name { get; set; }
    public int Age { get; set; }
    
    
    //Methods - a function inside of a class (non-static methods for now)
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
    
    //Constructors - a method that runs when the class is instantiated
    
    //Default constructor

     public Person()
     {
         
     }
    
    //custom constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}