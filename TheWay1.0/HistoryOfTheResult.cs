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
    public partial class HistoryOfTheResult : Form
    {
        public int _id;
        public HistoryOfTheResult(int vl)
        {
            _id = vl;
            InitializeComponent();
        }
        public void LoadImage()
        {
            try
            {
                //load openposition
                ModelDataInterfaceDataContext db = new ModelDataInterfaceDataContext(Connection.GetStringConnection());
                var imageBinary = from table in db.POSITIONs
                                  where table.ID == _id
                                  select table.ImageBinary;


                //byte[] y = imageBinary.First().ToArray();
                MemoryStream ms = new MemoryStream(imageBinary.First().ToArray());
                pbopen.Image = Image.FromStream(ms);
                pbopen.SizeMode = PictureBoxSizeMode.StretchImage;
                pbopen.Refresh();

               // if (_showclosed)
                {
                    var noteOpen = from table in db.POSITIONs
                                   where table.ID == _id
                                   select table.NoteOpen;
                    rtbopen.Text = noteOpen.First().ToString();
                }
                //////////////////
                var imageBinaryclosed = from table in db.POSITIONs
                                  where table.ID == _id
                                  select table.ImageBinaryClose;


                //byte[] y = imageBinary.First().ToArray();
                MemoryStream mss = new MemoryStream(imageBinaryclosed.First().ToArray());
                pbclosed.Image = Image.FromStream(mss);
                pbclosed.SizeMode = PictureBoxSizeMode.StretchImage;
                pbclosed.Refresh();

                {
                    var noteOpen = from table in db.POSITIONs
                                   where table.ID == _id
                                   select table.NoteClosed;
                    rtbclosed.Text = noteOpen.First().ToString();
                }
            }
            catch (Exception eff)
            {

                MessageBox.Show(eff.ToString());
            }


        }
        private void HistoryOfTheResult_Load(object sender, EventArgs e)
        {
            LoadImage();
        }
    }
}
