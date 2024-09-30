using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagement.Models;


namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        // GET: api/<StudentAdmissionController>
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailsModel> Get()
        {
            StudentAdmissionDetailsModel admissionObj1 = new StudentAdmissionDetailsModel();
            StudentAdmissionDetailsModel admissionObj2 = new StudentAdmissionDetailsModel();

            admissionObj1.StudentId = 1;
            admissionObj1.StudentName = "Adam";
            admissionObj1.StudentClass = "Math";
            admissionObj1.DateOfJoining = DateTime.Now;

            admissionObj2.StudentId = 2;
            admissionObj2.StudentName = "Brad";
            admissionObj2.StudentClass = "Math";
            admissionObj2.DateOfJoining = DateTime.Now;

            List<StudentAdmissionDetailsModel> listOfObj = new List<StudentAdmissionDetailsModel>
            {
                admissionObj1,
                admissionObj2
            };

            return listOfObj;
        }
    }
}
