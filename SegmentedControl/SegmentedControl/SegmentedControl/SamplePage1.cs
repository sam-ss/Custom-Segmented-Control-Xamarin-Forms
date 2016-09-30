using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace SegmentedControl
{
    public class SamplePage1 : ContentPage
    {

        public SamplePage1()
        {
            SegmentedControl Seg = new SegmentedControl();
            SegmentedControlOption segChil1 = new SegmentedControlOption();
            SegmentedControlOption segChil2 = new SegmentedControlOption();
            
            segChil1.Text = "One";
            segChil2.Text = "Two";
            Seg.Children.Add(new SegmentedControlOption {Text = "One" });
            Seg.Children.Add(new SegmentedControlOption { Text = "Two" });
            Content = new StackLayout 
            {
                Children = { Seg }
            };
        }
    }
}
