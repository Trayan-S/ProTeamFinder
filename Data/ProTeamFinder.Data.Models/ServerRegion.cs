namespace ProTeamFinder.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ServerRegion
    {
        public ServerRegion()
        {
            this.ApplicationUsers = new HashSet<ApplicationUser>();
            this.Teams = new HashSet<Team>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Abbreviation { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
