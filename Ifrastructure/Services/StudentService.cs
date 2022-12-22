public class StudentService
{
  public List<Student> students;

  public StudentService()
  {
    students = new List<Student>();
  }
  public List<Student> GetStudents()
  {
    return students;
  }
  public void AddStudent(Student student)
  {
    students.Add(student);
  }
  public void UpdateStudent(Student student)
  {
    var find = students.FirstOrDefault(x => x.Id == student.Id);
    if(find== null) {
      System.Console.WriteLine("not found");
      return;
    }
    find.FirstName = student.FirstName;
    find.LastName = student.LastName;
    find.Birthdate = student.Birthdate;
    find.Address = student.Address;
  }
  public void Delete(int Id)
  {
    var find = students.FirstOrDefault(x => x.Id == Id);
    students.Remove(find);
  }
}