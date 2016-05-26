using System;
using System.ServiceModel;

namespace Instigate.Command.Service
{
   internal static class InvoiceExtractServiceEndpoint
   {
      private static readonly Uri netTcpAddress = new Uri("net.tcp://localhost:1234/Command");

      public static void AddCommandService(this ServiceHost host)
      {
         NetTcpBinding binding = new NetTcpBinding();
         //binding.TransferMode = TransferMode.Streamed;
         binding.MaxReceivedMessageSize = int.MaxValue;
         host.AddServiceEndpoint(typeof(ICommandService), binding, netTcpAddress);
      }
   }
}
