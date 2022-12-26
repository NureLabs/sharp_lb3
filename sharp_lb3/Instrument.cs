using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_lb3
{
    enum Instrument_Type
    {
        Drum,
        Bass_Guitar,
        Rhythm_Guitar,
        Lead_Guitar,
        Synthesizer,
        Piano,
        Saxophone,
        Violin,
        Cello,
        Bayan
    }
    class Instrument : Room
    {
        private int instrument_id;
        private int instrument_type;
        private double instrument_price;

        public Instrument(int instrument_id, int instrument_type, double instrument_price)
        {
            this.instrument_id = instrument_id;
            this.instrument_type = instrument_type;
            this.instrument_price = instrument_price;

            Array.Resize(ref instrument_ids, instrument_ids.Length + 1);
            instrument_ids[instrument_ids.Length - 1] = instrument_id;
        }
    }
}
