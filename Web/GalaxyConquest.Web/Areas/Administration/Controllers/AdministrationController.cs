namespace GalaxyConquest.Web.Areas.Administration.Controllers
{
    using GalaxyConquest.Common;
    using GalaxyConquest.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
