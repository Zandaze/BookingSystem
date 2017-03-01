using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class MainForm : Form
    {
        enum State
        {
            None,
            Customers,
            Books,
            Booking
        };
        State state = State.None;

        public bool deleteClickedOnce = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            MenuClick();
            pnlCustomer.Visible = true;
            pnlListContainer.Visible = true;
            btnDelete.Visible = true;
            btnCustomerAddUpdate.Location = new System.Drawing.Point(36, 247);
            state = State.Customers;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            MenuClick();
            pnlBookings.Visible = true;
            pnlListContainer.Visible = true;
            btnDelete.Visible = true;
            state = State.Booking;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            MenuClick();
            pnlBook.Visible = true;
            pnlListContainer.Visible = true;
            btnDelete.Visible = true;
            state = State.Books;
        }
        
        private void MenuClick()
        {
            pnlCustomer.Visible = false;
            pnlBookings.Visible = false;
            pnlBook.Visible = false;
            pnlListContainer.Visible = false;
            btnDelete.Visible = false;
            lblInfo.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (state == State.Customers)
            {
                //TODO
                //if()
                //{
                lblInfo.Text = "Ingen kund är vald.";
                //}
                //else if istället
                if (!deleteClickedOnce)
                {
                    deleteClickedOnce = true;
                    lblInfo.Text = "Tryck en gång till för att bekräfta.";
                }
                else
                {
                    //TODO
                    //Ta bort kund med Erols kod
                    //Kom ihåg att lägga in att deleteClickedOnce blir false om man tryckt en gång och sedan klickar på en annan kund i listan.
                    deleteClickedOnce = false;
                    lblInfo.Text = "Kund borttagen.";
                } 
            }

            else if (state == State.Books)
            {

            }
            else if (state == State.Booking)
            {

            }

        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            //TODO
            //Lägg in kund med Erols kod
            //if (Det gick att lägga in)
            //{
            lblInfo.Text = "Kund inlagd.";
            //}
            //else if (det uppdaterades då kunden redan fanns)
            //{
            lblInfo.Text = "Kund uppdaterad.";
            //else
            //{
            lblInfo.Text = "Felaktigt format";
            //}
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MenuClick();
        }

        private void btnBookingAddUpdate_Click(object sender, EventArgs e)
        {
            //TODO
            //Lägg in erols kod

            //if-satser
            lblInfo.Text = "";
            lblInfo.Text = "";
        }

        private void btnBookAddUpdate_Click(object sender, EventArgs e)
        {
            //TODO
            //Lägg in erols kod

            //if-satser
            lblInfo.Text = "";
            lblInfo.Text = "";
        }
    }
}
