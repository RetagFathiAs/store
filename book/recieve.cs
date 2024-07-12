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
  public partial class recieve : Form
  {
    setconnection se = new setconnection();
    String query;
    DataSet ds;
    public recieve()
    {
      InitializeComponent();
    }

    private void recieve_Load(object sender, EventArgs e)
    {

    }
  }
}
