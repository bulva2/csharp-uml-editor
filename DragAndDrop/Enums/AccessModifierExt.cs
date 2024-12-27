using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop.Enums
{
    public static class AccessModifierExt
    {
        public static string GetAccessModifier(AccessModifier? modifier)
        {
            return modifier switch
            {
                AccessModifier.Public => "+",
                AccessModifier.Private => "-",
                AccessModifier.Protected => "#",
                _ => throw new ArgumentOutOfRangeException("Invalid access modifier!")
            };
        }
    }
}
