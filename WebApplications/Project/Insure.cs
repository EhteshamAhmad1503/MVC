using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Project
{
    class Insure
    {
        [JsonPropertyName("id")]
        public int ID{ get; set; }

        [JsonPropertyName("Firstname")]
        public string FirstName { get; set; }

        [JsonPropertyName("Lastname")]
        public string LastName { get; set; }

        [JsonPropertyName("Gender")]
        public string Gender { get; set; }

        [JsonPropertyName("salary")]
        public int Salary { get; set; }

    }
}
