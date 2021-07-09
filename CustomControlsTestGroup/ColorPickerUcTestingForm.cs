using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlsTestGroup
{
    public partial class ColorPickerUcTestingForm : Form
    {
        public ColorPickerUcTestingForm()
        {
            InitializeComponent();
        }

        //this was created after you made the ColorChanged property in the user control,
        //then once the uc was on the form, you selected it under the "Events" tab/
        //Double-clicking created this name, but you can rename,
        //or even write the method first then select it on the Events tab.
        private void ucSelectControl1_ColorChanged(object sender, EventArgs e)
        {
            txtRedValue.Text = ucSelectControl1.ControlColor.R.ToString();
            txtGreenValue.Text = ucSelectControl1.ControlColor.G.ToString();
            txtBlueValue.Text = ucSelectControl1.ControlColor.B.ToString();
            //something important here, showing you are reading a value from the app, not the UI:
            //each .Text gets its value from the UC's property of ControlColor,
            //which is the name of the "merged" RGB colors.
            //Not getting each value separately from the UI.
            //IE, each value was passed from the UI, and the event set those
            //combined values into a property on the UC itself.
            //And THAT property is used here as ControlColor.R, etc...
        }
    }
}
