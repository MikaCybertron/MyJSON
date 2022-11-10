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
		Example example = new Example
		{
			Name = "Mika Cybertron",
			Gender = "Male",
			Age = 22
		};
		
		// Create Json file with correct Format
		MyJSON.Create(example, "Test.json");
		
		// Update Value for Specific Key / Token in Json File
		MyJSON.Update("Name", "Platinmods"); // value string
		
		MyJSON.Update("Age", 6); // value int
	}
}
```
