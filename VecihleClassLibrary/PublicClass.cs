using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VecihleClassLibrary
{
    public class PublicClass
    {
        public int PublicProperty { get; set; }
        protected internal int ProtectedInternalProperty { get; set; }
        protected int ProtectedProperty { get; set; }
        internal int InternalProperty { get; set; }
        private protected int PrivateProtectedProperty { get; set; }
        private int PrivateProperty { get; set; }


        public void PublicMethod()
        {
            // 1. Within the class ✔️
            Console.WriteLine(PublicProperty);
        }

        protected internal void ProtectedInternalMethod()
        {
            // 6. Within the class ✔️
            Console.WriteLine(ProtectedInternalProperty);
        }

        protected void ProtectedMethod()
        {
            // 11. Within the class ✔️
            Console.WriteLine(ProtectedProperty);
        }

        internal void InternalMethod()
        {
            // 16. Within the class ✔️
            Console.WriteLine(InternalProperty);
        }

        private protected void PrivateProtectedMethod()
        {
            // 21. Within the class ✔️
            Console.WriteLine(PrivateProtectedProperty);
        }

        private void PrivateMethod()
        {
            // 26. Within the class ✔️
            Console.WriteLine(PrivateProperty);
        }
    }
}
