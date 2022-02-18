namespace RyanLateFeeCalculator
{
    partial class frmLateFeeCalculator
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxLateFee = new System.Windows.Forms.TextBox();
            this.txtBoxDaysLate = new System.Windows.Forms.TextBox();
            this.txtBoxCurrentDate = new System.Windows.Forms.TextBox();
            this.txtBoxDueDate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.labelLateFee = new System.Windows.Forms.Label();
            this.labelDaysLate = new System.Windows.Forms.Label();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.lblNumberOfMovies = new System.Windows.Forms.Label();
            this.txtBoxNumberOfMovies = new System.Windows.Forms.TextBox();
            this.lblNumberOfMoviesError = new System.Windows.Forms.Label();
            this.lblDueDateError = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.customerTypeCombobox = new System.Windows.Forms.ComboBox();
            this.lblMoviesReturned = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(214, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxLateFee
            // 
            this.txtBoxLateFee.Location = new System.Drawing.Point(242, 327);
            this.txtBoxLateFee.Name = "txtBoxLateFee";
            this.txtBoxLateFee.ReadOnly = true;
            this.txtBoxLateFee.Size = new System.Drawing.Size(152, 23);
            this.txtBoxLateFee.TabIndex = 11;
            this.txtBoxLateFee.TabStop = false;
            // 
            // txtBoxDaysLate
            // 
            this.txtBoxDaysLate.Location = new System.Drawing.Point(242, 275);
            this.txtBoxDaysLate.Name = "txtBoxDaysLate";
            this.txtBoxDaysLate.ReadOnly = true;
            this.txtBoxDaysLate.Size = new System.Drawing.Size(152, 23);
            this.txtBoxDaysLate.TabIndex = 9;
            this.txtBoxDaysLate.TabStop = false;
            // 
            // txtBoxCurrentDate
            // 
            this.txtBoxCurrentDate.Location = new System.Drawing.Point(241, 174);
            this.txtBoxCurrentDate.Name = "txtBoxCurrentDate";
            this.txtBoxCurrentDate.ReadOnly = true;
            this.txtBoxCurrentDate.Size = new System.Drawing.Size(152, 23);
            this.txtBoxCurrentDate.TabIndex = 5;
            // 
            // txtBoxDueDate
            // 
            this.txtBoxDueDate.Location = new System.Drawing.Point(242, 66);
            this.txtBoxDueDate.Name = "txtBoxDueDate";
            this.txtBoxDueDate.Size = new System.Drawing.Size(152, 23);
            this.txtBoxDueDate.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalculate.Location = new System.Drawing.Point(79, 371);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(151, 33);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculateClick);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReturn.Location = new System.Drawing.Point(243, 371);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(151, 33);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // labelLateFee
            // 
            this.labelLateFee.AutoSize = true;
            this.labelLateFee.Location = new System.Drawing.Point(79, 335);
            this.labelLateFee.Name = "labelLateFee";
            this.labelLateFee.Size = new System.Drawing.Size(50, 15);
            this.labelLateFee.TabIndex = 10;
            this.labelLateFee.Text = "Late Fee";
            // 
            // labelDaysLate
            // 
            this.labelDaysLate.AutoSize = true;
            this.labelDaysLate.Location = new System.Drawing.Point(79, 283);
            this.labelDaysLate.Name = "labelDaysLate";
            this.labelDaysLate.Size = new System.Drawing.Size(120, 15);
            this.labelDaysLate.TabIndex = 8;
            this.labelDaysLate.Text = "Number Of Days Late";
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Location = new System.Drawing.Point(79, 182);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(74, 15);
            this.labelCurrentDate.TabIndex = 4;
            this.labelCurrentDate.Text = "Current Date";
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(79, 74);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(55, 15);
            this.labelDueDate.TabIndex = 0;
            this.labelDueDate.Text = "&Due Date";
            // 
            // lblNumberOfMovies
            // 
            this.lblNumberOfMovies.AutoSize = true;
            this.lblNumberOfMovies.Location = new System.Drawing.Point(79, 230);
            this.lblNumberOfMovies.Name = "lblNumberOfMovies";
            this.lblNumberOfMovies.Size = new System.Drawing.Size(108, 15);
            this.lblNumberOfMovies.TabIndex = 6;
            this.lblNumberOfMovies.Text = "&Number Of Movies";
            // 
            // txtBoxNumberOfMovies
            // 
            this.txtBoxNumberOfMovies.Location = new System.Drawing.Point(241, 222);
            this.txtBoxNumberOfMovies.Name = "txtBoxNumberOfMovies";
            this.txtBoxNumberOfMovies.Size = new System.Drawing.Size(151, 23);
            this.txtBoxNumberOfMovies.TabIndex = 7;
            // 
            // lblNumberOfMoviesError
            // 
            this.lblNumberOfMoviesError.AutoSize = true;
            this.lblNumberOfMoviesError.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfMoviesError.ForeColor = System.Drawing.Color.Red;
            this.lblNumberOfMoviesError.Location = new System.Drawing.Point(241, 248);
            this.lblNumberOfMoviesError.Name = "lblNumberOfMoviesError";
            this.lblNumberOfMoviesError.Size = new System.Drawing.Size(128, 12);
            this.lblNumberOfMoviesError.TabIndex = 17;
            this.lblNumberOfMoviesError.Text = "Should Be Integer Value (1,2,....)";
            this.lblNumberOfMoviesError.Visible = false;
            // 
            // lblDueDateError
            // 
            this.lblDueDateError.AutoSize = true;
            this.lblDueDateError.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDueDateError.ForeColor = System.Drawing.Color.Red;
            this.lblDueDateError.Location = new System.Drawing.Point(243, 92);
            this.lblDueDateError.Name = "lblDueDateError";
            this.lblDueDateError.Size = new System.Drawing.Size(147, 12);
            this.lblDueDateError.TabIndex = 16;
            this.lblDueDateError.Text = "Should be in (YYYY-MM-DD) Format";
            this.lblDueDateError.Visible = false;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Location = new System.Drawing.Point(79, 132);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(86, 15);
            this.lblCustomerType.TabIndex = 2;
            this.lblCustomerType.Text = "&Customer Type";
            // 
            // customerTypeCombobox
            // 
            this.customerTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerTypeCombobox.FormattingEnabled = true;
            this.customerTypeCombobox.Items.AddRange(new object[] {
            "New",
            "Junior",
            "Loyal"});
            this.customerTypeCombobox.Location = new System.Drawing.Point(242, 124);
            this.customerTypeCombobox.Name = "customerTypeCombobox";
            this.customerTypeCombobox.Size = new System.Drawing.Size(151, 23);
            this.customerTypeCombobox.TabIndex = 3;
            // 
            // lblMoviesReturned
            // 
            this.lblMoviesReturned.AutoSize = true;
            this.lblMoviesReturned.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoviesReturned.Location = new System.Drawing.Point(413, 11);
            this.lblMoviesReturned.Name = "lblMoviesReturned";
            this.lblMoviesReturned.Size = new System.Drawing.Size(105, 17);
            this.lblMoviesReturned.TabIndex = 14;
            this.lblMoviesReturned.Text = "Movies Counter";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCounter.ForeColor = System.Drawing.Color.Red;
            this.lblCounter.Location = new System.Drawing.Point(454, 34);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(15, 17);
            this.lblCounter.TabIndex = 15;
            this.lblCounter.Text = "0";
            // 
            // frmLateFeeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(530, 439);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblMoviesReturned);
            this.Controls.Add(this.customerTypeCombobox);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.lblDueDateError);
            this.Controls.Add(this.lblNumberOfMoviesError);
            this.Controls.Add(this.txtBoxNumberOfMovies);
            this.Controls.Add(this.lblNumberOfMovies);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBoxLateFee);
            this.Controls.Add(this.txtBoxDaysLate);
            this.Controls.Add(this.txtBoxCurrentDate);
            this.Controls.Add(this.txtBoxDueDate);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.labelLateFee);
            this.Controls.Add(this.labelDaysLate);
            this.Controls.Add(this.labelCurrentDate);
            this.Controls.Add(this.labelDueDate);
            this.Name = "frmLateFeeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ryan\'s Late Fee Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private TextBox txtBoxLateFee;
        private TextBox txtBoxDaysLate;
        private TextBox txtBoxCurrentDate;
        private TextBox txtBoxDueDate;
        private Button btnCalculate;
        private Button btnReturn;
        private Label labelLateFee;
        private Label labelDaysLate;
        private Label labelCurrentDate;
        private Label labelDueDate;
        private Label lblNumberOfMovies;
        private TextBox txtBoxNumberOfMovies;
        private Label lblNumberOfMoviesError;
        private Label lblDueDateError;
        private Label lblCustomerType;
        private ComboBox customerTypeCombobox;
        private Label lblMoviesReturned;
        private Label lblCounter;
    }
}