namespace ProTeamFinder.Services.Data
{
    using ProTeamFinder.Services.Data.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IGetCountService
    {
        CountsDto GetCounts();
    }
}
