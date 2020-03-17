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
    public partial class HistoryOfTheTrue : Form
    {
        //public string connection = @"Data Source=SA2WKS0265\SQLEXPRESS;Initial Catalog=TheWay;Integrated Security=True";
        public int _id;
        public bool _showclosed;
        public HistoryOfTheTrue(int id,bool u)
        {
            _id = id;
            _showclosed = u;
            InitializeComponent();
        }
        public void LoadImage()
        {
            try
            {
                ModelDataInterfaceDataContext db = new ModelDataInterfaceDataContext(Connection.GetStringConnection());
                var imageBinary = from table in db.POSITIONs
                                  where table.ID == _id
                                  select table.ImageBinary;


                //byte[] y = imageBinary.First().ToArray();
                MemoryStream ms = new MemoryStream(imageBinary.First().ToArray());
                picImage.Image = Image.FromStream(ms);
                picImage.SizeMode = PictureBoxSizeMode.StretchImage;
                picImage.Refresh();

                if (_showclosed)
                {
                    var noteOpen = from table in db.POSITIONs
                               where table.ID == _id
                               select table.NoteOpen;
                 rtbNoteOpen.Text = noteOpen.First().ToString();
                }
                else
                {
                    var noteOpen = from table in db.POSITIONs
                                   where table.ID == _id
                                   select table.NoteClosed;
                    rtbNoteOpen.Text = noteOpen.First().ToString();
                }
            }
            catch (Exception eff)
            {

                MessageBox.Show(eff.ToString());
            }
            
           
        }
        private void HistoryOfTheTrue_Load(object sender, EventArgs e)
        {
            LoadImage();
        }
    }
}
