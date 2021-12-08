using FapClient.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FapClient.Web.Controllers
{
    public class CampusController : Controller
    {
        private readonly ICampusRepository campusRepository = new CampusRepository();

        public IActionResult Index()
        {
            var list = campusRepository.GetAll();
            return PartialView("_CampusList", list);
        }
    }
}
