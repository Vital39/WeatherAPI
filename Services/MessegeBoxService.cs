using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public class MessegeBoxService
    {
        public void ShowMessege(string messege, string caption=null)
        {
            System.Windows.MessageBox.Show(messege, caption);
        }
    }
}
