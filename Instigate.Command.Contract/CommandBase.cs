using Instigate.Common.Contract;

namespace Instigate.Command.Contract
{
   public abstract class CommandBase<T> : ICommand<T> where T : ICommandParams
   {
      private IDetail Detail { get; set; }

      public CommandBase():this("", "") { }
      public CommandBase(string name, string description = "") : this(new Detail() { Name = name, Description = description})
      {
      }
      public CommandBase(IDetail detail)
      {
         Detail = detail;
      }
      protected abstract void Invoke(T commandParams);

      #region IDetail
      string IDetail.Name { get { return Detail?.Name; } }
      string IDetail.Description { get { return Detail?.Description; } }
      #endregion

      #region ICommand
      void ICommand<T>.Invoke(T commandParams)
      {
         Invoke(commandParams);
      }
      #endregion

   }
}
