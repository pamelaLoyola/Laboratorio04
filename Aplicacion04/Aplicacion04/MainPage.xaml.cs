using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aplicacion04
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page1());
            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TabbedPageNew());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CarouselPageNew());
            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CarouselPageCode());
            };
            Item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ModalPage());
            };
            Item6.Clicked += async (sender, e) =>
            {
                var answer = await DisplayAlert("Question?", "Would you like to play a game?", "Yes", "No");
                Debug.WriteLine("Answer: " + answer);
            };
        }
    }
}
