using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class MyJSON
{
    public static void CreateWithoutIndented(object objectValue, string PathFile)
    {
        string jsonString = JsonConvert.SerializeObject(objectValue);

        File.WriteAllText(PathFile, jsonString);
    }

    public static void CreateWithIndented(object objectValue, string PathFile)
    {
        string jsonString = JsonConvert.SerializeObject(objectValue);

        JObject jObject = JsonConvert.DeserializeObject(jsonString) as JObject;

        File.WriteAllText(PathFile, jObject.ToString());
    }

    public static void CreateWithIndented(string jsonString, string PathFile)
    {
        JObject jObject = JsonConvert.DeserializeObject(jsonString) as JObject;

        File.WriteAllText(PathFile, jObject.ToString());
    }

    public static void Update(string KeyToken, JToken ReplaceValue, string PathFile)
    {
        if (File.Exists(PathFile))
        {
            string jsonString = File.ReadAllText(PathFile);

            JObject jObject = JsonConvert.DeserializeObject(jsonString) as JObject;

            JToken token = jObject.SelectToken(KeyToken);

            token.Replace(ReplaceValue);

            string updatedJsonString = jObject.ToString();

            File.WriteAllText(PathFile, updatedJsonString);
        }
    }
}
