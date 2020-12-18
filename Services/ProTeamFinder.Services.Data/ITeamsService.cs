namespace ProTeamFinder.Services.Data
{
    using System.Threading.Tasks;

    using ProTeamFinder.Web.ViewModels.Teams;

    public interface ITeamsService
    {
        Task CreateAsync(CreateTeamInputModel input, string userId);
    }
}
