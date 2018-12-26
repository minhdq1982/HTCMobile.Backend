using Microsoft.AspNetCore.Antiforgery;
using HTCMobile.Controllers;

namespace HTCMobile.Web.Host.Controllers
{
    public class AntiForgeryController : HTCMobileControllerBase
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
