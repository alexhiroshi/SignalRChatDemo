using System.Web.Mvc;

namespace SignalRChatDemo.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}