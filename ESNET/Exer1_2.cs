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
    public partial class Exer1_2 : Form
    {
        public Exer1_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conS = "Data source = (local); initial catalog = Dafesty;" +
                "integrated security = SSPI";

            SqlConnection cn = new SqlConnection(conS);
            cn.Open();

            string sql = "Select movieTitle from movies";
            SqlCommand cm = new SqlCommand(sql, cn);

            SqlDataReader rd = cm.ExecuteReader();
            while (rd.Read())
            {
                movies_list.Items.Add(rd[0].ToString());
            }

            rd.Close();
        }
    }
}
