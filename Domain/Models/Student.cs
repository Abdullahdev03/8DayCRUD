public class Student
{
  public int Id { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public DateTime Birthdate { get; set; }
  public string Address { get; set; }

  public void Delete(int v)
  {
    throw new NotImplementedException();
  }
}