using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNameSpace
{

    class MyClass1
    {
        enum Names
        { 
            Matt,
            Mike,
            Ryac,
        }
        string Name;
        public MyClass1(string name)
        {
            Name = name;
        }

        string name()
        {
            return Name;
        }

        Names myName = Names.Matt;

        public static void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public static void ShowMessage(int message)
        {
            MessageBox.Show(message.ToString());
        }
    }
}
