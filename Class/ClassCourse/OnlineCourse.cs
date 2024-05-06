

namespace Person.Class.ClassCourse
{
    public class OnlineCourse : Course
    {
        public string? url { get; set; }
        public override void suscribe(Estudiante estudiante)
        {
            throw new NotImplementedException();
        }
    }
}
