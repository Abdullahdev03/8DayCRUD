public class TeacherService
{
  public List<Teacher> teachers;

  public TeacherService()
  {
    teachers = new List<Teacher>();
  }
  public List<Teacher> GetTeachers()
  {
    return teachers;
  }
  public void AddTeacher(Teacher teacher)
  {
    teachers.Add(teacher);
  }
  public void UpdateTeacher(Teacher teacher)
  {
    var find = teachers.FirstOrDefault(x => x.Id == teacher.Id);
    if(find== null) {
      System.Console.WriteLine("not found");
      return;
    }
    find.FirstName = teacher.FirstName;
    find.LastName = teacher.LastName;
    find.Positions = teacher.Positions;
    find.ExperienceAmount = teacher.ExperienceAmount;
  }
  public void Delete(int Id)
  {
    var find = teachers.FirstOrDefault(x => x.Id == Id);
    teachers.Remove(find);
  }
}
