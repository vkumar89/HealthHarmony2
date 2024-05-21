using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthHarmony2.Models
{

    [Table("User")]
    public class User
    {
        [Key]
        public int UserID { get; set; }

        #region user name
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username cannot be longer than 50 characters")]
        [RegularExpression(@"[A-Za-z\s]{3,}", ErrorMessage = "Name can have alphabets & spaces with min size of 3.")]
        public string Username { get; set; }
        #endregion

        #region Email

        [RegularExpression(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage = "Email is not in Correct Formate")]
        [EmailAddress(ErrorMessage = "Email is not in Correct Formate")]
        public string Email { get; set; }
        #endregion

        #region Password
        [Required(ErrorMessage = "Password field can't be left empty.")]
        [RegularExpression(@"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$_-])(?=\S+$).{8,16}", ErrorMessage = "UserName or Password is not Correct ")]


        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password must be between 6 and 100 characters", MinimumLength = 6)]
        public string Password { get; set; }

        #endregion
       // public ICollection<UserDietPlans> DietPlans { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

    }
}