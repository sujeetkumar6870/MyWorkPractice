namespace BoralChartApplication
{
    partial class MainForm
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
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.ChartCreator = new System.Windows.Forms.Label();
            this.lblinput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblChartType = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cbxChartType = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(652, 77);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Browse";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(652, 120);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "Browse";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(338, 230);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(132, 23);
            this.btnChart.TabIndex = 2;
            this.btnChart.Text = "Load Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // ChartCreator
            // 
            this.ChartCreator.AutoSize = true;
            this.ChartCreator.Location = new System.Drawing.Point(363, 25);
            this.ChartCreator.Name = "ChartCreator";
            this.ChartCreator.Size = new System.Drawing.Size(68, 13);
            this.ChartCreator.TabIndex = 3;
            this.ChartCreator.Text = "Chart creator";
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Location = new System.Drawing.Point(127, 77);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(83, 13);
            this.lblinput.TabIndex = 4;
            this.lblinput.Text = "Select Input File";
            this.lblinput.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(127, 120);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(104, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Select Output Folder";
            // 
            // lblChartType
            // 
            this.lblChartType.AutoSize = true;
            this.lblChartType.Location = new System.Drawing.Point(127, 166);
            this.lblChartType.Name = "lblChartType";
            this.lblChartType.Size = new System.Drawing.Size(92, 13);
            this.lblChartType.TabIndex = 6;
            this.lblChartType.Text = "Select Chart Type";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(301, 77);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(345, 20);
            this.txtInput.TabIndex = 7;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(301, 120);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(345, 20);
            this.txtOutput.TabIndex = 8;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // cbxChartType
            // 
            this.cbxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChartType.FormattingEnabled = true;
            this.cbxChartType.IntegralHeight = false;
            this.cbxChartType.Items.AddRange(new object[] {
            "<Enter Graph Type>",
            "Column Chart",
            "Line Chart",
            "Pie Chart",
            "Doughnut Chart",
            "Bar Chart",
            "Area Chart",
            "XY (Scatter) Chart",
            "Bubble Chart",
            "Stock Chart",
            "Surface Chart",
            "Radar Chart",
            "Combo Chart"});
            this.cbxChartType.Location = new System.Drawing.Point(301, 166);
            this.cbxChartType.MaxDropDownItems = 5;
            this.cbxChartType.Name = "cbxChartType";
            this.cbxChartType.Size = new System.Drawing.Size(345, 21);
            this.cbxChartType.TabIndex = 9;
            this.cbxChartType.SelectedIndexChanged += new System.EventHandler(this.cbxChartType_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 291);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxChartType);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblChartType);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblinput);
            this.Controls.Add(this.ChartCreator);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnInput);
            this.Name = "MainForm";
            this.Text = "BoralChartApplication";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Label ChartCreator;
        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblChartType;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox cbxChartType;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

