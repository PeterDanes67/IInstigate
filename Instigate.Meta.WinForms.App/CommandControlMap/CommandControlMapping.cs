
using Instigate.Command.Contract;
using System.Windows.Forms;

namespace Instigate.Meta.WinForms.App
{
   internal interface ICommandControlMapping
   {

   }
   internal class CommandControlMapping<TCommand, TControl>: ICommandControlMapping where TCommand : ICommand where TControl : UserControl
   {
      private TCommand Command { get; set; }
      private TControl Control { get; set; }
      public CommandControlMapping(TCommand command, TControl control)
      {
         Command = command;
         Control = control;
      }
   }
}
