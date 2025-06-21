using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
namespace forms
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand command;
        string query="", ConnectionString = "";
        public Form1()
        {
            InitializeComponent();
            createdatabase();
        }
        private void createdatabase()
        {
            string Connection = "Server = . ; Database=master;Integrated Security=True;";
            query = @"IF NOT EXISTS (SELECT NAME FROM SYS.DATABASES WHERE NAME = 'CALCULATER')
                                 BEGIN
                                     CREATE DATABASE CALCULATER;
	                                 print 1
                                 END
                                 ELSE 
                                     begin
                                     print 0
                                 END
                                ";
            open(query, Connection);
            int result =(int)command.ExecuteNonQuery();
            con.Close();
            if (result == 1)
            {
                query = @"CREATE TABLE OPERATIONS
                                (
                                ID INT	PRIMARY KEY IDENTITY (1,1),
                                PROCESS VARCHAR (255),
                                RESULT VARCHAR (255)
                                )";
                open(query);
                command.ExecuteNonQuery();
                con.Close();
            }
        }
        private void history_Click(object sender, EventArgs e)
        {
            query = @"select top 10 PROCESS,RESULT from OPERATIONS
                                order by id  desc";
            open(query);
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGrid.DataSource = dt;
            }
            con.Close();
            dataGrid.Visible = true;
            dataGrid.BringToFront();
            dataGrid.Focus();
        }
        public void open(string query, string ConnectionString = "Server = . ; Database=CALCULATER;Integrated Security=True;")
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            command = new SqlCommand(query, con);
        }
        private void num0_Click(object sender, EventArgs e)
        {
            all_num.Text += 0;
        }
        private void num1_Click(object sender, EventArgs e)
        {
            all_num.Text += 1;
        }
        private void num2_Click(object sender, EventArgs e)
        {
            all_num.Text += 2;
        }
        private void num3_Click(object sender, EventArgs e)
        {
            all_num.Text += 3;
        }
        private void num4_Click(object sender, EventArgs e)
        {
            all_num.Text += 4;
        }
        private void num5_Click(object sender, EventArgs e)
        {
            all_num.Text += 5;
        }
        private void num6_Click(object sender, EventArgs e)
        {
            all_num.Text += 6;
        }
        private void num7_Click(object sender, EventArgs e)
        {
            all_num.Text += 7;
        }
        private void num8_Click(object sender, EventArgs e)
        {
            all_num.Text += 8;
        }
        private void num9_Click(object sender, EventArgs e)
        {
            all_num.Text += 9;
        }
        private void dot_Click(object sender, EventArgs e)
        {
            if (all_num.Text.Length != 0 && !new string[] {"(", "-", "+", "/", "*", "%" }.Contains(all_num.Text[all_num.Text.Length - 1].ToString()))
            {
                all_num.Text += ".";
            }
        }
        private void percentage_Click(object sender, EventArgs e)
        {
            add_process("%");
        }
        private void divide_Click(object sender, EventArgs e)
        {
            add_process("/");
        }
        private void hit_Click(object sender, EventArgs e)
        {
            add_process("*");
        }
        private void min_Click(object sender, EventArgs e)
        {
            add_process("-");
        }
        private void plus_Click(object sender, EventArgs e)
        {
            add_process("+");
        }
        private void add_process(string proces)
        {
            if (all_num.Text.Length != 0 && !new string[] { "(", "-", "+", "/", "*", "%" }.Contains(all_num.Text[all_num.Text.Length - 1].ToString()))
            {
                all_num.Text += proces;
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            all_num.Text = "";
            cal.Text = "";
        }
        private void Del_Click(object sender, EventArgs e)
        {
            if (all_num.Text != "")
            {
                 all_num.Text= all_num.Text.Remove(all_num.Text.Length- 1,1);
            }
        }
        private void result_Click(object sender, EventArgs e)
        {
            string text = all_num.Text;
            Brackets();
            all_num.Text = Operations("*", "/");
            all_num.Text = Operations("%");
            all_num.Text = Operations("+", "-");
            string res = cal.Text = all_num.Text;
            all_num.Text = text;
            query = @"   insert into OPERATIONS
                                values
                                ('" + text + "','" + res + "');";
            open(query);
            command.ExecuteNonQuery();
            con.Close();
        }
        private void Brackets()
        {
            int count = 0;
            for (int i = 0; i < all_num.Text.Length; i++)
            {
                if ("(".Contains(all_num.Text[i].ToString()))
                {
                    for (int j = i + 1; j < all_num.Text.Length; j++)
                    {
                        if (")".Contains(all_num.Text[j].ToString()) || j == all_num.Text.Length - 1)
                        {
                            count = j;
                            if (!")".Contains(all_num.Text[j].ToString()))
                            {  j++; count=j-1; }
                            string arry = all_num.Text.Substring(i + 1, j - i - 1);
                            arry = Operations("*", "/", arry);
                            arry = Operations("%", "", arry);
                            arry = Operations("+", "-", arry);
                            all_num.Text = all_num.Text.Substring(0, i) + arry + all_num.Text.Substring(count + 1);
                            break;
                        }
                    }
                    i = 0;
                }
            }
        }
        private string Operations(string cal1, string cal2 = "", string arry = "")
        {
            if (arry == "")
            {
                arry = all_num.Text;
            }
            for (int i = 0; i < arry.Length; i++)
            {
                if (new string[] { cal1, cal2 }.Contains(arry[i].ToString()) && i != 0)
                {
                    string x = arry[i].ToString();
                    if (x == cal1)
                    {
                        arry = calcul(x, i, arry);
                    }
                    else
                    {
                        arry = calcul(x, i, arry);
                    }
                    i = -1;
                }
            }
            return arry;
        }
        private string calcul(string x, int i, string arry)
        {
            if (arry == "")
            {
                arry = all_num.Text;
            }
            string num1 = "", num2 = "";
            int j = 0;
            for (j = i; j >= 0; j--)
            {
                if (j == 0 || new string[] { "-", "+", "/", "*", "%" }.Contains(arry[j - 1].ToString()))
                {
                    for (int t = j; t < i; t++)
                    {
                        num1 += arry[t].ToString();
                    }
                    break;
                }
            }
            for (i += 1; i < arry.Length; i++)
            {
                num2 += arry[i].ToString();
                if (i == arry.Length - 1 || new string[] { "-", "+", "/", "*", "%" }.Contains(arry[i + 1].ToString()))
                {
                    break;
                }
            }
            double res = 0;
            switch (x)
            {
                case "*":
                    res = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                    break;
                case "/":
                    res = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                    break;
                case "%":
                    res = Convert.ToDouble(num1) % Convert.ToDouble(num2);
                    break;
                case "+":
                    res = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                    break;
                case "-":
                    res = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                    break;
            }
            arry = arry.Substring(0, j) + res + arry.Substring(i + 1, arry.Length - i - 1);
            return arry;
        }
        private void square_Click(object sender, EventArgs e)
        {
            if (all_num.Text.Length > 0 && !"()-+/*%".Contains(all_num.Text[all_num.Text.Length - 1]))
            {
                string operators = "()-+/*%";
                int lastOpIndex = -1;
                for (int i = all_num.Text.Length - 1; i >= 0; i--)
                {
                    if (operators.Contains(all_num.Text[i]))
                    {
                        lastOpIndex = i;
                        break;
                    }
                }
                string lastNumber = all_num.Text.Substring(lastOpIndex + 1);
                if (double.TryParse(lastNumber, out double num))
                {
                    double squared = num * num;
                    all_num.Text = all_num.Text.Substring(0, lastOpIndex + 1) + squared;
                }
            }       
        }
        private void dataGrid_Leave(object sender, EventArgs e)
        {
            dataGrid.Visible = false;
        }
       
        private void quse2_Click(object sender, EventArgs e)
        {
            if (all_num.Text.Length > 0 && !new string[] { "%", "+", "-", "*", "/" }.Contains(all_num.Text[all_num.Text.Length - 1].ToString()))
            {
                all_num.Text += ")";
            }
        }
        private void quse1_Click(object sender, EventArgs e)
        {
            if (all_num.Text.Length > 0 && !new string[] {"%", "+", "-", "*", "/" }.Contains(all_num.Text[all_num.Text.Length - 1].ToString()))
            {
                all_num.Text += "*(";
            }
            else
                all_num.Text += "(";
        }
    }
}
