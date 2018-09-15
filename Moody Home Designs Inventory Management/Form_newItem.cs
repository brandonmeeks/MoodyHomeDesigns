using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Moody_Home_Designs_Inventory_Management
{
    public partial class Form_newItem : Form
    {
        public Form_newItem()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //reset label error
            lbl_Error.Text = "";

            //declare needed variables for use
            string itemName;
            string details;
            decimal salePrice;
            decimal partsCost;
            int workHours;

            /*
             * verify data before attempting to connect to database. If input is 
             * invalid, display error message using label and prevent database access
             * 
             */
            try
            {
                itemName = txtBox_ItemName.Text;
                details = txtBox_Details.Text;
                salePrice = Convert.ToDecimal(txtBox_SalePrice.Text);
                partsCost = Convert.ToDecimal(txtBox_CostOfParts.Text);
                workHours = Convert.ToInt32(txtBox_WorkHours.Text);
            }
            catch
            {
                lbl_Error.Text = "Data Entry Error. Please verify information.";
                return;
            }
            /*
             * verify successful connection and item addition to database.
             * If connection or item addition fails, display error message
             * and stop execution of button click code.
             */
            try
            {
                SqlConnection dbConnection = new SqlConnection(
                    "Server = localhost; " +
                    "Database = Moody Home Designs; " +
                    "Trusted_Connection = True;");

                SqlCommand dbCommand = new SqlCommand(
                    "INSERT INTO Item (itemName, salePrice, partsCost, workHours, details) " +
                    "VALUES (@param1, @param2, @param3, @param4, @param5);", dbConnection);

                dbCommand.Parameters.AddWithValue("@param1", itemName);
                dbCommand.Parameters.AddWithValue("@param2", salePrice);
                dbCommand.Parameters.AddWithValue("@param3", partsCost);
                dbCommand.Parameters.AddWithValue("@param4", workHours);
                dbCommand.Parameters.AddWithValue("@param5", details);

                dbConnection.Open();
                dbCommand.ExecuteNonQuery();
                dbConnection.Close();
            }
            catch
            {
                lbl_Error.Text = "Database error";
                return;
            }

            this.Close();

        }

        private void form_NewItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_home.secondaryWindow = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
