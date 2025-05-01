using Microsoft.AspNetCore.Mvc;
using ShantiHospitalWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ShantiHospitalWeb.Controllers
{
    public class PatientController : Controller
    {
        private readonly ShantiDbContext _context;

        public PatientController(ShantiDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var patients = await _context.Patients.ToListAsync();
            return View(patients);
        }
    }
}
