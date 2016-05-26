using System;
using System.Collections.Generic;

namespace Instigate.Meta.WinForms.App
{
   internal interface ICommandControlMap
   {
      void Add(IEnumerable<ICommandControlMapping> mappings);
      void Add(ICommandControlMapping mapping);
      IEnumerable<ICommandControlMapping> Items { get; }
   }
   internal class CommandControlMap : ICommandControlMap
   {
      private IList<ICommandControlMapping> Mappings = new List<ICommandControlMapping>();
      public IEnumerable<ICommandControlMapping> Items
      {
         get
         {
            return Mappings;
         }
      }
      public void Add(IEnumerable<ICommandControlMapping> mappings)
      {
         foreach(ICommandControlMapping mapping in mappings)
         {
            Add(mapping);
         }
      }

      public void Add(ICommandControlMapping mapping)
      {
         Mappings.Add(mapping);
      }
   }
}
