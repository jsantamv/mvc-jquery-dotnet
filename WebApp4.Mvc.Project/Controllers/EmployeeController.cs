using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp3.DataBase.Model;
using WebApp3.DataBase.DataAccess;
using System.Threading.Tasks;

namespace WebApp4.Mvc.Project.Controllers
{
    public class Parameters
    {
        public int IdEmployee { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override string ToString()
        {
            return $"IdEmployee: {IdEmployee} Name: {Name} StartDate: {StartDate:yyyy-MM-dd} EndDate:{EndDate:yyyy-MM-dd}";
        }

    }

    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ViewAll()
        {
            return View(GetEmployees());
        }

        IEnumerable<Employee> GetEmployees()
        {
            EmployeeDataAcces emp = new EmployeeDataAcces();
            return emp.List();
        }


        [HttpGet, ActionName("List")]
        public ActionResult List()
        {
            //https://www.youtube.com/watch?v=u147Q0NY6Qg
            EmployeeDataAcces emp = new EmployeeDataAcces();
            var employees = emp.List().ToList();
            return Json(new { data = employees }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet, ActionName("list-param")]
        public ActionResult List(Parameters param)
        {
            EmployeeDataAcces emp = new EmployeeDataAcces();
            var employees = emp.List().ToList();
            return Json(new { data = employees }, JsonRequestBehavior.AllowGet);
        }


        public ActionResult AddOrEdit(int id = 0)
        {
            Employee emp = new Employee();
            return View(emp);
        }

        [HttpPost]
        public ActionResult AddOrEdit(Employee emp)
        {
            var empda = new EmployeeDataAcces();

            emp.rowguid = Guid.NewGuid();
            emp.BirthDate = Convert.ToDateTime("2000-01-01");
            emp.HireDate = DateTime.Now;

            if (emp.ImageUpload != null)
            {
                string fileName = Path.GetFileNameWithoutExtension(emp.ImageUpload.FileName);
                string extension = Path.GetExtension(emp.ImageUpload.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                emp.ImagePath = "~/AppFiles/Images/" + fileName;

                //using (DBModel db = new DBModel())
                //{
                //    db.Employees.Add(emp);
                //    db.SaveChanges();
                //}

                emp.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/AppFiles/Images/"), fileName));
            }

            return RedirectToAction("ViewAll");
        }

        //public string GetDocs()
        //{
        //    return JsonConvert.SerializeObject(CreateDocumentQuery().ToList());
        //}

        //New Code(properly written - while async would work, it gives compile warnings):

        //public Task<string> GetDocs()
        //{
        //    return Task.ResultFrom(JsonConvert.SerializeObject(CreateDocumentQuery().ToList());
        //}
    }
}