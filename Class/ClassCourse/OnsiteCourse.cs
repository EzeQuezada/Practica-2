

namespace Person.Class.ClassCourse
{
    public class OnsiteCourse : Course
    {
        public string? location { get; set; }
        public int Days { get; set; }
        public override void suscribe(Estudiante estudiante)
        {
            throw new NotImplementedException();
        }
    }
}
