using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VecihleClassLibrary
{
    public class PublicDerivedClassSameAssembly: PublicClass
    {
        public PublicDerivedClassSameAssembly()
        {
            // 2. Derived class (same assembly) ✔️
            PublicMethod();

            // 7. Derived class (same assembly) ✔️
            ProtectedInternalMethod();

            // 12. Derived class (same assembly) ✔️
            ProtectedMethod();

            // 17. Derived class (same assembly) ✔️
            InternalMethod();

            // 22. Derived class (same assembly) ✔️
            PrivateProtectedMethod();

            // 27. Derived class (same assembly) ❌
            PrivateMethod();
        }
    }
}
