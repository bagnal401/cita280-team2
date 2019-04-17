using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;



namespace ExpenseTracker
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDB conn = new ConnectionDB("C:/Users/bagnal401/Documents/CITA 280/expense-tracker/ExpenseTracker/Database/ExpenseTracker.accdb");
            string sqlString = "insert into Users (firstName, lastName, Email, Password, Username, Gender, DOB, homePhone, Address) Values('";
            sqlString += textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "')";
            conn.ExecuteQuery(sqlString);

           
        }

        
    }
}
