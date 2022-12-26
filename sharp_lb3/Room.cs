using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_lb3
{
    class Room : Studio
    {
        private int room_id;

        protected int[] instrument_ids = new int[0];
        protected string[] employee_INNs = new string[0];

        private const int minimum_instruments = 2;
        private const int maximum_instruments = 6;

        private const int minimum_employees = 2;
        private const int maximum_employees = 4;

        private const double one_track_cost = 5000;

        protected int real_amount_of_instruments_in_room = 0;
        protected int real_amount_of_employees_in_room = 0;

        //private double one_track_time_to_record; //in minutes
        //one_track_time_to_record = 240 / real_amount_of_instruments_in_room;

        public Room()
        {
            
        }
        public Room(int room_id)
        {
            this.room_id = room_id;
        }

        public void SetInstruments(int value)
        {
            real_amount_of_instruments_in_room = value;
        }
    }
}