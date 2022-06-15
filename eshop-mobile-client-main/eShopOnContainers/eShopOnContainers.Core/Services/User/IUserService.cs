using eShopOnContainers.Core.Models.User;
using eShopOnContainers.Core.Validations;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.User
{
    public interface IUserService
    {
        Task<UserInfo> GetUserInfoAsync(string authToken);

        Task Add(ValidatableObject<string> username);
    }
}
