namespace BMI_Calculator
{
    partial class BMI_Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMI_Calculator));
            this.ReactionImage = new System.Windows.Forms.Panel();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.HeightInfo = new System.Windows.Forms.Label();
            this.WeightInfo = new System.Windows.Forms.Label();
            this.HeightVal = new System.Windows.Forms.TextBox();
            this.WeightVal = new System.Windows.Forms.TextBox();
            this.HeightUnit = new System.Windows.Forms.ComboBox();
            this.WeightUnit = new System.Windows.Forms.ComboBox();
            this.moodimages = new System.Windows.Forms.ImageList(this.components);
            this.ClearEverything = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CalculatedCondition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReactionImage
            // 
            this.ReactionImage.Location = new System.Drawing.Point(12, 12);
            this.ReactionImage.Name = "ReactionImage";
            this.ReactionImage.Size = new System.Drawing.Size(152, 153);
            this.ReactionImage.TabIndex = 0;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(22, 227);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(85, 20);
            this.ConditionLabel.TabIndex = 1;
            this.ConditionLabel.Text = "Condition";
            // 
            // HeightInfo
            // 
            this.HeightInfo.AutoSize = true;
            this.HeightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInfo.Location = new System.Drawing.Point(270, 39);
            this.HeightInfo.Name = "HeightInfo";
            this.HeightInfo.Size = new System.Drawing.Size(62, 20);
            this.HeightInfo.TabIndex = 2;
            this.HeightInfo.Text = "Height";
            // 
            // WeightInfo
            // 
            this.WeightInfo.AutoSize = true;
            this.WeightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightInfo.Location = new System.Drawing.Point(270, 136);
            this.WeightInfo.Name = "WeightInfo";
            this.WeightInfo.Size = new System.Drawing.Size(65, 20);
            this.WeightInfo.TabIndex = 3;
            this.WeightInfo.Text = "Weight";
            // 
            // HeightVal
            // 
            this.HeightVal.Location = new System.Drawing.Point(271, 75);
            this.HeightVal.Name = "HeightVal";
            this.HeightVal.Size = new System.Drawing.Size(100, 20);
            this.HeightVal.TabIndex = 4;
            // 
            // WeightVal
            // 
            this.WeightVal.Location = new System.Drawing.Point(271, 176);
            this.WeightVal.Name = "WeightVal";
            this.WeightVal.Size = new System.Drawing.Size(100, 20);
            this.WeightVal.TabIndex = 5;
            // 
            // HeightUnit
            // 
            this.HeightUnit.FormattingEnabled = true;
            this.HeightUnit.Items.AddRange(new object[] {
            "m",
            "ft",
            "cm"});
            this.HeightUnit.Location = new System.Drawing.Point(399, 75);
            this.HeightUnit.Name = "HeightUnit";
            this.HeightUnit.Size = new System.Drawing.Size(35, 21);
            this.HeightUnit.TabIndex = 6;
            // 
            // WeightUnit
            // 
            this.WeightUnit.FormattingEnabled = true;
            this.WeightUnit.Items.AddRange(new object[] {
            "kg",
            "lb",
            "g"});
            this.WeightUnit.Location = new System.Drawing.Point(399, 175);
            this.WeightUnit.Name = "WeightUnit";
            this.WeightUnit.Size = new System.Drawing.Size(35, 21);
            this.WeightUnit.TabIndex = 7;
            // 
            // moodimages
            // 
            this.moodimages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moodimages.ImageStream")));
            this.moodimages.TransparentColor = System.Drawing.Color.Transparent;
            this.moodimages.Images.SetKeyName(0, "happy.jpeg");
            this.moodimages.Images.SetKeyName(1, "normal.jpeg");
            this.moodimages.Images.SetKeyName(2, "sad.jpeg");
            // 
            // ClearEverything
            // 
            this.ClearEverything.Location = new System.Drawing.Point(271, 223);
            this.ClearEverything.Name = "ClearEverything";
            this.ClearEverything.Size = new System.Drawing.Size(87, 23);
            this.ClearEverything.TabIndex = 8;
            this.ClearEverything.Text = "Clear";
            this.ClearEverything.UseVisualStyleBackColor = true;
            this.ClearEverything.Click += new System.EventHandler(this.ClearEverything_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "CalculateBMI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CalculatedCondition
            // 
            this.CalculatedCondition.AutoSize = true;
            this.CalculatedCondition.Location = new System.Drawing.Point(26, 270);
            this.CalculatedCondition.Name = "CalculatedCondition";
            this.CalculatedCondition.Size = new System.Drawing.Size(0, 13);
            this.CalculatedCondition.TabIndex = 10;
            // 
            // BMI_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 377);
            this.Controls.Add(this.CalculatedCondition);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClearEverything);
            this.Controls.Add(this.WeightUnit);
            this.Controls.Add(this.HeightUnit);
            this.Controls.Add(this.WeightVal);
            this.Controls.Add(this.HeightVal);
            this.Controls.Add(this.WeightInfo);
            this.Controls.Add(this.HeightInfo);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ReactionImage);
            this.Name = "BMI_Calculator";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMI_Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ReactionImage;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label HeightInfo;
        private System.Windows.Forms.Label WeightInfo;
        private System.Windows.Forms.TextBox HeightVal;
        private System.Windows.Forms.TextBox WeightVal;
        private System.Windows.Forms.ComboBox HeightUnit;
        private System.Windows.Forms.ComboBox WeightUnit;
        private System.Windows.Forms.ImageList moodimages;
        private System.Windows.Forms.Button ClearEverything;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label CalculatedCondition;
    }
}

