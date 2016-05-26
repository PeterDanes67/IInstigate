using System.ServiceModel;

namespace Instigate.Wcf.Service
{
   public class MyCommand
   {
      
   }
   public sealed class ServiceClient<T> : ClientBase<T> where T : class
   {
      private bool _disposed = false;
      public ServiceClient()
         : base(typeof(T).FullName)
      {
      }
      public ServiceClient(string endpointConfigurationName)
         : base(endpointConfigurationName)
      {
      }
      public T Service
      {
         get { return Channel; }
      }
      public void Dispose(bool disposing)
      {
         if (!_disposed)
         {
            if (disposing)
            {
               if (State == CommunicationState.Faulted)
               {
                  Abort();
               }
               else
               {
                  try
                  {
                     Close();
                  }
                  catch
                  {
                     Abort();
                  }
               }
               _disposed = true;
            }
         }
      }
   }
}
