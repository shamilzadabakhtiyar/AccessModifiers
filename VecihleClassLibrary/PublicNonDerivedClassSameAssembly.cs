using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VecihleClassLibrary
{
    public class PublicNonDerivedClassSameAssembly
    {
        public PublicNonDerivedClassSameAssembly()
        {
            // 3. Non-derived class (same assembly) ✔️
            var publicClass = new PublicClass();
            publicClass.PublicMethod();

            // 8. Non-derived class (same assembly) ✔️
            publicClass.ProtectedInternalMethod();

            // 13. Non-derived class (same assembly) ❌
            publicClass.ProtectedMethod();

            // 18. Non-derived class (same assembly) ✔️
            publicClass.InternalMethod();

            // 23. Non-derived class (same assembly) ❌
            publicClass.PrivateProtectedMethod();

            // 28. Non-derived class (same assembly) ❌
            publicClass.PrivateMethod();
        }
    }
}
