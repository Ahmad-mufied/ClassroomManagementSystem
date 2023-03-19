// Declaring the namespace of the class
namespace ClassroomManagementSystem
{
    // Declaring a class named Classroom
    public class Classroom
    {
        // Declaring the private property ClassCode and public properties Capacity, Students, and Teacher
        private string ClassCode { get; }
        public string ClassName { get; }
        public int Capacity { get; }
        public Student[] Students { get; }
        public Teacher[] Teachers { get; }

        // Declaring a constructor that will be used to create an instance of the class
        public Classroom(string classCode, string className,  int capacity, Student[] students, Teacher[] teachers)
        {
            // Initializing the properties of the class with the provided arguments
            ClassCode = classCode;
            ClassName = className;
            Capacity = capacity;
            Students = students;
            Teachers = teachers;
        }

        // Declaring a method that will print the information of the classroom, its students, and its teacher
        public void DisplayClassInfo()
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"Selamat Datang di kelas {ClassName}.");
            Console.WriteLine($"Class code: {ClassCode}\nKapasitas Kelas: {Capacity} Orang");
            
            // Displaying the information of the teacher
            Console.WriteLine("\nDaftar Dosen: ");
            displayTeacher();

            // Displaying the information of the students
            Console.WriteLine("\nDaftar Mahasiswa:");
            displayStudent();

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Press any key to quit the program...");
        }

        private void displayTeacher()
        {
            // Printing the name, age, subject, and city of each teacher in the class
            foreach (var dosen in Teachers)
            {
                Console.WriteLine($"Nama Dosen : {dosen.Name} , Umur : {dosen.Age} , Jurusan : {dosen.Subject} , Kota : {dosen.City}");
            }
        }
        
        private void displayStudent()
        {
            // Printing the name and age of each student in the class
            foreach (var student in Students)
            {
                Console.WriteLine($"Nama Siswa : {student.Name} , Umur : {student.Age} , Kota : {student.City}");
            }
        }
    }
}