namespace EFDiyet2.PL
{
    partial class UserReportUI
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
            dateTimePicker1 = new DateTimePicker();
            dgvUserreport = new DataGridView();
            lblTotalCarb = new Label();
            lblTotalFat = new Label();
            lblTotalFiber = new Label();
            lblTotalProtein = new Label();
            lblCalorie = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUserreport).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // dgvUserreport
            // 
            dgvUserreport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserreport.Location = new Point(12, 41);
            dgvUserreport.Name = "dgvUserreport";
            dgvUserreport.Size = new Size(702, 315);
            dgvUserreport.TabIndex = 1;
            // 
            // lblTotalCarb
            // 
            lblTotalCarb.AutoSize = true;
            lblTotalCarb.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalCarb.Location = new Point(324, 415);
            lblTotalCarb.Name = "lblTotalCarb";
            lblTotalCarb.Size = new Size(147, 20);
            lblTotalCarb.TabIndex = 17;
            lblTotalCarb.Text = "Total Carbonhydrate:";
            // 
            // lblTotalFat
            // 
            lblTotalFat.AutoSize = true;
            lblTotalFat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalFat.Location = new Point(354, 384);
            lblTotalFat.Name = "lblTotalFat";
            lblTotalFat.Size = new Size(68, 20);
            lblTotalFat.TabIndex = 16;
            lblTotalFat.Text = "Total Fat:";
            // 
            // lblTotalFiber
            // 
            lblTotalFiber.AutoSize = true;
            lblTotalFiber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalFiber.Location = new Point(84, 447);
            lblTotalFiber.Name = "lblTotalFiber";
            lblTotalFiber.Size = new Size(82, 20);
            lblTotalFiber.TabIndex = 15;
            lblTotalFiber.Text = "Total Fiber:";
            // 
            // lblTotalProtein
            // 
            lblTotalProtein.AutoSize = true;
            lblTotalProtein.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalProtein.Location = new Point(84, 415);
            lblTotalProtein.Name = "lblTotalProtein";
            lblTotalProtein.Size = new Size(96, 20);
            lblTotalProtein.TabIndex = 14;
            lblTotalProtein.Text = "Total Protein:";
            // 
            // lblCalorie
            // 
            lblCalorie.AutoSize = true;
            lblCalorie.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCalorie.Location = new Point(84, 384);
            lblCalorie.Name = "lblCalorie";
            lblCalorie.Size = new Size(96, 20);
            lblCalorie.TabIndex = 13;
            lblCalorie.Text = "Total Calorie:";
            // 
            // UserReportUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 504);
            Controls.Add(lblTotalCarb);
            Controls.Add(lblTotalFat);
            Controls.Add(lblTotalFiber);
            Controls.Add(lblTotalProtein);
            Controls.Add(lblCalorie);
            Controls.Add(dgvUserreport);
            Controls.Add(dateTimePicker1);
            Name = "UserReportUI";
            Text = "UserReportUI";
            ((System.ComponentModel.ISupportInitialize)dgvUserreport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DataGridView dgvUserreport;
        private Label lblMaxMeal;
        private Label lblTotalCarb;
        private Label lblTotalFat;
        private Label lblTotalFiber;
        private Label lblTotalProtein;
        private Label lblCalorie;
    }
}