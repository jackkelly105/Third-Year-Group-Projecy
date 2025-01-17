﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace BloomFeildHotel
{
    public partial class formReception : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formReception(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void FormReception_Load(object sender, EventArgs e)
        {
            lblHiReceptionMenu.Text = "Hi " + Model.CurrentUser.FirstName;
        }

        private void BtnCreateReservation_Click(object sender, EventArgs e)
        {
            formCreateReservation form = new formCreateReservation(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            formViewReservations form = new formViewReservations(fc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void BtnViewRoomChart_Click(object sender, EventArgs e)
        {
            formViewRoomBookings f5 = new formViewRoomBookings(fc, Model);
            f5.Dock = DockStyle.Fill;

            f5.Show();
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            formCheckGuestIn f7 = new formCheckGuestIn(fc, Model);
            f7.Dock = DockStyle.Fill;

            f7.Show();
        }

        

        private void btnSearchForReservation_Click(object sender, EventArgs e)
        {
            formSearchReservation f9 = new formSearchReservation(fc, Model);
            f9.Dock = DockStyle.Fill;

            f9.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            formChangePassword f10 = new formChangePassword(fc, Model);
            f10.Dock = DockStyle.Fill;
            f10.Show();
        }

        private void btnViewGuests_Click(object sender, EventArgs e)
        {
            formViewGuests f11 = new formViewGuests(fc, Model);
            f11.Dock = DockStyle.Fill;

            f11.Show();
        }
    }
}
