using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Moody_Home_Designs_Inventory_Management
{
    public partial class Form_home : Form
    {
        //boolean value used to prevent multiple windows from being opened through the home screen.
        public static bool secondaryWindow = false;

        public Form_home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /*opens new item form when "New Item" button is clicked.
        *New Item form will allow user to upload new products to database.
        *More windows will not be allowed to open as long as one secondary window is open.
        */
        private void btn_NewItem_Click(object sender, EventArgs e)
        {
            if (secondaryWindow == false)
            {
                Form_newItem newItem = new Form_newItem();
                newItem.Show();
                secondaryWindow = true;
            }
        }

        /*opens new item form when "New Item" button is clicked.
        *New Item form will allow user to upload new products to database.
        *More windows will not be allowed to open as long as one secondary window is open.
        */
        private void btn_ViewItems_Click(object sender, EventArgs e)
        {
            if (secondaryWindow == false)
            {
                Form_viewItems viewItems = new Form_viewItems();
                viewItems.Show();
                secondaryWindow = true;
            }
        }
    }
}
