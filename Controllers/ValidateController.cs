using AAGL_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.SqlClient;

namespace AAGL_2023.Controllers
{
    public class ValidateController : Controller
    {

        string allData;

        public async Task<string> ValidateCredentials(string userCredentials)
        {

            using (HttpClient client = new())
            {
                client.DefaultRequestHeaders.Add("ATSUN", "AtsWebService");
                client.DefaultRequestHeaders.Add("ATSPW", "@t5@W3853rv1c3");
                client.DefaultRequestHeaders.Add("MEMBERNUMBER", userCredentials);
                client.DefaultRequestHeaders.Add("URLFETCHBYID", "https://aagl.memberclicks.net/api/v1/profile/search");
                client.DefaultRequestHeaders.Add("AUTHGRANTTYPE", "client_credentials");
                client.DefaultRequestHeaders.Add("AUTHUSERNAME", "l84CUyTeSZ118AzJYprY");
                client.DefaultRequestHeaders.Add("AUTHPASSWORD", "ba0eecbf54b2440ea7509e83c325faf0");
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                allData = await client.GetStringAsync("https://localhost:7100/AAGL/fetchbyid");

            }

            ApiResponseModel x = new ApiResponseModel(allData);
            


            return "";
        }












    }
}
