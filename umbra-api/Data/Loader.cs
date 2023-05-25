using umbra_api.Models;
using Newtonsoft.Json;

namespace umbra_api.Data
{
    public static class LoadData
    {
        public static List<Operation>? Operations()
        {
            string json = File.ReadAllText("Data/Data.json");

            List<Operation>? operations  = JsonConvert.DeserializeObject<List<Operation>>(json);

            return operations;
        }
    }
}

