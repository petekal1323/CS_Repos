using ClassesDemo;

var Peter = new Person();

//dot notation
Peter.Name = "Peter";
Peter.Age = 25;
Peter.clothes = "T-shirt and slacks";
Peter.wallet = 100;

Peter.Greet();


//object initializer
var John = new Person()
{
    Name = "John",
    Age = 30,
    clothes = "Suit and tie",
    wallet = 200
};

John.Greet();

//constructor

var Cruz = new Person("Cruz", 35);
Cruz.Greet();