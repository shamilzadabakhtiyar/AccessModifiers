using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VecihleClassLibrary;

namespace ConsoleApp
{
    internal class PublicNonDerivedClassDifferentAssembly
    {
        public PublicNonDerivedClassDifferentAssembly()
        {
            // 5. Non-derived class (different assembly) ✔️
            var publicClass = new PublicClass();
            publicClass.PublicMethod();

            // 10. Non-derived class (different assembly) ❌	
            publicClass.ProtectedInternalMethod();

            // 15. Non-derived class (different assembly) ❌	
            publicClass.ProtectedMethod();

            // 20. Non-derived class (different assembly) ❌	
            publicClass.InternalMethod();

            // 25. Non-derived class (different assembly) ❌	
            publicClass.PrivateProtectedMethod();

            // 30. Non-derived class (different assembly) ❌	
            publicClass.PrivateMethod();
        }
    }
}
