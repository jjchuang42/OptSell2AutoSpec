namespace WindowsFormsApplication2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ezDataGridView1 = new TSS.UI.EzDataGridView();
            this.Call_Deal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Call_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Put_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Put_Deal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ezDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ezDataGridView1
            // 
            this.ezDataGridView1.AllowUserToAddRows = false;
            this.ezDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ezDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ezDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ezDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Call_Deal,
            this.Call_Price,
            this.Column1,
            this.Put_Price,
            this.Put_Deal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("細明體", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ezDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.ezDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ezDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ezDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.ezDataGridView1.MultiSelect = false;
            this.ezDataGridView1.Name = "ezDataGridView1";
            this.ezDataGridView1.ReadOnly = true;
            this.ezDataGridView1.RowHeadersVisible = false;
            this.ezDataGridView1.RowTemplate.Height = 27;
            this.ezDataGridView1.Size = new System.Drawing.Size(584, 408);
            this.ezDataGridView1.TabIndex = 0;
            // 
            // Call_Deal
            // 
            this.Call_Deal.HeaderText = "Call_Deal";
            this.Call_Deal.Name = "Call_Deal";
            this.Call_Deal.ReadOnly = true;
            // 
            // Call_Price
            // 
            this.Call_Price.HeaderText = "Call_Price";
            this.Call_Price.Name = "Call_Price";
            this.Call_Price.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Commodity";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Put_Price
            // 
            this.Put_Price.HeaderText = "Put_Price";
            this.Put_Price.Name = "Put_Price";
            this.Put_Price.ReadOnly = true;
            // 
            // Put_Deal
            // 
            this.Put_Deal.HeaderText = "Put_Deal";
            this.Put_Deal.Name = "Put_Deal";
            this.Put_Deal.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 408);
            this.Controls.Add(this.ezDataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ezDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TSS.UI.EzDataGridView ezDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Call_Deal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Call_Price;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Put_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Put_Deal;
    }
}