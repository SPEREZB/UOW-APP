using Microsoft.EntityFrameworkCore;
using UOW_APP.Models;

namespace UOW_APP.Repositorys
{
    public class SchoolContext
    {
        public DbSet<Student> Students { get; set; }

        internal object Entry(Student student)
        {
            throw new NotImplementedException();
        }

        internal void Update(Student student)
        {
            throw new NotImplementedException();
        }

        internal DbSet<object> Set<T>()
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        internal object Entry<TEntity>(TEntity entityToDelete) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
