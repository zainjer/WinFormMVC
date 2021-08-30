using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vplquiz.Views;

namespace Vplquiz.Controllers
{
    public class EntryController
    {
        private static EntryController _instance;
        public static EntryController Instance => _instance ?? (_instance = new EntryController());

        public EntryController()
        {
            Startup();
        }

        private void Startup()
        {
            var folderPath = Directory.GetCurrentDirectory() + "/Resources";
            var filepath = folderPath + "/cookie.txt";
            if (!Directory.Exists(folderPath) || !File.Exists(filepath))
            {
                FirstStartup(folderPath);
            }

            var txt = File.ReadAllText(filepath);
            if (string.IsNullOrWhiteSpace(txt))
            {
                new SignInView().Show();
            }

        }

        private void FirstStartup(string folderPath)
        {
            Directory.CreateDirectory(folderPath);
            File.Create(folderPath + "/cookie.txt");
            var signup = new SignupView();
            signup.FirstTime();
        }
    }
}
