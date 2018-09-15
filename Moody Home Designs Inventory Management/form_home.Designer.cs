namespace Moody_Home_Designs_Inventory_Management
{
    partial class Form_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_NewItem = new System.Windows.Forms.Button();
            this.btn_ViewItems = new System.Windows.Forms.Button();
            this.btn_EditItem = new System.Windows.Forms.Button();
            this.btn_NewOrder = new System.Windows.Forms.Button();
            this.btn_EditOrder = new System.Windows.Forms.Button();
            this.btn_ViewOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Moody_Home_Designs_Inventory_Management.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_NewItem
            // 
            this.btn_NewItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_NewItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewItem.ForeColor = System.Drawing.Color.White;
            this.btn_NewItem.Location = new System.Drawing.Point(12, 142);
            this.btn_NewItem.Name = "btn_NewItem";
            this.btn_NewItem.Size = new System.Drawing.Size(109, 38);
            this.btn_NewItem.TabIndex = 1;
            this.btn_NewItem.Text = "New Item";
            this.btn_NewItem.UseVisualStyleBackColor = false;
            this.btn_NewItem.Click += new System.EventHandler(this.btn_NewItem_Click);
            // 
            // btn_ViewItems
            // 
            this.btn_ViewItems.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ViewItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ViewItems.ForeColor = System.Drawing.Color.White;
            this.btn_ViewItems.Location = new System.Drawing.Point(242, 142);
            this.btn_ViewItems.Name = "btn_ViewItems";
            this.btn_ViewItems.Size = new System.Drawing.Size(109, 38);
            this.btn_ViewItems.TabIndex = 3;
            this.btn_ViewItems.Text = "View Items";
            this.btn_ViewItems.UseVisualStyleBackColor = false;
            this.btn_ViewItems.Click += new System.EventHandler(this.btn_ViewItems_Click);
            // 
            // btn_EditItem
            // 
            this.btn_EditItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_EditItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditItem.ForeColor = System.Drawing.Color.White;
            this.btn_EditItem.Location = new System.Drawing.Point(127, 142);
            this.btn_EditItem.Name = "btn_EditItem";
            this.btn_EditItem.Size = new System.Drawing.Size(109, 38);
            this.btn_EditItem.TabIndex = 4;
            this.btn_EditItem.Text = "Edit Item";
            this.btn_EditItem.UseVisualStyleBackColor = false;
            // 
            // btn_NewOrder
            // 
            this.btn_NewOrder.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_NewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewOrder.ForeColor = System.Drawing.Color.White;
            this.btn_NewOrder.Location = new System.Drawing.Point(12, 186);
            this.btn_NewOrder.Name = "btn_NewOrder";
            this.btn_NewOrder.Size = new System.Drawing.Size(109, 38);
            this.btn_NewOrder.TabIndex = 5;
            this.btn_NewOrder.Text = "New Order";
            this.btn_NewOrder.UseVisualStyleBackColor = false;
            // 
            // btn_EditOrder
            // 
            this.btn_EditOrder.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_EditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditOrder.ForeColor = System.Drawing.Color.White;
            this.btn_EditOrder.Location = new System.Drawing.Point(127, 186);
            this.btn_EditOrder.Name = "btn_EditOrder";
            this.btn_EditOrder.Size = new System.Drawing.Size(109, 38);
            this.btn_EditOrder.TabIndex = 6;
            this.btn_EditOrder.Text = "Edit Order";
            this.btn_EditOrder.UseVisualStyleBackColor = false;
            // 
            // btn_ViewOrders
            // 
            this.btn_ViewOrders.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ViewOrders.ForeColor = System.Drawing.Color.White;
            this.btn_ViewOrders.Location = new System.Drawing.Point(242, 186);
            this.btn_ViewOrders.Name = "btn_ViewOrders";
            this.btn_ViewOrders.Size = new System.Drawing.Size(109, 38);
            this.btn_ViewOrders.TabIndex = 7;
            this.btn_ViewOrders.Text = "View Orders";
            this.btn_ViewOrders.UseVisualStyleBackColor = false;
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(363, 257);
            this.Controls.Add(this.btn_ViewOrders);
            this.Controls.Add(this.btn_EditOrder);
            this.Controls.Add(this.btn_NewOrder);
            this.Controls.Add(this.btn_EditItem);
            this.Controls.Add(this.btn_ViewItems);
            this.Controls.Add(this.btn_NewItem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_home";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_NewItem;
        private System.Windows.Forms.Button btn_ViewItems;
        private System.Windows.Forms.Button btn_EditItem;
        private System.Windows.Forms.Button btn_NewOrder;
        private System.Windows.Forms.Button btn_EditOrder;
        private System.Windows.Forms.Button btn_ViewOrders;
    }
}

