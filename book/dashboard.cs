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
  public partial class dashboard : Form
  {
    setconnection se = new setconnection();
    String query;
    DataSet ds;
    
    public dashboard()
    {
      InitializeComponent();
    }

    private void dashboard_Load(object sender, EventArgs e)
    {

      storelebel.Text = login.str1;
      uslebel.Text = login.usname1;

    }

    private void button1_Click(object sender, EventArgs e)
    {
      insert_store ins = new insert_store();
      ins.Show();
      this.Hide();

    }

    private void newbookstr_Click(object sender, EventArgs e)
    {
      new_book n = new new_book();
      n.Show();
      this.Close();
    }

    private void newclassstr_Click(object sender, EventArgs e)
    {
      new_class nc = new new_class();
      nc.Show();
      this.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      
      Application.Exit();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      recieve r = new recieve();
      r.Show();
      this.Close();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      report_book report_Book = new report_book();
      report_Book.Show(); 
      this.Close();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      excel_import excel = new excel_import();
      excel.Show();
      this.Close(); 
    }
  }
}
