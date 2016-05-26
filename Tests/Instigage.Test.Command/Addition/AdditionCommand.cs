using Instigate.Command.Contract;

namespace Instigate.Command.Test
{
   class AdditionCommand : CommandBase<IAdditionParams>
   {
      protected override void Invoke(IAdditionParams additionParams)
      {
         additionParams.Result = additionParams.A + additionParams.B;
      }
   }
}
