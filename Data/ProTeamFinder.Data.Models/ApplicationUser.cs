// ReSharper disable VirtualMemberCallInConstructor
namespace ProTeamFinder.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;
    using ProTeamFinder.Data.Common.Models;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.ApplicationUserTeam = new HashSet<ApplicationUserTeam>();
        }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 3)]
        public string SummenerName { get; set; }

        public bool AccountVerify { get; set; }

        [Url]
        public string ImageUrl { get; set; }

        [Required]
        public int ServerRegionId { get; set; }

        public virtual ServerRegion ServerRegion { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public virtual ICollection<ApplicationUserTeam> ApplicationUserTeam { get; set; }
    }
}
