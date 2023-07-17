namespace SGBD_Lab1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewShops = new System.Windows.Forms.DataGridView();
            this.dataGridViewAngestellte = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtMatNr = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtLohn = new System.Windows.Forms.TextBox();
            this.labelMatNr = new System.Windows.Forms.Label();
            this.labelLohn = new System.Windows.Forms.Label();
            this.labelVorname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAngestellte)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.connButton_Click);
            // 
            // dataGridViewShops
            // 
            this.dataGridViewShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShops.Location = new System.Drawing.Point(28, 71);
            this.dataGridViewShops.Name = "dataGridViewShops";
            this.dataGridViewShops.RowHeadersWidth = 62;
            this.dataGridViewShops.RowTemplate.Height = 28;
            this.dataGridViewShops.Size = new System.Drawing.Size(538, 300);
            this.dataGridViewShops.TabIndex = 1;
            this.dataGridViewShops.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShops_CellClick);
            // 
            // dataGridViewAngestellte
            // 
            this.dataGridViewAngestellte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAngestellte.Location = new System.Drawing.Point(603, 71);
            this.dataGridViewAngestellte.Name = "dataGridViewAngestellte";
            this.dataGridViewAngestellte.RowHeadersWidth = 62;
            this.dataGridViewAngestellte.RowTemplate.Height = 28;
            this.dataGridViewAngestellte.Size = new System.Drawing.Size(626, 300);
            this.dataGridViewAngestellte.TabIndex = 2;
            this.dataGridViewAngestellte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAngestellte_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Insert Angestellte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(677, 559);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete Angestellte";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(482, 558);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 41);
            this.button4.TabIndex = 5;
            this.button4.Text = "Update Angestellte";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // txtMatNr
            // 
            this.txtMatNr.Location = new System.Drawing.Point(1017, 395);
            this.txtMatNr.Multiline = true;
            this.txtMatNr.Name = "txtMatNr";
            this.txtMatNr.Size = new System.Drawing.Size(156, 29);
            this.txtMatNr.TabIndex = 6;
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(759, 443);
            this.txtVorname.Multiline = true;
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(156, 31);
            this.txtVorname.TabIndex = 9;
            // 
            // txtLohn
            // 
            this.txtLohn.Location = new System.Drawing.Point(1017, 443);
            this.txtLohn.Multiline = true;
            this.txtLohn.Name = "txtLohn";
            this.txtLohn.Size = new System.Drawing.Size(156, 31);
            this.txtLohn.TabIndex = 11;
            // 
            // labelMatNr
            // 
            this.labelMatNr.AutoSize = true;
            this.labelMatNr.Location = new System.Drawing.Point(948, 398);
            this.labelMatNr.Name = "labelMatNr";
            this.labelMatNr.Size = new System.Drawing.Size(60, 20);
            this.labelMatNr.TabIndex = 14;
            this.labelMatNr.Text = "MatNr :";
            // 
            // labelLohn
            // 
            this.labelLohn.AutoSize = true;
            this.labelLohn.Location = new System.Drawing.Point(954, 449);
            this.labelLohn.Name = "labelLohn";
            this.labelLohn.Size = new System.Drawing.Size(57, 20);
            this.labelLohn.TabIndex = 15;
            this.labelLohn.Text = "Lohn : ";
            // 
            // labelVorname
            // 
            this.labelVorname.AutoSize = true;
            this.labelVorname.Location = new System.Drawing.Point(667, 446);
            this.labelVorname.Name = "labelVorname";
            this.labelVorname.Size = new System.Drawing.Size(86, 20);
            this.labelVorname.TabIndex = 16;
            this.labelVorname.Text = "Vorname : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(759, 397);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 29);
            this.txtName.TabIndex = 17;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(690, 397);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 20);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Name : ";
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(759, 487);
            this.txtCNP.Multiline = true;
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(156, 30);
            this.txtCNP.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "CNP : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelVorname);
            this.Controls.Add(this.labelLohn);
            this.Controls.Add(this.labelMatNr);
            this.Controls.Add(this.txtLohn);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.txtMatNr);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewAngestellte);
            this.Controls.Add(this.dataGridViewShops);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Konditorei";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAngestellte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewShops;
        private System.Windows.Forms.DataGridView dataGridViewAngestellte;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtMatNr;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtLohn;
        private System.Windows.Forms.Label labelMatNr;
        private System.Windows.Forms.Label labelLohn;
        private System.Windows.Forms.Label labelVorname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label label1;
    }
}

