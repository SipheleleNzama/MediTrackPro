using MediTrackPro.Data;
using MediTrackPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class PatientsController : Controller
{
    private readonly ApplicationDbContext _context;

    public PatientsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Patients
    public async Task<IActionResult> Index()
    {
        return View(await _context.Patients.ToListAsync());
    }
}