using System.ComponentModel.DataAnnotations;
namespace Shared.DataTransferObjects.IdentityDTOs
{
    public class UpdateRoleDTO
    {
        [Required]
        public string Role { get; set; } = default!;
    }
}