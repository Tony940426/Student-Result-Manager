using Student_Result_Manager;

Console.WriteLine("First Project Student Result Manager");

Student student1 = new Student
{
    Id = Guid.NewGuid(),
    Name = "John Doe",
    Age = 20,
    Grades = new int[] { 7, 8, 1 }
};

Student student2 = new Student
{
    Id = Guid.NewGuid(),
    Name = "Jane Smith",
    Age = 22,
    Grades = new int[] { 7, 9, 4 }
};

Student student3 = new Student
{
    Id = Guid.NewGuid(),
    Name = "Alice Johnson",
    Age = 19,
    Grades = new int[] { 9, 9, 9 }
};

List<Student> students = new List<Student> { student1, student2, student3 };

foreach (var student in students)
{
    Console.WriteLine("Student ID: " + student.Id);
    Console.WriteLine("Student Name: " + student.Name);
    Console.WriteLine("Student Age: " + student.Age);
    Console.WriteLine("Student Grades: " + string.Join(", ", student.Grades));
    Console.WriteLine("Average Grade: " + Math.Round(student.Grades.Average(), 2));
    Console.WriteLine();
}

Console.ReadKey();