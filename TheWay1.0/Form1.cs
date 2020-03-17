using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWay1._0
{
    public partial class Form1 : Form
    {
        
      
        
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadOpenningPosition()
        {
            ModelDataInterfaceDataContext db = new ModelDataInterfaceDataContext(Connection.GetStringConnection());
            var opennings = from pos in db.POSITIONs
                            join sta in db.STATUSSes on  pos.IdStatus equals sta.ID
                            
                            join cucucuc in db.PAIRs on pos.IdPair equals cucucuc.ID

                            join tableresult in db.RESULTs on pos.IdResult equals tableresult.ID
                            where sta.StatusName== "Openning"
                            select new { 
                                
                               pos.ID,cucucuc.PairName, pos.DateOpen };
            dtgOpenning.DataSource = opennings;
            dtgOpenning.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgOpenning.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgOpenning.AllowUserToResizeRows = false;
            DataGridViewButtonColumn btnsee = new DataGridViewButtonColumn();
            btnsee.HeaderText = "Information";
            btnsee.Text = "See";
            btnsee.Name = "btn";
            dtgOpenning.Columns.Add(btnsee);
            btnsee.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Status";
            btn.Text = "Close!";
            btn.Name = "btn";
            dtgOpenning.Columns.Add(btn);
            btn.UseColumnTextForButtonValue = true;
        }
        public void LoadClosedPositions()
        {
            
            ModelDataInterfaceDataContext db = new ModelDataInterfaceDataContext(Connection.GetStringConnection());
            var opennings = from pos in db.POSITIONs
                            join sta in db.STATUSSes on pos.IdStatus equals sta.ID

                            join cucucuc in db.PAIRs on pos.IdPair equals cucucuc.ID

                            
                            where sta.StatusName == "Closed"
                            select new
                            {

                                pos.ID,
                                cucucuc.PairName,
                                pos.DateOpen
                            };
            dtgClosedPosition.DataSource = opennings;
            dtgClosedPosition.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgClosedPosition.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgClosedPosition.AllowUserToResizeRows = false;
            DataGridViewButtonColumn btnsee = new DataGridViewButtonColumn();
            btnsee.HeaderText = "Information";
            btnsee.Text = "See";
            btnsee.Name = "btn";
            dtgClosedPosition.Columns.Add(btnsee);
            btnsee.UseColumnTextForButtonValue = true;

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //load openning positions
            LoadOpenningPosition();
            ///load closed position
            LoadClosedPositions();
            ///
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public void ResetDataGridview()
        {
            dtgOpenning.Rows.Clear();
            dtgOpenning.Columns.Clear();
            dtgOpenning.Refresh();
            dtgClosedPosition.Rows.Clear();
            dtgClosedPosition.Columns.Clear();
            dtgClosedPosition.Refresh();
        }
        private void dtgOpenning_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ModelDataInterfaceDataContext db = new ModelDataInterfaceDataContext(Connection.GetStringConnection());
            if (this.dtgOpenning[e.ColumnIndex, e.RowIndex].Value.ToString() == "Close!")//Closed
            {
                //Why close
                int vale = Int32.Parse(this.dtgOpenning[0, e.RowIndex].Value.ToString());
                Note_Close_Position f = new Note_Close_Position(vale);
                DialogResult ok = f.ShowDialog();
               
            }else if(this.dtgOpenning[e.ColumnIndex, e.RowIndex].Value.ToString() == "See")
            {
                int vale = Int32.Parse(this.dtgOpenning[0, e.RowIndex].Value.ToString());
                HistoryOfTheTrue fm = new HistoryOfTheTrue(vale,true);
                fm.Text = "History Of The True " + this.dtgOpenning[1, e.RowIndex].Value.ToString() + " " + this.dtgOpenning[2, e.RowIndex].Value.ToString();
                fm.ShowDialog();
            }
        
           // MessageBox.Show(e.ColumnIndex.ToString());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenPosition fm = new OpenPosition();
            fm.ShowDialog();
        }

        private void dtgClosedPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (this.dtgClosedPosition[e.ColumnIndex, e.RowIndex].Value.ToString() == "See")
            {
                int vale = Int32.Parse(this.dtgClosedPosition[0, e.RowIndex].Value.ToString());
                /////other form
                HistoryOfTheResult fm = new HistoryOfTheResult(vale);
                fm.Text = "History Of The Result " + this.dtgClosedPosition[1, e.RowIndex].Value.ToString() + " " + this.dtgClosedPosition[2, e.RowIndex].Value.ToString();
                fm.ShowDialog();
            }
        }

        private void addPairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPair frm = new AddPair();
            frm.ShowDialog();
           
        }
    }
}
