using Instigate.Command.Contract;

namespace Instigate.Command.Test
{
   interface IAdditionParams : ICommandParams
   {
      int A { get; }
      int B { get; }
      int Result { get; set; }
   }
}
