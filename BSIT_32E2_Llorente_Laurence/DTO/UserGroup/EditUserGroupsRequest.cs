using System.ComponentModel.DataAnnotations;

namespace BSIT_32E2_Llorente_Laurence.DTO.UserGroup
{
    public class EditUserGroupsRequest
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters.")]
        public string Name { get; set; } = string.Empty;

        [StringLength(200, ErrorMessage = "Description must not exceed 200 characters.")]
        public string? Description { get; set; }
    }
}