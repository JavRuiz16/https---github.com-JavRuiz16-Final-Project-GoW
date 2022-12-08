using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Final_Project_GoW.Pages;

public class IndexModel : PageModel
{
  private readonly CharacterGoWContext _context;  
    private readonly ILogger<IndexModel> _logger;

    public List<CharacterGoW>CharacterGoW {get; set;} = default!;

    public SelectList CharacterGoWDropDown {get; set;} = default!;

    public IndexModel(CharacterGoWContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
            CharacterGoW = _context.CharacterGoW.ToList();

            CharacterGoWDropDown = new SelectList(CharacterGoW, "CharacterGoWID", "Title");
            
    }
}
