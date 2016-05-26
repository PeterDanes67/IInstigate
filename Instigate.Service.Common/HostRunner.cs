using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Instigate.Wcf.Service
{
   /// <summary>
   /// 
   /// </summary>
   public static class HostRunner
   {
      public static void Run(object instance)
      {
         throw new NotImplementedException();
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="host"></param>
      public static void Run(ServiceHost host)
      {
         using (host)
         {
            host.Faulted += host_Faulted;

            host.Open();

            Console.WriteLine("The host {0} provides these Services...", host.GetType().Name);
            foreach (ServiceEndpoint endpoint in host.Description.Endpoints)
            {
               Console.WriteLine("{0,-20}\t({1})", endpoint.Contract.ContractType.Name, endpoint.Address);
            }
            Console.WriteLine("Press <Enter> to stop the service");
            Console.ReadLine();

            host.Close();
         }
      }

      static void host_Faulted(object sender, EventArgs e)
      {
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("Faulted {0}", e);
      }
   }
}
