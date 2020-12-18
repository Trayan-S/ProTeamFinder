namespace ProTeamFinder.Services.Data
{
    using System.Threading.Tasks;

    using ProTeamFinder.Data.Common.Repositories;
    using ProTeamFinder.Data.Models;
    using ProTeamFinder.Web.ViewModels.Teams;

    public class TeamsService : ITeamsService
    {
        private readonly IDeletableEntityRepository<Team> teamsRepository;

        public TeamsService(IDeletableEntityRepository<Team> teamsRepository)
        {
            this.teamsRepository = teamsRepository;
        }

        public async Task CreateAsync(CreateTeamInputModel input, string userId)
        {
            var team = new Team
            {
                Name = input.Name,
                Tag = input.Tag,
                Description = input.Description,
                CaptainId = userId,
            };

            await this.teamsRepository.AddAsync(team);
            await this.teamsRepository.SaveChangesAsync();
        }
    }
}
