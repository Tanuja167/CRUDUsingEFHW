using CRUDUsingEFHW.Data;
namespace CRUDUsingEFHW.Models
{
    public class StudentDAL
    {
        ApplicationDbContext db;

        public StudentDAL(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Student> GetStudents()
        {
            var result = from s in db.Students
                         select s;
             return result;
        }

        public Student GetStudentById(int id)
        {

            var result = db.Students.Where(x => x.Id == id).SingleOrDefault();
            return result;
        }
        public int AddStudent(Student student)
        {
           db.Students.Add(student);
            int result = db.SaveChanges();
            return result;
        }

        public int UpdateStudent(Student student)
        {
            int res = 0;
            var result = db.Students.Where(x => x.Id == student.Id).FirstOrDefault();

            if(result != null)
            {
                result.Name = student.Name;
                result.Percentage = student.Percentage;
                result.City = student.City;

                res = db.SaveChanges();
            }
            return res;
        }

        public int DeleteStudent(int id)
        {
            int res = 0;
            var result = db.Students.Where(x => x.Id == id).FirstOrDefault();   
            if( result != null )
            {
                db.Students.Remove(result);
                res = db.SaveChanges();
            }
            return res;
        }
    }
}
