using ph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace book
{
  public partial class new_class : Form
  {
    setconnection se = new setconnection();
    DataSet ds = new DataSet();
    string query;
    public new_class()
    {
      InitializeComponent();
    }

    private void exitbtn_Click(object sender, EventArgs e)
    {
      dashboard d = new dashboard();
      d.Show();
      this.Close();
    }

    private void savebtn_Click(object sender, EventArgs e)
    {
       query = "insert into class_table (class_num,class_name)values('" + int.Parse(classnumtext.Text) + "',N'" + this.classnametext.Text + "');";
      try
      {
        se.setData(query);
        MessageBox.Show("تمت عملية الحفظ");
        this.classnumtext.Text = "";
        this.classnametext.Text = "";

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);

      }
      

    }
  }
}
