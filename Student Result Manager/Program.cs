using Student_Result_Manager;

Console.WriteLine("First Project Student Result Manager");

Console.Write("How many students would you like to add? ");
int numberOfStudents = int.Parse(Console.ReadLine());

//Ask how many students to add
for (int i = 0; i < numberOfStudents; i++)
{
    Console.WriteLine($"Enter the details of student {i + 1} ");

    //Ask a student name
    Console.Write("Name: ");
    string name = Console.ReadLine();

    //Ask a student age
    Console.Write("Age: ");
    int age = int.Parse(Console.ReadLine());

    //Ask a student marks
    List<int> marks = new List<int>();
    Console.Write("How many marks does this student have? ");
    int numberOfMarks = int.Parse(Console.ReadLine());

    //Ask a student marks
    for (int j = 0; j < numberOfMarks; j++)
    {
        Console.Write($"Enter mark {j + 1}: ");
        int mark = int.Parse(Console.ReadLine());
        if (mark < 0 || mark > 100)
        {
            Console.WriteLine($"Invalid mark {mark} for student {name}. Marks should be between 0 and 100. Please enter again");
            j--;
        }
        else
        {
            marks.Add(mark);
        }
    }
    Student student = new Student(name, age, marks);
    Console.WriteLine($"New student created: ID = {student.Id},Name: {student.Name}, Marks: {string.Join(", ", student.Marks)}");
}

Console.Write("How many teachers would you like to add? ");
int numberOfTeachers = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTeachers; i++)
{
    Console.WriteLine($"Enter the details of teacher {i + 1}");

    //Ask a teacher name
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Subject: ");
    string subject = Console.ReadLine();

    Teacher teacher = new Teacher(name, subject);
    Console.WriteLine($"New teacher created: ID = {teacher.Id},Name: {teacher.Name}, Subject: {teacher.Subject}");
}
Person.ListPeople();
Person.GetTopStudent();

Console.ReadKey();