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
            this.lblCodSind.Location = new System.Drawing.Point(29, 37);
            this.lblCodSind.Name = "lblCodSind";
            this.lblCodSind.Size = new System.Drawing.Size(126, 17);
            this.lblCodSind.TabIndex = 0;
            this.lblCodSind.Text = "Código do Sindico:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(29, 70);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 17);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF:";
            this.lblCPF.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblInicioMand
            // 
            this.lblInicioMand.AutoSize = true;
            this.lblInicioMand.Location = new System.Drawing.Point(29, 126);
            this.lblInicioMand.Name = "lblInicioMand";
            this.lblInicioMand.Size = new System.Drawing.Size(177, 17);
            this.lblInicioMand.TabIndex = 2;
            this.lblInicioMand.Text = "Data de Inicio do Mandato:";
            // 
            // lblFimMand
            // 
            this.lblFimMand.AutoSize = true;
            this.lblFimMand.Location = new System.Drawing.Point(29, 185);
            this.lblFimMand.Name = "lblFimMand";
            this.lblFimMand.Size = new System.Drawing.Size(167, 17);
            this.lblFimMand.TabIndex = 3;
            this.lblFimMand.Text = "Data do Fim do Mandato:";
            // 
            // lblEleicao
            // 
            this.lblEleicao.AutoSize = true;
            this.lblEleicao.Location = new System.Drawing.Point(32, 244);
            this.lblEleicao.Name = "lblEleicao";
            this.lblEleicao.Size = new System.Drawing.Size(112, 17);
            this.lblEleicao.TabIndex = 4;
            this.lblEleicao.Text = "Data da Eleição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Exemplo de código";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(32, 90);
            this.mskCPF.Mask = "000\\.000\\.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(120, 22);
            this.mskCPF.TabIndex = 1;
            // 
            // mskInicioMand
            // 
            this.mskInicioMand.Location = new System.Drawing.Point(32, 146);
            this.mskInicioMand.Mask = "00/00/0000";
            this.mskInicioMand.Name = "mskInicioMand";
            this.mskInicioMand.Size = new System.Drawing.Size(100, 22);
            this.mskInicioMand.TabIndex = 2;
            this.mskInicioMand.ValidatingType = typeof(System.DateTime);
            // 
            // mskFimMand
            // 
            this.mskFimMand.Location = new System.Drawing.Point(32, 206);
            this.mskFimMand.Mask = "00/00/0000";
            this.mskFimMand.Name = "mskFimMand";
            this.mskFimMand.Size = new System.Drawing.Size(100, 22);
            this.mskFimMand.TabIndex = 3;
            this.mskFimMand.ValidatingType = typeof(System.DateTime);
            this.mskFimMand.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskFimMand_MaskInputRejected);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(32, 265);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(342, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(448, 282);
            this.dataGridView1.TabIndex = 6;
            // 
            // frmSindico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 331);
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