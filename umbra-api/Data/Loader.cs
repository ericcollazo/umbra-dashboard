using react_learn.Models;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace react_learn.Data
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

