using Moonbase_Alpha.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase_Alpha
{
    public partial class FormMain : Form
    {
        //background image applied to the form upon navigating to the landers.
        private Bitmap HazardousImage = Resources.Hazardous_Material_storage;
        //background image applied to the form upon navigating to the landers.
        private Bitmap ExcavationImage = Resources.Main_excavation_area;
        //background image applied to the form upon navigating to the landers.
        private Bitmap MarsBaseImage = Resources.Mars_Base;
        //background image applied to the form upon navigating to the landers.
        private Bitmap VehiclesImage = Resources.Vehicles_we_use;
        //background image applied to the form upon navigating to the landers.
        private Bitmap EarthImage = Resources.Earth_picture;

        //random number generator for randomizing the descriptions
        private Random randomGenerator = new Random();
        private int randomNum;

        //title of this moon base
        private string baseTitle = "Sereniy Base Alpha";

        //the room the user is currently in
        private string currentRoomTitle = "";

        //area title and information display
        private string serenityBaseTitle = "Serenity Base Alpha";
        private string serenityBaseDescription = "This is Serenity base from the ridge to the north. " +
            "You can see our advanced Biodome, vehicle operations center, and main living area.";

        //area title and information display
        private string hazardousTitle = "Hazardous Waste";
        private string hazardousDescription = "This is the area where we store all hazardous waste." +
            " I.E. nuclear materies or human waste. We use this material to power the base and for recycling.";

        //area title and information display
        private string earthTitle = "Earth View";
        private string earthDescription = "From this angle of the base we can see ou beloved Earth clearly. " +
            "We have workers doing odd jobs here and there, gathering materials for research and materials for production on aditional bases.";

        //area title and information display
        private string vehicleYardTitle = "Vehicle Yard";
        private string vehicleYardDescription = "This is our vehicle yard. We have many advanced equipment here for use around the Moon and space. " +
            "You can see a few of our vehicles sitting out for display, our Moon Buggy, Flat Bed Buggy, and our Heavy Carrier Buggy";

        //area title and information display
        private string excavationTitle = "Excavation Site";
        private string excavationDescription = "This is our current Excavation Site. Here we are gathering all the materials we need " +
            "for research and development. We also are adapting these materials for future builds around the Moon.";


        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }
        //label object for display
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        //text box object for display
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //group box to display location for user
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //text box for displaying descriptions
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //label for descriptions box
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        //hazardous waste button
        private void button2_Click(object sender, EventArgs e)
        {
            // When entering room it picks a random discription
            RandomNumberGenerator();

            //swap background image
            this.BackgroundImage = HazardousImage;

            //set rooms title and description
            RoomNameBox.Text = hazardousTitle;
            //RoomDescriptionBox.Text = hazardousDescription;

            //random descriptions
            switch (randomNum)
            {
                case 0: 
                    RoomDescriptionBox.Text = "You have entered Cthulhu's realm of sparkles and sunshine!";
                    break;
                case 1:
                    RoomDescriptionBox.Text = "Yo mama so fat, when she moons people they turn into werewolves!";
                    break;
                case 2:
                    RoomDescriptionBox.Text = "One time at band camp...";
                    break;
                case 3:
                    RoomDescriptionBox.Text = "Never gonna give you up\r\nNever gonna let you down\r\nNever gonna" +
                        " run around and desert you\r\nNever gonna make you cry\r\nNever gonna say goodbye\r\nNever gonna" +
                        " tell a lie and hurt you";
                    break;
                case 4:
                    RoomDescriptionBox.Text = "Klaatu barada nikto";
                    break;
                default:
                    RoomDescriptionBox.Text = hazardousDescription;
                    break;
            }

            //set current location
            currentRoomTitle = hazardousTitle;

            //check button and turn off or on
            NavigationButtonCheck();
        }

        //earth view button
        private void button3_Click(object sender, EventArgs e)
        {
            // When entering room it picks a random discription
            RandomNumberGenerator();

            //swap background image
            this.BackgroundImage = EarthImage;

            //set rooms title and description
            RoomNameBox.Text = earthTitle;
            //RoomDescriptionBox.Text = earthDescription;

            //random descriptions
            switch (randomNum)
            {
                case 0:
                    RoomDescriptionBox.Text = "You have entered Cthulhu's realm of sparkles and sunshine!";
                    break;
                case 1:
                    RoomDescriptionBox.Text = "Yo mama so fat, when she moons people they turn into werewolves!";
                    break;
                case 2:
                    RoomDescriptionBox.Text = "One time at band camp...";
                    break;
                case 3:
                    RoomDescriptionBox.Text = "Never gonna give you up\r\nNever gonna let you down\r\nNever gonna" +
                        " run around and desert you\r\nNever gonna make you cry\r\nNever gonna say goodbye\r\nNever gonna" +
                        " tell a lie and hurt you";
                    break;
                case 4:
                    RoomDescriptionBox.Text = "Klaatu barada nikto";
                    break;
                default:
                    RoomDescriptionBox.Text = earthDescription;
                    break;
            }

            //set current location
            currentRoomTitle = earthTitle;

            //check button and turn off or on
            NavigationButtonCheck();
        }

        //vehicle yard button
        private void North_Click(object sender, EventArgs e)
        {
            // When entering room it picks a random discription
            RandomNumberGenerator();

            //swap background image
            this.BackgroundImage = VehiclesImage;

            //set rooms title and description
            RoomNameBox.Text = vehicleYardTitle;
            //RoomDescriptionBox.Text = vehicleYardDescription;

            //random descriptions
            switch (randomNum)
            {
                case 0:
                    RoomDescriptionBox.Text = "You have entered Cthulhu's realm of sparkles and sunshine!";
                    break;
                case 1:
                    RoomDescriptionBox.Text = "Yo mama so fat, when she moons people they turn into werewolves!";
                    break;
                case 2:
                    RoomDescriptionBox.Text = "One time at band camp...";
                    break;
                case 3:
                    RoomDescriptionBox.Text = "Never gonna give you up\r\nNever gonna let you down\r\nNever gonna" +
                        " run around and desert you\r\nNever gonna make you cry\r\nNever gonna say goodbye\r\nNever gonna" +
                        " tell a lie and hurt you";
                    break;
                case 4:
                    RoomDescriptionBox.Text = "Klaatu barada nikto";
                    break;
                default:
                    RoomDescriptionBox.Text = vehicleYardDescription;
                    break;
            }

            //set current location
            currentRoomTitle = vehicleYardTitle;

            //check button and turn off or on
            NavigationButtonCheck();
        }

        //excavation site button
        private void South_Click(object sender, EventArgs e)
        {
            // When entering room it picks a random discription
            RandomNumberGenerator();

            //swap background image
            this.BackgroundImage = ExcavationImage;

            //set rooms title and description
            RoomNameBox.Text = excavationTitle;
            //RoomDescriptionBox.Text = excavationDescription;

            //random descriptions
            switch (randomNum)
            {
                case 0:
                    RoomDescriptionBox.Text = "You have entered Cthulhu's realm of sparkles and sunshine!";
                    break;
                case 1:
                    RoomDescriptionBox.Text = "Yo mama so fat, when she moons people they turn into werewolves!";
                    break;
                case 2:
                    RoomDescriptionBox.Text = "One time at band camp...";
                    break;
                case 3:
                    RoomDescriptionBox.Text = "Never gonna give you up\r\nNever gonna let you down\r\nNever gonna" +
                        " run around and desert you\r\nNever gonna make you cry\r\nNever gonna say goodbye\r\nNever gonna" +
                        " tell a lie and hurt you";
                    break;
                case 4:
                    RoomDescriptionBox.Text = "Klaatu barada nikto";
                    break;
                default:
                    RoomDescriptionBox.Text = excavationDescription;
                    break;
            }

            //set current location
            currentRoomTitle = excavationTitle;

            //check button and turn off or on
            NavigationButtonCheck();
        }

        //mars base return to home button
        private void Home_Click(object sender, EventArgs e)
        {
            // When entering room it picks a random discription
            RandomNumberGenerator();

            //swap background image
            this.BackgroundImage = MarsBaseImage;

            //set rooms title and description
            RoomNameBox.Text = serenityBaseTitle;
            //RoomDescriptionBox.Text = serenityBaseDescription;

            //random descriptions
            switch (randomNum)
            {
                case 0:
                    RoomDescriptionBox.Text = "You have entered Cthulhu's realm of sparkles and sunshine!";
                    break;
                case 1:
                    RoomDescriptionBox.Text = "Yo mama so fat, when she moons people they turn into werewolves!";
                    break;
                case 2:
                    RoomDescriptionBox.Text = "One time at band camp...";
                    break;
                case 3:
                    RoomDescriptionBox.Text = "Never gonna give you up\r\nNever gonna let you down\r\nNever gonna" +
                        " run around and desert you\r\nNever gonna make you cry\r\nNever gonna say goodbye\r\nNever gonna" +
                        " tell a lie and hurt you";
                    break;
                case 4:
                    RoomDescriptionBox.Text = "Klaatu barada nikto";
                    break;
                default:
                    RoomDescriptionBox.Text = serenityBaseDescription;
                    break;
            }

            //set current location
            currentRoomTitle = serenityBaseTitle;

            //check button and turn off or on
            NavigationButtonCheck();
        }

        //button disable or enable function
        private void NavigationButtonCheck()
        {
            //checking to see if you are at the current spot and making sure other buttons are on or off
            if (currentRoomTitle == "Serenity Base Alpha")
            {
                Excavation.Enabled = true;
                Earth.Enabled = true;
                Hazardous.Enabled = true;
                VehicleYard.Enabled = true;
                Home.Enabled = false;
            }

            //checking to see if you are at the current spot and making sure other buttons are on or off
            else if (currentRoomTitle == "Hazardous Waste")
            {
                Excavation.Enabled = true;
                Earth.Enabled = true;
                Hazardous.Enabled = false;
                VehicleYard.Enabled = true;
                Home.Enabled = true;
            }

            //checking to see if you are at the current spot and making sure other buttons are on or off
            else if (currentRoomTitle == "Earth View")
            {
                Excavation.Enabled = true;
                Earth.Enabled = false;
                Hazardous.Enabled = true;
                VehicleYard.Enabled = true;
                Home.Enabled = true;
            }

            //checking to see if you are at the current spot and making sure other buttons are on or off
            else if (currentRoomTitle == "Vehicle Yard")
            {
                Excavation.Enabled = true;
                Earth.Enabled = true;
                Hazardous.Enabled = true;
                VehicleYard.Enabled = false;
                Home.Enabled = true;
            }

            //checking to see if you are at the current spot and making sure other buttons are on or off
            else if (currentRoomTitle == "Excavation Site")
            {
                Excavation.Enabled = false;
                Earth.Enabled = true;
                Hazardous.Enabled = true;
                VehicleYard.Enabled = true;
                Home.Enabled = true;
            }
        }
        //random number generator
        private void RandomNumberGenerator()
        {
            // generates a value from 0 to 4
            randomNum = randomGenerator.Next(5);
        }
    }
}
