namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Arr = new int[14];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 14; i++)
            {
                Arr[i] = rnd.Next(-10, 10);
                listBox1.Items.Add("Arr[" + i.ToString() + "]=" + Arr[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int m = 0, a = 0, sum = 0;
            for (int i = 0; i < 14; i++)
            {
                if (Arr[i] < 0)
                {
                    a = Arr[i];
                    m = i;
                    break;
                }
            }
            for (int i = 0; i < m; i++)
            {
                sum += Arr[i];
            }
            textBox1.Text=("sum=" + sum.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = ("");
        }
    }
}
    
