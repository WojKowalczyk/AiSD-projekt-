namespace aisd_pop_1
{
    public partial class Form1 : Form
    {
        bool manual = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            int n = (int)nudN.Value;
            int wynik = Fib2(n);
            string napis = wynik.ToString();
            MessageBox.Show(napis);
        }

        int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        int Fib2(int n)
        {
            int[] wyrazy = new int[n + 2];
            wyrazy[0] = 0;
            wyrazy[1] = 1;
            for (int i = 2; i < n + 1; i++)
            {
                wyrazy[i] = wyrazy[i - 1] + wyrazy[i - 2];
            }
            return wyrazy[n];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textNumbersM_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSB_Click(object sender, EventArgs e)
        {
            int wynik = 0;
            textNumbersSorted.Text = wynik.ToString();
        }

        private void textNumbersSorted_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_auto_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_auto.Checked.Equals(true))
            {
                textNumbersM.Enabled = true;
                nmrcNumbersA.Enabled = false;
                MessageBox.Show("zmieniono na manual");
                manual = true;
            }
            else
            {
                textNumbersM.Enabled = false;
                nmrcNumbersA.Enabled = true;
                MessageBox.Show("zmieniono na automat");
                manual = false;
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int tyleLiczb = (int)nmrcNumbersA.Value;
            int[] tablicaLiczb = new int[tyleLiczb];
            for (int i = 0; i < tyleLiczb; i++)
            {
                tablicaLiczb[i] = rnd.Next(1000);
            }
            string liczby = "";
            for (int i = 0; i < liczby.Length; i++)
            {
                liczby.Append
            }
            textNumbersM.Text = tablicaLiczb.ToString();
        }

        private void nmrcNumbersA_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}