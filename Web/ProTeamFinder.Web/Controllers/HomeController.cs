namespace ProTeamFinder.Web.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;
    using ProTeamFinder.Services.Data;
    using ProTeamFinder.Web.ViewModels;
    using ProTeamFinder.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IGetCountService countsService;

        public HomeController(IGetCountService countsService)
        {
            this.countsService = countsService;
        }

        public IActionResult Index()
        {
            var counts = this.countsService.GetCounts();
            var viewModel = new IndexViewModel
            {
                UsersCount = counts.UsersCount,
                TeamsCount = counts.TeamsCount,
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
