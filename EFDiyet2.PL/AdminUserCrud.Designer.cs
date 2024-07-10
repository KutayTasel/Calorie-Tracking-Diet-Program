namespace EFDiyet2.PL
{
    partial class AdminUserCrud
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
            gBoxFoodCategory = new GroupBox();
            groupBox1 = new GroupBox();
            btnUSERADMIN = new Button();
            btnADMIN = new Button();
            btnLISTALL = new Button();
            btnDELETE = new Button();
            groupBox3 = new GroupBox();
            label10 = new Label();
            btnSEARCH = new Button();
            label8 = new Label();
            txtSEARCH = new TextBox();
            dtwUSER = new DataGridView();
            gBoxFoodCategory.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtwUSER).BeginInit();
            SuspendLayout();
            // 
            // gBoxFoodCategory
            // 
            gBoxFoodCategory.Controls.Add(groupBox1);
            gBoxFoodCategory.Controls.Add(groupBox3);
            gBoxFoodCategory.Location = new Point(12, 13);
            gBoxFoodCategory.Margin = new Padding(3, 4, 3, 4);
            gBoxFoodCategory.Name = "gBoxFoodCategory";
            gBoxFoodCategory.Padding = new Padding(3, 4, 3, 4);
            gBoxFoodCategory.Size = new Size(975, 473);
            gBoxFoodCategory.TabIndex = 30;
            gBoxFoodCategory.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUSERADMIN);
            groupBox1.Controls.Add(btnADMIN);
            groupBox1.Controls.Add(btnLISTALL);
            groupBox1.Controls.Add(btnDELETE);
            groupBox1.Location = new Point(7, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 338);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manage Users";
            // 
            // btnUSERADMIN
            // 
            btnUSERADMIN.Location = new Point(99, 184);
            btnUSERADMIN.Name = "btnUSERADMIN";
            btnUSERADMIN.Size = new Size(177, 51);
            btnUSERADMIN.TabIndex = 30;
            btnUSERADMIN.Text = "MAKE USER TO ADMIN";
            btnUSERADMIN.UseVisualStyleBackColor = true;
            btnUSERADMIN.Click += button1_Click;
            // 
            // btnADMIN
            // 
            btnADMIN.Location = new Point(21, 59);
            btnADMIN.Name = "btnADMIN";
            btnADMIN.Size = new Size(139, 96);
            btnADMIN.TabIndex = 28;
            btnADMIN.Text = "MAKE ADMIN TO USER";
            btnADMIN.UseVisualStyleBackColor = true;
            btnADMIN.Click += btnADMIN_Click;
            // 
            // btnLISTALL
            // 
            btnLISTALL.Location = new Point(99, 259);
            btnLISTALL.Name = "btnLISTALL";
            btnLISTALL.Size = new Size(177, 51);
            btnLISTALL.TabIndex = 27;
            btnLISTALL.Text = "LIST ALL USERS";
            btnLISTALL.UseVisualStyleBackColor = true;
            btnLISTALL.Click += btnLISTALL_Click_1;
            // 
            // btnDELETE
            // 
            btnDELETE.Location = new Point(188, 59);
            btnDELETE.Name = "btnDELETE";
            btnDELETE.Size = new Size(153, 96);
            btnDELETE.TabIndex = 2;
            btnDELETE.Text = "DELETE";
            btnDELETE.UseVisualStyleBackColor = true;
            btnDELETE.Click += btnDELETE_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnSEARCH);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtSEARCH);
            groupBox3.Controls.Add(dtwUSER);
            groupBox3.Location = new Point(384, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(577, 427);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "User";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 43);
            label10.Name = "label10";
            label10.Size = new Size(129, 20);
            label10.TabIndex = 29;
            label10.Text = "Sought After User:";
            // 
            // btnSEARCH
            // 
            btnSEARCH.Location = new Point(342, 39);
            btnSEARCH.Name = "btnSEARCH";
            btnSEARCH.Size = new Size(150, 31);
            btnSEARCH.TabIndex = 30;
            btnSEARCH.Text = "SEARCH USER";
            btnSEARCH.UseVisualStyleBackColor = true;
            btnSEARCH.Click += btnSEARCH_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 77);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 20;
            label8.Text = "CHOSEN CATEGORY:";
            // 
            // txtSEARCH
            // 
            txtSEARCH.Location = new Point(197, 39);
            txtSEARCH.Name = "txtSEARCH";
            txtSEARCH.Size = new Size(125, 27);
            txtSEARCH.TabIndex = 28;
            // 
            // dtwUSER
            // 
            dtwUSER.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtwUSER.Location = new Point(27, 123);
            dtwUSER.Name = "dtwUSER";
            dtwUSER.RowHeadersWidth = 51;
            dtwUSER.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtwUSER.Size = new Size(526, 283);
            dtwUSER.TabIndex = 0;
            dtwUSER.CellClick += dtwUSER_CellClick;
            // 
            // AdminUserCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 506);
            Controls.Add(gBoxFoodCategory);
            Name = "AdminUserCrud";
            Text = "AdminUserCrud";
            gBoxFoodCategory.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtwUSER).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxFoodCategory;
        private GroupBox groupBox1;
        private Button btnLISTALL;
        private Button btnADD;
        private Button btnDELETE;
        private Label label1;
        private TextBox txtNAME;
        private GroupBox groupBox3;
        private Label label10;
        private Button btnSEARCH;
        private Label label8;
        private TextBox txtSEARCH;
        private DataGridView dtwUSER;
        private Button btnADMIN;
        private Button btnUSERADMIN;
    }
}