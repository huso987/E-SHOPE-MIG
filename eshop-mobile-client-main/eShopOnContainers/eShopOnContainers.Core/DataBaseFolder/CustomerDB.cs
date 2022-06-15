using eShopOnContainers.Core.Validations;
using Firebase.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.DatabaseFolder
{
    public class CustomerDB
    {

        readonly FirebaseClient firebase = new FirebaseClient("https://migroshacerhuso-default-rtdb.europe-west1.firebasedatabase.app/");



        public async Task SaveCustomer(ValidatableObject<string> username)
        {

            await firebase.Child("Müşteriler").PostAsync(JsonConvert.SerializeObject(username));

        }

    }
}
