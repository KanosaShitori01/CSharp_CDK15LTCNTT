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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=C203-25;Database=qlda;Integrated Security=true");
        SqlDataAdapter adap;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }
        private void fetchInfor()
        {
            string query = "SELECT * FROM DUAN; SELECT NHANVIEN.MANV, NHANVIEN.HODEM+' '+NHANVIEN.TENNV AS HOTEN,THAMGIA.SOGIOLAMVIEC " +
                "FROM NHANVIEN, THAMGIA WHERE NHANVIEN.MANV = THAMGIA.MANV";
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            DataTable dt1 = ds.Tables[0];
            DataTable dt2 = ds.Tables[1];

            cb_mada.DataSource = dt1;
            cb_mada.ValueMember = "MADA";
            cb_mada.DisplayMember = "MADA";

            txt_tenda.DataBindings.Clear();
            txt_tenda.DataBindings.Add("Text", dt1, "TENDA");

            cb_manv.DataSource = dt2;
            cb_manv.ValueMember = "MANV";
            cb_manv.DisplayMember = "HOTEN";

            txt_sgtg.DataBindings.Clear();
            txt_sgtg.DataBindings.Add("Text", dt2, "SOGIOLAMVIEC");
        }
        private void allStatus()
        {
            int tsnvtg = 0;
            int tsg = 0;
            for (int i = 0; i < dataGV.RowCount - 1; i++)
            {
                tsg += Convert.ToInt32(dataGV.Rows[i].Cells["SOGIOTG"].Value);
                tsnvtg++;
            }
            txt_tsnvtg.Text = tsnvtg.ToString();
            txt_tsg.Text = tsg.ToString();
        }
        private void activeGridData(string id)
        {
            string query = String.Format("SELECT DUAN.MADA, DUAN.TENDA, NHANVIEN.MANV, NHANVIEN.HODEM + ' ' + NHANVIEN.TENNV AS HOTEN,"+
                        "THAMGIA.SOGIOLAMVIEC FROM DUAN, NHANVIEN, THAMGIA "+
                        "WHERE DUAN.MADA = THAMGIA.MADA AND NHANVIEN.MANV = THAMGIA.MANV AND THAMGIA.TENDA=N'{0}'", id);
            adap = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            adap.Fill(dt);
            dataGV.DataSource = dt;
            allStatus();
        }
        private void activeTreeView()
        {
            adap = new SqlDataAdapter("SELECT * FROM DUAN", conn);
            dt = new DataTable(); dt.Clear();
            adap.Fill(dt);
            trv_da.Nodes.Clear();
            trv_da.BeginUpdate();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string query = String.Format("SELECT NHANVIEN.MANV, NHANVIEN.HODEM,"+ 
                "NHANVIEN.TENNV, NHANVIEN.HODEM + ' ' + NHANVIEN.TENNV AS HOTEN FROM "+ 
                "THAMGIA, NHANVIEN WHERE THAMGIA.MANV = NHANVIEN.MANV AND "+
                "THAMGIA.MADA = THAMGIA.MADA AND THAMGIA.TENDA = N'{0}'", dt.Rows[i]["TENDA"].ToString());  
                trv_da.Nodes.Add(dt.Rows[i]["TENDA"].ToString());
                SqlDataAdapter datg = new SqlDataAdapter(query, conn);
                DataTable dt_tg = new DataTable();
                dt_tg.Clear();
                datg.Fill(dt_tg);
                for (int j = 0; j < dt_tg.Rows.Count; j++)
                {
                    trv_da.Nodes[i].Nodes.Add(dt_tg.Rows[j]["HOTEN"].ToString());
                }
            }
            trv_da.EndUpdate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            activeTreeView();
            fetchInfor();
        }
        private void TreeNodeChild()
        {
            foreach (TreeNode node in trv_da.Nodes)
            {
                if (node.IsSelected)
                {
                    activeGridData(node.Text);
                }
            }
        }
        private void trv_da_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNodeChild();
        }

        private void cb_mahd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_manv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = String.Format("INSERT INTO THAMGIA(MADA,MANV,TENDA,SOGIOLAMVIEC)"+ 
            " VALUES('{0}', '{1}', N'{2}', '{3}')", cb_mada.Text, cb_manv.SelectedValue, txt_tenda.Text, txt_sgtg.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Connection.Open();
            if (txt_sgtg.Text != "")
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã lưu");
                TreeNodeChild();
            }
            else
            {
                MessageBox.Show("Not Allows For Null");
            }
            cmd.Connection.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
