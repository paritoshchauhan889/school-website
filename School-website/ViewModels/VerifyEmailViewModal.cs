using System.ComponentModel.DataAnnotations;

namespace School_website.ViewModels
{
    public class VerifyEmailViewModal
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]

        public string Email { get; set; }
    }
}
