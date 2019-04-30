#r "Newtonsoft.Json"


 


using System;

using System.Text;

using Newtonsoft.Json;

using Newtonsoft.Json.Linq;


 


public static void Run(TimerInfo myTimer, out String output, ILogger log)

{

    int num = RandomNumber(0, 100);

    log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

    log.LogInformation($"Random INT - 1000: {num}");

    

    JObject jsonData = new JObject();

    jsonData["eventTimestamp"] = DateTime.UtcNow.ToString("o");

    jsonData["marketingFlightNumber"] = "1754";

    jsonData["delayInMinutes"] = num;


 


    log.LogInformation(jsonData.ToString());

    output = jsonData.ToString();


 


}


 


public static int RandomNumber(int min, int max)

{    

    Random random = new Random();    

    return random.Next(min, max);    

}    

    

// Generate a random string with a given size    

public static string RandomString(int size, bool lowerCase)    

{    

    StringBuilder builder = new StringBuilder();    

    Random random = new Random();    

    char ch;    

    for (int i = 0; i < size; i++)    

    {    

        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));    

        builder.Append(ch);    

    }    

    if (lowerCase)    

        return builder.ToString().ToLower();    

    return builder.ToString();    

}  

 
