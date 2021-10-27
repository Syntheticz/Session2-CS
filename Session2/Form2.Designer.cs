
namespace Session2
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AssetSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_closed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssetSN,
            this.AssetName,
            this.last_closed,
            this.number_em});
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(685, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Assets: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send Emergency Maintinance Request";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AssetSN
            // 
            this.AssetSN.DataPropertyName = "AssetSN";
            this.AssetSN.Frozen = true;
            this.AssetSN.HeaderText = "AssetSN";
            this.AssetSN.Name = "AssetSN";
            this.AssetSN.ReadOnly = true;
            this.AssetSN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AssetSN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AssetName
            // 
            this.AssetName.DataPropertyName = "AssetName";
            this.AssetName.Frozen = true;
            this.AssetName.HeaderText = "Asset Name";
            this.AssetName.Name = "AssetName";
            this.AssetName.ReadOnly = true;
            this.AssetName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AssetName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AssetName.Width = 300;
            // 
            // last_closed
            // 
            this.last_closed.DataPropertyName = "EMEndDate";
            this.last_closed.Frozen = true;
            this.last_closed.HeaderText = "Last Closed EM";
            this.last_closed.Name = "last_closed";
            this.last_closed.ReadOnly = true;
            this.last_closed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.last_closed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.last_closed.Width = 150;
            // 
            // number_em
            // 
            this.number_em.DataPropertyName = "number_em";
            this.number_em.Frozen = true;
            this.number_em.HeaderText = "Number EM";
            this.number_em.Name = "number_em";
            this.number_em.ReadOnly = true;
            this.number_em.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.number_em.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.number_em.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_closed;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_em;
    }
}