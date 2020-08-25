namespace FarmSystem.Fornecedor
{
    partial class Frmlistaproduto
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
            this.dvgprod = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgprod)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgprod
            // 
            this.dvgprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgprod.Location = new System.Drawing.Point(12, 54);
            this.dvgprod.Name = "dvgprod";
            this.dvgprod.Size = new System.Drawing.Size(763, 352);
            this.dvgprod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Procurar:";
            // 
            // txtbusca
            // 
            this.txtbusca.Location = new System.Drawing.Point(270, 19);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(242, 20);
            this.txtbusca.TabIndex = 2;
            this.txtbusca.TextChanged += new System.EventHandler(this.txtbusca_TextChanged);
            // 
            // Frmlistaproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgprod);
            this.Name = "Frmlistaproduto";
            this.Text = "Frmlistaproduto";
            ((System.ComponentModel.ISupportInitialize)(this.dvgprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgprod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbusca;
    }
}