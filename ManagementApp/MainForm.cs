using System;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class MainForm : Form
    {
        private static AirBeeNBee airBee = new AirBeeNBee("AirBeenBee");

        public MainForm()
        {
            InitializeComponent();

          
        }

        private void cbBeeTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void lbBeeGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
