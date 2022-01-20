using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Example1
{
    public class Creater
    {
        public Oyun FactoryMethod(Oyunlar oyunTipi)
        {
            Oyun oyun = null;
            switch (oyunTipi)
            {
                case Oyunlar.Atari:
                    oyun = new Atari();
                    break;
                case Oyunlar.PC:
                    oyun = new PC();
                    break;
                case Oyunlar.PS:
                    oyun = new PS();
                    break;
                default:
                    break;
            }
            return oyun;
        }
    }
}
