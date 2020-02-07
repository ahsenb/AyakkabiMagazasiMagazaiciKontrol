using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayakkabı_Mağazası
{
    public interface ICommand//her komut icin oluşturulan sınıfların ortak türesahip olması icin olusturuldu-
    {
        void Execute();
    }
   
    
    public class Switch
    {
        private List<ICommand> _commands = new List<ICommand>();
        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }
    }
    
    
    public class Isik
    {
        public void TurnOn()
        {
            MessageBox.Show("Işıklar Açıldı");
        }
        public void TurnOff()
        {
            MessageBox.Show("Işıklar Kapatıldı!");
        }

    }
    
    public class FlipUpCommand : ICommand
    {
        private Isik _isik;
        public FlipUpCommand(Isik isik)
        {
            _isik = isik;
        }
        public void Execute()
        {
            _isik.TurnOn();
        }
    }
    public class FlipDownCommand : ICommand
    {
        private Isik _isik;
        public FlipDownCommand(Isik isik)
        {
            _isik = isik;
        }
        public void Execute()
        {
            _isik.TurnOff();
        }
    }



}

