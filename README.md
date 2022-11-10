# Description
Create JSON Object and Update Value JSON File in C# easily

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
	
	private static void ExampleUsage()
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
