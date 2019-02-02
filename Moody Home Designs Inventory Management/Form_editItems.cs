using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Moody_Home_Designs_Inventory_Management {
    public partial class Form_editItems : Form {
        public Form_editItems() {
            InitializeComponent();
        }

        private void Form_editItems_FormClosed(object sender, FormClosedEventArgs e) {
            Form_home.secondaryWindow = false;
        }

        private void Form_editItems_Shown(object sender, EventArgs e) {
            //connect to database and populate listbox with names of items stored in "Item" table
            try {
                SqlConnection dbConnection = new SqlConnection(
                    "Server = localhost; " +
                    "Database = Moody Home Designs; " +
                    "Trusted_Connection = True;");

                dbConnection.Open();

                SqlCommand dbCommand = new SqlCommand("SELECT itemName FROM Item", dbConnection);
                SqlDataReader dbReader = dbCommand.ExecuteReader();

                while (dbReader.Read()) {
                    lsBox_Items.Items.Add(dbReader["itemName"].ToString());
                }

                dbConnection.Close();
            }
            catch {
                lbl_Error.Text = "Database error";
                return;
            }

        }

        private void lsBox_Items_SelectedValueChanged(object sender, EventArgs e) {

            //when listbox items are selected, update the form with the information associated with the selected item
            try {
                SqlConnection dbConnection = new SqlConnection(
                    "Server = localhost; " +
                    "Database = Moody Home Designs; " +
                    "Trusted_Connection = True;");

                dbConnection.Open();

                SqlCommand dbCommand = new SqlCommand("SELECT itemName, details, salePrice, partsCost, workHours " +
                    "FROM Item WHERE itemName = @param1", dbConnection);
                dbCommand.Parameters.AddWithValue("@param1", lsBox_Items.SelectedItem.ToString());

                SqlDataReader dbReader = dbCommand.ExecuteReader();
                dbReader.Read();

                txtBox_ItemName.Text = dbReader["itemName"].ToString();
                txtBox_Details.Text = dbReader["details"].ToString();
                txtBox_SalePrice.Text = dbReader["salePrice"].ToString();
                txtBox_CostOfParts.Text = dbReader["partsCost"].ToString();
                txtBox_WorkHours.Text = dbReader["workHours"].ToString();

                dbConnection.Close();
            }
            catch {
                lbl_Error.Text = "Database error";
                return;
            }
        }

        private void btn_SaveItem_Click(object sender, EventArgs e) {
            
        }
    }
}
