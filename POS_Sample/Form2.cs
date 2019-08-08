using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Sample
{
    public partial class Form2 : Form
    {
        float totalPrice;
        float cash;
        float balance;

        public Form2(string Form1Sum)
        {
            InitializeComponent();

            textTotal.Text = Form1Sum;
            totalPrice = float.Parse(Form1Sum);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            textCash.Enabled = false;

            textBalance.Text = balance.ToString();

            buttonOK.Visible = false;

            labelBalance.Visible = true;
            textBalance.Visible = true;

            buttonDone.Visible = true;
            
         
        }

        private void TextCash_TextChanged(object sender, EventArgs e)
        {
            if (textCash.Text.Length > 0)
            {
                cash = float.Parse(textCash.Text);
                
            }
            else
            {
                cash = 0;
            }

            balance = cash - totalPrice;
            if ( balance >= 0)
            {
                buttonOK.BackColor = System.Drawing.Color.PaleGreen;
                buttonOK.Enabled = true;
                
            }
            else
            {
                buttonOK.BackColor = System.Drawing.SystemColors.AppWorkspace;
                buttonOK.Enabled = false;
                
            }
        }

        private void TextCash_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            else if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
