
namespace PresentationProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadCTbl = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.custFname = new System.Windows.Forms.Label();
            this.custLname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.custFnamebx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.custLnamebx = new System.Windows.Forms.TextBox();
            this.cityBx = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.upDCust = new System.Windows.Forms.Button();
            this.DltCust = new System.Windows.Forms.Button();
            this.NewCust = new System.Windows.Forms.Button();
            this.LnameFilter = new System.Windows.Forms.CheckBox();
            this.CFilter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadCTbl
            // 
            this.LoadCTbl.Location = new System.Drawing.Point(56, 406);
            this.LoadCTbl.Name = "LoadCTbl";
            this.LoadCTbl.Size = new System.Drawing.Size(144, 23);
            this.LoadCTbl.TabIndex = 0;
            this.LoadCTbl.Text = "Search Customers";
            this.LoadCTbl.UseVisualStyleBackColor = true;
            this.LoadCTbl.Click += new System.EventHandler(this.LoadCTbl_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(319, 12);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 25;
            this.grid.Size = new System.Drawing.Size(723, 426);
            this.grid.TabIndex = 1;
            // 
            // custFname
            // 
            this.custFname.AutoSize = true;
            this.custFname.Location = new System.Drawing.Point(13, 13);
            this.custFname.Name = "custFname";
            this.custFname.Size = new System.Drawing.Size(64, 15);
            this.custFname.TabIndex = 2;
            this.custFname.Text = "First Name";
            // 
            // custLname
            // 
            this.custLname.AutoSize = true;
            this.custLname.Location = new System.Drawing.Point(13, 50);
            this.custLname.Name = "custLname";
            this.custLname.Size = new System.Drawing.Size(63, 15);
            this.custLname.TabIndex = 3;
            this.custLname.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "City";
            // 
            // custFnamebx
            // 
            this.custFnamebx.Location = new System.Drawing.Point(100, 13);
            this.custFnamebx.Name = "custFnamebx";
            this.custFnamebx.Size = new System.Drawing.Size(100, 23);
            this.custFnamebx.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone Number";
            // 
            // custLnamebx
            // 
            this.custLnamebx.Location = new System.Drawing.Point(100, 50);
            this.custLnamebx.Name = "custLnamebx";
            this.custLnamebx.Size = new System.Drawing.Size(100, 23);
            this.custLnamebx.TabIndex = 8;
            // 
            // cityBx
            // 
            this.cityBx.Location = new System.Drawing.Point(100, 86);
            this.cityBx.Name = "cityBx";
            this.cityBx.Size = new System.Drawing.Size(100, 23);
            this.cityBx.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 11;
            // 
            // upDCust
            // 
            this.upDCust.Location = new System.Drawing.Point(56, 369);
            this.upDCust.Name = "upDCust";
            this.upDCust.Size = new System.Drawing.Size(144, 23);
            this.upDCust.TabIndex = 12;
            this.upDCust.Text = "Update Customer";
            this.upDCust.UseVisualStyleBackColor = true;
            this.upDCust.Click += new System.EventHandler(this.upDCust_Click);
            // 
            // DltCust
            // 
            this.DltCust.Location = new System.Drawing.Point(56, 335);
            this.DltCust.Name = "DltCust";
            this.DltCust.Size = new System.Drawing.Size(144, 23);
            this.DltCust.TabIndex = 13;
            this.DltCust.Text = "Delete Customer";
            this.DltCust.UseVisualStyleBackColor = true;
            this.DltCust.Click += new System.EventHandler(this.DltCust_Click);
            // 
            // NewCust
            // 
            this.NewCust.Location = new System.Drawing.Point(56, 301);
            this.NewCust.Name = "NewCust";
            this.NewCust.Size = new System.Drawing.Size(144, 23);
            this.NewCust.TabIndex = 14;
            this.NewCust.Text = "Add Customer";
            this.NewCust.UseVisualStyleBackColor = true;
            this.NewCust.Click += new System.EventHandler(this.NewCust_Click);
            // 
            // LnameFilter
            // 
            this.LnameFilter.AutoSize = true;
            this.LnameFilter.Location = new System.Drawing.Point(230, 180);
            this.LnameFilter.Name = "LnameFilter";
            this.LnameFilter.Size = new System.Drawing.Size(82, 19);
            this.LnameFilter.TabIndex = 15;
            this.LnameFilter.Text = "Last Name";
            this.LnameFilter.UseVisualStyleBackColor = true;
            this.LnameFilter.CheckedChanged += new System.EventHandler(this.LnameFilter_CheckedChanged);
            // 
            // CFilter
            // 
            this.CFilter.AutoSize = true;
            this.CFilter.Location = new System.Drawing.Point(230, 229);
            this.CFilter.Name = "CFilter";
            this.CFilter.Size = new System.Drawing.Size(76, 19);
            this.CFilter.TabIndex = 16;
            this.CFilter.Text = "City Filter";
            this.CFilter.UseVisualStyleBackColor = true;
            this.CFilter.CheckedChanged += new System.EventHandler(this.CFilter_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 464);
            this.Controls.Add(this.CFilter);
            this.Controls.Add(this.LnameFilter);
            this.Controls.Add(this.NewCust);
            this.Controls.Add(this.DltCust);
            this.Controls.Add(this.upDCust);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cityBx);
            this.Controls.Add(this.custLnamebx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.custFnamebx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.custLname);
            this.Controls.Add(this.custFname);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.LoadCTbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadCTbl;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label custFname;
        private System.Windows.Forms.Label custLname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox custFnamebx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custLnamebx;
        private System.Windows.Forms.TextBox cityBx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button upDCust;
        private System.Windows.Forms.Button DltCust;
        private System.Windows.Forms.Button NewCust;
        private System.Windows.Forms.CheckBox LnameFilter;
        private System.Windows.Forms.CheckBox CFilter;
    }
}

