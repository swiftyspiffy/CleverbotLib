# CleverbotLib

## About
CleverbotLib is a simple .NET library that is capable of interfacing with the Cleverbot API in an elegant and easy to use fashion. All information provided in the API responses are available to the programmer, and cleverbot state is easily maintained between messages.


## Implementing
Below is a basic ConsoleApplication implementation of CleverbotLib taken directly from the provided example applicaiton.
#### TwitchClient
```csharp
Console.WriteLine("CleverbotLib Example Application");
Console.WriteLine("Insert your API key:");
string apiKey = Console.ReadLine();
CleverbotLib.Core.SetAPIKey(apiKey);
Console.WriteLine("Now begin your conversation!");
CleverbotLib.Models.CleverbotResponse resp = null;
while(true)
{
	Console.Write("You: ");
	string myMessage = Console.ReadLine();
	string force = null;
	if (resp == null)
		resp = CleverbotLib.Core.Talk(myMessage, force);
	else
		resp = CleverbotLib.Core.Talk(myMessage, resp);
	Console.WriteLine($"Cleverbot: {resp.Output}");
}
```

## Installation

### [NuGet](https://www.nuget.org/packages/CleverbotLib/)

To install this library via NuGet via NuGet console, use:
```
Install-Package CleverbotLib
```
and via Package Manager, simply search:
```
CleverbotLib
```
You are also more than welcome to clone/fork this repo and build the library yourself!

## Dependencies

* Newtonsoft.Json 7.0.1+ ([nuget link](https://www.nuget.org/packages/Newtonsoft.Json/7.0.1))

## License

This project is available under the MIT license. See the LICENSE file for more info.