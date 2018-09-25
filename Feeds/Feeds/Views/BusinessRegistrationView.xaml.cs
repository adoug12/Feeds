﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Feeds.Models;

namespace Feeds.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BusinessRegistrationView : ContentPage
	{
        public BusinessRegistrationModel businessRegistrationModel;

		public BusinessRegistrationView ()
		{
			InitializeComponent ();
            businessRegistrationModel = new BusinessRegistrationModel();

            MessagingCenter.Subscribe<BusinessRegistrationModel, string>(this, "BusinessSubmitAlert", (sender, username) =>
            {
                DisplayAlert("Title", username, "Okay");
            });

            this.BindingContext = businessRegistrationModel;

            usernameEntry.Completed += (object sender, EventArgs e) =>
            {
                businessNameEntry.Focus();
            };

            businessNameEntry.Completed += (object sender, EventArgs e) =>
            {
                addressEntry.Focus();
            };

            addressEntry.Completed += (object sender, EventArgs e) =>
            {
                emailEntry.Focus();
            };

            emailEntry.Completed += (object sender, EventArgs e) =>
            {
                email2Entry.Focus();
            };

            email2Entry.Completed += (object sender, EventArgs e) =>
            {
                phoneEntry.Focus();
            };

            phoneEntry.Completed += (object sender, EventArgs e) =>
            {
                passwordEntry.Focus();
            };

            passwordEntry.Completed += (object sender, EventArgs e) =>
            {
                password2Entry.Focus();
            };

            password2Entry.Completed += (object sender, EventArgs e) =>
            {
                businessRegistrationModel.SubmitCommand.Execute(null);
            };
        }
	}
}