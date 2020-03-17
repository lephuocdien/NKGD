using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWay1._0
{
    public partial class AddPair : Form
    {
        public AddPair()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelDataInterfaceDataContext db = new ModelDataInterfaceDataContext(Connection.GetStringConnection());
            PAIR ob = new PAIR();
            ob.PairName = textBox1.Text;
            db.PAIRs.InsertOnSubmit(ob);
            db.SubmitChanges();
            this.Close();

        }
    }
}
