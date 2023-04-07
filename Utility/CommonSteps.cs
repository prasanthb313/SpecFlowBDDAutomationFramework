using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace SampleProject.GenericMethods
{
    public class CommonSteps
    {
        public static string configData(string key)
        {

            string filePath = @"C:\Users\Nagarjuna\OneDrive\Desktop\TestAutomation_April\TestProject\TestProject\settings.json";
            

            dynamic jsonData = JsonConvert.DeserializeObject(File.ReadAllText(filePath));

            string value = jsonData[key];

            return value;
        }
    }
}
