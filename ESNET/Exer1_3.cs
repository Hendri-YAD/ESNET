using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ESNET
{
    public partial class Exer1_3 : Form
    {
        public Exer1_3()
        {
            InitializeComponent();
        }

        private void btn_retrieve_Click(object sender, EventArgs e)
        {
            string conS = "Data source=(local); initial catalog = Dafesty;" +
                "integrated security = SSPI";
            SqlConnection cn = new SqlConnection(conS);

            string sql = "Select VideoCode, MovieTitle, RentalPrice from Movies";
            SqlCommand cm = new SqlCommand(sql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);

            DataSet ds = new DataSet();
            
            da.Fill(ds, "Movies");
            

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (tb_videoCode.Text.Equals
                    (ds.Tables["Movies"].Rows[i]["VideoCode"].ToString()))
                {
                    tb_movieTitle.Text = ds.Tables["Movies"].Rows[i]["MovieTitle"].ToString();
                    tb_rentalPrice.Text = ds.Tables["Movies"].Rows[i]["RentalPrice"].ToString();
                }
            }

            if(tb_videoCode.Text.Equals(""))
            {
                tb_movieTitle.Text = "";
                tb_rentalPrice.Text = "";
            }
                
            

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string conS = "Data source = (local); Initial catalog = Dafesty;" +
                "integrated security = SSPI";
            SqlConnection cn = new SqlConnection(conS);

            string sql = "Select VideoCode, MovieTitle, RentalPrice from Movies";
            SqlCommand cm = new SqlCommand(sql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();

            da.Fill(ds, "Movies");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (tb_movieTitle.Text.Equals
                    (ds.Tables["Movies"].Rows[i]["MovieTitle"].ToString()))
                {
                    ds.Tables["Movies"].Rows[i]["RentalPrice"] = tb_rentalPrice.Text;
                }

            }

            da.Update(ds, "Movies");

        }
    }
}
