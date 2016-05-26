
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Instigate.Wcf.Command.Stub
{
   public partial class CommandServiceHost : ICommandService
   {
      private static readonly Uri netTcpAddress = new Uri("net.tcp://localhost:1234/Command");

      public void Configure()
      {
         NetTcpBinding binding = new NetTcpBinding();
         //binding.TransferMode = TransferMode.Streamed;
         binding.MaxReceivedMessageSize = int.MaxValue;
         AddServiceEndpoint(typeof(ICommandService), binding, netTcpAddress);
      }
      public void Invoke(string message)
      {
         Console.WriteLine("Invoked -> " + message);
      }

      public void InvokeMessage(Message message)
      {
      }
   }
}
