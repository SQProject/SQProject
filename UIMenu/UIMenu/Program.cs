using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UIMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            TheCompany.EmployeeData container = new TheCompany.EmployeeData();
            UIMenu UI = new UIMenu();
            UI.SetEmployeeContainer(ref container);
            UI.Run();
        }
    }
}
