using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project_GoW.Models;

namespace FinalProjectGoW.Pages;

public class CharacterGoWModel : PageModel
{
    private readonly CharacterGoWContext _context;
   private readonly ILogger<CharacterGoWModel>_logger;

   [BindProperty]

   public CharacterGoW CharacterGoW {get; set;} = default!;

   public CharacterGoWModel(CharacterGoWContext context, ILogger<CharacterGoWModel> logger)
    
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
    }
     public IActionResult OnPost()
{
    if (!ModelState.IsValid)
    {
        return Page();
    }
        _context.CharacterGoW.Add(CharacterGoW);
        _context.SaveChanges();

   return RedirectToPage("./Index");
}


}