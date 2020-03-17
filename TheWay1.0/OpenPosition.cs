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
    public partial class OpenPosition : Form
    {
       // public string connection = @"Data Source=SA2WKS0265\SQLEXPRESS;Initial Catalog=TheWay;Integrated Security=True";
        public void LoadDataCombobox()
        {
            //combbox PAIR
            ModelDataInterfaceDataContext db = new ModelDataInterfaceDataContext(Connection.GetStringConnection());
            var pairsss = from table in db.PAIRs
                          select table.PairName;
            cmbPair.DataSource = pairsss;

            //combobox Status
            var statuss = from table in db.STATUSSes
                          select table.StatusName;
            cmbstatus.DataSource = statuss;

        }
        public OpenPosition()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                ModelDataInterfaceDataContext db = new ModelDataInterfaceDataContext(Connection.GetStringConnection());
                POSITION openFrm = new POSITION();
                openFrm.IdPair = cmbPair.SelectedIndex + 1;
                openFrm.IdStatus = cmbstatus.SelectedIndex + 1;
                openFrm.Entryprice = float.Parse(txtEntry.Text);
                openFrm.Stoploss = float.Parse(txtSL.Text);
                openFrm.TakeProfit = float.Parse(txtTP.Text);
                openFrm.DateOpen = dtpDateOpen.Value;
                openFrm.NoteOpen = rtbNoteOpen.Text;
                openFrm.NoteClosed = "";
                openFrm.IdResult = 3;
                
                OpenFileDialog fop = new OpenFileDialog();
                fop.InitialDirectory = @"D:\project\NhatKyGiaoDich\";
                fop.Filter = "[png]|*.png";
                if (fop.ShowDialog() == DialogResult.OK)
                {
                    FileStream FS = new FileStream(@fop.FileName, FileMode.Open, FileAccess.Read);
                    byte[] img = new byte[FS.Length];
                    FS.Read(img, 0, Convert.ToInt32(FS.Length));
                    openFrm.ImageBinary = img;
                    openFrm.ImageBinaryClose = img;
                }
                db.POSITIONs.InsertOnSubmit(openFrm);
                db.SubmitChanges();
                MessageBox.Show("Saved!!!");

                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
                ((Form1)f).ResetDataGridview();
                ((Form1)f).LoadOpenningPosition();
                ((Form1)f).LoadClosedPositions();
                this.Close();
            }
            catch (Exception ef)
            {

                MessageBox.Show(ef.ToString());
            }
        }

        private void OpenPosition_Load(object sender, EventArgs e)
        {
            LoadDataCombobox();
        }
    }
}
