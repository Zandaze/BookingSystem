namespace BookingSystem
{
    partial class MainForm
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.pnlListContainer = new System.Windows.Forms.Panel();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.pnlBookings = new System.Windows.Forms.Panel();
            this.btnBookingAddUpdate = new System.Windows.Forms.Button();
            this.lblBookedTo = new System.Windows.Forms.Label();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.txtBookedTo = new System.Windows.Forms.TextBox();
            this.txtBookedFrom = new System.Windows.Forms.TextBox();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.lblBookedFrom = new System.Windows.Forms.Label();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.btnBookAddUpdate = new System.Windows.Forms.Button();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.btnCustomerAddUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPnr = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPnr = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlListContainer.SuspendLayout();
            this.pnlBookings.SuspendLayout();
            this.pnlBook.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnBooking);
            this.pnlMenu.Controls.Add(this.btnBooks);
            this.pnlMenu.Controls.Add(this.btnCustomer);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(136, 441);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(21, 398);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 28);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logga ut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(0, 96);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(136, 50);
            this.btnBooking.TabIndex = 6;
            this.btnBooking.Text = "Bokning";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(0, 48);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(136, 50);
            this.btnBooks.TabIndex = 5;
            this.btnBooks.Text = "Böcker";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(136, 50);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "Kunder";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnlListContainer
            // 
            this.pnlListContainer.Controls.Add(this.lstResult);
            this.pnlListContainer.Location = new System.Drawing.Point(236, 88);
            this.pnlListContainer.Name = "pnlListContainer";
            this.pnlListContainer.Size = new System.Drawing.Size(401, 317);
            this.pnlListContainer.TabIndex = 1;
            this.pnlListContainer.Visible = false;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(0, 0);
            this.lstResult.MultiColumn = true;
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(401, 316);
            this.lstResult.TabIndex = 1;
            // 
            // pnlBookings
            // 
            this.pnlBookings.Controls.Add(this.btnBookingAddUpdate);
            this.pnlBookings.Controls.Add(this.lblBookedTo);
            this.pnlBookings.Controls.Add(this.lblBookingId);
            this.pnlBookings.Controls.Add(this.txtBookedTo);
            this.pnlBookings.Controls.Add(this.txtBookedFrom);
            this.pnlBookings.Controls.Add(this.txtBookingId);
            this.pnlBookings.Controls.Add(this.lblBookedFrom);
            this.pnlBookings.Location = new System.Drawing.Point(20, 88);
            this.pnlBookings.Name = "pnlBookings";
            this.pnlBookings.Size = new System.Drawing.Size(178, 316);
            this.pnlBookings.TabIndex = 12;
            this.pnlBookings.Visible = false;
            // 
            // btnBookingAddUpdate
            // 
            this.btnBookingAddUpdate.Location = new System.Drawing.Point(39, 160);
            this.btnBookingAddUpdate.Name = "btnBookingAddUpdate";
            this.btnBookingAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnBookingAddUpdate.TabIndex = 13;
            this.btnBookingAddUpdate.Text = "Add/Update";
            this.btnBookingAddUpdate.UseVisualStyleBackColor = true;
            this.btnBookingAddUpdate.Click += new System.EventHandler(this.btnBookingAddUpdate_Click);
            // 
            // lblBookedTo
            // 
            this.lblBookedTo.AutoSize = true;
            this.lblBookedTo.Location = new System.Drawing.Point(16, 113);
            this.lblBookedTo.Name = "lblBookedTo";
            this.lblBookedTo.Size = new System.Drawing.Size(53, 13);
            this.lblBookedTo.TabIndex = 12;
            this.lblBookedTo.Text = "Bokad till:";
            // 
            // lblBookingId
            // 
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Location = new System.Drawing.Point(16, 16);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(65, 13);
            this.lblBookingId.TabIndex = 11;
            this.lblBookingId.Text = "BokningsID:";
            // 
            // txtBookedTo
            // 
            this.txtBookedTo.Location = new System.Drawing.Point(16, 129);
            this.txtBookedTo.Name = "txtBookedTo";
            this.txtBookedTo.Size = new System.Drawing.Size(127, 20);
            this.txtBookedTo.TabIndex = 6;
            // 
            // txtBookedFrom
            // 
            this.txtBookedFrom.Location = new System.Drawing.Point(16, 81);
            this.txtBookedFrom.Name = "txtBookedFrom";
            this.txtBookedFrom.Size = new System.Drawing.Size(127, 20);
            this.txtBookedFrom.TabIndex = 5;
            // 
            // txtBookingId
            // 
            this.txtBookingId.Location = new System.Drawing.Point(16, 33);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.Size = new System.Drawing.Size(127, 20);
            this.txtBookingId.TabIndex = 4;
            // 
            // lblBookedFrom
            // 
            this.lblBookedFrom.AutoSize = true;
            this.lblBookedFrom.Location = new System.Drawing.Point(16, 64);
            this.lblBookedFrom.Name = "lblBookedFrom";
            this.lblBookedFrom.Size = new System.Drawing.Size(62, 13);
            this.lblBookedFrom.TabIndex = 2;
            this.lblBookedFrom.Text = "Bokad från:";
            // 
            // pnlBook
            // 
            this.pnlBook.Controls.Add(this.btnBookAddUpdate);
            this.pnlBook.Controls.Add(this.lblBookId);
            this.pnlBook.Controls.Add(this.txtYear);
            this.pnlBook.Controls.Add(this.lblYear);
            this.pnlBook.Controls.Add(this.txtCategory);
            this.pnlBook.Controls.Add(this.txtTitle);
            this.pnlBook.Controls.Add(this.txtBookId);
            this.pnlBook.Controls.Add(this.lblCategory);
            this.pnlBook.Controls.Add(this.lblTitle);
            this.pnlBook.Location = new System.Drawing.Point(20, 88);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(178, 316);
            this.pnlBook.TabIndex = 11;
            this.pnlBook.Visible = false;
            // 
            // btnBookAddUpdate
            // 
            this.btnBookAddUpdate.Location = new System.Drawing.Point(40, 202);
            this.btnBookAddUpdate.Name = "btnBookAddUpdate";
            this.btnBookAddUpdate.Size = new System.Drawing.Size(85, 25);
            this.btnBookAddUpdate.TabIndex = 12;
            this.btnBookAddUpdate.Text = "Add/Update";
            this.btnBookAddUpdate.UseVisualStyleBackColor = true;
            this.btnBookAddUpdate.Click += new System.EventHandler(this.btnBookAddUpdate_Click);
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(16, 17);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(37, 13);
            this.lblBookId.TabIndex = 11;
            this.lblBookId.Text = "BokID";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(16, 173);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(127, 20);
            this.txtYear.TabIndex = 9;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(16, 157);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(17, 13);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "År";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(16, 125);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(127, 20);
            this.txtCategory.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(16, 79);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(127, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(16, 33);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(127, 20);
            this.txtBookId.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(16, 112);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kategori";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 63);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Titel";
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.btnCustomerAddUpdate);
            this.pnlCustomer.Controls.Add(this.txtEmail);
            this.pnlCustomer.Controls.Add(this.txtPhone);
            this.pnlCustomer.Controls.Add(this.lblEmail);
            this.pnlCustomer.Controls.Add(this.lblPhone);
            this.pnlCustomer.Controls.Add(this.txtAddress);
            this.pnlCustomer.Controls.Add(this.txtName);
            this.pnlCustomer.Controls.Add(this.txtPnr);
            this.pnlCustomer.Controls.Add(this.lblAddress);
            this.pnlCustomer.Controls.Add(this.lblName);
            this.pnlCustomer.Controls.Add(this.lblPnr);
            this.pnlCustomer.Location = new System.Drawing.Point(20, 88);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(178, 316);
            this.pnlCustomer.TabIndex = 2;
            this.pnlCustomer.Visible = false;
            // 
            // btnCustomerAddUpdate
            // 
            this.btnCustomerAddUpdate.Location = new System.Drawing.Point(36, 247);
            this.btnCustomerAddUpdate.Name = "btnCustomerAddUpdate";
            this.btnCustomerAddUpdate.Size = new System.Drawing.Size(89, 22);
            this.btnCustomerAddUpdate.TabIndex = 11;
            this.btnCustomerAddUpdate.Text = "Add/Update";
            this.btnCustomerAddUpdate.UseVisualStyleBackColor = true;
            this.btnCustomerAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(127, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(16, 176);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(127, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 204);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(16, 160);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(16, 126);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(127, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtPnr
            // 
            this.txtPnr.Location = new System.Drawing.Point(16, 32);
            this.txtPnr.Name = "txtPnr";
            this.txtPnr.Size = new System.Drawing.Size(127, 20);
            this.txtPnr.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(16, 110);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(39, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Adress";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Namn";
            // 
            // lblPnr
            // 
            this.lblPnr.AutoSize = true;
            this.lblPnr.Location = new System.Drawing.Point(16, 16);
            this.lblPnr.Name = "lblPnr";
            this.lblPnr.Size = new System.Drawing.Size(77, 13);
            this.lblPnr.TabIndex = 1;
            this.lblPnr.Text = "Personnummer";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.pnlListContainer);
            this.pnlMain.Controls.Add(this.pnlBook);
            this.pnlMain.Controls.Add(this.pnlCustomer);
            this.pnlMain.Controls.Add(this.pnlBookings);
            this.pnlMain.Location = new System.Drawing.Point(136, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(665, 441);
            this.pnlMain.TabIndex = 13;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(358, 415);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(538, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 24);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 439);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.Name = "MainForm";
            this.Text = "Bokningshanteraren";
            this.pnlMenu.ResumeLayout(false);
            this.pnlListContainer.ResumeLayout(false);
            this.pnlBookings.ResumeLayout(false);
            this.pnlBookings.PerformLayout();
            this.pnlBook.ResumeLayout(false);
            this.pnlBook.PerformLayout();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Panel pnlListContainer;
        private System.Windows.Forms.Panel pnlBook;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Panel pnlBookings;
        private System.Windows.Forms.Label lblBookingId;
        private System.Windows.Forms.TextBox txtBookedTo;
        private System.Windows.Forms.TextBox txtBookedFrom;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.Label lblBookedFrom;
        private System.Windows.Forms.Label lblBookedTo;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPnr;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPnr;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCustomerAddUpdate;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBookingAddUpdate;
        private System.Windows.Forms.Button btnBookAddUpdate;
    }
}

