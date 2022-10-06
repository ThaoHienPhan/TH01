using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bai2 : ContentPage
    {
        public Bai2()
        {
            InitializeComponent();
            Grid layout = new Grid
            {
                RowSpacing = 0,
                ColumnSpacing = 0,
                RowDefinitions =
                {
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width= new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width= new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width= new GridLength(1, GridUnitType.Star)},
                }

            };

            Boolean flag = true;
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    if (flag == true)
                    {
                        layout.Children.Add(new BoxView
                        {
                            Color = Color.FromHex("FF8FB1")
                        }, i, j);
                    }
                    else
                    {
                        layout.Children.Add(new BoxView
                        {
                            Color = Color.FromHex("FCF8E8")
                        }, i, j);
                    }
                    flag = !flag;
                }
                flag = !flag;
            }
            Content = layout;
        }

    }
}