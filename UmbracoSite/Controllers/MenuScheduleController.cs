using System.Web.Mvc;
using Umbraco.Web.Models;

namespace UmbracoSite.Controllers
{
    public class MenuScheduleController : Umbraco.Web.Mvc.RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            return base.Index(model);
        }
    }
}