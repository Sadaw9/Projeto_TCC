namespace CondoFrame
{
    partial class frmCondomino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCondomino));
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNomeCond = new System.Windows.Forms.Label();
            this.lblNumApt = new System.Windows.Forms.Label();
            this.lblTelCond = new System.Windows.Forms.Label();
            this.lblEmailCond = new System.Windows.Forms.Label();
            this.lblDataEnt = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCond = new System.Windows.Forms.TextBox();
            this.mskNumApt = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskEmailCond = new System.Windows.Forms.MaskedTextBox();
            this.mskEntradaCond = new System.Windows.Forms.MaskedTextBox();
            this.mskSaidaCondo = new System.Windows.Forms.MaskedTextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.dgv_porteiro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_porteiro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(24, 27);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(98, 13);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF do Condômino";
            // 
            // lblNomeCond
            // 
            this.lblNomeCond.AutoSize = true;
            this.lblNomeCond.Location = new System.Drawing.Point(24, 70);
            this.lblNomeCond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCond.Name = "lblNomeCond";
            this.lblNomeCond.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCond.TabIndex = 1;
            this.lblNomeCond.Text = "Nome";
            // 
            // lblNumApt
            // 
            this.lblNumApt.AutoSize = true;
            this.lblNumApt.Location = new System.Drawing.Point(24, 114);
            this.lblNumApt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumApt.Name = "lblNumApt";
            this.lblNumApt.Size = new System.Drawing.Size(121, 13);
            this.lblNumApt.TabIndex = 2;
            this.lblNumApt.Text = "Número do apartamento";
            this.lblNumApt.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTelCond
            // 
            this.lblTelCond.AutoSize = true;
            this.lblTelCond.Location = new System.Drawing.Point(24, 158);
            this.lblTelCond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelCond.Name = "lblTelCond";
            this.lblTelCond.Size = new System.Drawing.Size(49, 13);
            this.lblTelCond.TabIndex = 3;
            this.lblTelCond.Text = "Telefone";
            // 
            // lblEmailCond
            // 
            this.lblEmailCond.AutoSize = true;
            this.lblEmailCond.Location = new System.Drawing.Point(24, 201);
            this.lblEmailCond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailCond.Name = "lblEmailCond";
            this.lblEmailCond.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCond.TabIndex = 4;
            this.lblEmailCond.Text = "E-mail";
            // 
            // lblDataEnt
            // 
            this.lblDataEnt.AutoSize = true;
            this.lblDataEnt.Location = new System.Drawing.Point(24, 245);
            this.lblDataEnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataEnt.Name = "lblDataEnt";
            this.lblDataEnt.Size = new System.Drawing.Size(85, 13);
            this.lblDataEnt.TabIndex = 5;
            this.lblDataEnt.Text = "Data de Entrada";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(24, 290);
            this.lblDataSaida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(77, 13);
            this.lblDataSaida.TabIndex = 6;
            this.lblDataSaida.Text = "Data de Saída";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(24, 336);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(26, 43);
            this.mskCPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskCPF.Mask = "000\\.000\\.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(96, 20);
            this.mskCPF.TabIndex = 8;
            // 
            // txtNomeCond
            // 
            this.txtNomeCond.Location = new System.Drawing.Point(26, 87);
            this.txtNomeCond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeCond.Name = "txtNomeCond";
            this.txtNomeCond.Size = new System.Drawing.Size(213, 20);
            this.txtNomeCond.TabIndex = 9;
            // 
            // mskNumApt
            // 
            this.mskNumApt.Location = new System.Drawing.Point(26, 131);
            this.mskNumApt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskNumApt.Mask = "009";
            this.mskNumApt.Name = "mskNumApt";
            this.mskNumApt.Size = new System.Drawing.Size(35, 20);
            this.mskNumApt.TabIndex = 10;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(26, 175);
            this.mskTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskTel.Mask = "(00) 90000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(96, 20);
            this.mskTel.TabIndex = 11;
            // 
            // mskEmailCond
            // 
            this.mskEmailCond.Location = new System.Drawing.Point(26, 217);
            this.mskEmailCond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskEmailCond.Name = "mskEmailCond";
            this.mskEmailCond.Size = new System.Drawing.Size(142, 20);
            this.mskEmailCond.TabIndex = 12;
            // 
            // mskEntradaCond
            // 
            this.mskEntradaCond.Location = new System.Drawing.Point(26, 262);
            this.mskEntradaCond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskEntradaCond.Mask = "00/00/0000";
            this.mskEntradaCond.Name = "mskEntradaCond";
            this.mskEntradaCond.Size = new System.Drawing.Size(76, 20);
            this.mskEntradaCond.TabIndex = 13;
            this.mskEntradaCond.ValidatingType = typeof(System.DateTime);
            // 
            // mskSaidaCondo
            // 
            this.mskSaidaCondo.Location = new System.Drawing.Point(26, 307);
            this.mskSaidaCondo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskSaidaCondo.Mask = "00/00/0000";
            this.mskSaidaCondo.Name = "mskSaidaCondo";
            this.mskSaidaCondo.Size = new System.Drawing.Size(76, 20);
            this.mskSaidaCondo.TabIndex = 14;
            this.mskSaidaCondo.ValidatingType = typeof(System.DateTime);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(26, 353);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(142, 20);
            this.txtStatus.TabIndex = 15;
            // 
            // dgv_porteiro
            // 
            this.dgv_porteiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_porteiro.Location = new System.Drawing.Point(254, 27);
            this.dgv_porteiro.Name = "dgv_porteiro";
            this.dgv_porteiro.Size = new System.Drawing.Size(382, 346);
            this.dgv_porteiro.TabIndex = 16;
            // 
            // frmCondomino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 394);
            this.Controls.Add(this.dgv_porteiro);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.mskSaidaCondo);
            this.Controls.Add(this.mskEntradaCond);
            this.Controls.Add(this.mskEmailCond);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.mskNumApt);
            this.Controls.Add(this.txtNomeCond);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.lblDataEnt);
            this.Controls.Add(this.lblEmailCond);
            this.Controls.Add(this.lblTelCond);
            this.Controls.Add(this.lblNumApt);
            this.Controls.Add(this.lblNomeCond);
            this.Controls.Add(this.lblCPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCondomino";
            this.Text = "Cadastro de Condômino";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_porteiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNomeCond;
        private System.Windows.Forms.Label lblNumApt;
        private System.Windows.Forms.Label lblTelCond;
        private System.Windows.Forms.Label lblEmailCond;
        private System.Windows.Forms.Label lblDataEnt;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.TextBox txtNomeCond;
        private System.Windows.Forms.MaskedTextBox mskNumApt;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskEmailCond;
        private System.Windows.Forms.MaskedTextBox mskEntradaCond;
        private System.Windows.Forms.MaskedTextBox mskSaidaCondo;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DataGridView dgv_porteiro;
    }
}