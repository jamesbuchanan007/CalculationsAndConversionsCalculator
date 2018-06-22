namespace CalculationsAndConversionsCalculator
{
    partial class formCircuitry
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
            this.buttonCircuitryHome = new System.Windows.Forms.Button();
            this.buttonCircuitryExit = new System.Windows.Forms.Button();
            this.labelDirections = new System.Windows.Forms.Label();
            this.labelCircuitCapacitors = new System.Windows.Forms.Label();
            this.textBoxCapacitorParallel = new System.Windows.Forms.TextBox();
            this.textBoxCapacitorSeries = new System.Windows.Forms.TextBox();
            this.labelCapacitorsParallel = new System.Windows.Forms.Label();
            this.labelCapacitorsSeries = new System.Windows.Forms.Label();
            this.labelCircuitInductors = new System.Windows.Forms.Label();
            this.textBoxInductorParallel = new System.Windows.Forms.TextBox();
            this.textBoxInductorSeries = new System.Windows.Forms.TextBox();
            this.labelInductorsParallel = new System.Windows.Forms.Label();
            this.labelInductorsSeries = new System.Windows.Forms.Label();
            this.labelCircuitResistors = new System.Windows.Forms.Label();
            this.buttonCircuitResistanceClear = new System.Windows.Forms.Button();
            this.textBoxResistorParallel = new System.Windows.Forms.TextBox();
            this.textBoxResistorSeries = new System.Windows.Forms.TextBox();
            this.labelParallelResistance = new System.Windows.Forms.Label();
            this.labelCircuitOutput = new System.Windows.Forms.Label();
            this.labelSeriesResistance = new System.Windows.Forms.Label();
            this.buttonCircuitResistanceCalculate = new System.Windows.Forms.Button();
            this.textBoxCircuitryOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCircuitryHome
            // 
            this.buttonCircuitryHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCircuitryHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCircuitryHome.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCircuitryHome.Location = new System.Drawing.Point(12, 328);
            this.buttonCircuitryHome.Name = "buttonCircuitryHome";
            this.buttonCircuitryHome.Size = new System.Drawing.Size(75, 23);
            this.buttonCircuitryHome.TabIndex = 9;
            this.buttonCircuitryHome.Text = "Home";
            this.buttonCircuitryHome.UseVisualStyleBackColor = false;
            this.buttonCircuitryHome.Click += new System.EventHandler(this.buttonCircuitryHome_Click);
            // 
            // buttonCircuitryExit
            // 
            this.buttonCircuitryExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCircuitryExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCircuitryExit.ForeColor = System.Drawing.Color.White;
            this.buttonCircuitryExit.Location = new System.Drawing.Point(284, 328);
            this.buttonCircuitryExit.Name = "buttonCircuitryExit";
            this.buttonCircuitryExit.Size = new System.Drawing.Size(75, 23);
            this.buttonCircuitryExit.TabIndex = 10;
            this.buttonCircuitryExit.Text = "Exit Program";
            this.buttonCircuitryExit.UseVisualStyleBackColor = false;
            this.buttonCircuitryExit.Click += new System.EventHandler(this.buttonCircuitryExit_Click);
            // 
            // labelDirections
            // 
            this.labelDirections.AutoSize = true;
            this.labelDirections.Location = new System.Drawing.Point(20, 272);
            this.labelDirections.Name = "labelDirections";
            this.labelDirections.Size = new System.Drawing.Size(333, 13);
            this.labelDirections.TabIndex = 91;
            this.labelDirections.Text = "Enter Series / Parallel values to pertinent columns and click calculate";
            // 
            // labelCircuitCapacitors
            // 
            this.labelCircuitCapacitors.AutoSize = true;
            this.labelCircuitCapacitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCircuitCapacitors.Location = new System.Drawing.Point(252, 10);
            this.labelCircuitCapacitors.Name = "labelCircuitCapacitors";
            this.labelCircuitCapacitors.Size = new System.Drawing.Size(95, 20);
            this.labelCircuitCapacitors.TabIndex = 117;
            this.labelCircuitCapacitors.Text = "Capacitors";
            // 
            // textBoxCapacitorParallel
            // 
            this.textBoxCapacitorParallel.Location = new System.Drawing.Point(308, 53);
            this.textBoxCapacitorParallel.Multiline = true;
            this.textBoxCapacitorParallel.Name = "textBoxCapacitorParallel";
            this.textBoxCapacitorParallel.Size = new System.Drawing.Size(41, 138);
            this.textBoxCapacitorParallel.TabIndex = 6;
            // 
            // textBoxCapacitorSeries
            // 
            this.textBoxCapacitorSeries.Location = new System.Drawing.Point(251, 53);
            this.textBoxCapacitorSeries.Multiline = true;
            this.textBoxCapacitorSeries.Name = "textBoxCapacitorSeries";
            this.textBoxCapacitorSeries.Size = new System.Drawing.Size(46, 138);
            this.textBoxCapacitorSeries.TabIndex = 5;
            // 
            // labelCapacitorsParallel
            // 
            this.labelCapacitorsParallel.AutoSize = true;
            this.labelCapacitorsParallel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacitorsParallel.Location = new System.Drawing.Point(304, 37);
            this.labelCapacitorsParallel.Name = "labelCapacitorsParallel";
            this.labelCapacitorsParallel.Size = new System.Drawing.Size(49, 13);
            this.labelCapacitorsParallel.TabIndex = 114;
            this.labelCapacitorsParallel.Text = "Parallel";
            this.labelCapacitorsParallel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCapacitorsSeries
            // 
            this.labelCapacitorsSeries.AutoSize = true;
            this.labelCapacitorsSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacitorsSeries.Location = new System.Drawing.Point(253, 37);
            this.labelCapacitorsSeries.Name = "labelCapacitorsSeries";
            this.labelCapacitorsSeries.Size = new System.Drawing.Size(42, 13);
            this.labelCapacitorsSeries.TabIndex = 113;
            this.labelCapacitorsSeries.Text = "Series";
            this.labelCapacitorsSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCircuitInductors
            // 
            this.labelCircuitInductors.AutoSize = true;
            this.labelCircuitInductors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCircuitInductors.Location = new System.Drawing.Point(142, 9);
            this.labelCircuitInductors.Name = "labelCircuitInductors";
            this.labelCircuitInductors.Size = new System.Drawing.Size(85, 20);
            this.labelCircuitInductors.TabIndex = 112;
            this.labelCircuitInductors.Text = "Inductors";
            // 
            // textBoxInductorParallel
            // 
            this.textBoxInductorParallel.Location = new System.Drawing.Point(195, 53);
            this.textBoxInductorParallel.Multiline = true;
            this.textBoxInductorParallel.Name = "textBoxInductorParallel";
            this.textBoxInductorParallel.Size = new System.Drawing.Size(41, 138);
            this.textBoxInductorParallel.TabIndex = 4;
            // 
            // textBoxInductorSeries
            // 
            this.textBoxInductorSeries.Location = new System.Drawing.Point(138, 53);
            this.textBoxInductorSeries.Multiline = true;
            this.textBoxInductorSeries.Name = "textBoxInductorSeries";
            this.textBoxInductorSeries.Size = new System.Drawing.Size(46, 138);
            this.textBoxInductorSeries.TabIndex = 3;
            // 
            // labelInductorsParallel
            // 
            this.labelInductorsParallel.AutoSize = true;
            this.labelInductorsParallel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInductorsParallel.Location = new System.Drawing.Point(191, 37);
            this.labelInductorsParallel.Name = "labelInductorsParallel";
            this.labelInductorsParallel.Size = new System.Drawing.Size(49, 13);
            this.labelInductorsParallel.TabIndex = 109;
            this.labelInductorsParallel.Text = "Parallel";
            this.labelInductorsParallel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInductorsSeries
            // 
            this.labelInductorsSeries.AutoSize = true;
            this.labelInductorsSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInductorsSeries.Location = new System.Drawing.Point(140, 37);
            this.labelInductorsSeries.Name = "labelInductorsSeries";
            this.labelInductorsSeries.Size = new System.Drawing.Size(42, 13);
            this.labelInductorsSeries.TabIndex = 108;
            this.labelInductorsSeries.Text = "Series";
            this.labelInductorsSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCircuitResistors
            // 
            this.labelCircuitResistors.AutoSize = true;
            this.labelCircuitResistors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCircuitResistors.Location = new System.Drawing.Point(29, 9);
            this.labelCircuitResistors.Name = "labelCircuitResistors";
            this.labelCircuitResistors.Size = new System.Drawing.Size(85, 20);
            this.labelCircuitResistors.TabIndex = 107;
            this.labelCircuitResistors.Text = "Resistors";
            // 
            // buttonCircuitResistanceClear
            // 
            this.buttonCircuitResistanceClear.BackColor = System.Drawing.Color.Red;
            this.buttonCircuitResistanceClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCircuitResistanceClear.ForeColor = System.Drawing.Color.White;
            this.buttonCircuitResistanceClear.Location = new System.Drawing.Point(227, 224);
            this.buttonCircuitResistanceClear.Name = "buttonCircuitResistanceClear";
            this.buttonCircuitResistanceClear.Size = new System.Drawing.Size(75, 23);
            this.buttonCircuitResistanceClear.TabIndex = 8;
            this.buttonCircuitResistanceClear.Text = "Clear";
            this.buttonCircuitResistanceClear.UseVisualStyleBackColor = false;
            this.buttonCircuitResistanceClear.Click += new System.EventHandler(this.buttonCircuitResistanceClear_Click);
            // 
            // textBoxResistorParallel
            // 
            this.textBoxResistorParallel.Location = new System.Drawing.Point(79, 52);
            this.textBoxResistorParallel.Multiline = true;
            this.textBoxResistorParallel.Name = "textBoxResistorParallel";
            this.textBoxResistorParallel.Size = new System.Drawing.Size(41, 138);
            this.textBoxResistorParallel.TabIndex = 2;
            // 
            // textBoxResistorSeries
            // 
            this.textBoxResistorSeries.Location = new System.Drawing.Point(22, 52);
            this.textBoxResistorSeries.Multiline = true;
            this.textBoxResistorSeries.Name = "textBoxResistorSeries";
            this.textBoxResistorSeries.Size = new System.Drawing.Size(46, 138);
            this.textBoxResistorSeries.TabIndex = 1;
            // 
            // labelParallelResistance
            // 
            this.labelParallelResistance.AutoSize = true;
            this.labelParallelResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParallelResistance.Location = new System.Drawing.Point(75, 36);
            this.labelParallelResistance.Name = "labelParallelResistance";
            this.labelParallelResistance.Size = new System.Drawing.Size(49, 13);
            this.labelParallelResistance.TabIndex = 102;
            this.labelParallelResistance.Text = "Parallel";
            this.labelParallelResistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCircuitOutput
            // 
            this.labelCircuitOutput.AutoSize = true;
            this.labelCircuitOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCircuitOutput.Location = new System.Drawing.Point(117, 202);
            this.labelCircuitOutput.Name = "labelCircuitOutput";
            this.labelCircuitOutput.Size = new System.Drawing.Size(36, 13);
            this.labelCircuitOutput.TabIndex = 103;
            this.labelCircuitOutput.Text = "Total";
            this.labelCircuitOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSeriesResistance
            // 
            this.labelSeriesResistance.AutoSize = true;
            this.labelSeriesResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeriesResistance.Location = new System.Drawing.Point(24, 36);
            this.labelSeriesResistance.Name = "labelSeriesResistance";
            this.labelSeriesResistance.Size = new System.Drawing.Size(42, 13);
            this.labelSeriesResistance.TabIndex = 100;
            this.labelSeriesResistance.Text = "Series";
            this.labelSeriesResistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCircuitResistanceCalculate
            // 
            this.buttonCircuitResistanceCalculate.BackColor = System.Drawing.Color.Lime;
            this.buttonCircuitResistanceCalculate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCircuitResistanceCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCircuitResistanceCalculate.ForeColor = System.Drawing.Color.Black;
            this.buttonCircuitResistanceCalculate.Location = new System.Drawing.Point(78, 224);
            this.buttonCircuitResistanceCalculate.Name = "buttonCircuitResistanceCalculate";
            this.buttonCircuitResistanceCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCircuitResistanceCalculate.TabIndex = 7;
            this.buttonCircuitResistanceCalculate.Text = "Calculate";
            this.buttonCircuitResistanceCalculate.UseVisualStyleBackColor = false;
            this.buttonCircuitResistanceCalculate.Click += new System.EventHandler(this.buttonCircuitResistanceCalculate_Click_1);
            // 
            // textBoxCircuitryOutput
            // 
            this.textBoxCircuitryOutput.Location = new System.Drawing.Point(159, 198);
            this.textBoxCircuitryOutput.Name = "textBoxCircuitryOutput";
            this.textBoxCircuitryOutput.ReadOnly = true;
            this.textBoxCircuitryOutput.Size = new System.Drawing.Size(100, 20);
            this.textBoxCircuitryOutput.TabIndex = 118;
            this.textBoxCircuitryOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // formCircuitry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 363);
            this.Controls.Add(this.textBoxCircuitryOutput);
            this.Controls.Add(this.labelCircuitCapacitors);
            this.Controls.Add(this.textBoxCapacitorParallel);
            this.Controls.Add(this.textBoxCapacitorSeries);
            this.Controls.Add(this.labelCapacitorsParallel);
            this.Controls.Add(this.labelCapacitorsSeries);
            this.Controls.Add(this.labelCircuitInductors);
            this.Controls.Add(this.textBoxInductorParallel);
            this.Controls.Add(this.textBoxInductorSeries);
            this.Controls.Add(this.labelInductorsParallel);
            this.Controls.Add(this.labelInductorsSeries);
            this.Controls.Add(this.labelCircuitResistors);
            this.Controls.Add(this.buttonCircuitResistanceClear);
            this.Controls.Add(this.textBoxResistorParallel);
            this.Controls.Add(this.textBoxResistorSeries);
            this.Controls.Add(this.labelParallelResistance);
            this.Controls.Add(this.labelCircuitOutput);
            this.Controls.Add(this.labelSeriesResistance);
            this.Controls.Add(this.buttonCircuitResistanceCalculate);
            this.Controls.Add(this.labelDirections);
            this.Controls.Add(this.buttonCircuitryExit);
            this.Controls.Add(this.buttonCircuitryHome);
            this.Name = "formCircuitry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circuitry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCircuitryHome;
        private System.Windows.Forms.Button buttonCircuitryExit;
        private System.Windows.Forms.Label labelDirections;
        private System.Windows.Forms.Label labelCircuitCapacitors;
        private System.Windows.Forms.TextBox textBoxCapacitorParallel;
        private System.Windows.Forms.TextBox textBoxCapacitorSeries;
        private System.Windows.Forms.Label labelCapacitorsParallel;
        private System.Windows.Forms.Label labelCapacitorsSeries;
        private System.Windows.Forms.Label labelCircuitInductors;
        private System.Windows.Forms.TextBox textBoxInductorParallel;
        private System.Windows.Forms.TextBox textBoxInductorSeries;
        private System.Windows.Forms.Label labelInductorsParallel;
        private System.Windows.Forms.Label labelInductorsSeries;
        private System.Windows.Forms.Label labelCircuitResistors;
        private System.Windows.Forms.Button buttonCircuitResistanceClear;
        private System.Windows.Forms.TextBox textBoxResistorParallel;
        private System.Windows.Forms.TextBox textBoxResistorSeries;
        private System.Windows.Forms.Label labelParallelResistance;
        private System.Windows.Forms.Label labelCircuitOutput;
        private System.Windows.Forms.Label labelSeriesResistance;
        private System.Windows.Forms.Button buttonCircuitResistanceCalculate;
        private System.Windows.Forms.TextBox textBoxCircuitryOutput;
    }
}