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

namespace book
{
  public partial class report_book : Form
  {
    setconnection se = new setconnection();
    String query;
    DataSet ds;

    public report_book()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      query = "select * from  sarfquiry_table where book_num ='" + booknumtex.Text + "'  ;";
      ds = se.getdata(query);
      if (ds.Tables[0].Rows.Count != 0)
      {

     
        booknametex.Text= ds.Tables[0].Rows[0][3].ToString();
      booknumtex.Text = ds.Tables[0].Rows[0][2].ToString();
        bookcounttex.Text = ds.Tables[0].Rows[0][5].ToString(); 
      }
      else
      {
        MessageBox.Show("no books with this number");
      }

    }
  }
}
