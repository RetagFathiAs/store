using ph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book
{
  public partial class excel_import : Form
  {
    
    public excel_import()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        this.textBox_path.Text = openFileDialog1.FileName;

      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      string pathconn  = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox_path.Text + ";Extended Properties='Excel 12.0 Xml;HDR=YES;'";

      OleDbConnection conn = new OleDbConnection(pathconn);
      OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + textBox_sheet.Text + "$]", conn);
      DataTable dt = new DataTable();
      myDataAdapter.Fill(dt);
      dataGridView1.DataSource = dt;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      string constring = (@"Data Source=DESKTOP-VSMEBK0\SQLEXPRESS;Initial Catalog=manahg;Integrated Security=True");
      for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
      {

        string Query = "INSERT INTO books_table (book_num, book_name, class_name) VALUES (" + dataGridView1.Rows[i].Cells[0].Value + ", N'" + dataGridView1.Rows[i].Cells[1].Value + "', N'" + dataGridView1.Rows[i].Cells[2].Value + "')";
        SqlConnection conDataBase = new SqlConnection(constring);
        SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
        SqlDataReader myReader;

        try
        {
          conDataBase.Open();
          myReader = cmdDataBase.ExecuteReader();

          // MessageBox.Show("تمت عملية الحفظ");

          // dataGridView1.Rows.Clear();

        }


       
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);

        }

      }
      MessageBox.Show("تمت عملية الحفظ");
      dataGridView1.Rows.Clear();

    }
  }
}
