﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpCS_ASP_0028
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void fromCupsRadio_CheckedChanged(object sender, EventArgs e)
        {
            //if the text box is empty once all white space is removed..
            if (quantityTextBox.Text.Trim().Length == 0)
                //exit the method
                return;

            //set quantity to 0.0
            double quantity = 0.0;
            //if whatever's in the text box can't be parsed into a double
            if (!Double.TryParse(quantityTextBox.Text, out quantity))
                //exit the method
                return;

            //otherwise set the text box to....
            resultLabel.Text = "The number of cups: " + quantity.ToString();
 
        }

        protected void fromPintsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (quantityTextBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(quantityTextBox.Text, out quantity))
                return;

            double cups = quantity * 2.0;
            resultLabel.Text = "The number of cups: " + quantity.ToString();

        }

        protected void fromQuartsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (quantityTextBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(quantityTextBox.Text, out quantity))
                return;

            double cups = quantity * 4.0;
            resultLabel.Text = "The number of cups: " + quantity.ToString();

        }

        protected void fromGallonsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (quantityTextBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(quantityTextBox.Text, out quantity))
                return;

            double cups = quantity * 16;
            resultLabel.Text = "The number of cups: " + quantity.ToString();

        }

        protected void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}