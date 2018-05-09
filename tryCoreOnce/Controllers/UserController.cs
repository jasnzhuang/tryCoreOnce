using Microsoft.AspNetCore.Mvc;
using tryCoreOnce.Models;

namespace tryCoreOnce.Controllers
{
    public class UserController : Controller
    {
        private IUserRespository respository;

        public UserController(IUserRespository repo)
        {
            respository = repo;
        }

        public ViewResult List() => View(respository.Users);
    }
}