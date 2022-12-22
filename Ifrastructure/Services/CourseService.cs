public class CourseService
{
  public List<Course> courses;

  public CourseService()
  {
    courses = new List<Course>();
  }
  public List<Course> GetCourse()
  {
    return courses;
  }
  public void AddCourse(Course course)
  {
    courses.Add(course);
  }
  public void UpdateCourseStudent(Course course)
  {
     var find = courses.FirstOrDefault(x => x.Id == course.Id);
    if(find== null) {
      System.Console.WriteLine("not found");
      return;
    }
    find.Id = course.Id;
    find.Title = course.Title;
    find.Description = course.Description;
    find.Fee = course.Fee;
  }
  public void Delete(int Id)
  {
    var find = courses.FirstOrDefault(x => x.Id == Id);
    courses.Remove(find);
  }
}
