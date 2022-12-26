namespace sharp_lb3
{
    public partial class Form1 : Form
    {
        Studio studio;
        List<Room> rooms = new List<Room>();
        List<Instrument> instruments = new List<Instrument>();
        List<Instrument> instruments_for_room = new List<Instrument>();
        Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studio = new Studio(textBox1.Text, textBox2.Text, double.Parse(textBox3.Text));

            rooms = studio.Get_Rooms_List;
            instruments = studio.Get_Instruments_List;
            employees = studio.Get_Employees_Dict;

            comboBox1.Items.Add(Instrument_Type.Drum);
            comboBox1.Items.Add(Instrument_Type.Bass_Guitar);
            comboBox1.Items.Add(Instrument_Type.Rhythm_Guitar);
            comboBox1.Items.Add(Instrument_Type.Lead_Guitar);
            comboBox1.Items.Add(Instrument_Type.Synthesizer);
            comboBox1.Items.Add(Instrument_Type.Piano);
            comboBox1.Items.Add(Instrument_Type.Saxophone);
            comboBox1.Items.Add(Instrument_Type.Violin);
            comboBox1.Items.Add(Instrument_Type.Cello);
            comboBox1.Items.Add(Instrument_Type.Bayan);

            textBox18.Text = studio.Get_Fund.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            studio.Add_Room(int.Parse(textBox11.Text), instruments_for_room);
            instruments_for_room.Clear();
            textBox14.Text = rooms.Count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studio.Recruit_Employee(textBox4.Text, textBox5.Text, double.Parse(textBox6.Text), int.Parse(textBox7.Text));
            textBox15.Text = employees.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studio.Fire_Employee(textBox8.Text);
            textBox15.Text = employees.Count.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Instrument instrument = new Instrument(int.Parse(textBox9.Text), comboBox1.SelectedIndex, double.Parse(textBox10.Text));
            if (studio.Get_Fund > double.Parse(textBox10.Text))
            {
                instruments.Add(instrument);
                instruments_for_room.Add(instrument);

                studio.Set_Fund(-double.Parse(textBox10.Text));
                textBox18.Text = studio.Get_Fund.ToString();
                textBox16.Text = instruments.Count.ToString();
            }
            else MessageBox.Show("Недостатньо коштів! Поповніть касу студії!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studio.Remove_Room(int.Parse(textBox12.Text));
            textBox14.Text = rooms.Count.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            studio.Set_Fund(double.Parse(textBox13.Text));
            textBox18.Text = studio.Get_Fund.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            instruments.RemoveAt(int.Parse(textBox17.Text) - 1);
            textBox16.Text = instruments.Count.ToString();
        }
    }
}