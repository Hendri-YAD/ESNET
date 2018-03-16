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

namespace ESNET
{
    public partial class Exer1_1 : Form
    {
        public Exer1_1()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string conS = "data source = (local); initial catalog = Dafesty;" +
                "Integrated Security = SSPI";
            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            string sql = "Update Movies SET RentalPrice = '" + RentalPrice_tb.Text +
                "' where VideoCode = '" + VideoCode_tb.Text + "'";
            SqlCommand cm = new SqlCommand(sql, cn);

            if (cm.ExecuteNonQuery() == 0)
                MessageBox.Show("Not Found");

            cn.Close();
            
            
        }
    }
}
