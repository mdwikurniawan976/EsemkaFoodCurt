namespace Dekstop_Dwi
{
    partial class ReservationHistory
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReservationDateC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MenuC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceC2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotalC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationDateC,
            this.TblColumn,
            this.PriceC,
            this.iDDataGridViewTextBoxColumn1,
            this.userIDDataGridViewTextBoxColumn,
            this.customerFirstNameDataGridViewTextBoxColumn,
            this.customerLastNameDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.customerPhoneNumberDataGridViewTextBoxColumn,
            this.numberOfPeopleDataGridViewTextBoxColumn,
            this.tableIDDataGridViewTextBoxColumn,
            this.reservationDateDataGridViewTextBoxColumn,
            this.reservationDetailsDataGridViewTextBoxColumn,
            this.tablesDataGridViewTextBoxColumn,
            this.usersDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(910, 188);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ReservationDateC
            // 
            this.ReservationDateC.DataPropertyName = "ReservationDate";
            this.ReservationDateC.HeaderText = "ReservationDate";
            this.ReservationDateC.MinimumWidth = 6;
            this.ReservationDateC.Name = "ReservationDateC";
            this.ReservationDateC.ReadOnly = true;
            // 
            // TblColumn
            // 
            this.TblColumn.HeaderText = "Table No";
            this.TblColumn.MinimumWidth = 6;
            this.TblColumn.Name = "TblColumn";
            this.TblColumn.ReadOnly = true;
            // 
            // PriceC
            // 
            this.PriceC.HeaderText = "Total Price";
            this.PriceC.MinimumWidth = 6;
            this.PriceC.Name = "PriceC";
            this.PriceC.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerFirstNameDataGridViewTextBoxColumn
            // 
            this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.HeaderText = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
            this.customerFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerFirstNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerLastNameDataGridViewTextBoxColumn
            // 
            this.customerLastNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerLastName";
            this.customerLastNameDataGridViewTextBoxColumn.HeaderText = "CustomerLastName";
            this.customerLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
            this.customerLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerLastNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmail";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "CustomerEmail";
            this.customerEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            this.customerEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerEmailDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerPhoneNumberDataGridViewTextBoxColumn
            // 
            this.customerPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhoneNumber";
            this.customerPhoneNumberDataGridViewTextBoxColumn.HeaderText = "CustomerPhoneNumber";
            this.customerPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerPhoneNumberDataGridViewTextBoxColumn.Name = "customerPhoneNumberDataGridViewTextBoxColumn";
            this.customerPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerPhoneNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberOfPeopleDataGridViewTextBoxColumn
            // 
            this.numberOfPeopleDataGridViewTextBoxColumn.DataPropertyName = "NumberOfPeople";
            this.numberOfPeopleDataGridViewTextBoxColumn.HeaderText = "NumberOfPeople";
            this.numberOfPeopleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfPeopleDataGridViewTextBoxColumn.Name = "numberOfPeopleDataGridViewTextBoxColumn";
            this.numberOfPeopleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableIDDataGridViewTextBoxColumn
            // 
            this.tableIDDataGridViewTextBoxColumn.DataPropertyName = "TableID";
            this.tableIDDataGridViewTextBoxColumn.HeaderText = "TableID";
            this.tableIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tableIDDataGridViewTextBoxColumn.Name = "tableIDDataGridViewTextBoxColumn";
            this.tableIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tableIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // reservationDateDataGridViewTextBoxColumn
            // 
            this.reservationDateDataGridViewTextBoxColumn.DataPropertyName = "ReservationDate";
            this.reservationDateDataGridViewTextBoxColumn.HeaderText = "ReservationDate";
            this.reservationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationDateDataGridViewTextBoxColumn.Name = "reservationDateDataGridViewTextBoxColumn";
            this.reservationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // reservationDetailsDataGridViewTextBoxColumn
            // 
            this.reservationDetailsDataGridViewTextBoxColumn.DataPropertyName = "ReservationDetails";
            this.reservationDetailsDataGridViewTextBoxColumn.HeaderText = "ReservationDetails";
            this.reservationDetailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationDetailsDataGridViewTextBoxColumn.Name = "reservationDetailsDataGridViewTextBoxColumn";
            this.reservationDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationDetailsDataGridViewTextBoxColumn.Visible = false;
            // 
            // tablesDataGridViewTextBoxColumn
            // 
            this.tablesDataGridViewTextBoxColumn.DataPropertyName = "Tables";
            this.tablesDataGridViewTextBoxColumn.HeaderText = "Tables";
            this.tablesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tablesDataGridViewTextBoxColumn.Name = "tablesDataGridViewTextBoxColumn";
            this.tablesDataGridViewTextBoxColumn.ReadOnly = true;
            this.tablesDataGridViewTextBoxColumn.Visible = false;
            // 
            // usersDataGridViewTextBoxColumn
            // 
            this.usersDataGridViewTextBoxColumn.DataPropertyName = "Users";
            this.usersDataGridViewTextBoxColumn.HeaderText = "Users";
            this.usersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersDataGridViewTextBoxColumn.Name = "usersDataGridViewTextBoxColumn";
            this.usersDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Dekstop_Dwi.Reservations);
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuC,
            this.Qty,
            this.PriceC2,
            this.SubTotalC,
            this.iDDataGridViewTextBoxColumn,
            this.reservationIDDataGridViewTextBoxColumn,
            this.menuIDDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.menusDataGridViewTextBoxColumn,
            this.reservationsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(19, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(910, 198);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // MenuC
            // 
            this.MenuC.HeaderText = "Menu";
            this.MenuC.MinimumWidth = 6;
            this.MenuC.Name = "MenuC";
            this.MenuC.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // PriceC2
            // 
            this.PriceC2.HeaderText = "Price";
            this.PriceC2.MinimumWidth = 6;
            this.PriceC2.Name = "PriceC2";
            this.PriceC2.ReadOnly = true;
            // 
            // SubTotalC
            // 
            this.SubTotalC.HeaderText = "SubTotal";
            this.SubTotalC.MinimumWidth = 6;
            this.SubTotalC.Name = "SubTotalC";
            this.SubTotalC.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // menuIDDataGridViewTextBoxColumn
            // 
            this.menuIDDataGridViewTextBoxColumn.DataPropertyName = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.HeaderText = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menuIDDataGridViewTextBoxColumn.Name = "menuIDDataGridViewTextBoxColumn";
            this.menuIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Visible = false;
            // 
            // menusDataGridViewTextBoxColumn
            // 
            this.menusDataGridViewTextBoxColumn.DataPropertyName = "Menus";
            this.menusDataGridViewTextBoxColumn.HeaderText = "Menus";
            this.menusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menusDataGridViewTextBoxColumn.Name = "menusDataGridViewTextBoxColumn";
            this.menusDataGridViewTextBoxColumn.ReadOnly = true;
            this.menusDataGridViewTextBoxColumn.Visible = false;
            // 
            // reservationsDataGridViewTextBoxColumn
            // 
            this.reservationsDataGridViewTextBoxColumn.DataPropertyName = "Reservations";
            this.reservationsDataGridViewTextBoxColumn.HeaderText = "Reservations";
            this.reservationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationsDataGridViewTextBoxColumn.Name = "reservationsDataGridViewTextBoxColumn";
            this.reservationsDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationsDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(Dekstop_Dwi.ReservationDetails);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menu Ordered";
            // 
            // ReservationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ReservationHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esemka Foodcurt";
            this.Load += new System.EventHandler(this.ReservationHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationDateC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TblColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceC;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceC2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotalC;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationsDataGridViewTextBoxColumn;
    }
}