using Instigate.Wcf.Command;
using Instigate.Wcf.Command.Proxy;
using Instigate.Wcf.Service;
using Microsoft.Practices.Unity;
using System;
using System.ServiceModel.Channels;
using System.Windows.Forms;
using Message = System.ServiceModel.Channels.Message;

namespace Instigate.Meta.WinForms.App
{
   static class Program
   {
      private static IUnityContainer Container { get; set; }
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         InitialiseContainer();

         //ICommandService commandService = new CommandServiceProxy();
         Container.Resolve<TestCommandInvoke>();
         Container.Resolve<TestCommandInvokeMessage>();
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(Container.Resolve<MetaAppForm>());
      }

      private static void InitialiseContainer()
      {
         Container = new UnityContainer();

         Container.RegisterInstance<ICommandService>(Container.Resolve<CommandServiceProxy>());
      }

   }

   public class TestCommandInvoke
   {
      public TestCommandInvoke(ICommandService commandService)
      {
         commandService.Invoke("Invoking from the WinFormsApp");
      }
   }

   public class TestCommandInvokeMessage
   {
      public TestCommandInvokeMessage(ICommandService commandService)
      {
         commandService.InvokeMessage(Message.CreateMessage(MessageVersion.None, null));
      }
   }

   //internal class CommandServiceProxy : ICommandService
   //{
   //   private ServiceClient<ICommandService> CreateClient()
   //   {
   //      ServiceClient<ICommandService> client = new ServiceClient<ICommandService>("NetTcpEndpoint_ICommandService");
   //      client.Open();
   //      return client;
   //   }

   //   public void Invoke()
   //   {
   //      using (ServiceClient<ICommandService> client = CreateClient())
   //      {
   //         client.Service.Invoke();
   //      }
   //   }
   //}

}
