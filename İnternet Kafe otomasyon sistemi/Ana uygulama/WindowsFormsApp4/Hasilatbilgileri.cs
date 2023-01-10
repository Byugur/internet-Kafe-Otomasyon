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
using System.Data.Sql;

namespace WindowsFormsApp4
{
    public partial class Hasilatbilgileri : Form
    {
        SqlConnection veritabani = new SqlConnection("Data Source=UĞUR;Initial Catalog=InternetKafe;Integrated Security=True");
        public Hasilatbilgileri()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void Form6_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Hesap", veritabani);
            da.Fill(dt);    
            dataGridView1.DataSource = dt;
        }
    }
}
