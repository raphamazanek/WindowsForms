namespace AulaWindowsForms
{
    partial class FormularioPrincipal
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
            this.btnSomar = new System.Windows.Forms.Button();
            this.txtNumeroDois = new System.Windows.Forms.TextBox();
            this.txtNumeroUm = new System.Windows.Forms.TextBox();
            this.lblNumeroUm = new System.Windows.Forms.Label();
            this.lblNumeroDois = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(12, 99);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(212, 33);
            this.btnSomar.TabIndex = 0;
            this.btnSomar.Text = "SOMAR";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // txtNumeroDois
            // 
            this.txtNumeroDois.BackColor = System.Drawing.Color.White;
            this.txtNumeroDois.Location = new System.Drawing.Point(121, 56);
            this.txtNumeroDois.Name = "txtNumeroDois";
            this.txtNumeroDois.Size = new System.Drawing.Size(103, 20);
            this.txtNumeroDois.TabIndex = 1;
            // 
            // txtNumeroUm
            // 
            this.txtNumeroUm.BackColor = System.Drawing.Color.White;
            this.txtNumeroUm.Location = new System.Drawing.Point(121, 12);
            this.txtNumeroUm.Name = "txtNumeroUm";
            this.txtNumeroUm.Size = new System.Drawing.Size(103, 20);
            this.txtNumeroUm.TabIndex = 2;
            // 
            // lblNumeroUm
            // 
            this.lblNumeroUm.AutoSize = true;
            this.lblNumeroUm.Location = new System.Drawing.Point(46, 15);
            this.lblNumeroUm.Name = "lblNumeroUm";
            this.lblNumeroUm.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroUm.TabIndex = 3;
            this.lblNumeroUm.Text = "Número:";
            // 
            // lblNumeroDois
            // 
            this.lblNumeroDois.AutoSize = true;
            this.lblNumeroDois.Location = new System.Drawing.Point(46, 59);
            this.lblNumeroDois.Name = "lblNumeroDois";
            this.lblNumeroDois.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroDois.TabIndex = 4;
            this.lblNumeroDois.Text = "Número:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(5, 135);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(155, 31);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(236, 173);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNumeroDois);
            this.Controls.Add(this.lblNumeroUm);
            this.Controls.Add(this.txtNumeroUm);
            this.Controls.Add(this.txtNumeroDois);
            this.Controls.Add(this.btnSomar);
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtNumeroDois;
        private System.Windows.Forms.TextBox txtNumeroUm;
        private System.Windows.Forms.Label lblNumeroUm;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblNumeroDois;
    }
}

