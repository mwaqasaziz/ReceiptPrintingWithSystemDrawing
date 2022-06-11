namespace ReceiptPrinting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvPrint = new System.Windows.Forms.DataGridView();
            this.DgvColProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColUnitRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.ComBoxPrinters = new System.Windows.Forms.ComboBox();
            this.LblDisPrinter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPrint
            // 
            this.DgvPrint.AllowUserToAddRows = false;
            this.DgvPrint.AllowUserToDeleteRows = false;
            this.DgvPrint.AllowUserToResizeColumns = false;
            this.DgvPrint.AllowUserToResizeRows = false;
            this.DgvPrint.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvPrint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPrint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvColProduct,
            this.DgvColQ,
            this.DgvColUnitRate,
            this.DgvColAmount});
            this.DgvPrint.Location = new System.Drawing.Point(12, 63);
            this.DgvPrint.Name = "DgvPrint";
            this.DgvPrint.ReadOnly = true;
            this.DgvPrint.RowHeadersVisible = false;
            this.DgvPrint.RowTemplate.Height = 25;
            this.DgvPrint.Size = new System.Drawing.Size(274, 170);
            this.DgvPrint.TabIndex = 0;
            // 
            // DgvColProduct
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DgvColProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvColProduct.FillWeight = 55F;
            this.DgvColProduct.HeaderText = "Product";
            this.DgvColProduct.MaxInputLength = 150;
            this.DgvColProduct.Name = "DgvColProduct";
            this.DgvColProduct.ReadOnly = true;
            this.DgvColProduct.Width = 141;
            // 
            // DgvColQ
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DgvColQ.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvColQ.FillWeight = 10F;
            this.DgvColQ.HeaderText = "Q";
            this.DgvColQ.MaxInputLength = 2;
            this.DgvColQ.Name = "DgvColQ";
            this.DgvColQ.ReadOnly = true;
            this.DgvColQ.Width = 25;
            // 
            // DgvColUnitRate
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DgvColUnitRate.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvColUnitRate.FillWeight = 15F;
            this.DgvColUnitRate.HeaderText = "$/Q";
            this.DgvColUnitRate.MaxInputLength = 4;
            this.DgvColUnitRate.Name = "DgvColUnitRate";
            this.DgvColUnitRate.ReadOnly = true;
            this.DgvColUnitRate.Width = 39;
            // 
            // DgvColAmount
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DgvColAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvColAmount.FillWeight = 20F;
            this.DgvColAmount.HeaderText = "Amount";
            this.DgvColAmount.MaxInputLength = 5;
            this.DgvColAmount.Name = "DgvColAmount";
            this.DgvColAmount.ReadOnly = true;
            this.DgvColAmount.Width = 51;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(199, 239);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(75, 23);
            this.BtnPrint.TabIndex = 1;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // ComBoxPrinters
            // 
            this.ComBoxPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxPrinters.FormattingEnabled = true;
            this.ComBoxPrinters.Location = new System.Drawing.Point(12, 34);
            this.ComBoxPrinters.Name = "ComBoxPrinters";
            this.ComBoxPrinters.Size = new System.Drawing.Size(269, 23);
            this.ComBoxPrinters.TabIndex = 2;
            this.ComBoxPrinters.SelectedIndexChanged += new System.EventHandler(this.ComBoxPrinters_SelectedIndexChanged);
            // 
            // LblDisPrinter
            // 
            this.LblDisPrinter.AutoSize = true;
            this.LblDisPrinter.Location = new System.Drawing.Point(12, 9);
            this.LblDisPrinter.Name = "LblDisPrinter";
            this.LblDisPrinter.Size = new System.Drawing.Size(76, 15);
            this.LblDisPrinter.TabIndex = 3;
            this.LblDisPrinter.Text = "Select Printer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 274);
            this.Controls.Add(this.LblDisPrinter);
            this.Controls.Add(this.ComBoxPrinters);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.DgvPrint);
            this.Name = "Form1";
            this.Text = "Printer Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DgvPrint;
        private Button BtnPrint;
        private DataGridViewTextBoxColumn DgvColProduct;
        private DataGridViewTextBoxColumn DgvColQ;
        private DataGridViewTextBoxColumn DgvColUnitRate;
        private DataGridViewTextBoxColumn DgvColAmount;
        private ComboBox ComBoxPrinters;
        private Label LblDisPrinter;
    }
}