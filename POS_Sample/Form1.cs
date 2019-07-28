using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace POS_Sample
{
    public partial class Form1 : Form
    {

        StockDB stock;
        public Form1()
        {
            stock = new StockDB();
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            
            List<string> data = stock.Query(textID.Text,textName.Text);

            if (data.Count != 0)
            {
                dataGridView1.AllowUserToAddRows = true;

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = data[0];
                row.Cells[1].Value = data[1];
                row.Cells[2].Value = data[2];
                row.Cells[3].Value = textQty.Text;

                dataGridView1.Rows.Add(row);

                dataGridView1.AllowUserToAddRows = false;
            }
            else
            {
                InputBoxClear();
            }
        }

        private void ButtonWater_Click(object sender, EventArgs e)
        {


            List<string> data = stock.Query("","water");

            
            dataGridView1.AllowUserToAddRows = true;

            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = data[0];
            row.Cells[1].Value = data[1];
            row.Cells[2].Value = data[2];
            


            dataGridView1.Rows.Add(row);

            dataGridView1.AllowUserToAddRows = false;
            
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to clear ?", "Clear", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
            }
                  
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        void InputBoxClear()
        {
            textID.Text = "";
            textName.Text = "";
            textQty.Text = "";
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            labelTotal.Text = GetTotalPrice().ToString();   
        }

        private double GetTotalPrice()
        {
            double TotalPrice=0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TotalPrice += double.Parse(row.Cells[4].Value.ToString());
            }
            
            return TotalPrice;
        }
    }
    public class StockDB : Object
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
      
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private SQLiteDataReader sql_datareader;

        public StockDB()
        {
            sql_con = new SQLiteConnection("Data Source=Demo.db");
            this.Connect();
        }

        void Connect()
        {
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "CREATE TABLE IF NOT EXISTS " +
                "`stock` (" +
                "`id`TEXT NOT NULL UNIQUE," +
                "`name`TEXT NOT NULL UNIQUE," +
                "`price`DOUB NOT NULL," +
                "`quantity`INTEGER NOT NULL); ";
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        public List<string> Query(string id="", string name="")
        {
            sql_con = new SQLiteConnection("Data Source=Demo.db");
            this.Connect();

            List<string> strList = new List<string>();

            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = String.Format("select * from stock where id='{0}' or name='{1}'",id,name);
            sql_datareader = sql_cmd.ExecuteReader();

            if (sql_datareader.HasRows)
            {
                while (sql_datareader.Read())  
                {
                    strList.Add(sql_datareader["id"].ToString());
                    strList.Add(sql_datareader["name"].ToString());
                    strList.Add(sql_datareader["price"].ToString());
                }
            }

            sql_con.Close();
            return strList;
        }
    }
}

