using ph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace book
{
  public partial class login : Form
  {
    setconnection se = new setconnection();
     String query;
    DataSet ds;
    public static string str1;
    public static string usname1;
    public login()
    {
      
      InitializeComponent();
    }

    private void loginbtn_Click(object sender, EventArgs e)
    {
      query = "SELECT * FROM word_Table";
      ds = se.getdata(query);
      if (ds.Tables[0].Rows.Count == 0)
      {

        if (nametxt.Text == "root" && passtxt.Text == "root")
        {
         usname1 = "root";
          str1 = "  ";
          dashboard am = new dashboard();
          am.Show();
          this.Hide();
        }
        else
        {
          MessageBox.Show("Welcome , please insert the admin.");
        }
      }

      else
      {
        query = "SELECT * FROM word_Table WHERE user_name='" + nametxt.Text + "' AND pass_word='" + passtxt.Text + "'";
        ds = se.getdata(query);
        if (ds.Tables[0].Rows.Count != 0)
        {
          string role = ds.Tables[0].Rows[0][4].ToString();
          if (role == "Admin")
          {
             usname1 = ds.Tables[0].Rows[0][1].ToString();
             str1 = ds.Tables[0].Rows[0][2].ToString();
            
            dashboard am = new dashboard();
            am.Show();
            this.Hide();

          }
          else if (role == "Employee")
          {

            Employee ph = new Employee();
            ph.Show();
            this.Hide();

          }
        }
        else
        {
          MessageBox.Show("incorrect info.");
        }


      }

     
      

      
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
