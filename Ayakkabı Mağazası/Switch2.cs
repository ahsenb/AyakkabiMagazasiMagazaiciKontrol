using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayakkabı_Mağazası
{
    public interface ICommand2//her komut icin oluşturulan sınıfların ortak türe sahip olması icin olusturuldu
    {
        void Execute();
    }
    
    public class Switch2
    {
        private List<ICommand2> _commands2 = new List<ICommand2>();
        public void StoreAndExecute(ICommand2 command2)
        {
            _commands2.Add(command2);
            command2.Execute();
        }
    }
    
    public class Klima
    {
        public void TurnOn()
        {
            MessageBox.Show("Klimalar Açıldı");
        }
        public void TurnOff()
        {
            MessageBox.Show("Klimalar Kapatıldı!");
        }

    }
    
    public class FlipUpCommand2 : ICommand2
    {
        private Klima _klima;
        public FlipUpCommand2(Klima klima)
        {
            _klima = klima;
        }
        public void Execute()
        {
            _klima.TurnOn();
        }
    }
    public class FlipDownCommand2 : ICommand2
    {
        private Klima _klima;
        public FlipDownCommand2(Klima klima)
        {
            _klima = klima;
        }
        public void Execute()
        {
            _klima.TurnOff();
        }
    }


}
