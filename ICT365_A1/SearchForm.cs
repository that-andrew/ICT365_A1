using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT365_A1
{
    public partial class SearchForm : MapForm
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Opened Search Form");
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked SEARCH button");
            //Search.NewSearch("01/Jan/2017 21:44:36");
            
            
            var displayList = Search.NewSearch("03/Jan/2017 03:24:10");
            this.listView1.Columns.Add("Date \\ Time", 300);
            this.listView1.Columns.Add("Event Type", 300);

            ListViewItem item;
            string[] itemArr = new string[2];

            foreach (var i in displayList)
            {
                
                itemArr[0] = i.DateTimeStamp.ToString();
                itemArr[1] = i.Context;
                
                item = new ListViewItem(itemArr);
                
                this.listView1.Items.Add(item);
            }
            this.label_numberOfResults.Text = displayList.Count.ToString();
            this.label_numberOfResults.Visible = true;
            this.listView1.Visible = true;



            //Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked CANCEL button");
            Close();
        }

        private void Search_Textbox_Changed(object sender, EventArgs e)
        {
            Console.WriteLine("Search TextBox Changed");
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Search listView1_SelectedIndexChanged triggered");
            Console.WriteLine(e.ToString());
            
        }

        private void TextBox_Search_Click(object sender, EventArgs e)
        {
            this.textBox_Search.Text = "";
        }
        

    }
}
