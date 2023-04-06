using UOW_APP.Repositorys;
using Microsoft.EntityFrameworkCore; 
namespace UOW_APP.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }


    }

    
}
