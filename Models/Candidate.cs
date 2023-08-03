using System.ComponentModel.DataAnnotations;

namespace Akademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Email Alanının Doldurulması Zorunludur")]
        public string? Email { get; set; } = string.Empty;
         [Required(ErrorMessage = "İsim Alanının Doldurulması Zorunludur")]
        public string? FirstName { get; set; } = string.Empty;
         [Required(ErrorMessage = "Soyisim Alanının Doldurulması Zorunludur")]
        public string? LastName { get; set; } = string.Empty;
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public string? SelectedCourse { get; set; } = string.Empty;
        public DateTime ApplyAt { get; set; }
        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }

    }
}