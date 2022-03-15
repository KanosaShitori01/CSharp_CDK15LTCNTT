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
namespace OnTapADO
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.;Database=QuanLySinhVien;Integrated Security=true");
        SqlDataAdapter adap;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }
        private void activeTreeView()
        {
            adap = new SqlDataAdapter("SELECT * FROM LOP", conn);
            dt = new DataTable();
            dt.Clear();
            adap.Fill(dt);
            trv_dsl.Nodes.Clear();
            trv_dsl.BeginUpdate();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string TENLOP = dt.Rows[i]["TENLOP"].ToString();
                trv_dsl.Nodes.Add(TENLOP);
                string query = String.Format("SELECT SINHVIEN.MASV, SINHVIEN.MALOP, LOP.MALOP, "+
                "SINHVIEN.HOTEN FROM SINHVIEN, LOP "+ 
                "WHERE SINHVIEN.MALOP = LOP.MALOP AND LOP.TENLOP = N'{0}'", 
                TENLOP);
                SqlDataAdapter adap_Child = new SqlDataAdapter(query, conn);
                DataTable dt_Child = new DataTable();
                adap_Child.Fill(dt_Child);
                for (int j = 0; j < dt_Child.Rows.Count; j++)
                {
                    string TENSV = dt_Child.Rows[j]["HOTEN"].ToString();
                    trv_dsl.Nodes[i].Nodes.Add(TENSV);
                }
            }
            trv_dsl.EndUpdate();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            activeTreeView();
            getIDClasses();
        }

        private void dataGV_sv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string reverseString(string str){
            string[] arr = str.Split(new Char[] { '/' });
            Array.Reverse(arr);
            string newstr = string.Join("/", arr); 
            return newstr;
        }
        private void AddStudent()
        {
            string query = String.Format("INSERT INTO SINHVIEN(MASV, HOTEN, NGAYSINH, "+
            "GIOITINH, QUEQUAN, MALOP) VALUES"+
            "('{0}', N'{1}', '{2}', '{3}', N'{4}', '{5}')", txt_masv.Text, txt_hoten.Text,reverseString(dtp_ngaysinh.Text), 
            checkb_nam.Checked, txt_quequan.Text, cb_lophoc.Text);
            //MessageBox.Show(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            if (txt_masv.Text != "" || txt_hoten.Text != "" ||
            txt_quequan.Text != "" || cb_lophoc.Text != "" || dtp_ngaysinh.Text != "")
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
          
            cmd.Connection.Close();
        }
        private void sumTS_All()
        {
            int tssv_nam = 0;
            int tssv_nu = 0;
            for (int i = 0; i < dataGV_sv.Rows.Count - 1; i++)
            {
                if (dataGV_sv.Rows[i].Cells["GIOITINH"].Value.ToString() == "Nam")
                {
                    tssv_nam++;
                }
                else tssv_nu++;
            }
            lb_tssv_nam.Text = tssv_nam.ToString();
            lb_tssv_nu.Text = tssv_nu.ToString();
        }
        private void getGender(string id)
        {
            adap = new SqlDataAdapter("SELECT GIOITINH FROM SINHVIEN, LOP WHERE SINHVIEN.MALOP = LOP.MALOP"+
            " AND LOP.TENLOP = N'"+id+"'", conn);
            dt = new DataTable();
            adap.Fill(dt);
            for (int i = 0; i < dataGV_sv.RowCount - 1; i++)
            {
                string checkGT = dt.Rows[i]["GIOITINH"].ToString();
                dataGV_sv.Rows[i].Cells["GIOITINH"].Value = (checkGT == "True") ? "Nam" : "Nữ";
            }
        }
        private void getIDClasses()
        {
            adap = new SqlDataAdapter("SELECT * FROM LOP", conn);
            dt = new DataTable();
            adap.Fill(dt);
            cb_lophoc.DataSource = dt;
            cb_lophoc.DisplayMember = "MALOP";
            cb_lophoc.ValueMember = "MALOP";
        }
        private void activeDataGrid(string id)
        {
            string query = String.Format("SELECT MASV, HOTEN, NGAYSINH, "+
            "QUEQUAN, SINHVIEN.MALOP FROM SINHVIEN, LOP "+
            "WHERE SINHVIEN.MALOP = LOP.MALOP AND LOP.TENLOP = N'{0}'", id);
            adap = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            adap.Fill(dt);
            dataGV_sv.DataSource = dt;
            getGender(id);
            sumTS_All();
        }
        private void trv_dsl_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in trv_dsl.Nodes)
            {
                if (node.IsSelected)
                {
                    activeDataGrid(node.Text);
                }
            }
        }

        private void dtp_ngaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            AddStudent();
        }
    }
}
