using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ayakkabı_Mağazası
{
    //musteri,sepettekiürün ve kargosirketi modelleri
    public class Musteri
    {
        public int Id { get; set; }
        public string MagazaAdi { get; set; }
    }
    public class SepettekiUrun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
    }
    public class KargoSirketi
    {
        public int Id { get; set; }
        public string SirketAdi { get; set; }
    }
    //gerekli operasyonların sorumluluğunu üstlenecek business sınıflar
     
    public class SiparisIslemleri
    {
        public int SiparisEkle(DateTime siparisTarihi, Musteri musteri, KargoSirketi kargoSirketi)
        {
            MessageBox.Show(siparisTarihi.ToString() + " tarihinde "  +  musteri.MagazaAdi + " isimli müsteri siparisi eklendi.Seçilen kargo şirketi: " + kargoSirketi.SirketAdi,"Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            return 1;
        }
    }
    
    public class SiparisDetaylari
    {
        public void SiparisDetaylariniEkle(int siparisId, List<SepettekiUrun> urunler)
        {
            MessageBox.Show(siparisId + " numaralı siparişte alınan ürünler: ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
    public class UrunIslemleri
    {
        public void StokGuncelle(int urunId, int adet)
        {
            MessageBox.Show( urunId + " id'li ürünün stoğundan " + adet + " adet düşürüldü.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    //siparis verme işlemi tüm business nesnelerini ve model nesnelerini bir arada kulllanır
  
    public class SiparisFacade
    {
        Musteri musteri;
        KargoSirketi kargoSirketi;
        UrunIslemleri urunIslemleri = new UrunIslemleri();
        SiparisIslemleri siparisIslemleri = new SiparisIslemleri();
        SiparisDetaylari siparisDetaylari = new SiparisDetaylari();
        public void SiparisVer(string musteriAdi, string secilenKargoSirketi, List<SepettekiUrun> urunler)
        {
            musteri = new Musteri { MagazaAdi = musteriAdi };
            kargoSirketi = new KargoSirketi { SirketAdi = secilenKargoSirketi };
            int siparisId = siparisIslemleri.SiparisEkle(DateTime.Now, musteri, kargoSirketi);
            urunler.ForEach(u => urunIslemleri.StokGuncelle(u.Id, u.Adet));
            MessageBox.Show("İşlem tamamlandı");
        }
    }
}
