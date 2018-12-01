using GMap.NET;
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

namespace ICT365_A1
{
    public partial class AddForm : Form
    {
        private static PointLatLng clickedLoc;

        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(PointLatLng sp)
        {
            InitializeComponent();
            clickedLoc = sp;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked Cancel button");
            Close();
        }

        private void Btn_Add_Video_Click(object sender, EventArgs e)
        {
            Console.WriteLine("New Video");
            Close();
        }

        private void Btn_Add_Route_Click(object sender, EventArgs e)
        {
            Console.WriteLine("New Route");
            Close();
        }

        private void Btn_Add_Person_Click(object sender, EventArgs e)
        {
            Console.WriteLine("New Person");
            AddPerson addPerson = new AddPerson(clickedLoc);
            Close();
            addPerson.ShowDialog();
            
        }

        private void Btn_Add_Photo_Click(object sender, EventArgs e)
        {
            Console.WriteLine("New Photo");
            Close();
        }
    }
}
