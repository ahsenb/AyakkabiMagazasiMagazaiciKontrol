using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayakkabı_Mağazası
{
    //template metodu
    abstract class Operasyon
    {
        public int OpHazirla(int sayi1, int sayi2)
        {
            int opyap = OpYap(sayi1, sayi2);
            return Sonuc(opyap);
        }

        public abstract int Sonuc(int opyap);//degiskenlik gösterebilmesi icin
        public abstract int OpYap(int sayi1, int sayi2);
    }
    
    class Bolme : Operasyon
    {
        public override int OpYap(int sayi1, int sayi2)
        {
            return ((sayi1 + sayi2) / 2);
        }

        public override int Sonuc(int opyap)
        {
            return opyap;
        }
        
    }
    
    class Carpma : Operasyon
    {
        public override int OpYap(int sayi1, int sayi2)
        {
            return (sayi1 * sayi2);
        }

        public override int Sonuc(int opyap)
        {
            return opyap;
        }

    }
    
    class Cikarma : Operasyon
    {
        public override int OpYap(int sayi1, int sayi2)
        {
            if (sayi1 >= sayi2)
            {
                return sayi1 - sayi2;
            }
            else
            {
                return sayi2 - sayi1;
            }
        }

        public override int Sonuc(int opyap)
        {
            return opyap;
        }

    }
    
    class Toplama : Operasyon
    {
        public override int OpYap(int sayi1, int sayi2)
        {
            return (sayi1 + sayi2);
        }

        public override int Sonuc(int opyap)
        {
            return opyap;
        }

    }
    
}
