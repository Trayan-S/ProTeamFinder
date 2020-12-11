namespace ProTeamFinder.Web.Areas.Administration.Controllers
{
    using ProTeamFinder.Common;
    using ProTeamFinder.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
