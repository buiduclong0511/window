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

namespace BuiDucLong
{
    public partial class Form1 : Form
    {
        string strConnectionString = @"Data Source=DESKTOP-BL5V4B0;Initial Catalog=QLBanHang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlCommand cmd = null;

        public Form1()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            da = new SqlDataAdapter("SELECT * FROM SanPham", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvSanPham.DataSource = dt;
        }

        void LoadCombo()
        {
            da = new SqlDataAdapter("SELECT * FROM LoaiSP", conn);
            dt = new DataTable();
            da.Fill(dt);
            cbLoaiSP.DataSource = dt;
            cbLoaiSP.DisplayMember = "TenLoai";
            cbLoaiSP.ValueMember = "MaLoai";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            LoadData();
            LoadCombo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            string sql = "exec ThemSanPham '" + txtMaSP.Text + "', N'" + txtTenSanPham.Text + "', '" + cbLoaiSP.SelectedValue + "', " + txtDonGia.Text;
            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            } catch
            {
                MessageBox.Show("Trùng mã sản phẩm!");
            }
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            string sql = "delete from SanPham where MaSP = '" + txtMaSP.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            string sql = "update SanPham set TenSP = '" + txtTenSanPham.Text 
                + "', MaLoai = '" + cbLoaiSP.SelectedValue + "', DonGia = " + txtDonGia.Text 
                + " where MaSP = '" + txtMaSP.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void dgvSanPham_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSP.Text = dgvSanPham.Rows[dong].Cells[0].Value.ToString();
            txtTenSanPham.Text = dgvSanPham.Rows[dong].Cells[1].Value.ToString();
            cbLoaiSP.SelectedValue = dgvSanPham.Rows[dong].Cells[2].Value.ToString();
            txtDonGia.Text = dgvSanPham.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = "select * from SanPham where MaLoai = '" + cbLoaiSP.SelectedValue + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvSanPham.DataSource = dt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            LoadData();
        }
    }
}
