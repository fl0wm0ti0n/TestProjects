using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcApiGw_Test.Protos;

namespace GrpcApiGw_Test.Services
{
    public class GrpcClientBase
    {
        protected GrpcChannel Channel;
        public GrpcClientBase(Uri uri)
        {
            Channel = GrpcChannel.ForAddress(uri);
        }
    }
}
