using ph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace book
{
  public partial class insert_store : Form
  {
    setconnection se = new setconnection();
    DataSet ds = new DataSet();
    string query;
    public insert_store()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      
      int num = int.Parse(storephonetex.Text);
      int n = int.Parse(storenumtex.Text);
      query= "insert into store_table(store_num, store_name, city_name, store_manger, store_phone)values('" + n + "', N'" + this.storenametex.Text + "', N'" + this.storecitytex.Text + "', N'" + this.storemangertex.Text + "', N'" + num + "'); ";
      try
      {
        se.setData(query);
       

        MessageBox.Show("تمت عملية الحفظ");
        this.storenumtex.Text = "";
        this.storenametex.Text = "";
        this.storecitytex.Text = "";
        this.storemangertex.Text = "";
        this.storephonetex.Text = "";


      }
      catch (Exception ex)
      {
        MessageBox.Show("يوجد خطأ");
        MessageBox.Show(ex.Message);



      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      dashboard d = new dashboard();
      d.Show();
      this.Hide();
    }
  }
}
