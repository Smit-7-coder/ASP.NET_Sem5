using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.Lab_Tutorial4
{
    class College
    {
        private string name;
        protected string uni_name;
        public string department;

        public College(string name, string uni_name, string department)
        {
            this.name = name;
            this.uni_name = uni_name;
            this.department = department;
        }

        public void DisplayName()
        {
            Console.WriteLine("Name of the College" + name);
        }

        public void DisplayUniName()
        {
            Console.WriteLine("University Name" + uni_name);
        }

        public void DisplayDepartment()
        {
            Console.WriteLine("Department Name" + department);
        }

        public void Display()
        {
            DisplayName();
            DisplayUniName();
            DisplayDepartment();
        }        
    }

    class SOE : College
    {
        private string Event_name;
        protected string cost_of_Event;
        public string coordinator_name;

        public SOE(string name, string uni_name, string department, string Event_name,
            string Cost_of_Event, string cooordinator_name) : base(name, uni_name, department)
        {
            this.Event_name = Event_name;
            this.uni_name = uni_name;
            this.department = department;
        }
    }
    internal class P3_4
    {
        public static void Run()
        {
            SOE s1 = new SOE("Noble", "RK University", "Information Technology", "TechnoPlanet", "10000", "Samit Sakariya");
            s1.Display();
        }
    }
}
