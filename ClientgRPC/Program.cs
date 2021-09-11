using Grpc.Net.Client;
using System;
using MyFirstgRPCService;

namespace ClientgRPC
{
    class Program
    {
        static void Main(string[] args)
        {

            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            // создаем клиента
            var client = new MyService.MyServiceClient(channel);
            while (true)
            {
                string messgae = Console.ReadLine();
                var result = client.getInfo(new RequestType() { Message = messgae });
                Console.WriteLine(result.Message);
            }
            //Console.Write("Введите имя: ");
            //string name = Console.ReadLine();
            //// обмениваемся сообщениями с сервером
            //var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
            //Console.WriteLine("Ответ сервера: " + reply.Message);
            //Console.ReadKey();
        }
    }
}
