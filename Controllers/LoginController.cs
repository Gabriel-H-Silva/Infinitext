using Microsoft.AspNetCore.Mvc;
using Infinitext.Models.UserViewModel;

namespace Infinitext.Controllers;

public class LoginController : Controller
{
    public ActionResult Index()
    {
        UserModel user = new UserModel();
        return View("Index", user);
    }
    public ActionResult Auth(UserModel user)
    {
        return View("Index", user);
    }
}