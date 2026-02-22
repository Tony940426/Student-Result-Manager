using Student_Result_Manager;

Console.WriteLine("First Project Student Result Manager");

string[] subjects = { "Math", "Science", "History" , "PE"};
Random rand = new Random();


Student student1 = new Student("Alice", 20, new int[] { 85, 90, 101 });
Teacher teacher1 = new Teacher("Mr. Smith", subjects[rand.Next(subjects.Length)]);
Teacher teacher2 = new Teacher("Ms. Johnson", subjects[rand.Next(subjects.Length)]);

//teacher1.GetTeacherInfo();
//teacher2.GetTeacherInfo();
student1.GetStudentInfo();
Console.ReadKey();