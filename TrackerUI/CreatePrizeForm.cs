using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Connection;
using TrackerLibrary.Interface;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNumbertextBox.Text, 
                    PlaceNametextBox.Text,
                    PrizeAmounttextBox.Text,
                    PrizePercentagetextBox.Text
                    );
                // for each interface in the connections list, which is a list of interfaces (IDataConnection)
                
                
                GlobalConfig.Connection.CreatePrize(model);
                

                PlaceNametextBox.Text = "";
                PlaceNumbertextBox.Text = "";
                PrizeAmounttextBox.Text = "0";
                PrizePercentagetextBox.Text = "0";
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            string MsgErro = "";
            bool placeNumberValidNumber = (int.TryParse(PlaceNumbertextBox.Text, out placeNumber));

            if (!placeNumberValidNumber)
            {
                MsgErro += "Please insert a valid Place Number." + Environment.NewLine; ;
                PlaceNumbertextBox.ForeColor = Color.Red;
                output = false;
            }
            else
            {
                PlaceNumbertextBox.ForeColor = Color.Black;
            }

            if (placeNumber < 1)
            {
                MsgErro += "Please insert a Place Number larger than 0." + Environment.NewLine; ;
                PlaceNumbertextBox.ForeColor = Color.Red;
                output = false;
            }
            else
            {
                PlaceNumbertextBox.ForeColor = Color.Black;
            }

            if (PlaceNametextBox.Text.Length == 0)
            {
                MsgErro += "Please insert a valid Place Name." + Environment.NewLine; ;
                PlaceNametextBox.ForeColor = Color.Red;
                output = false;
            }
            else
            {
                PlaceNametextBox.ForeColor = Color.Black;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmounttextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentagetextBox.Text, out prizePercentage);
            
            if (!prizeAmountValid || !prizePercentageValid)
            {
                MsgErro += "Please insert a valid Prize Amount / Prize Percentage." + Environment.NewLine;
                PrizeAmounttextBox.ForeColor = Color.Red;
                PrizePercentagetextBox.ForeColor = Color.Red;
                output = false;
            }
            else
            {
                PrizeAmounttextBox.ForeColor = Color.Black;
                PrizePercentagetextBox.ForeColor = Color.Black;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                MsgErro += "Please insert a Prize Amount / Prize Percentage larger than 0." + Environment.NewLine; ;
                PrizeAmounttextBox.ForeColor = Color.Red;
                PrizePercentagetextBox.ForeColor = Color.Red;
                output = false;
            }
            else
            {
                PrizeAmounttextBox.ForeColor = Color.Black;
                PrizePercentagetextBox.ForeColor = Color.Black;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                MsgErro += "Please insert a valid Prize Percentage between o and 100." + Environment.NewLine; ;
                PrizePercentagetextBox.ForeColor = Color.Red;
                output = false;
            }
            else
            {
                PrizePercentagetextBox.ForeColor = Color.Black;
            }

            if (!output)
            {
                MessageBox.Show(MsgErro);
            }
            
            return output;
        }
    }
}
