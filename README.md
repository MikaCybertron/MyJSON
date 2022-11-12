# Description
Create JSON Object and Update Value in JSON Files easily with C#

# How to Use
- First install NuGet
```
Newtonsoft.Json
```

- Example Usage
```cs
public class Config
{
	public class Example
	{
		public string Name { get; set; }
		
		public string Gender { get; set; }
		
		public int Age { get; set; }
	}
	
	public static void ExampleUsage()
	{
		string PathFile = Directory.GetCurrentDirectory() + "\\Test.json";
		
		Example exampleObject = new Example
		{
			Name = "Mika Cybertron",
			Gender = "Male",
			Age = 22
		};
		
		// Create Json file with correct Format
		MyJSON.Create(exampleObject, PathFile);
		
		// Update Value for Specific Key / Token in Json File
		MyJSON.Update("Name", "Platinmods", PathFile); // value string
		
		MyJSON.Update("Age", 6, PathFile); // value int
	}
}
```

# Use this site to Create C# Classes for your JSON
Link Site: [Convert Json to C# Classes Online](https://json2csharp.com/)
- Example:
```json
{
  "OfficialSite":"https://platinmods.com",
  "DataPeople": [
    {
      "Name": "Person 1",
      "Gender": "Male"
    },
    {
      "Name": "Person 2",
      "Gender": "Male"
    },
	{
      "Name": "Person 3",
      "Gender": "Female"
    },
  ]
}
```
- Result:
```cs
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); // this code to Load your JSON Data

public class DataPerson
{
	public string Name { get; set; }
	public string Gender { get; set; }
}

public class Root
{
	public string OfficialSite { get; set; }
	public List<DataPerson> DataPeople { get; set; }
}
```
