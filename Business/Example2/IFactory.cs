using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Example2
{
    public interface IFactory
    {
        void Drive(int miles);
        void Color(string colorName);

    }
}
