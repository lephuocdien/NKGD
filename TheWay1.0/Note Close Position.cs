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
    public partial class Note_Close_Position : Form
    {
        public Note_Close_Position()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
           ( (Form1)f).reasonToClose = rtbNoteClose.Text;
            ((Form1)f).idresult = cbbTypeclose.SelectedIndex + 1;
            this.Close();
        }
        private void LoadDataCombobox()
        {
            //combbox PAIR
            ModelDataInterfaceDataContext db = new ModelDataInterfaceDataContext(Connection.GetStringConnection());
            var pairsss = from table in db.RESULTs
                          select table.NameResult;
            cbbTypeclose.DataSource = pairsss;

            
        }
        private void Note_Close_Position_Load(object sender, EventArgs e)
        {
            //load data to combobox
            LoadDataCombobox();
        }

        private void Note_Close_Position_FormClosing(object sender, FormClosingEventArgs e)
        {
           
          }
    }
}
