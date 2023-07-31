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

namespace ders_programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + Application.StartupPath + "\\ders_programi.accdb");
        OleDbDataAdapter da;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        void alinacak_dersler_datagrid_temizle()
        {
            dataGridView1.DataSource = "";
            bs.DataSource = "";
            dt.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = 0;
            a = comboBox1.SelectedIndex;
            switch (a)
            {
                case 0:
                    alinacak_dersler_datagrid_temizle();
                    da = new OleDbDataAdapter("select ders_adi,alacagi_ders_saati from dersler,a_9 where dersler.ders_no=a_9.alacagi_ders_no", con);
                    da.Fill(dt);
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[0].Width = 140;
                    break;
                case 1:
                    alinacak_dersler_datagrid_temizle();
                    da = new OleDbDataAdapter("select ders_adi,alacagi_ders_saati from dersler,b_9 where dersler.ders_no=b_9.alacagi_ders_no", con);
                    da.Fill(dt);
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[0].Width = 140;
                    break;
                case 2:
                    alinacak_dersler_datagrid_temizle();
                    da = new OleDbDataAdapter("select ders_adi,alacagi_ders_saati from dersler,c_9 where dersler.ders_no=c_9.alacagi_ders_no", con);
                    da.Fill(dt);
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[0].Width = 140;
                    break;
                case 3:
                    alinacak_dersler_datagrid_temizle();
                    da = new OleDbDataAdapter("select ders_adi,alacagi_ders_saati from dersler,a_10 where dersler.ders_no=a_10.alacagi_ders_no", con);
                    da.Fill(dt);
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[0].Width = 140;
                    break;
                case 4:
                    alinacak_dersler_datagrid_temizle();
                    da = new OleDbDataAdapter("select ders_adi,alacagi_ders_saati from dersler,b_10 where dersler.ders_no=b_10.alacagi_ders_no", con);
                    da.Fill(dt);
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[0].Width = 140;
                    break;
                case 5:
                    alinacak_dersler_datagrid_temizle();
                    da = new OleDbDataAdapter("select ders_adi,alacagi_ders_saati from dersler,c_10 where dersler.ders_no=c_10.alacagi_ders_no", con);
                    da.Fill(dt);
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[0].Width = 140;
                    break;
                case 6:
                    alinacak_dersler_datagrid_temizle();
                    da = new OleDbDataAdapter("select ders_adi,alacagi_ders_saati from dersler,a_11 where dersler.ders_no=a_11.alacagi_ders_no", con);
                    da.Fill(dt);
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[0].Width = 140;
                    break;
                case 7:
                    alinacak_dersler_datagrid_temizle();
                    da = new OleDbDataAdapter("select ders_adi,alacagi_ders_saati from dersler,b_11 where dersler.ders_no=b_11.alacagi_ders_no", con);
                    da.Fill(dt);
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[0].Width = 140;
                    break;
                case 8:
                    alinacak_dersler_datagrid_temizle();
                    da = new OleDbDataAdapter("select ders_adi,alacagi_ders_saati from dersler,c_11 where dersler.ders_no=c_11.alacagi_ders_no", con);
                    da.Fill(dt);
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[0].Width = 140;
                    break;
                case 9:
                    alinacak_dersler_datagrid_temizle();
                    da = new OleDbDataAdapter("select ders_adi,alacagi_ders_saati from dersler,a_12 where dersler.ders_no=a_12.alacagi_ders_no", con);
                    da.Fill(dt);
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[0].Width = 140;
                    break;
                case 10:
                    alinacak_dersler_datagrid_temizle();
                    da = new OleDbDataAdapter("select ders_adi,alacagi_ders_saati from dersler,b_12 where dersler.ders_no=b_12.alacagi_ders_no", con);
                    da.Fill(dt);
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[0].Width = 140;
                    break;
                case 11:
                    alinacak_dersler_datagrid_temizle();
                    da = new OleDbDataAdapter("select ders_adi,alacagi_ders_saati from dersler,c_12 where dersler.ders_no=c_12.alacagi_ders_no", con);
                    da.Fill(dt);
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[0].Width = 140;
                    break;
            }
        }
    }
}
