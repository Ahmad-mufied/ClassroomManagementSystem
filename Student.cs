// Declaring the namespace of the class
namespace ClassroomManagementSystem
{
    // Declaring a class named Student
    public class Student
    {
        // Declaring the properties of the class
        public string Name { get; }
        public int Age { get; }
        public string City { get; }

        // Declaring a constructor that will be used to create an instance of the class
        public Student(string name, int age, string city)
        {
            // Initializing the properties of the class with the provided arguments
            Name = name;
            Age = age;
            City = city;
        }
    }
}