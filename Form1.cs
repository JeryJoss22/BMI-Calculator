using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class BMI_Calculator : Form
    {
        public BMI_Calculator()
        {
            InitializeComponent();
        }

        private void ClearEverything_Click(object sender, EventArgs e)
        {
            HeightVal.ResetText();
            HeightUnit.ResetText();
            WeightVal.ResetText();
            WeightUnit.ResetText();
            CalculatedCondition.ResetText();
            ReactionImage.BackgroundImage = null;
        }

        private void button2_Click(object sender, EventArgs e) { 

            if (HeightVal.Text == "" || HeightUnit.Text == "" || WeightVal.Text == "" || WeightUnit.Text == ""){

                MessageBox.Show(
                    "You have left one or two field empty",
                    "Insufficient Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error

                    );
                return;

    }
            double height = Convert.ToDouble(HeightVal.Text);
            double weight = Convert.ToDouble(WeightVal.Text);
            if (HeightUnit.Text == "ft")
                height /= 3.28;
            else if (HeightUnit.Text == "cm")
                height /= 100;
            if (WeightUnit.Text == "lb")
                weight *= 0.45359237;
            else if (WeightUnit.Text == "g")
                weight /= 1000;
            double BMI = weight / (height * height);
            if (BMI <= 18.5)
            {
                CalculatedCondition.Text = "Under Weight";
                ReactionImage.BackgroundImage = moodimages.Images[2];

            }
            else if (BMI <= 24.9)
            {
                CalculatedCondition.Text = "Normal Weight";
                ReactionImage.BackgroundImage = moodimages.Images[1];

            }
            else if (BMI <= 29.9)

            { 
                CalculatedCondition.Text = "Over Weight";
                ReactionImage.BackgroundImage = moodimages.Images[0];

            }
            else
            {
                CalculatedCondition.Text = "Obese";
                ReactionImage.BackgroundImage = moodimages.Images[2];
            }

        }

        private void BMI_Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
