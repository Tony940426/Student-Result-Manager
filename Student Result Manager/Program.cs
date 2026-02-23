using Student_Result_Manager;

Console.WriteLine("First Project Student Result Manager");

string[] subjects = { "Math", "Science", "History" , "PE"};
Random rand = new Random();


Student student1 = new Student("Alice", 20, new List<int> { 85, 90, 101 });
Student student2 = new Student("Tom", 22, new List<int> { 59, 65, 42 });
Student student3 = new Student("Bob", 19, new List<int> { 75, -1, 88 });
Student student4 = new Student("Eve", 21, new List<int> { 92, 95, 89 });

Teacher teacher1 = new Teacher("Mr. Smith", subjects[rand.Next(subjects.Length)]);
Teacher teacher2 = new Teacher("Ms. Johnson", subjects[rand.Next(subjects.Length)]);

//teacher1.GetTeacherInfo();
//teacher2.GetTeacherInfo();
//student1.GetStudentInfo();
Person.ListPeople();
student1.GetStudentInfo();
student3.GetStudentInfo();
Console.ReadKey();