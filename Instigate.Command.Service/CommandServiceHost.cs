using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Instigate.Wcf.Command.Stub
{
   [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
   public partial class CommandServiceHost : ServiceHost
   {
      private static CommandServiceHost Host = null;
      public static ServiceHost Instance
      {
         get
         {
            if (Host == null)
            {
               Host = new CommandServiceHost(typeof(CommandServiceHost));
            }
            return Host;
         }
      }

      private CommandServiceHost() { }
      private CommandServiceHost(Type type) : base(type) { }

      protected override void ApplyConfiguration()
      {
         base.ApplyConfiguration();

         ServiceMetadataBehavior smb = new ServiceMetadataBehavior { HttpGetEnabled = false };
         Description.Behaviors.Add(smb);

         Configure();
      }
   }
}
