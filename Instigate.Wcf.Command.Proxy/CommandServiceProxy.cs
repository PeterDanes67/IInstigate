using System;
using System.ServiceModel.Channels;
using Instigate.Wcf.Service;

namespace Instigate.Wcf.Command.Proxy
{
   public class CommandServiceProxy : ICommandService
   {
      private ServiceClient<ICommandService> CreateClient()
      {
         ServiceClient<ICommandService> client = new ServiceClient<ICommandService>("NetTcpEndpoint_ICommandService");
         client.Open();
         return client;
      }

      public void Invoke(string message)
      {
         using (ServiceClient<ICommandService> client = CreateClient())
         {
            client.Service.Invoke(message + " (via proxy)");
         }
      }

      public void InvokeMessage(Message message)
      {
         using (ServiceClient<ICommandService> client = CreateClient())
         {
            client.Service.InvokeMessage(message);
         }
      }
   }
}
