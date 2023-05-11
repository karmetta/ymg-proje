using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class UyeleriGoruntule : Form
    {
        public UyeleriGoruntule()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OUESDKU\SQLEXPRESS01;Initial Catalog=SporDB;Integrated Security=True;Pooling=False");

        private void uyeler()
        {
            baglanti.Close();
            string query = "select*from UyeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDGV.DataSource = ds.Tables[0];
            baglanti.Close();

           
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UyeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Application.Exit(); 
        }

        private void UyeleriGoruntule_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();

        }
    }
}
