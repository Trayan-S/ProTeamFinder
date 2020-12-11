namespace ProTeamFinder.Web.ViewModels.Teams
{
    using System.ComponentModel.DataAnnotations;

    public class CreateTeamInputModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name should be between 3 and 30 symbols!")]
        public string Name { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 2, ErrorMessage ="Team tag should be 2 or 3 symbols!")]
        public string TeamTag { get; set; }

        public string Description { get; set; }
    }
}
