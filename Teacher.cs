// Declare the namespace of the class
namespace ClassroomManagementSystem
{
    // Declare the public class Teacher
    public class Teacher
    {
        // Declare properties for the teacher's name, age, and subject
        public string Name { get; }
        public int Age { get;}
        public string Subject { get;}
        public string City { get; }

        // Declare a constructor for the Teacher class that takes in a name, age, and subject parameter
        public Teacher(string name, int age, string subject, string city)
        {
            // Set the Name, Age, and Subject properties to the values passed in through the constructor parameters
            Name = name;
            Age = age;
            Subject = subject;
            City = city;
        }

        // Declare a method for the teacher to say hello and print their name, age, and subject they teach
        public void SayHello()
        {
            Console.WriteLine($"Hello, Nama saya {Name} dan saya berumur {Age} . Saya berasal dari kota {City}. Saya mengajar pelajaran {Subject}.");
        }
    }
}