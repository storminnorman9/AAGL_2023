

using Newtonsoft.Json.Linq;


namespace AAGL_2023.Models
{
    public class ApiResponseModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Credentials { get; set; }
        public string? Email { get; set; }
        public string? Company { get; set; }
        public string? Address1 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? MemberID { get; set; }


        public ApiResponseModel(string allData)
        {
            
            JObject objData = JObject.Parse(allData);
            bool tryToken = objData.TryGetValue("profiles", StringComparison.OrdinalIgnoreCase, out JToken? myProfileOut);

            if (tryToken)
            {
                JObject _data = JObject.FromObject(myProfileOut.First());

                _data.TryGetValue("[Name | First]", StringComparison.OrdinalIgnoreCase, out JToken? firstName);
                _data.TryGetValue("[Name | Last]", StringComparison.OrdinalIgnoreCase, out JToken? lastName);
                _data.TryGetValue("Credentials", StringComparison.OrdinalIgnoreCase, out JToken? credentials);
                _data.TryGetValue("[Email | Primary]", StringComparison.OrdinalIgnoreCase, out JToken? email);
                _data.TryGetValue("Company/Institution Affiliation", StringComparison.OrdinalIgnoreCase, out JToken? company);
                _data.TryGetValue("[Address | Primary | Line 1]", StringComparison.OrdinalIgnoreCase, out JToken? address1);
                _data.TryGetValue("[Address | Primary | City]", StringComparison.OrdinalIgnoreCase, out JToken? city);
                _data.TryGetValue("[Address | Primary | State]", StringComparison.OrdinalIgnoreCase, out JToken? state);
                _data.TryGetValue("[Address | Primary | Zip]", StringComparison.OrdinalIgnoreCase, out JToken? zip);
                _data.TryGetValue("[Member Number]", StringComparison.OrdinalIgnoreCase, out JToken? memberId);

                FirstName = (firstName != null) ? firstName.ToString() : "";
                LastName = (lastName != null) ? lastName.ToString() : "";
                Credentials = (credentials != null) ? credentials.ToString() : "";
                Email = (email != null) ? email.ToString() : "";
                Company = (company != null) ? company.ToString() : "";
                Address1 = (address1 != null) ? address1.ToString() : "";
                City = (city != null) ? city.ToString() : "";
                State = (state != null) ? state.ToString() : "";
                Zip = (zip != null) ? zip.ToString() : "";
                MemberID = (memberId != null) ? memberId.ToString() : "";



            }

        }

        //  2007701445
        //  36838


    }

}