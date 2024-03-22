namespace Lesson11
{
    public class Program
    {

        public class Driver
        {
            public string Name;
            public Car Car { get; set; }
            public Driver(string name) 
            {
                Name = name;
            }

            public void Drive()
            {
                Console.WriteLine($"{Name} is driving a car {Car.Brand} {Car.Model}");
            }
        }

        public class Engine
        {
            public string Type { get; set; }
            public Engine(string type)
            {
                Type = type;
            }
        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public Engine Engine { get; set; }

            public Car(string brand, string model) 
            {
                Brand = brand;
                Model = model;
                Engine = new Engine("V8");
            }
        }


        static void Main(string[] args)
        {
            // Assosiation example
            Car newCar = new Car("VW", "Bug");
            Driver newDriver = new Driver("Jhon Doe") { Car = newCar};
            newDriver.Drive();

            Console.WriteLine();
            // Aggregation example
            Library cityLibrary = new Library("City Library");
            Book novel = new Book("1984", "George Orwell");
            Book roman = new Book("To Kill a Mockinbird", "Harper Lee");
            cityLibrary.AddBook(novel);
            cityLibrary.AddBook(roman);

            Console.WriteLine($"{cityLibrary.Name} has the following books:");
            foreach (var book in cityLibrary.Books)
            {
                Console.WriteLine($"{book.Title} by {book.Author}");
            }

            Console.WriteLine();
            // Composition example
            Car sportCar = new Car("Ferrari", "Spider");
            Console.WriteLine($"The {sportCar.Brand} {sportCar.Model} has a {sportCar.Engine.Type} engine");

            Console.ReadKey();
        }
    }
}