using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CSDL
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string conString = @"Data Source=DESKTOP-QU1E559\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select * from dbo.sanpham";
            SqlConnection con = new SqlConnection(conString);
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                else
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string masp = TextBox2.Text.Trim();
            string tensp = TextBox1.Text.Trim();
            string gia = TextBox3.Text.Trim();
            string query = @"INSERT INTO dbo.sanpham (masp, tensp, gia)
                              VALUES (@masp, @tensp, @gia);";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@tensp", tensp);
                cmd.Parameters.AddWithValue("@gia", gia);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            Response.Redirect(Request.RawUrl);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string masp = TextBox2.Text.Trim();
            string tensp = TextBox1.Text.Trim();
            string gia = TextBox3.Text.Trim();
            string query = @"UPDATE dbo.sanpham SET tensp = @tensp, gia = @gia WHERE masp = @masp";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@tensp", tensp);
                cmd.Parameters.AddWithValue("@gia", gia);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            Response.Redirect(Request.RawUrl);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string masp = TextBox2.Text.Trim();
            string query = @"DELETE FROM dbo.sanpham WHERE masp = @masp";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@masp", masp);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            Response.Redirect(Request.RawUrl);
        }
    }
}