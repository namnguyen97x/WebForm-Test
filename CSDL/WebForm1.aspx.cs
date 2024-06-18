using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSDL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string conString = @"Data Source=DESKTOP-QU1E559\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadTensp();
            LoadMasp();
            SqlConnection con = new SqlConnection(conString);
            string query = @"select * from dbo.dathang";
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                try
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();

                    }
                    else
                    {
                        con.Open();
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }


                }
                catch (Exception ex)
                {

                    Response.Write(ex.Message);

                }

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string tensp = CbTenSp.Text.Trim();
            string masp = CbMaSp.Text.Trim();
            string soluong = TxtSl.Text.Trim();
            string tenkhach = TxtKh.Text.Trim();
            string diachi = TxtDc.Text.Trim();
            string sdt = TxtSdt.Text.Trim();
            string query = @"INSERT INTO dbo.dathang (tensp, masp, soluong, tenkhach, diachi, sdt)
                 VALUES (@tensp, @masp, @soluong, @tenkhach, @diachi, @sdt)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@tensp", tensp);
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@soluong", soluong);
                cmd.Parameters.AddWithValue("@tenkhach", tenkhach);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally { con.Close(); }
            }
            Response.Redirect(Request.RawUrl);
        }

        protected void BtnRemove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string tensp = CbTenSp.Text.Trim();
            string masp = CbMaSp.Text.Trim();
            string query = @"DELETE FROM dbo.dathang WHERE tensp = @tensp OR masp = @masp";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@tensp", tensp);
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
        protected void LoadTensp()
        {
            SqlConnection conn = new SqlConnection(conString);
            string query = @"select tensp from dbo.sanpham";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                CbTenSp.DataSource = dt;
                CbTenSp.DataValueField = "tensp";
                CbTenSp.DataTextField = "tensp";
                CbTenSp.DataBind();
            }
        }
        protected void LoadMasp()
        {
            SqlConnection conn = new SqlConnection(conString);
            string query = @"select masp from dbo.sanpham";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                CbMaSp.DataSource = dt;
                CbMaSp.DataValueField = "masp";
                CbMaSp.DataTextField = "masp";
                CbMaSp.DataBind();
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string tensp = CbTenSp.Text.Trim();
            string masp = CbMaSp.Text.Trim();
            string soluong = TxtSl.Text.Trim();
            string tenkhach = TxtKh.Text.Trim();
            string diachi = TxtDc.Text.Trim();
            string sdt = TxtSdt.Text.Trim();
            string query = @"UPDATE dbo.dathang SET tensp = @tensp, masp = @masp, soluong = @soluong, tenkhach = @tenkhach, diachi = @diachi, sdt = @sdt
                     WHERE masp = @masp";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@tensp", tensp);
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@soluong", soluong);
                cmd.Parameters.AddWithValue("@tenkhach", tenkhach);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally { con.Close(); }
            }
            Response.Redirect(Request.RawUrl);
        }

        protected void BtnView_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }
    }

}