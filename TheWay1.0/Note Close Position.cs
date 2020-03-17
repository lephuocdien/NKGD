using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWay1._0
{
    public partial class Note_Close_Position : Form
    {
        public int _id;
        public Note_Close_Position(int vl)
        {
            _id = vl;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelDataInterfaceDataContext db = new ModelDataInterfaceDataContext(Connection.GetStringConnection());
            var opennings = (from pos in db.POSITIONs
                                    where pos.ID == _id
                                    select pos).First();
            OpenFileDialog fop = new OpenFileDialog();
            fop.InitialDirectory = @"D:\project\NhatKyGiaoDich\";
            fop.Filter = "[png]|*.png";
            if (fop.ShowDialog() == DialogResult.OK)
            {
                FileStream FS = new FileStream(@fop.FileName, FileMode.Open, FileAccess.Read);
                byte[] img = new byte[FS.Length];
                FS.Read(img, 0, Convert.ToInt32(FS.Length));
                opennings.ImageBinaryClose = img;
            }
            opennings.IdStatus = 2;
            opennings.NoteClosed = rtbNoteClose.Text;
            opennings.IdResult = cbbTypeclose.SelectedIndex + 1;
            
            db.SubmitChanges();

            ///note
            //
           
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
            ((Form1)f).ResetDataGridview();
            ((Form1)f).LoadOpenningPosition();
            ((Form1)f).LoadClosedPositions();
            // ((Form1)f).idresult = cbbTypeclose.SelectedIndex + 1;
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
