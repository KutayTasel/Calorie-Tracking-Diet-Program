namespace EFDiyet2.PL
{
    partial class AdminReport
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            lblMaxMeal = new Label();
            lblTotalCarb = new Label();
            lblTotalFat = new Label();
            lblTotalFiber = new Label();
            lblTotalProtein = new Label();
            lblCalorie = new Label();
            gboxDate = new GroupBox();
            dtvEnd = new DateTimePicker();
            dtvStart = new DateTimePicker();
            radioMonthly = new RadioButton();
            radioWeekly = new RadioButton();
            dgvFoodReport = new DataGridView();
            cboxUser = new ComboBox();
            btnGetReport = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gboxDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoodReport).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(lblMaxMeal);
            groupBox1.Controls.Add(lblTotalCarb);
            groupBox1.Controls.Add(lblTotalFat);
            groupBox1.Controls.Add(lblTotalFiber);
            groupBox1.Controls.Add(lblTotalProtein);
            groupBox1.Controls.Add(lblCalorie);
            groupBox1.Controls.Add(gboxDate);
            groupBox1.Controls.Add(dgvFoodReport);
            groupBox1.Controls.Add(cboxUser);
            groupBox1.Controls.Add(btnGetReport);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 494);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Food Report";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(369, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(407, 225);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consumed Foods:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(389, 197);
            dataGridView1.TabIndex = 14;
            // 
            // lblMaxMeal
            // 
            lblMaxMeal.AutoSize = true;
            lblMaxMeal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMaxMeal.Location = new Point(190, 382);
            lblMaxMeal.Name = "lblMaxMeal";
            lblMaxMeal.Size = new Size(77, 20);
            lblMaxMeal.TabIndex = 12;
            lblMaxMeal.Text = "Max Meal:";
            // 
            // lblTotalCarb
            // 
            lblTotalCarb.AutoSize = true;
            lblTotalCarb.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalCarb.Location = new Point(160, 350);
            lblTotalCarb.Name = "lblTotalCarb";
            lblTotalCarb.Size = new Size(147, 20);
            lblTotalCarb.TabIndex = 11;
            lblTotalCarb.Text = "Total Carbonhydrate:";
            // 
            // lblTotalFat
            // 
            lblTotalFat.AutoSize = true;
            lblTotalFat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalFat.Location = new Point(190, 319);
            lblTotalFat.Name = "lblTotalFat";
            lblTotalFat.Size = new Size(68, 20);
            lblTotalFat.TabIndex = 10;
            lblTotalFat.Text = "Total Fat:";
            // 
            // lblTotalFiber
            // 
            lblTotalFiber.AutoSize = true;
            lblTotalFiber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalFiber.Location = new Point(17, 382);
            lblTotalFiber.Name = "lblTotalFiber";
            lblTotalFiber.Size = new Size(82, 20);
            lblTotalFiber.TabIndex = 9;
            lblTotalFiber.Text = "Total Fiber:";
            // 
            // lblTotalProtein
            // 
            lblTotalProtein.AutoSize = true;
            lblTotalProtein.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalProtein.Location = new Point(17, 350);
            lblTotalProtein.Name = "lblTotalProtein";
            lblTotalProtein.Size = new Size(96, 20);
            lblTotalProtein.TabIndex = 8;
            lblTotalProtein.Text = "Total Protein:";
            // 
            // lblCalorie
            // 
            lblCalorie.AutoSize = true;
            lblCalorie.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCalorie.Location = new Point(17, 319);
            lblCalorie.Name = "lblCalorie";
            lblCalorie.Size = new Size(96, 20);
            lblCalorie.TabIndex = 7;
            lblCalorie.Text = "Total Calorie:";
            // 
            // gboxDate
            // 
            gboxDate.Controls.Add(dtvEnd);
            gboxDate.Controls.Add(dtvStart);
            gboxDate.Controls.Add(radioMonthly);
            gboxDate.Controls.Add(radioWeekly);
            gboxDate.Location = new Point(79, 61);
            gboxDate.Name = "gboxDate";
            gboxDate.Size = new Size(233, 137);
            gboxDate.TabIndex = 6;
            gboxDate.TabStop = false;
            // 
            // dtvEnd
            // 
            dtvEnd.Location = new Point(23, 60);
            dtvEnd.Name = "dtvEnd";
            dtvEnd.Size = new Size(200, 23);
            dtvEnd.TabIndex = 7;
            // 
            // dtvStart
            // 
            dtvStart.Location = new Point(23, 22);
            dtvStart.Name = "dtvStart";
            dtvStart.Size = new Size(200, 23);
            dtvStart.TabIndex = 5;
            dtvStart.ValueChanged += dtvStart_ValueChanged;
            // 
            // radioMonthly
            // 
            radioMonthly.AutoSize = true;
            radioMonthly.Location = new Point(134, 99);
            radioMonthly.Name = "radioMonthly";
            radioMonthly.Size = new Size(70, 19);
            radioMonthly.TabIndex = 4;
            radioMonthly.Text = "Monthly";
            radioMonthly.UseVisualStyleBackColor = true;
            radioMonthly.CheckedChanged += radioMonthly_CheckedChanged;
            // 
            // radioWeekly
            // 
            radioWeekly.AutoSize = true;
            radioWeekly.Checked = true;
            radioWeekly.Location = new Point(40, 99);
            radioWeekly.Name = "radioWeekly";
            radioWeekly.Size = new Size(63, 19);
            radioWeekly.TabIndex = 3;
            radioWeekly.TabStop = true;
            radioWeekly.Text = "Weekly";
            radioWeekly.UseVisualStyleBackColor = true;
            radioWeekly.CheckedChanged += radioWeekly_CheckedChanged;
            // 
            // dgvFoodReport
            // 
            dgvFoodReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodReport.Location = new Point(333, 22);
            dgvFoodReport.Name = "dgvFoodReport";
            dgvFoodReport.Size = new Size(437, 226);
            dgvFoodReport.TabIndex = 5;
            // 
            // cboxUser
            // 
            cboxUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxUser.FormattingEnabled = true;
            cboxUser.Location = new Point(79, 25);
            cboxUser.Name = "cboxUser";
            cboxUser.Size = new Size(214, 23);
            cboxUser.TabIndex = 3;
            // 
            // btnGetReport
            // 
            btnGetReport.Location = new Point(79, 204);
            btnGetReport.Name = "btnGetReport";
            btnGetReport.Size = new Size(98, 58);
            btnGetReport.TabIndex = 1;
            btnGetReport.Text = "Get Report";
            btnGetReport.UseVisualStyleBackColor = true;
            btnGetReport.Click += btnGetReport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 28);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "User:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 72);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 16;
            label2.Text = "Date:";
            // 
            // AdminReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminReport";
            Text = "AdminRapor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gboxDate.ResumeLayout(false);
            gboxDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoodReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboxUser;
        private Button btnGetReport;
        private DataGridView dgvFoodReport;
        private GroupBox gboxDate;
        private RadioButton radioMonthly;
        private RadioButton radioWeekly;
        private DateTimePicker dtvEnd;
        private DateTimePicker dtvStart;
        private Label lblCalorie;
        private Label lblTotalCarb;
        private Label lblTotalFat;
        private Label lblTotalFiber;
        private Label lblTotalProtein;
        private Label lblMaxMeal;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
    }
}