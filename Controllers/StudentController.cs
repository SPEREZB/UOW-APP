using System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UOW_APP.Models;
using UOW_APP.Repositorys;
using Microsoft.Extensions.DependencyInjection;
namespace UOW_APP.Controllers
{
    public class StudentController : Controller
    {
        private InterfaceStudent studentRepository;
        private UnitOfWork unitOfWork= new UnitOfWork();


        public StudentController(InterfaceStudent studentRepository)
        {
            this.studentRepository = studentRepository;
        }

     
    
        // GET: /Student/Details/5

        public ViewResult Details(int id)
        {
            Student student = unitOfWork.RepStudent.GetByID(id);
            return View(student);
        }

       
        // GET: /Student/Create

        public ActionResult Create()
        {
            return View();
        }

      
        // POST: /Student/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind] Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.RepStudent.Insert(student);
                    unitOfWork.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(student);
        }
         
        // GET: /Student/Edit/5

      public ActionResult Edit(int id)
        {
            Student student = unitOfWork.RepStudent.GetByID(id);
           return View(student);
         } 

   
        // POST: /Student/Edit/5
 
         
         //GET: /Student/Delete/5

         public ActionResult Delete(bool? saveChangesError = false, int id = 0)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Student student = unitOfWork.RepStudent.GetByID(id);
            return View(student);
        }

    
        // POST: /Student/Delete/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Student student = studentRepository.GetStudentByID(id);
                unitOfWork.RepStudent.Delete(id);
                unitOfWork.Save();
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            unitOfWork.Dispose();
            base.Dispose(disposing);
        }



    }
}
