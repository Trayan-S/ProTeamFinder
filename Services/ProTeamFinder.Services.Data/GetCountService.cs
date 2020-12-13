namespace ProTeamFinder.Services.Data
{
    using ProTeamFinder.Data.Common.Repositories;
    using ProTeamFinder.Data.Models;
    using ProTeamFinder.Services.Data.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GetCountService : IGetCountService
    {
        private readonly IDeletableEntityRepository<Team> teamsRepository;
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepository;

        public GetCountService(
            IDeletableEntityRepository<Team> teamsRepository,
            IDeletableEntityRepository<ApplicationUser> usersRepository)
        {
            this.teamsRepository = teamsRepository;
            this.usersRepository = usersRepository;
        }

        public CountsDto GetCounts()
        {
            var data = new CountsDto
            {
                UsersCount = this.usersRepository.All().Count(),
                TeamsCount = 0,
            };

            return data;
        }
    }
}
