namespace Moody_Home_Designs_Inventory_Management
{
    partial class Form_newItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_newItem));
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.txtBox_ItemName = new System.Windows.Forms.TextBox();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.lbl_Details = new System.Windows.Forms.Label();
            this.txtBox_Details = new System.Windows.Forms.TextBox();
            this.pBox_itemPicture = new System.Windows.Forms.PictureBox();
            this.txtBox_SalePrice = new System.Windows.Forms.TextBox();
            this.lbl_SalePrice = new System.Windows.Forms.Label();
            this.lbl_WorkHours = new System.Windows.Forms.Label();
            this.lbl_CostOfParts = new System.Windows.Forms.Label();
            this.txtBox_WorkHours = new System.Windows.Forms.TextBox();
            this.txtBox_CostOfParts = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_itemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(12, 462);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(109, 38);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(549, 462);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(109, 38);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Upload.ForeColor = System.Drawing.Color.White;
            this.btn_Upload.Location = new System.Drawing.Point(549, 204);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(109, 38);
            this.btn_Upload.TabIndex = 4;
            this.btn_Upload.Text = "Upload Picture";
            this.btn_Upload.UseVisualStyleBackColor = false;
            // 
            // txtBox_ItemName
            // 
            this.txtBox_ItemName.Location = new System.Drawing.Point(154, 15);
            this.txtBox_ItemName.Name = "txtBox_ItemName";
            this.txtBox_ItemName.Size = new System.Drawing.Size(366, 20);
            this.txtBox_ItemName.TabIndex = 5;
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.AutoSize = true;
            this.lbl_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_ItemName.Location = new System.Drawing.Point(12, 9);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(136, 26);
            this.lbl_ItemName.TabIndex = 6;
            this.lbl_ItemName.Text = "Item Name:";
            // 
            // lbl_Details
            // 
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Details.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Details.Location = new System.Drawing.Point(12, 64);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(93, 26);
            this.lbl_Details.TabIndex = 8;
            this.lbl_Details.Text = "Details:";
            // 
            // txtBox_Details
            // 
            this.txtBox_Details.AcceptsReturn = true;
            this.txtBox_Details.AcceptsTab = true;
            this.txtBox_Details.Location = new System.Drawing.Point(111, 70);
            this.txtBox_Details.Multiline = true;
            this.txtBox_Details.Name = "txtBox_Details";
            this.txtBox_Details.Size = new System.Drawing.Size(409, 162);
            this.txtBox_Details.TabIndex = 9;
            // 
            // pBox_itemPicture
            // 
            this.pBox_itemPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_itemPicture.Location = new System.Drawing.Point(12, 248);
            this.pBox_itemPicture.Name = "pBox_itemPicture";
            this.pBox_itemPicture.Size = new System.Drawing.Size(646, 208);
            this.pBox_itemPicture.TabIndex = 10;
            this.pBox_itemPicture.TabStop = false;
            // 
            // txtBox_SalePrice
            // 
            this.txtBox_SalePrice.Location = new System.Drawing.Point(531, 38);
            this.txtBox_SalePrice.Name = "txtBox_SalePrice";
            this.txtBox_SalePrice.Size = new System.Drawing.Size(100, 20);
            this.txtBox_SalePrice.TabIndex = 11;
            // 
            // lbl_SalePrice
            // 
            this.lbl_SalePrice.AutoSize = true;
            this.lbl_SalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalePrice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_SalePrice.Location = new System.Drawing.Point(526, 9);
            this.lbl_SalePrice.Name = "lbl_SalePrice";
            this.lbl_SalePrice.Size = new System.Drawing.Size(129, 26);
            this.lbl_SalePrice.TabIndex = 12;
            this.lbl_SalePrice.Text = "Sale Price:";
            // 
            // lbl_WorkHours
            // 
            this.lbl_WorkHours.AutoSize = true;
            this.lbl_WorkHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WorkHours.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_WorkHours.Location = new System.Drawing.Point(526, 113);
            this.lbl_WorkHours.Name = "lbl_WorkHours";
            this.lbl_WorkHours.Size = new System.Drawing.Size(144, 26);
            this.lbl_WorkHours.TabIndex = 13;
            this.lbl_WorkHours.Text = "Work Hours:";
            // 
            // lbl_CostOfParts
            // 
            this.lbl_CostOfParts.AutoSize = true;
            this.lbl_CostOfParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CostOfParts.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_CostOfParts.Location = new System.Drawing.Point(526, 61);
            this.lbl_CostOfParts.Name = "lbl_CostOfParts";
            this.lbl_CostOfParts.Size = new System.Drawing.Size(158, 26);
            this.lbl_CostOfParts.TabIndex = 14;
            this.lbl_CostOfParts.Text = "Cost of Parts:";
            // 
            // txtBox_WorkHours
            // 
            this.txtBox_WorkHours.Location = new System.Drawing.Point(531, 142);
            this.txtBox_WorkHours.Name = "txtBox_WorkHours";
            this.txtBox_WorkHours.Size = new System.Drawing.Size(100, 20);
            this.txtBox_WorkHours.TabIndex = 15;
            // 
            // txtBox_CostOfParts
            // 
            this.txtBox_CostOfParts.Location = new System.Drawing.Point(531, 90);
            this.txtBox_CostOfParts.Name = "txtBox_CostOfParts";
            this.txtBox_CostOfParts.Size = new System.Drawing.Size(100, 20);
            this.txtBox_CostOfParts.TabIndex = 16;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(127, 470);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 20);
            this.lbl_Error.TabIndex = 17;
            // 
            // Form_newItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(683, 512);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.txtBox_CostOfParts);
            this.Controls.Add(this.txtBox_WorkHours);
            this.Controls.Add(this.lbl_CostOfParts);
            this.Controls.Add(this.lbl_WorkHours);
            this.Controls.Add(this.lbl_SalePrice);
            this.Controls.Add(this.txtBox_SalePrice);
            this.Controls.Add(this.pBox_itemPicture);
            this.Controls.Add(this.txtBox_Details);
            this.Controls.Add(this.lbl_Details);
            this.Controls.Add(this.lbl_ItemName);
            this.Controls.Add(this.txtBox_ItemName);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_newItem";
            this.Text = "New Item";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_NewItem_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_itemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.TextBox txtBox_ItemName;
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.Label lbl_Details;
        private System.Windows.Forms.TextBox txtBox_Details;
        private System.Windows.Forms.PictureBox pBox_itemPicture;
        private System.Windows.Forms.TextBox txtBox_SalePrice;
        private System.Windows.Forms.Label lbl_SalePrice;
        private System.Windows.Forms.Label lbl_WorkHours;
        private System.Windows.Forms.Label lbl_CostOfParts;
        private System.Windows.Forms.TextBox txtBox_WorkHours;
        private System.Windows.Forms.TextBox txtBox_CostOfParts;
        private System.Windows.Forms.Label lbl_Error;
    }
}