namespace ProTeamFinder.Web.ViewModels.Teams
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateTeamInputModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Team name should be between 3 and 30 symbols!")]
        [Display(Name = "Team name")]
        public string Name { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 2, ErrorMessage ="Team tag should be 2 or 3 symbols!")]
        [Display(Name = "Team tag")]
        public string Tag { get; set; }

        [Display(Name = "Description (optional)")]
        public string Description { get; set; }

        // public IEnumerable<SelectListItem> MyProperty { get; set; }
    }
}
