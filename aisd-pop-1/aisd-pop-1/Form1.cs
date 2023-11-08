using System;
using System.IO.Pipes;

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
            nmrcNumbersA.Value = 6;
            textNumbersM.Enabled = false;
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
            tyleLiczb = (int)nmrcNumbersA.Value;
            tablicaLiczb = new int[tyleLiczb];
            for (int i = 0; i < tyleLiczb; i++)
            {
                tablicaLiczb[i] = rnd.Next(1000);
            }
            //liczby = "";
            //for (int i = 0; i < tyleLiczb; i++)
            //{
            //    liczby += tablicaLiczb[i].ToString() + " ";
            //}
            //textNumbersM.Text = liczby;
        }
        private void labelTime_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        int[] napisNaTablice(string napis)
        {
            var LiczbyS = napis.Trim().Split(' ');
            tablicaLiczb = new int[LiczbyS.Length];
            tyleLiczb = (int)LiczbyS.Length;
            for (int i = 0; i < LiczbyS.Length; i++)
            {
                tablicaLiczb[i] = int.Parse(LiczbyS[i]);
            }
            return tablicaLiczb;
            
        }
        private void textNumbersM_TextChanged(object sender, EventArgs e)
        {
            string napisDoTablicy = textNumbersM.Text;
            tablicaLiczb = napisNaTablice(napisDoTablicy);
            //string costam = tablicaNaString(tablicaLiczb);
            
            
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
            return zwroc;
        }
        private void buttonSB_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int liczba_temp;
            string debugg = "";
            int[] tablicaLiczb_temp = new int[tyleLiczb];
            tablicaLiczb_temp = (int[])tablicaLiczb.Clone();
            watch.Start();
            for (int j = 0; j < tyleLiczb; j++)
            {
                for (int i = 1; i < tyleLiczb; i++)
                {

                    if (tablicaLiczb_temp[i] < tablicaLiczb_temp[i - 1])
                    {
                        liczba_temp = tablicaLiczb_temp[i];
                        tablicaLiczb_temp[i] = tablicaLiczb_temp[i - 1];
                        tablicaLiczb_temp[i - 1] = liczba_temp;

                    }

                }
            }
            watch.Stop();
            labelTime.Text = watch.Elapsed.ToString();
            textNumbersSorted.Text = tablicaNaString(tablicaLiczb_temp);
        }
        private void buttonSS_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int liczba_temp;
            int[] tablicaLiczb_temp = new int[tyleLiczb];
            tablicaLiczb_temp = (int[])tablicaLiczb.Clone();

            watch.Start();
            for (int j = 0; j < tyleLiczb; j++)
            {
                int min = tablicaLiczb_temp[j];
                int min_i = j;
                for (int i = j + 1; i < tyleLiczb; i++)
                {
                    if (tablicaLiczb_temp[i] < min)
                    {
                        min = tablicaLiczb_temp[i];
                        min_i = i;
                    }
                }
                liczba_temp = tablicaLiczb_temp[j];
                tablicaLiczb_temp[j] = tablicaLiczb_temp[min_i];
                tablicaLiczb_temp[min_i] = liczba_temp;
            }
            watch.Stop();
            labelTime.Text = watch.Elapsed.ToString();
            textNumbersSorted.Text = tablicaNaString(tablicaLiczb_temp);
        }

        private int[] merg(int[] lew, int[] praw)
        {
            int[] zwroc = new int[0];

            while (lew.Length > 0 || praw.Length > 0)
            {
                if (lew.Length > 0 && praw.Length > 0)
                {
                    if (lew.First() <= praw.First())  //Comparing First two elements to see which is smaller
                    {
                        zwroc = zwroc.Append(lew.First()).ToArray();
                        lew = lew.Where((val, idx) => idx != 0).ToArray();      //Rest of the list minus the first element
                    }
                    else
                    {
                        zwroc = zwroc.Append(praw.First()).ToArray();
                        praw = praw.Where((val, idx) => idx != 0).ToArray();
                    }
                }
                else if (lew.Length > 0)
                {
                    zwroc = zwroc.Append(lew.First()).ToArray();
                    lew = lew.Where((val, idx) => idx != 0).ToArray();
                }
                else if (praw.Length > 0)
                {
                    zwroc = zwroc.Append(praw.First()).ToArray();

                    praw = praw.Where((val, idx) => idx != 0).ToArray();
                }
            }
            return zwroc;
        }

        private int[] sortMerg(int[] a)
        {
            if (a.Length <= 1)
            {
                return a;
            }
            int[] lewo = new int[0];
            int[] prawo = new int[0];


            int middle = a.Length / 2;
            for (int i = 0; i < middle; i++)
            {
                lewo = lewo.Append(a[i]).ToArray();
            }
            for (int i = middle; i < a.Length; i++)
            {
                prawo = prawo.Append(a[i]).ToArray();
            }

            lewo = sortMerg(lewo);
            prawo = sortMerg(prawo);
            return merg(lewo, prawo);
        }

        private void buttonSM_Click_1(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int liczba_temp;
            int[] tablicaLiczb_temp = new int[tyleLiczb];
            tablicaLiczb_temp = (int[])tablicaLiczb.Clone();
            watch.Start();
            tablicaLiczb_temp = sortMerg(tablicaLiczb_temp);
            watch.Stop();
            labelTime.Text = watch.Elapsed.ToString();
            textNumbersSorted.Text = tablicaNaString(tablicaLiczb_temp);
        }

        private int[] quickquick(int[] a, int lew, int praw)
        {
            int i = lew;
            int j = praw;
            int pivot = a[lew];
            while (i <= j)
            {
                while (a[i] < pivot)
                {
                    i++;
                }
                while (a[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }

            if (lew < j)
                quickquick(a, lew, j);
            if (i < praw)
                quickquick(a, i, praw);
            return a;
        }
        private void buttonSQ_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int liczba_temp;
            int[] tablicaLiczb_temp = new int[tyleLiczb];
            tablicaLiczb_temp = (int[])tablicaLiczb.Clone();

            watch.Start();
            tablicaLiczb_temp = quickquick(tablicaLiczb_temp, 0, tablicaLiczb_temp.Length - 1);
            watch.Stop();
            labelTime.Text = watch.Elapsed.ToString();
            textNumbersSorted.Text = tablicaNaString(tablicaLiczb_temp);
        }

        private void buttonSI_Click_1(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int liczba_temp;
            int[] tablicaLiczb_temp = new int[tyleLiczb];
            tablicaLiczb_temp = (int[])tablicaLiczb.Clone();


            watch.Start();
            for (int i = 1; i < tyleLiczb; i++)
            {

                int tutaj = tablicaLiczb_temp[i];
                bool dawaj = false;
                for (int j = i - 1; j >= 0 && dawaj == false;)
                {
                    if (tutaj < tablicaLiczb_temp[j])
                    {

                        tablicaLiczb_temp[j + 1] = tablicaLiczb_temp[j];
                        j--;
                        tablicaLiczb_temp[j + 1] = tutaj;
                    }
                    else dawaj = true;
                }
            }
            watch.Stop();
            labelTime.Text = watch.Elapsed.ToString();
            textNumbersSorted.Text = tablicaNaString(tablicaLiczb_temp);
        }


    }
}