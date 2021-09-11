using Grpc.Core;
using Microsoft.Extensions.Logging;
using MyFirstgRPCService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService1
{
    public class myFirstgRPCapiService:MyFirstgRPCService.MyService.MyServiceBase
    {
        public override Task<ResponseType> getInfo(RequestType request, ServerCallContext context)
        {
            return Task.FromResult(new ResponseType() {Message="Message:"+request.Message+"\nServer:Hi!",Id=3 });
        }
    }
}
