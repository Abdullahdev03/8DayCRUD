/*
var students = new List<Student>();
int counter = 1;
while(counter<=2)
{
var student = new Student();
student.Id =counter;
System.Console.WriteLine("FirstName of the Student");
student.FirstName = Convert.ToString(Console.ReadLine());
System.Console.WriteLine("LastName of the Student");
student.LastName = Convert.ToString(Console.ReadLine());
System.Console.WriteLine("Birthdate of the Student");
student.Birthdate = DateTime.Now;
System.Console.WriteLine("Adres of the Student");
student.Address = Convert.ToString(Console.ReadLine());
students.Add(student);
counter++;
}
var StudServ1 = new StudentService();
foreach (var element in StudServ1.GetStudents())
{
  System.Console.WriteLine(element.Id + " " + element.FirstName + " " + element.LastName + " " + element.Birthdate + " " + element.Address);
}*/

var St1 = new Student();
St1.Id = 1;
St1.FirstName = "Muhammad1";
St1.LastName = "Mukumov1";
St1.Birthdate =DateTime.Today;
St1.Address = "Hisor1";
var St2 = new Student();
St2.Id = 2;
St2.FirstName = "Muhammad2";
St2.LastName = "Mukumov2";
St2.Birthdate =DateTime.Today;
St2.Address = "Hisor2";
var St3 = new Student();
St3.Id = 3;
St3.FirstName = "Muhammad3";
St3.LastName = "Mukumov3";
St3.Birthdate =DateTime.Today;
St3.Address = "Hisor3";
var St4 = new Student();
St4.Id = 4;
St4.FirstName = "Muhammad4";
St4.LastName = "Mukumov4";
St4.Birthdate =DateTime.Today;
St4.Address = "Hisor4";
var StudServ1 = new StudentService();
StudServ1.AddStudent(St1);
StudServ1.AddStudent(St2);
StudServ1.AddStudent(St3);
StudServ1.AddStudent(St4);

System.Console.WriteLine();
var StudDelete = new StudentService();
StudServ1.Delete(3);
foreach (var element in StudServ1.GetStudents())
{
  System.Console.WriteLine(element.FirstName + " " + element.LastName + " " + element.Birthdate + " " + element.Address);
}

St2.FirstName = "Muhammadjon";
St2.LastName = "Mukumov";
St2.Birthdate =DateTime.Today;
St2.Address = "Hisor";

StudServ1.UpdateStudent(St2);
System.Console.WriteLine("After Update");
foreach (var element in StudServ1.GetStudents())
{
  System.Console.WriteLine(element.FirstName + " " + element.LastName + " " + element.Birthdate + " " + element.Address);
}
