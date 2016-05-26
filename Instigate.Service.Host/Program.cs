
using Instigate.Wcf.Command.Stub;

namespace Instigate.Wcf.Service.Host
{
   class Program
   {
      static void Main(string[] args)
      {
         HostRunner.Run(CommandServiceHost.Instance);
      }
   }
}
