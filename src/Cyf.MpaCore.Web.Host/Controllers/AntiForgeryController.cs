using Microsoft.AspNetCore.Antiforgery;
using Cyf.MpaCore.Controllers;

namespace Cyf.MpaCore.Web.Host.Controllers
{
    public class AntiForgeryController : MpaCoreControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
