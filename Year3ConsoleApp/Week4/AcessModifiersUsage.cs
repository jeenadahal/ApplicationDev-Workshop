using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MainApp.Week4.AccessModifiers;
using static MainApp.Week4.PolymorphismClass;

namespace MainApp.Week4
{
    internal class AccessModifiersUsage : MainClassAccessModifiers
    {
        public static void mainMethodAccessModifiers()
        {
            // private methods are no accessible from another class
            // MainClassAM.privateMethod();

            // to use protected method, inherit parent class containing protected method -- create its object -- then use method



            MainClassAccessModifiers.internalMethod();
            MainClassAccessModifiers.publicMethod();
        }
    }
}
