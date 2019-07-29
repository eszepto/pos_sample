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

/* [+]Bug found:
 *  - empty box/ input validation
 *  - !!!! when update qty  Database lock !!!!
 *  - Problem with Public obj ?
 */  
namespace POS_Sample
{
    public partial class Form1 : Form
    {

        private StockDB stock;
        private OrderDB order;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        public Form1()
        {
            stock = new StockDB();
            order = new OrderDB();
            InitializeComponent();
            dtgRefresh();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            float total;
            string command;
            string inputID = textID.Text;
            string inputName = textName.Text;
            string inputQty = textQty.Text;

            List<string> data = stock.Read(inputID,inputName);   ///0:id  1:name  2:price 

            if (data.Count != 0) //input check
            {
                if (order.IsInTable(textID.Text, textName.Text)) /// item is already in order
                {
                    string inOrderQty = order.GetQty(inputID, inputName);
                    total = (float.Parse(data[2]) *  ( float.Parse(inOrderQty) + float.Parse(inputQty) )  );

                    command = string.Format("UPDATE 'order' SET qty={0}, total={1} WHERE id='{2}' or name='{3}' ", inputQty, total.ToString(), inputID, inputName);///Error Here
                }

                else /// item isn't in order  -> add item to order
                {
                    total = (float.Parse(data[2]) * float.Parse(textQty.Text));
                    command = string.Format("INSERT INTO 'order' VALUES('{0}', '{1}', {2}, {3}, {4});", data[0], data[1], data[2], textQty.Text, total.ToString()); 
                }

            }
            else
            {
                InputBoxClear();
                return;
            }
            order.Query(command);
            dtgRefresh();
        }

        private void ButtonWater_Click(object sender, EventArgs e)
        {
            List<string> data = stock.Read("","water");
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
            Form2 fm2 = new Form2();
            this.Hide();
            fm2.ShowDialog();
            this.Show();
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

        private void dtgRefresh()
        {
            using (SQLiteConnection sqlCon = new SQLiteConnection("Data Source=order_temp.db"))
            {
                sqlCon.Open();
                SQLiteDataAdapter DA = new SQLiteDataAdapter("select * from `order`", order.sql_con);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlCon.Close();
            }
        }

        private void ButtonApple_Click(object sender, EventArgs e)
        {
            dtgRefresh();
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
            this.CreateTable();
        }

        void CreateTable()
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

        public List<string> Read(string id="", string name="")
        {
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
    public class OrderDB : Object
    {
        public SQLiteConnection sql_con;
        public SQLiteCommand sql_cmd;

        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private SQLiteDataReader sql_datareader;
        public SQLiteDataAdapter DA;
        public OrderDB()
        {
            sql_con = new SQLiteConnection("Data Source=order_temp.db;new=True");
            this.CreateTable();
        }

        public void CreateTable()
        {
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "drop table if exists `order`;" +
                "CREATE TABLE " +
                "`order` (" +
                "`id`TEXT NOT NULL UNIQUE," +
                "`name`TEXT NOT NULL UNIQUE," +
                "`price`DOUB NOT NULL," +
                "`qty`INTEGER NOT NULL," +
                "`total`DOUB NOT NULL);";
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        public bool IsInTable(string id = "", string name = "")
        {
            bool hasrow;

            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = String.Format("select * from `order` where id='{0}' or name='{1}'", id, name);
            sql_datareader = sql_cmd.ExecuteReader();

            hasrow = sql_datareader.HasRows;
            sql_con.Close();

            return hasrow;

        }
        public void Query(string command)
        {
            
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = command;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        public string GetQty(string id, string name) ///ProblemHere
        {
            string qty;
            
            this.sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = String.Format("select * from `order` where id='{0}' or name='{1}'", id, name);
            sql_datareader = sql_cmd.ExecuteReader();

            sql_datareader.Read();
            qty = sql_datareader["qty"].ToString();
            
            sql_con.Close();
            return qty;
        }
    }
}

