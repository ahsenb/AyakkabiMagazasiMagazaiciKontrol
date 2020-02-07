using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ayakkabı_Mağazası
{
    //composite pattern
    //kurum calısanı
    
    interface IPerson
    {
        string Name { get; set; }
    }
    
    class Contractor:IPerson
    {
        public string Name { get; set; }
    }
    
    class Employee:IPerson,IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();//hiyerarsiye subordinates eklendi
        public void AddSubordinate(IPerson person)//hiyerarsiye ekleme
        {
            _subordinates.Add(person);
            
        }
        public void RemoveSubordinates(IPerson person)
        {
            _subordinates.Remove(person);
            
        }
        //hiyerarşideki nesneye direkt erisebilecek
        public IPerson GetSubordinates(int index)
        {
            return _subordinates[index];
        }
        public string Name { get; set; }
        public IEnumerator<IPerson> GetEnumerator()
        {
            //implement etmek icin foreach kulllanıldı
            // Iterator’e çağrı yapan foreach döngüsüne bir eleman döndürülürken kullanılır.
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
