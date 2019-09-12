namespace AtividadeAulaMetodos
{
    partial class frmExercicio_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.rbtnDepositar = new System.Windows.Forms.RadioButton();
            this.rbtnSacar = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(79, 22);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(79, 81);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            // 
            // rbtnDepositar
            // 
            this.rbtnDepositar.AutoSize = true;
            this.rbtnDepositar.Checked = true;
            this.rbtnDepositar.Location = new System.Drawing.Point(79, 117);
            this.rbtnDepositar.Name = "rbtnDepositar";
            this.rbtnDepositar.Size = new System.Drawing.Size(70, 17);
            this.rbtnDepositar.TabIndex = 4;
            this.rbtnDepositar.TabStop = true;
            this.rbtnDepositar.Text = "Depositar";
            this.rbtnDepositar.UseVisualStyleBackColor = true;
            // 
            // rbtnSacar
            // 
            this.rbtnSacar.AutoSize = true;
            this.rbtnSacar.Location = new System.Drawing.Point(79, 140);
            this.rbtnSacar.Name = "rbtnSacar";
            this.rbtnSacar.Size = new System.Drawing.Size(53, 17);
            this.rbtnSacar.TabIndex = 5;
            this.rbtnSacar.Text = "Sacar";
            this.rbtnSacar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 173);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(205, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmExercicio_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 208);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rbtnSacar);
            this.Controls.Add(this.rbtnDepositar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label1);
            this.Name = "frmExercicio_1";
            this.Text = "Exercicio 1 - Saldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton rbtnDepositar;
        private System.Windows.Forms.RadioButton rbtnSacar;
        private System.Windows.Forms.Button btnOk;
    }
}