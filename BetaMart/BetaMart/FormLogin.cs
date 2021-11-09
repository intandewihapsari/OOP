using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BetaMart
{
    public partial class FormLogin : Form
    {
        OleDbConnection koneksi = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Sekolah XII RPL 3\Bootcamp\OOP\BetaMartAccess.accdb");
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "select count (*) from login where Username='" + tbUsername.Text + "'and Password='" + tbPassword.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(perintah, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Username and password is correct");
                koneksi.Close();
                koneksi.Dispose();
                this.Hide();
                FormUtama f2 = new FormUtama();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect try again..");
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
