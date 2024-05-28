using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Web;

namespace clinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            Form2 MainMenu = new Form2();
            string str = File.ReadAllText("DataBaseConnestion.txt");
            DataBase DB = new DataBase();
            DataTable DT = new DataTable();
            DB.SetLogPass(textBox_login.Text, textBox_password.Text);
            string querry = "select CURRENT_USER";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(querry, DB.GetCon());
                adapter.Fill(DT);
                MainMenu.account = DT.Rows[0].ItemArray[0].ToString();
            }
            catch { }
            DB.OpenCon();
            if (DB.IsCon() == true)
            {
                MainMenu.roles();
                this.Hide();
                MainMenu.Show();
            }
        }

        private void ExitProgrampictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
