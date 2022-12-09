using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesAbilities.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final_Project_GoW.Pages
{
    public class AbilitiesModel : PageModel
    {
        private readonly ILogger<Abilities> _logger;
        private readonly AbilitiesContext _context;
        [BindProperty]
        public Abilities Abilities {get; set;} = default!;
        public SelectList AbilityDropDown {get; set;} = default!;

        public AbilitiesModel(AbilitiesContext context, ILogger<AbilitiesModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            AbilitiesDropDown = new SelectList(_context.Abilities.ToList(), "AbilityId", "Title");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Abilities.Add(Abilities);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}