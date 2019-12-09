using System;
using System.Linq;
using Grpc.Net.Client;
using System.Threading.Tasks;
using GrpcService;

namespace Web.Data
{
    public class HelloService
    {
        public Hello GetResponse()
        {
            var input = new HelloRequest { Name = "Matija Katadzic" };
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = client.SayHello(input);
            return new Hello(reply);
        }
    }
}
