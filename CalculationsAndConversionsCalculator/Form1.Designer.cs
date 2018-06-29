namespace CalculationsAndConversionsCalculator
{
    partial class FormMain
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
            this.comboBoxChooseType = new System.Windows.Forms.ComboBox();
            this.labelSelectType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxChooseType
            // 
            this.comboBoxChooseType.FormattingEnabled = true;
            this.comboBoxChooseType.Items.AddRange(new object[] {
            "Circuitry",
            "Math Formulas",
            "Conversions",
            "Miscellaneous"});
            this.comboBoxChooseType.Location = new System.Drawing.Point(269, 79);
            this.comboBoxChooseType.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxChooseType.Name = "comboBoxChooseType";
            this.comboBoxChooseType.Size = new System.Drawing.Size(316, 39);
            this.comboBoxChooseType.TabIndex = 66;
            this.comboBoxChooseType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseType_SelectedIndexChanged);
            this.comboBoxChooseType.SelectedValueChanged += new System.EventHandler(this.comboBoxChooseType_SelectedValueChanged);
            // 
            // labelSelectType
            // 
            this.labelSelectType.AutoSize = true;
            this.labelSelectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectType.Location = new System.Drawing.Point(272, 34);
            this.labelSelectType.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelSelectType.Name = "labelSelectType";
            this.labelSelectType.Size = new System.Drawing.Size(176, 32);
            this.labelSelectType.TabIndex = 67;
            this.labelSelectType.Text = "Select Type";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 287);
            this.Controls.Add(this.labelSelectType);
            this.Controls.Add(this.comboBoxChooseType);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversions and Calculations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxChooseType;
        private System.Windows.Forms.Label labelSelectType;
    }
}

