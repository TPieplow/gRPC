using ClientApplication;
using ClientApplication.Services;

var grpc = new GrpcService("https://localhost:7014");


// Subscribe
Console.Clear();
Console.Write("Email to subscribe: ");
var subscribeRequest = new SubscribeRequest { Email = Console.ReadLine() };  

var subscribeResponse = await grpc.SubscribeAsync(subscribeRequest);
Console.WriteLine($"{subscribeResponse.Message}");
Console.ReadKey();


// Unsubscribe
Console.Clear();
Console.Write("Email to unsubscribe: ");
var unsubscribeRequest = new UnsubscribeRequest { Email = Console.ReadLine() };

var unsubscriberesponse = await grpc.UnsubscribeAsync(unsubscribeRequest);
Console.WriteLine($"{unsubscriberesponse.Message}");
Console.ReadKey();