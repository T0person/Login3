using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Univer2.Models;

namespace Univer2.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _context;
        // Вывод таблицы
        public List<Person> People { get; set; }
        public IndexModel(ApplicationContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
            People = _context.People.AsNoTracking().ToList();
        }

        // Ввод в таблицу
        // Привязываю своиства и параметры формы
        [BindProperty]
        public Person Person { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(Person);
                await _context.SaveChangesAsync();
            }
            //return Page();
            return RedirectToPage();
        }

        // Удаление
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var product = await _context.People.FindAsync(id);

            if (product != null)
            {
                _context.People.Remove(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}