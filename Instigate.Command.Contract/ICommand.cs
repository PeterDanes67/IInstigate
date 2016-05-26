using Instigate.Common.Contract;

namespace Instigate.Command.Contract
{
   public interface ICommand
   {
   }

   public interface ICommand<T> : IDetail, ICommand where T : ICommandParams
   {
      void Invoke(T commandParams);
   }
}
