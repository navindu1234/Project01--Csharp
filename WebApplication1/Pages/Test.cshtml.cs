using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data; // MUST match your actual namespace
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class TestModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public TestModel(ApplicationDbContext context) => _context = context;

        [BindProperty]
        public string FirstName { get; set; }

        [BindProperty]
        public string LastName { get; set; }

        public string? Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var person = new Person
            {
                FirstName = FirstName,
                LastName = LastName
            };

            _context.People.Add(person);
            _context.SaveChanges();

            Message = "Saved!";
            return Page();
        }
    }
}
