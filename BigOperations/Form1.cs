using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BigOperations
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Primo.Tag = "1";
            Secondo.Tag = "2";
        }


        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                BigNumber BN1 = new BigNumber(Primo.Text);
                BigNumber BN2 = new BigNumber(Secondo.Text);

                var watch = Stopwatch.StartNew();
                
                BN1 = (BN1 + BN2);

                watch.Stop();
                Time.Text= watch.ElapsedMilliseconds.ToString() + " ms";

                Totale.Text = BN1.ToString();
            }
            catch
            {
                MessageBox.Show("Errore");
            }
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            try
            {
                var watch = Stopwatch.StartNew();

                BigNumber BN1 = new BigNumber(Primo.Text);
                BigNumber BN2 = new BigNumber(Secondo.Text);

                BN1 = (BN1 * BN2);

                watch.Stop();
                Time.Text = watch.ElapsedMilliseconds.ToString() + " ms";

                Totale.Text = BN1.ToString();
            }
            catch
            {
                MessageBox.Show("Errore");
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            try
            {
                BigNumber BN1 = new BigNumber(Primo.Text);
                BigNumber BN2 = new BigNumber(Secondo.Text);

                var watch = Stopwatch.StartNew();

                BN1 = (BN1 - BN2);

                watch.Stop();
                Time.Text = watch.ElapsedMilliseconds.ToString() + " ms";

                Totale.Text = BN1.ToString();
            }
            catch
            {
                MessageBox.Show("Errore");
            }
        }

        private void Div_Click(object sender, EventArgs e)
        {
            try
            {
                var watch = Stopwatch.StartNew();

                BigNumber BN1 = new BigNumber(Primo.Text);
                BigNumber BN2 = new BigNumber(Secondo.Text);

                string s;

                if (SuperDivision.Checked)
                    s = BigNumber.SuperDivision(BN1, BN2);
                else
                    s = (BN1 / BN2).ToString();

                watch.Stop();
                Time.Text = watch.ElapsedMilliseconds.ToString() + " ms";

                Totale.Text = s;
            }
            catch
            {
                MessageBox.Show("Errore");
            }
        }


        private void Totalchar(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            string check = (string)TB.Tag;
            if (check == "1")
                Counter1.Text = TB.Text.Length.ToString();
            else if (check == "2")
                Counter2.Text = TB.Text.Length.ToString();
            else
            {
                if (TB.Text.Length > 0)
                    if (TB.Text[0] == '-')
                        Counter3.Text = (TB.Text.Length - 1).ToString();
                    else
                        Counter3.Text = TB.Text.Length.ToString();
            }

            Counter1.Location = new Point(417 - Counter1.Width, Counter1.Location.Y);
            Counter2.Location = new Point(417 - Counter2.Width, Counter2.Location.Y);
            Counter3.Location = new Point(417 - Counter3.Width, Counter3.Location.Y);
        }

        private void Keepchars(object sender, KeyPressEventArgs e)
        {
            string allowed = "0123456789";

            if (!allowed.Contains(e.KeyChar) && (e.KeyChar != (char)8) && (e.KeyChar != (char)24))
                e.Handled = true;
        }

        private void AllowPaste(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.V))
                (sender as TextBox).Paste();
        }

        private void SDInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BigOperations works with integer numbers. Most of divisions resolve in real numbers and this cannot be managed within the integers.\n" + 
                "\"Super Division\" fixes this problem using something like a cheat, approximating the result to the 100th decimal unit.\n" +
                "This means that, by ticking the flag, you will have a more precise result, but a longer calculation time.", "What Super Division do?");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Copyto1_Click(object sender, EventArgs e)
        {
            Primo.Text = new string(Totale.Text.Split('.')[0].ToArray());
        }

        private void Copyto2_Click(object sender, EventArgs e)
        {
            Secondo.Text = new string(Totale.Text.Split('.')[0].ToArray());
        }

        private void CopytoC_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Totale.Text);
        }
    }
}
