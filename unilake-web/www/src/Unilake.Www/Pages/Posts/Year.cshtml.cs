using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Unilake.Www.Pages.Posts;

public class YearModel : PageModel
{
    [FromRoute]
    public int Year { get; set; }
}