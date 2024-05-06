
namespace Person.Class.ClassCourse
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? Area { get; set; }
        public int Credit { get; set; }

       public abstract void suscribe(Estudiante estudiante); 
        

    }
}
