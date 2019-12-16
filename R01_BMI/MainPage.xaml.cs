﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R01_BMI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (hei.Text != null && wei.Text != null)
            {

                float height = float.Parse(hei.Text);
                float weight = float.Parse(wei.Text);

                float result = (weight / (height * height)) * 10000;
                double answer = Math.Round(result);

                res.Text = "あなたのBMIは" + answer + "です";

            }
            else
            {
                res.Text = "身長と体重を入力してください";
            }
        }
    }
}
