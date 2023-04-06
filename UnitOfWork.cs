using System;
using UOW_APP.Models;
using UOW_APP.Repositorys;

namespace UOW_APP
{
    public class UnitOfWork : IDisposable
    {
        private SchoolContext context = new SchoolContext();
        private GenericRepository<Student> student;

        public UnitOfWork()
        {

        }
        public GenericRepository<Student> RepStudent
        {
            get
            {
                if (this.student == null)
                {
                    this.student = new GenericRepository<Student>(context);
                }
                return student;
            }
        }



        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
