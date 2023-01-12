namespace Hospital_management
{
    partial class PatientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pfntxt = new System.Windows.Forms.TextBox();
            this.plntxt = new System.Windows.Forms.TextBox();
            this.pdctxt = new System.Windows.Forms.TextBox();
            this.pidtxt = new System.Windows.Forms.TextBox();
            this.psntxt = new System.Windows.Forms.TextBox();
            this.pbtxt = new System.Windows.Forms.TextBox();
            this.pdstxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "DeptCode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "PatientID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "SectionNo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Balance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "DischargeStatus:";
            // 
            // pfntxt
            // 
            this.pfntxt.Location = new System.Drawing.Point(204, 53);
            this.pfntxt.Name = "pfntxt";
            this.pfntxt.Size = new System.Drawing.Size(231, 26);
            this.pfntxt.TabIndex = 7;
            this.pfntxt.TextChanged += new System.EventHandler(this.pfntxt_TextChanged);
            // 
            // plntxt
            // 
            this.plntxt.Location = new System.Drawing.Point(204, 103);
            this.plntxt.Name = "plntxt";
            this.plntxt.Size = new System.Drawing.Size(231, 26);
            this.plntxt.TabIndex = 8;
            // 
            // pdctxt
            // 
            this.pdctxt.Location = new System.Drawing.Point(204, 165);
            this.pdctxt.Name = "pdctxt";
            this.pdctxt.Size = new System.Drawing.Size(231, 26);
            this.pdctxt.TabIndex = 9;
            // 
            // pidtxt
            // 
            this.pidtxt.Location = new System.Drawing.Point(204, 227);
            this.pidtxt.Name = "pidtxt";
            this.pidtxt.Size = new System.Drawing.Size(231, 26);
            this.pidtxt.TabIndex = 10;
            // 
            // psntxt
            // 
            this.psntxt.Location = new System.Drawing.Point(204, 282);
            this.psntxt.Name = "psntxt";
            this.psntxt.Size = new System.Drawing.Size(231, 26);
            this.psntxt.TabIndex = 11;
            // 
            // pbtxt
            // 
            this.pbtxt.Location = new System.Drawing.Point(204, 330);
            this.pbtxt.Name = "pbtxt";
            this.pbtxt.Size = new System.Drawing.Size(231, 26);
            this.pbtxt.TabIndex = 12;
            // 
            // pdstxt
            // 
            this.pdstxt.Location = new System.Drawing.Point(204, 381);
            this.pdstxt.Name = "pdstxt";
            this.pdstxt.Size = new System.Drawing.Size(231, 26);
            this.pdstxt.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(509, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 50);
            this.button3.TabIndex = 16;
            this.button3.Text = "DeletePatient";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(610, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 50);
            this.button4.TabIndex = 17;
            this.button4.Text = "Mainmenu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 432);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(982, 150);
            this.dataGridView.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(751, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 50);
            this.button5.TabIndex = 19;
            this.button5.Text = "Display";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(751, 153);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(170, 50);
            this.button6.TabIndex = 20;
            this.button6.Text = "search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 584);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pdstxt);
            this.Controls.Add(this.pbtxt);
            this.Controls.Add(this.psntxt);
            this.Controls.Add(this.pidtxt);
            this.Controls.Add(this.pdctxt);
            this.Controls.Add(this.plntxt);
            this.Controls.Add(this.pfntxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pfntxt;
        private System.Windows.Forms.TextBox plntxt;
        private System.Windows.Forms.TextBox pdctxt;
        private System.Windows.Forms.TextBox pidtxt;
        private System.Windows.Forms.TextBox psntxt;
        private System.Windows.Forms.TextBox pbtxt;
        private System.Windows.Forms.TextBox pdstxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}