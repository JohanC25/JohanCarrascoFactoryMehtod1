using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohanCarrascoFactoryMehtod1
{
    internal class Tesla : Carros
    {
        public override String QueCarroSoy()
        {
            return "Soy un Tesla!!";
        }
    }
}
