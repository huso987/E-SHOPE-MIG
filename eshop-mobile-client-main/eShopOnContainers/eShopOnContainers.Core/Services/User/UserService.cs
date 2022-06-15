using eShopOnContainers.Core.DatabaseFolder;
using eShopOnContainers.Core.Helpers;
using eShopOnContainers.Core.Models.User;
using eShopOnContainers.Core.Services.RequestProvider;
using eShopOnContainers.Core.Validations;
using System;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.User
{
    public class UserService : IUserService
    {
        private readonly IRequestProvider _requestProvider;
        CustomerDB customerDB = new CustomerDB();


        public UserService()
        {

        }

        public UserService(IRequestProvider requestProvider)
        {
            _requestProvider = requestProvider;
        }

        public async Task<UserInfo> GetUserInfoAsync(string authToken)
        {
            var uri = UriHelper.CombineUri(GlobalSetting.Instance.UserInfoEndpoint);

            var userInfo = await _requestProvider.GetAsync<UserInfo>(uri, authToken);
            return userInfo;
        }

        public async Task Add(ValidatableObject<string> username)
        {

            await customerDB.SaveCustomer(username);



        }
    }
}