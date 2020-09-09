using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;



namespace azureipaddr
{
    public class Whitelist {
        private string _ipAddress;
        //private string _comment;

        public string ipAddress { get => _ipAddress; set => _ipAddress = value; }
        //public string comment { get => _comment; set => _comment = value; }
    }
 class Program
    {
        // Path to the locally saved weekly file
        const string weeklyFilePath = @"C:\Users\pras_\Downloads\ServiceTags_Public_20200824.json";

        static void Main(string[] args)
        {
            // United States geography has the following regions:
            // Central US, East US 2, East US, North Central US, 
            // South Central US, West Central US, West US, West US 2
            List<Whitelist> warray = new List<Whitelist>();
            List<string> USGeographyRegions = new List<string>
            {
//                "centralus",
                "eastus",
                "eastus2",
                "northcentralus",
                "southcentralus",
                "westcentralus",
                "westus",
                "westus2"
            };

            // Load the weekly file
            JObject weeklyFile = JObject.Parse(File.ReadAllText(weeklyFilePath));
            JArray values = (JArray)weeklyFile["values"];

            foreach (string region in USGeographyRegions)
            {
                string azureCloudRegion = $"AzureCloud.{region}";
                Console.WriteLine(azureCloudRegion);

                var ipList =
                    from v in values
                    where (string)v["name"] == azureCloudRegion
                    select v["properties"]["addressPrefixes"];

                foreach (var ip in ipList.Children())
                {
                    Whitelist wlist = new Whitelist();
                    wlist.ipAddress = ip.Value<string>();
                   // wlist.comment = azureCloudRegion;
                    
                    warray.Add(wlist);
                }
                
            }
            Console.WriteLine(warray.Count);
            var json = JsonSerializer.Serialize(warray);
            Console.WriteLine(json);
        }
    }
}
