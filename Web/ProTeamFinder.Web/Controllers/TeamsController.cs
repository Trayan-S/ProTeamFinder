namespace ProTeamFinder.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using ProTeamFinder.Services.Data;
    using ProTeamFinder.Web.ViewModels.Teams;

    [Authorize]
    public class TeamsController : Controller
    {
        private readonly ITeamsService teamsService;

        public TeamsController(ITeamsService teamsService)
        {
            this.teamsService = teamsService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All(int id)
        {


            return this.View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new CreateTeamInputModel();

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTeamInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.teamsService.CreateAsync(input, userId);

            return this.Redirect("/");
        }
    }
}
