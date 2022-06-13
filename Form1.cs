namespace Visual_Lab6
{
    public partial class Form1 : Form
    {
        int k = 1;
        List<Program.Station> Stations = new List<Program.Station>();
        int StationAmount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "5";
            textBox2.Text = "10";
        }
        private void Panel1_Click(object sender, EventArgs e)
        {
            Point point = panel1.PointToClient(Cursor.Position);
            Program.Station s = new Program.Station();
            s.X = point.X;
            s.Y = point.Y;
            s.SignalPower = Convert.ToInt32(textBox1.Text);
            Stations.Add(s);
            int sAmount = Stations.Count() - StationAmount;
            string lb = "Stations Added: " + Convert.ToString(sAmount);
            label1.Text = lb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " ";

            panel1.Invalidate();
            StationAmount = Stations.Count();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Stations;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !e.KeyChar.Equals('.'))
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "10";
            }
            k = Convert.ToInt32(textBox2.Text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !e.KeyChar.Equals('.'))
                e.Handled = true;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Program.Station s in Stations)
            {
                int r = Convert.ToInt32(Math.Sqrt(k / s.SignalPower));
                g.DrawEllipse(Pens.Red, s.X, s.Y, r,r);
            }
        }
    }
}