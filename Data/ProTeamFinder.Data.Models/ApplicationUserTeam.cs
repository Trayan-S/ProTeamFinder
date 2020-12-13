namespace ProTeamFinder.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using ProTeamFinder.Data.Common.Models;

    public class ApplicationUserTeam : BaseDeletableModel<int>
    {
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int TeamId { get; set; }

        public Team Team { get; set; }
    }
}
