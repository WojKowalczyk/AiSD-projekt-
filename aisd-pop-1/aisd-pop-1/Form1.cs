namespace aisd_pop_1
{
    public partial class Form1 : Form
    {
        bool manual = false;
        int tyleLiczb;
        string liczby;
        int[] tablicaLiczb;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void checkBox_auto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_auto.Checked.Equals(true))
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
            tablicaLiczb = new int[tyleLiczb];
            for (int i = 0; i < tyleLiczb; i++)
            {
                tablicaLiczb[i] = rnd.Next(1000);
            }
            liczby = "";
            for (int i = 0; i < tyleLiczb; i++)
            {
                liczby += tablicaLiczb[i].ToString() + " ";
            }
            textNumbersM.Text = liczby;
        }
        private void labelTime_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textNumbersM_TextChanged(object sender, EventArgs e)
        {

        }
        private void textNumbersSorted_TextChanged(object sender, EventArgs e)
        {

        }
        private void nmrcNumbersA_ValueChanged(object sender, EventArgs e)
        {

        }

        private string tablicaNaString(int[] tablica)
        {
            string zwroc = "";
            for (int i = 0; i < tyleLiczb; i++)
            {
                zwroc += tablica[i].ToString() + " ";
            }
            textNumbersM.Text = zwroc;
            return zwroc;
        }
        private void buttonSB_Click(object sender, EventArgs e)
        {
            int wynik = 0;
            bool another_one = true;
            int liczba_temp;
            textNumbersSorted.Text = wynik.ToString();
            while (another_one)
            {
                another_one = false;
                for (int i = 1; i < tyleLiczb; i++)
                {
                    if (tablicaLiczb[i] > tablicaLiczb[i - 1])
                    {
                        liczba_temp = tablicaLiczb[i];
                        tablicaLiczb[i] = tablicaLiczb[i - 1];
                        tablicaLiczb[i - 1] = liczba_temp;
                        another_one = true;
                    }

                }
            }
            MessageBox.Show(tablicaLiczb[0].ToString());
            textNumbersSorted.Text = tablicaNaString(tablicaLiczb);

        }
        private void buttonSS_Click(object sender, EventArgs e)
        {

        }
        private void buttonSI_Click(object sender, EventArgs e)
        {

        }
        private void buttonSM_Click(object sender, EventArgs e)
        {

        }
        private void buttonSQ_Click(object sender, EventArgs e)
        {

        }
    }
}