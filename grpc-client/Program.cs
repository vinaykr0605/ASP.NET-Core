using Grpc.Net.Client;
using grpc_client;

var channel = GrpcChannel.ForAddress("http://localhost:5211");

var WebDevClient = new WebDev.WebDevClient(channel);
var webDevReply = WebDevClient.CreateProject(new Project
{
    Name = "Update Website", Id = 5
});
Console.WriteLine("Greeting: " + webDevReply.Msg);