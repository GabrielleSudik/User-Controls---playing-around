using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlsLesson1
{
    public partial class ucSelectColor : UserControl
    {
        //private field and public properties of the ColorController
        private Color _controlColor { get; set; }

        public Color ControlColor
        {
            get { return _controlColor; }
            set { _controlColor = value; }
        }

        //this is the declaration of the event, that happens when the color changes.
        //It will be raised in a method below.
        public event EventHandler ColorChanged;
        //TIP! After adding new events to a user control, build the project,
        //check anywhere the UC is used in a form, and check for the new
        //property in the Properties - Events window. Cool.
        //.

        public ucSelectColor()
        {
            InitializeComponent();
        }

        //method attached to all three scroll bars
        //they do the same thing so you just need one method for all three
        //their properties were already set, ie 0 to 255, with 5 as ticks
        private void tb_Scroll(object sender, EventArgs e)
        {
            int redValue = tbRed.Value;
            int blueValue = tbBlue.Value;
            int greenValue = tbGreen.Value;
            Color controlColor = Color.FromArgb(redValue, greenValue, blueValue);
            //ie, this line is the "intersection" of the three values. THE color.

            //when user changes the values on the sliders
            //the color will also change
            try
            {
                pnlColor.BackColor = controlColor; //this sets the color box within the UI only.

                //this next part is for setting the UI's color value to the property in this UC.
                _controlColor = controlColor;
                OnColorChanged(EventArgs.Empty); //gets called every time the scrollbars change.
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //method to raise the ColorChanged event.
        protected virtual void OnColorChanged(EventArgs e)
        {
            ColorChanged?.Invoke(this, e);
            //that means: If ColorChanged is true, invoke this instance of the class 
            //and the event that kicked off this method call.
        }
    }
}
