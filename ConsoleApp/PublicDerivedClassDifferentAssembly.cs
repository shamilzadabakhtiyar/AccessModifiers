using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VecihleClassLibrary;

namespace ConsoleApp
{
    public class PublicDerivedClassDifferentAssembly: PublicClass
    {
        public PublicDerivedClassDifferentAssembly()
        {
            // 4. Derived class (different assembly) ✔️
            PublicMethod();

            // 9. Derived class (different assembly) ✔️
            ProtectedInternalMethod();

            // 14. Derived class (different assembly) ✔️
            ProtectedMethod();

            // 19. Derived class (different assembly) ❌	
            InternalMethod();

            // 24. Derived class (different assembly) ❌	
            PrivateProtectedMethod();

            // 29. Derived class (different assembly) ❌	
            PrivateMethod();
        }
    }
}
