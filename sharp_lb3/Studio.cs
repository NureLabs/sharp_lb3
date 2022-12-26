using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_lb3
{
    interface ICloneable
    {
        object Clone();
    }
    class Studio : ICloneable
    {
        private string name_of_studio;
        private string adress_of_studio;
        private double fund_of_studio;

        private List<Room> rooms = new List<Room>();
        private List<Instrument> instruments = new List<Instrument>();
        private Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

        public Studio()
        {

        }
        public Studio(string name_of_studio, string adress_of_studio, double fund_of_studio)
        {
            this.name_of_studio = name_of_studio;
            this.adress_of_studio = adress_of_studio;
            this.fund_of_studio = fund_of_studio;
        }

        public void Add_Room(int creating_room_id, List<Instrument> instruments_of_room)
        {
            Room room = new Room(creating_room_id);
            rooms.Add(room);

            room.SetInstruments(instruments_of_room.Count);
        }

        public void Remove_Room(int removing_room_id)
        {
            rooms.RemoveAt(removing_room_id - 1);
        }

        public Instrument GetInstrument(int searching_instrument)
        {
            return instruments[searching_instrument - 1];
        }
        public Employee GetEmployee(string searching_employee_INN)
        {
            return employees[searching_employee_INN];
        }

        public void Recruit_Employee(string INN, string full_name_employee, double salary_of_employee, int amount_of_recorded_tracks)
        {
            Employee employee = new Employee(INN, full_name_employee, salary_of_employee, amount_of_recorded_tracks);
            employees.Add(INN, employee);
        }
        public void Fire_Employee(string employees_INN)
        {
            employees.Remove(employees_INN);
        }

        public List<Room> Get_Rooms_List
        {
            get { return rooms; }
        }
        public List<Instrument> Get_Instruments_List
        {
            get { return instruments; }
        }
        public Dictionary<string, Employee> Get_Employees_Dict
        {
            get { return employees; }
        }
        public int Get_Amount_Of_Rooms
        {
            get { return rooms.Count; }
        }
        public int Get_Amount_Of_Instruments
        {
            get { return instruments.Count; }
        }
        public int Get_Amount_Of_Employees
        {
            get { return employees.Count; }
        }

        public string Get_Name
        {
            get { return name_of_studio; }
        }
        public double Get_Fund
        {
            get { return fund_of_studio; }
        }
        public void Set_Fund(double fund)
        {
            fund_of_studio += fund;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
