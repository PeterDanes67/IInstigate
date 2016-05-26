using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Instigate.Wcf.Command
{
   [ServiceContract]
   public interface ICommandService
   {
      [OperationContract]
      void Invoke(string message);

      [OperationContract]
      void InvokeMessage(Message message);
   }
}
