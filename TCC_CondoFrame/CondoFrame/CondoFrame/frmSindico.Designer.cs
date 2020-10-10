namespace CondoFrame
{
    partial class frmSindico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSindico));
            this.lblCodSind = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblInicioMand = new System.Windows.Forms.Label();
            this.lblFimMand = new System.Windows.Forms.Label();
            this.lblEleicao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskInicioMand = new System.Windows.Forms.MaskedTextBox();
            this.mskFimMand = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodSind
            // 
            this.lblCodSind.AutoSize = true;
            this.lblCodSind.Location = new System.Drawing.Point(22, 30);
            this.lblCodSind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodSind.Name = "lblCodSind";
            this.lblCodSind.Size = new System.Drawing.Size(96, 13);
            this.lblCodSind.TabIndex = 0;
            this.lblCodSind.Text = "Código do Sindico:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(22, 57);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF:";
            this.lblCPF.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblInicioMand
            // 
            this.lblInicioMand.AutoSize = true;
            this.lblInicioMand.Location = new System.Drawing.Point(22, 102);
            this.lblInicioMand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInicioMand.Name = "lblInicioMand";
            this.lblInicioMand.Size = new System.Drawing.Size(136, 13);
            this.lblInicioMand.TabIndex = 2;
            this.lblInicioMand.Text = "Data de Inicio do Mandato:";
            // 
            // lblFimMand
            // 
            this.lblFimMand.AutoSize = true;
            this.lblFimMand.Location = new System.Drawing.Point(22, 150);
            this.lblFimMand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFimMand.Name = "lblFimMand";
            this.lblFimMand.Size = new System.Drawing.Size(127, 13);
            this.lblFimMand.TabIndex = 3;
            this.lblFimMand.Text = "Data do Fim do Mandato:";
            // 
            // lblEleicao
            // 
            this.lblEleicao.AutoSize = true;
            this.lblEleicao.Location = new System.Drawing.Point(24, 198);
            this.lblEleicao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEleicao.Name = "lblEleicao";
            this.lblEleicao.Size = new System.Drawing.Size(86, 13);
            this.lblEleicao.TabIndex = 4;
            this.lblEleicao.Text = "Data da Eleição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Exemplo de código";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(24, 73);
            this.mskCPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskCPF.Mask = "000\\.000\\.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(91, 20);
            this.mskCPF.TabIndex = 1;
            // 
            // mskInicioMand
            // 
            this.mskInicioMand.Location = new System.Drawing.Point(24, 119);
            this.mskInicioMand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskInicioMand.Mask = "00/00/0000";
            this.mskInicioMand.Name = "mskInicioMand";
            this.mskInicioMand.Size = new System.Drawing.Size(76, 20);
            this.mskInicioMand.TabIndex = 2;
            this.mskInicioMand.ValidatingType = typeof(System.DateTime);
            // 
            // mskFimMand
            // 
            this.mskFimMand.Location = new System.Drawing.Point(24, 167);
            this.mskFimMand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskFimMand.Mask = "00/00/0000";
            this.mskFimMand.Name = "mskFimMand";
            this.mskFimMand.Size = new System.Drawing.Size(76, 20);
            this.mskFimMand.TabIndex = 3;
            this.mskFimMand.ValidatingType = typeof(System.DateTime);
            this.mskFimMand.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskFimMand_MaskInputRejected);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(24, 215);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(224, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 205);
            this.dataGridView1.TabIndex = 6;
            // 
            // frmSindico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 269);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.mskFimMand);
            this.Controls.Add(this.mskInicioMand);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEleicao);
            this.Controls.Add(this.lblFimMand);
            this.Controls.Add(this.lblInicioMand);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblCodSind);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSindico";
            this.Text = "Cadastro de Sindico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodSind;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblInicioMand;
        private System.Windows.Forms.Label lblFimMand;
        private System.Windows.Forms.Label lblEleicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskInicioMand;
        private System.Windows.Forms.MaskedTextBox mskFimMand;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}