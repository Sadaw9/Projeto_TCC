namespace CondoFrame
{
    partial class frmPorteiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPorteiro));
            this.lblCodPort = new System.Windows.Forms.Label();
            this.lblNomePort = new System.Windows.Forms.Label();
            this.lblRgPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamePort = new System.Windows.Forms.TextBox();
            this.mtxtRGPort = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPFPort = new System.Windows.Forms.MaskedTextBox();
            this.mtxtdtADDPort = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDTDemPort = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_porteiro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_porteiro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodPort
            // 
            this.lblCodPort.AutoSize = true;
            this.lblCodPort.Location = new System.Drawing.Point(27, 30);
            this.lblCodPort.Name = "lblCodPort";
            this.lblCodPort.Size = new System.Drawing.Size(126, 17);
            this.lblCodPort.TabIndex = 0;
            this.lblCodPort.Text = "Código do Porteiro";
            // 
            // lblNomePort
            // 
            this.lblNomePort.AutoSize = true;
            this.lblNomePort.Location = new System.Drawing.Point(27, 75);
            this.lblNomePort.Name = "lblNomePort";
            this.lblNomePort.Size = new System.Drawing.Size(119, 17);
            this.lblNomePort.TabIndex = 1;
            this.lblNomePort.Text = "Nome do Porteiro";
            // 
            // lblRgPort
            // 
            this.lblRgPort.AutoSize = true;
            this.lblRgPort.Location = new System.Drawing.Point(27, 129);
            this.lblRgPort.Name = "lblRgPort";
            this.lblRgPort.Size = new System.Drawing.Size(29, 17);
            this.lblRgPort.TabIndex = 2;
            this.lblRgPort.Text = "RG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de Admissão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de Demissão";
            // 
            // txtNamePort
            // 
            this.txtNamePort.Location = new System.Drawing.Point(29, 95);
            this.txtNamePort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamePort.Name = "txtNamePort";
            this.txtNamePort.Size = new System.Drawing.Size(220, 22);
            this.txtNamePort.TabIndex = 6;
            // 
            // mtxtRGPort
            // 
            this.mtxtRGPort.Location = new System.Drawing.Point(29, 150);
            this.mtxtRGPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtRGPort.Mask = "00\\.000\\.000-0>A";
            this.mtxtRGPort.Name = "mtxtRGPort";
            this.mtxtRGPort.Size = new System.Drawing.Size(123, 22);
            this.mtxtRGPort.TabIndex = 7;
            // 
            // mtxtCPFPort
            // 
            this.mtxtCPFPort.Location = new System.Drawing.Point(29, 204);
            this.mtxtCPFPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtCPFPort.Mask = "000\\.000\\.000-00";
            this.mtxtCPFPort.Name = "mtxtCPFPort";
            this.mtxtCPFPort.Size = new System.Drawing.Size(123, 22);
            this.mtxtCPFPort.TabIndex = 8;
            // 
            // mtxtdtADDPort
            // 
            this.mtxtdtADDPort.Location = new System.Drawing.Point(29, 263);
            this.mtxtdtADDPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtdtADDPort.Mask = "00/00/0000";
            this.mtxtdtADDPort.Name = "mtxtdtADDPort";
            this.mtxtdtADDPort.Size = new System.Drawing.Size(100, 22);
            this.mtxtdtADDPort.TabIndex = 9;
            this.mtxtdtADDPort.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtDTDemPort
            // 
            this.mtxtDTDemPort.Location = new System.Drawing.Point(29, 327);
            this.mtxtDTDemPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtDTDemPort.Mask = "00/00/0000";
            this.mtxtDTDemPort.Name = "mtxtDTDemPort";
            this.mtxtDTDemPort.Size = new System.Drawing.Size(100, 22);
            this.mtxtDTDemPort.TabIndex = 10;
            this.mtxtDTDemPort.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Código";
            // 
            // dgv_porteiro
            // 
            this.dgv_porteiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_porteiro.Location = new System.Drawing.Point(276, 30);
            this.dgv_porteiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_porteiro.Name = "dgv_porteiro";
            this.dgv_porteiro.RowHeadersWidth = 51;
            this.dgv_porteiro.Size = new System.Drawing.Size(508, 322);
            this.dgv_porteiro.TabIndex = 12;
            // 
            // frmPorteiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.dgv_porteiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtDTDemPort);
            this.Controls.Add(this.mtxtdtADDPort);
            this.Controls.Add(this.mtxtCPFPort);
            this.Controls.Add(this.mtxtRGPort);
            this.Controls.Add(this.txtNamePort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRgPort);
            this.Controls.Add(this.lblNomePort);
            this.Controls.Add(this.lblCodPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPorteiro";
            this.Text = "Cadastro de Porteiro";
            this.Load += new System.EventHandler(this.frmPorteiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_porteiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodPort;
        private System.Windows.Forms.Label lblNomePort;
        private System.Windows.Forms.Label lblRgPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamePort;
        private System.Windows.Forms.MaskedTextBox mtxtRGPort;
        private System.Windows.Forms.MaskedTextBox mtxtCPFPort;
        private System.Windows.Forms.MaskedTextBox mtxtdtADDPort;
        private System.Windows.Forms.MaskedTextBox mtxtDTDemPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_porteiro;
    }
}