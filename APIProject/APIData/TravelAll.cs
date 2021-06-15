using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIProject
{
    class TravelAll
    {
        [JsonProperty("cases_time_series")]
        public TableCasesTime[] casesall { get; set; }
    }
}
