using Instigate.Command.Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Instigate.Command.Test
{
   [TestClass]
   public class CommandTests
   {
      const int TestValueA = 2;
      const int TestValueB = 4;
      [TestMethod]
      public void InvokeAdditionCommandTest()
      {
         ICommand<IAdditionParams> additionCommand = new AdditionCommand();
         IAdditionParams additionParams = new AdditionParams() { A = TestValueA, B = TestValueB };

         additionCommand.Invoke(additionParams);

         Assert.IsTrue(additionParams.Result == (additionParams.A + additionParams.B));
      }

      [TestMethod]
      public void CreateAdditionParamsTest()
      {
         IAdditionParams additionParams = new AdditionParams() { A = TestValueA, B = TestValueB };

         Assert.IsTrue(additionParams.A == TestValueA);
         Assert.IsTrue(additionParams.B == TestValueB);
      }
   }
}
