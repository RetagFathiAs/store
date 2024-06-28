using ph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace book
{
  public partial class new_book : Form
  {
    setconnection se = new setconnection();
    DataSet ds = new DataSet();
    string query;
    public new_book()
    {
      InitializeComponent();
    }
    void fillcombo1()
    {
      try { 
      comboBox1.Items.Clear();
      comboBox1.Text = "";
      query = "select class_name from class_table ;";
      ds = se.getdata(query);
       
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
         comboBox1.Items.Add(ds.Tables[0].Rows[i][0]);
        }
        
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);

      }
    }

    

    private void button2_Click(object sender, EventArgs e)
    {
      
        OpenFileDialog dlg = new OpenFileDialog();
        dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
        if (dlg.ShowDialog() == DialogResult.OK)
        {
          string picpath = dlg.FileName.ToString();
          textBox_image_path.Text = picpath;
          pictureBox1.ImageLocation = picpath;
        }
      
    }

    private void new_book_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      byte[] imageBt = null;
      FileStream fstream = new FileStream(this.textBox_image_path.Text, FileMode.Open, FileAccess.Read);
      BinaryReader br = new BinaryReader(fstream);
      imageBt = br.ReadBytes((int)fstream.Length);
     ;
      query = "insert into book_table (book_num,book_name,class_name,book_image,class_num)values('" + this.booknumtex.Text + "',N'" + this.booknametex.Text + "',N'" + this.comboBox1.Text + "','"+imageBt+"','" + classnumtex.Text + "');";
      try
      {
        se.setData(query);

        MessageBox.Show("تمت عملية الحفظ");
        this.booknumtex.Text = "";
        this.comboBox1.Text = "";
        this.booknametex.Text = "";
        this.classnumtex.Text = "";
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);

      }
     


    }

    private void button3_Click(object sender, EventArgs e)
    {
      dashboard d = new dashboard();
      d.Show();
      this.Close();
    }
  }
}
