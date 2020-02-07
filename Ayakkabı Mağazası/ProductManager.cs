using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ayakkabı_Mağazası
{
    //yeni bir özellik eklediğinde mevcut sistemin hiçbir değişikliğe uğramaması gerekir
    class ProductManager
    {
        private ISatis _satis;
        public ProductManager(ISatis satis)
        {
            _satis = satis;
        }
        public void Save()
        {
            _satis.Satmak("Sistem Bilgisi");
            
        }
    }
    interface ISatis
    {
        void Satmak(string message);
    }
    
    class Canta : ISatis
    {
        public void Satmak(string message)
        {
            MessageBox.Show("Satılacak ürün canta",message);
        }
    }
    //dokunulmayacak olan class
    class Ayakkabı
    {
        public void SatmakM(string message)
        {
            MessageBox.Show("Satılacak ürün ayakkabı",message);
        }
    }
    //adapter deseninin devreye girdiği yer
    //ISatıs ın Satmak'ı Ayakkabı nın gerekli implementasyonunu gerçekleştirir
    //class ayakkabı ya ulaşmak için
    class AyakkabıAdapter : ISatis
    {
        public void Satmak(string message)
        {
            Ayakkabı ayakkabı = new Ayakkabı();
            ayakkabı.SatmakM(message);
        }
    }
}
