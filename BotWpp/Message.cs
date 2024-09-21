using EasyAutomationFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotWpp
{
    public class WppSendMessage : Web
    {
        public void SendMessage(string message , string to)
        {
            StartBrowser(TypeDriver.GoogleChorme , "C:\\Users\\davi.borges\\AppData\\Local\\Google\\Chrome\\User Data");

            Navigate("https://web.whatsapp.com/");

            WaitForLoad(); 
        }
    }
}
