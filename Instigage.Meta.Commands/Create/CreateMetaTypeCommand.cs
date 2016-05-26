using System;
using Instigate.Command.Contract;

namespace Instigate.Meta.Commands
{
   public class CreateMetaTypeCommand : CommandBase<ICreateMetaTypeParams>
   {
      protected override void Invoke(ICreateMetaTypeParams commandParams)
      {
      }
   }
}
