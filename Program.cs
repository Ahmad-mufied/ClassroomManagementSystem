using System;

namespace ClassroomManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Student objects
            var joko = new Student("Joko Smith", 20, "Jogja");
            var jaka = new Student("Samuel Jaka", 25, "Silicon Valley");
            var ahmed = new Student("Ahmed Malik", 30, "Delhi");
            
            // Creating Teacher object
            var pakDosen1 = new Teacher("Dosen Killer 1", 30, "Computer Science", "Selandia Baru");
            var pakDosen2 = new Teacher("Dosen Killer 2", 40, "Kesehatan", "Kanada");
            var pakDosen3 = new Teacher("Dosen Killer 3", 50, "Ekonomi", "Australia");
            
            // Creating an array of Student objects
            var students = new Student[] { joko, jaka, ahmed };
            
            // Creating an array of Teacher objects
            var teachers = new Teacher[] { pakDosen1, pakDosen2, pakDosen3 };
            
            // Creating a Classroom object
            var classroom = new Classroom("IF","Informatika", 60, students, teachers);
            
            // Calling the DisplayClassInfo method of the Classroom object
            classroom.DisplayClassInfo();

            // Waiting for user input to exit the console application
            Console.ReadLine();
        }
    }
}