using eShopOnContainers.Core.Models;
using Firebase.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.DataBaseFolder
{
    public class ProductDB
    {
        readonly FirebaseClient firebase = new FirebaseClient("https://migroshacerhuso-default-rtdb.europe-west1.firebasedatabase.app/");

        public async Task Sepettenürünüekle(Product aramaü)
        {


            await firebase.Child("Sepet").PostAsync(JsonConvert.SerializeObject(aramaü));


        }
    }
}
