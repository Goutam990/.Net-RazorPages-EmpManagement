
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_Practice_purpose_.Data;

namespace RazorPages_Practice_purpose_.Pages
{


    public class EmployeeModel : PageModel
    {
        private readonly AppDbContext _context;

        public EmployeeModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employees { get; set; } = new List<Employee>();

        public async Task OnGetAsync()
        {
            Employees = await _context.Employees.ToListAsync();
        }

        [BindProperty]
        public Employee NewEmployee { get; set; } = new Employee();

        public async Task<IActionResult > OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employees.Add(NewEmployee);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}
