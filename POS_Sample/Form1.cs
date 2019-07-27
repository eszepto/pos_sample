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
            List<string> data = stock.Query(textID.Text, textName.Text);
            
            if (data.Any())
            {
                dataGridView1.AllowUserToAddRows = true;

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = data[0];
                row.Cells[1].Value = data[1];
                row.Cells[2].Value = data[2];
                row.Cells[3].Value = data[3];

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
        
            
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = "XYZ";
            row.Cells[1].Value = "Water";
            row.Cells[2].Value = 

            dataGridView1.Rows.Add(row);
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
            sql_con = new SQLiteConnection("Data Source=Demo.db;Version=3;New=True;Compress=True;");
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
            List<string> strList = new List<string>();

            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "SELECT * FROM stock WHERE id='5' or name='apple'";
            sql_datareader = sql_cmd.ExecuteReader();
            
            if (sql_datareader.HasRows)
            {

                while (sql_datareader.Read())
                {
                    strList.Add(sql_datareader.GetString(0));
                }
            }

            sql_con.Close();
            return strList;
        }
    }
}

