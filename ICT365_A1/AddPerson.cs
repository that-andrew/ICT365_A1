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
    public partial class AddPerson :  Form
    {
        
        public Person np;
        public PointLatLng loc;

        public AddPerson()
        {
            InitializeComponent();
            
        }
        public AddPerson(PointLatLng sp)
        {
            InitializeComponent();
            lbl_clickedOnMap.Text = sp.ToString();
            loc = sp;
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            Console.WriteLine("AddPerson Form Loaded");
        }

        private void TextBox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_StreetNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_StreetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Suburb_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_State_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Country_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_PostCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_AddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog personImage = new OpenFileDialog
            {
                Title = "Select a Image",
                Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*"
            };
           
            
            Console.WriteLine(personImage.FileName);

            //3RD-PARTY CODE REFFERENCE
            // link.awgm.co/3651 
            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Person\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }

            if (personImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //personImage.FileName = np.PhoneNumber.ToString();
                    string imageFileName = personImage.SafeFileName;
                    string filepath = personImage.FileName;
                    File.Copy(filepath, appPath + imageFileName);
                    np.ImagePath = appPath + imageFileName;
                    Console.WriteLine("Image Saved to: " + np.ImagePath);
                    pictureBox_Person.Image = new Bitmap(personImage.OpenFile());
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                personImage.Dispose();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked SAVE button");


            Close();
        }
    

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SavePerson()
        {
            Person np = new Person();

            np.Name.FirstName = textBox_FirstName.Text;
            np.Name.LastName = textBox_LastName.Text;

            var phoneAccepted = np.ValidatePhoneNumber(textBox_Phone.Text);
            if (phoneAccepted)
            {
                Console.WriteLine("Valid Phone Number");
            }
            else
            {
                MessageBox.Show("Oops!", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Invalid Phone Number");
                return;
            }
            np.Address.Number = textBox_StreetNumber.Text;
            np.Address.Street = textBox_StreetName.Text;
            np.Address.City = textBox_Suburb.Text;
            np.Address.State = textBox_State.Text;
            np.Address.Country = textBox_Country.Text;
            np.Address.PostCode = textBox_PostCode.Text;
            np.Address.Location = loc;

            MapConfig.PeopleDictionary = MapConfig.personData.AddPerson(np, MapConfig.PeopleDictionary);
            Console.WriteLine("Person Added at: " + np.Address.Location.ToString());



            //Saving is Broken :(
            //PersonData.SavePeople();


            Console.WriteLine("Saved New Person: " + np.Name.ToString());
        }
    }
}
