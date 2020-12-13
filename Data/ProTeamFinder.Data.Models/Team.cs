namespace ProTeamFinder.Data.Models
{
    using ProTeamFinder.Data.Common.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Team : BaseDeletableModel<int>
    {
        public Team()
        {
            this.ApplicationUserTeams = new HashSet<ApplicationUserTeam>();
        }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 2)]
        public string Tag { get; set; }

        [MaxLength(1000)]
        public string Information { get; set; }

        public string CaptainId { get; set; }

        public ApplicationUser Captain { get; set; }

        public virtual ICollection<ApplicationUserTeam> ApplicationUserTeams { get; set; }

        // Add images,
    }
}
