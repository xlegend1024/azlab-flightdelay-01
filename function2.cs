#r "../bin/Microsoft.Azure.EventHubs.dll"

#r "Microsoft.Azure.DocumentDB.Core"


 


using System;

using System.Text;

using Microsoft.Azure.EventHubs;


 


public static void Run(EventData eventData, out string outputDocument, ILogger log)

{

    var exceptions = new List<Exception>();


 


    try

    {

        string messageBody = Encoding.UTF8.GetString(eventData.Body.Array, eventData.Body.Offset, eventData.Body.Count);

        log.LogInformation($"C# Event Hub trigger function processed a message: {messageBody}");

            

        outputDocument = messageBody;

    }

    catch

    {

        outputDocument = "{\"code\" : \"error\"}";        

    }

}
