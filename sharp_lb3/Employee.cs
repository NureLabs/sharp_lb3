using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_lb3
{
    class Employee : Room
    {
        private string INN;
        private string full_name_employee;
        private double salary_of_employee;
        private int amount_of_recorded_tracks;

        /*public Employee()
        {
            Array.Resize(ref employee_INNs, employee_INNs.Length + 1);
            employee_INNs[employee_INNs.Length - 1] = employee_INNs.Last() + 1;
        }*/
        public Employee(string INN, string full_name_employee, double salary_of_employee, int amount_of_recorded_tracks)
        {
            this.INN = INN;
            this.full_name_employee = full_name_employee;
            this.salary_of_employee = salary_of_employee;
            this.amount_of_recorded_tracks = amount_of_recorded_tracks;

            Array.Resize(ref employee_INNs, employee_INNs.Length + 1);
            employee_INNs[employee_INNs.Length - 1] = INN;
        }
    }
}