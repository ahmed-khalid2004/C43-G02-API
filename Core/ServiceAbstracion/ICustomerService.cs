using Shared.DataTransferObjects.IdentityDTOs;
using Shared.DataTransferObjects.OrderDTOs;
namespace ServiceAbstracion
{
    public interface ICustomerService
    {
        Task<IReadOnlyList<CustomerDTO>> GetAllCustomersAsync();
        Task<CustomerDTO> GetCustomerByIdAsync(string userId);
        Task<IReadOnlyList<OrderToReturnDTO>> GetCustomerOrdersAsync(string userId);
        Task<CustomerStatsDTO> GetCustomerStatsAsync(string userId);
        Task UpdateCustomerRoleAsync(string userId, string newRole);
        Task DeleteCustomerAsync(string userId);
    }
}