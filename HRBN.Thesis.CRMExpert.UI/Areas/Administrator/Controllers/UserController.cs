using HRBN.Thesis.CRMExpert.UI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HRBN.Thesis.CRMExpert.UI.Areas.Administrator.Controllers;

[Area("Administrator")]
[ServiceFilter(typeof(JwtAuthFilter))]
[Authorize]
public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Edit()
    {
        return View();
    }
}