namespace EFDiyet2.PL
{
    partial class FoodCrud
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
            dtwFOOD = new DataGridView();
            btnADD = new Button();
            btnDELETE = new Button();
            btnUPDATE = new Button();
            txtNAME = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCALORIE = new TextBox();
            txtFAT = new TextBox();
            txtPROTEIN = new TextBox();
            txtCARBONHYDRATE = new TextBox();
            txtFIBER = new TextBox();
            groupBox1 = new GroupBox();
            btnPCFND = new Button();
            cmbFOODCATEGORY = new ComboBox();
            pctCHOOSENFOOD = new PictureBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            txtSEARCH = new TextBox();
            label9 = new Label();
            btnSEARCH = new Button();
            groupBox4 = new GroupBox();
            btnLISTALL = new Button();
            ((System.ComponentModel.ISupportInitialize)dtwFOOD).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctCHOOSENFOOD).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dtwFOOD
            // 
            dtwFOOD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtwFOOD.Location = new Point(24, 68);
            dtwFOOD.Margin = new Padding(3, 2, 3, 2);
            dtwFOOD.Name = "dtwFOOD";
            dtwFOOD.RowHeadersWidth = 51;
            dtwFOOD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtwFOOD.Size = new Size(564, 473);
            dtwFOOD.TabIndex = 0;
            dtwFOOD.CellClick += dtwFOOD_CellClick;
            // 
            // btnADD
            // 
            btnADD.Location = new Point(18, 40);
            btnADD.Margin = new Padding(3, 2, 3, 2);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(82, 22);
            btnADD.TabIndex = 1;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnADD_Click_1;
            // 
            // btnDELETE
            // 
            btnDELETE.Location = new Point(291, 40);
            btnDELETE.Margin = new Padding(3, 2, 3, 2);
            btnDELETE.Name = "btnDELETE";
            btnDELETE.Size = new Size(82, 22);
            btnDELETE.TabIndex = 2;
            btnDELETE.Text = "DELETE";
            btnDELETE.UseVisualStyleBackColor = true;
            btnDELETE.Click += btnDELETE_Click;
            // 
            // btnUPDATE
            // 
            btnUPDATE.Location = new Point(152, 40);
            btnUPDATE.Margin = new Padding(3, 2, 3, 2);
            btnUPDATE.Name = "btnUPDATE";
            btnUPDATE.Size = new Size(82, 22);
            btnUPDATE.TabIndex = 3;
            btnUPDATE.Text = "UPDATE";
            btnUPDATE.UseVisualStyleBackColor = true;
            btnUPDATE.Click += btnUPDATE_Click;
            // 
            // txtNAME
            // 
            txtNAME.Location = new Point(141, 28);
            txtNAME.Margin = new Padding(3, 2, 3, 2);
            txtNAME.Name = "txtNAME";
            txtNAME.Size = new Size(110, 23);
            txtNAME.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 33);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "NAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 77);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "CALORIE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 120);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 7;
            label3.Text = "FAT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 160);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 8;
            label4.Text = "PROTEIN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 199);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 9;
            label5.Text = "CARBONHYDRATE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 236);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 10;
            label6.Text = "FIBER:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 278);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 11;
            label7.Text = "FOODCATEGORY:";
            // 
            // txtCALORIE
            // 
            txtCALORIE.Location = new Point(141, 75);
            txtCALORIE.Margin = new Padding(3, 2, 3, 2);
            txtCALORIE.Name = "txtCALORIE";
            txtCALORIE.Size = new Size(110, 23);
            txtCALORIE.TabIndex = 12;
            // 
            // txtFAT
            // 
            txtFAT.Location = new Point(141, 118);
            txtFAT.Margin = new Padding(3, 2, 3, 2);
            txtFAT.Name = "txtFAT";
            txtFAT.Size = new Size(110, 23);
            txtFAT.TabIndex = 13;
            // 
            // txtPROTEIN
            // 
            txtPROTEIN.Location = new Point(141, 158);
            txtPROTEIN.Margin = new Padding(3, 2, 3, 2);
            txtPROTEIN.Name = "txtPROTEIN";
            txtPROTEIN.Size = new Size(110, 23);
            txtPROTEIN.TabIndex = 14;
            // 
            // txtCARBONHYDRATE
            // 
            txtCARBONHYDRATE.Location = new Point(141, 194);
            txtCARBONHYDRATE.Margin = new Padding(3, 2, 3, 2);
            txtCARBONHYDRATE.Name = "txtCARBONHYDRATE";
            txtCARBONHYDRATE.Size = new Size(110, 23);
            txtCARBONHYDRATE.TabIndex = 15;
            // 
            // txtFIBER
            // 
            txtFIBER.Location = new Point(141, 233);
            txtFIBER.Margin = new Padding(3, 2, 3, 2);
            txtFIBER.Name = "txtFIBER";
            txtFIBER.Size = new Size(110, 23);
            txtFIBER.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPCFND);
            groupBox1.Controls.Add(cmbFOODCATEGORY);
            groupBox1.Controls.Add(pctCHOOSENFOOD);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNAME);
            groupBox1.Controls.Add(txtFIBER);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCARBONHYDRATE);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPROTEIN);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFAT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCALORIE);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(27, 187);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(598, 327);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnPCFND
            // 
            btnPCFND.Location = new Point(314, 217);
            btnPCFND.Margin = new Padding(3, 2, 3, 2);
            btnPCFND.Name = "btnPCFND";
            btnPCFND.Size = new Size(96, 53);
            btnPCFND.TabIndex = 27;
            btnPCFND.Text = "FIND PICTURE";
            btnPCFND.UseVisualStyleBackColor = true;
            btnPCFND.Click += btnPCFND_Click_1;
            // 
            // cmbFOODCATEGORY
            // 
            cmbFOODCATEGORY.FormattingEnabled = true;
            cmbFOODCATEGORY.Location = new Point(141, 275);
            cmbFOODCATEGORY.Margin = new Padding(3, 2, 3, 2);
            cmbFOODCATEGORY.Name = "cmbFOODCATEGORY";
            cmbFOODCATEGORY.Size = new Size(133, 23);
            cmbFOODCATEGORY.TabIndex = 24;
            // 
            // pctCHOOSENFOOD
            // 
            pctCHOOSENFOOD.Location = new Point(314, 40);
            pctCHOOSENFOOD.Margin = new Padding(3, 2, 3, 2);
            pctCHOOSENFOOD.Name = "pctCHOOSENFOOD";
            pctCHOOSENFOOD.Size = new Size(264, 173);
            pctCHOOSENFOOD.SizeMode = PictureBoxSizeMode.Zoom;
            pctCHOOSENFOOD.TabIndex = 23;
            pctCHOOSENFOOD.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnADD);
            groupBox2.Controls.Add(btnDELETE);
            groupBox2.Controls.Add(btnUPDATE);
            groupBox2.Location = new Point(27, 518);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(423, 94);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 22);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 20;
            label8.Text = "CHOSEN FOOD:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtwFOOD);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(670, 25);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(609, 556);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // txtSEARCH
            // 
            txtSEARCH.Location = new Point(169, 37);
            txtSEARCH.Margin = new Padding(3, 2, 3, 2);
            txtSEARCH.Name = "txtSEARCH";
            txtSEARCH.Size = new Size(110, 23);
            txtSEARCH.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 42);
            label9.Name = "label9";
            label9.Size = new Size(107, 15);
            label9.TabIndex = 23;
            label9.Text = "Sought After Food:";
            // 
            // btnSEARCH
            // 
            btnSEARCH.Location = new Point(346, 35);
            btnSEARCH.Margin = new Padding(3, 2, 3, 2);
            btnSEARCH.Name = "btnSEARCH";
            btnSEARCH.Size = new Size(155, 22);
            btnSEARCH.TabIndex = 24;
            btnSEARCH.Text = "SEARCH FOOD";
            btnSEARCH.UseVisualStyleBackColor = true;
            btnSEARCH.Click += btnSEARCH_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnLISTALL);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(btnSEARCH);
            groupBox4.Controls.Add(txtSEARCH);
            groupBox4.Location = new Point(27, 35);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(578, 140);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // btnLISTALL
            // 
            btnLISTALL.Location = new Point(23, 94);
            btnLISTALL.Margin = new Padding(3, 2, 3, 2);
            btnLISTALL.Name = "btnLISTALL";
            btnLISTALL.Size = new Size(155, 22);
            btnLISTALL.TabIndex = 28;
            btnLISTALL.Text = "LIST ALL FOODS";
            btnLISTALL.UseVisualStyleBackColor = true;
            btnLISTALL.Click += btnLISTALL_Click;
            // 
            // FoodCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 702);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FoodCrud";
            Text = "FoodCrud";
            ((System.ComponentModel.ISupportInitialize)dtwFOOD).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctCHOOSENFOOD).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtwFOOD;
        private Button btnADD;
        private Button btnDELETE;
        private Button btnUPDATE;
        private TextBox txtNAME;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCALORIE;
        private TextBox txtFAT;
        private TextBox txtPROTEIN;
        private TextBox txtCARBONHYDRATE;
        private TextBox txtFIBER;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private GroupBox groupBox3;
        private ComboBox cmbFOODCATEGORY;
        private PictureBox pctCHOOSENFOOD;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox txtSEARCH;
        private Label label9;
        private Button btnSEARCH;
        private GroupBox groupBox4;
        private Button btnPCFND;
        private Button btnLISTALL;
    }
}