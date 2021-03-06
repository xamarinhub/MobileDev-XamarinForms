﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace BasicNavigation
{
    public partial class NameEditPage : ContentPage
    {
        private string _name;

        // This is without binding - purely view based

        // **************************** Accessors *****************************
        public string Name
        {
            get => _name;
            set
            {
                if (_name == value) return;
                _name = value;
                NameEntry.Text = _name;
            }
        }

        // **************************** Constructor ****************************
        public NameEditPage(string name)
        {
            InitializeComponent();

            // This performs a copy
            Name = name;

            //Set up event handlers
            NameEntry.TextChanged += NameEntry_TextChanged;
            SaveButton.Clicked += SaveButton_Clicked;
        }

        // ************************** Event Handlers ***************************
        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Save Clicked");

            //Navigate back to the previous view
            //await Navigation.PopAsync();

            //Navigate back to the root view
            await Navigation.PopToRootAsync();
        }

        private void NameEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Name = e.NewTextValue;
        }
    }
}
