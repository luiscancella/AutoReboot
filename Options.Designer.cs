namespace MonitorOMPH
{
    partial class Options
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
            this.reboot = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.listaLabel = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reboot
            // 
            this.reboot.Location = new System.Drawing.Point(78, 112);
            this.reboot.Name = "reboot";
            this.reboot.Size = new System.Drawing.Size(75, 23);
            this.reboot.TabIndex = 0;
            this.reboot.Text = "Reiniciar";
            this.reboot.UseVisualStyleBackColor = true;
            this.reboot.Click += new System.EventHandler(this.reboot_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(231, 31);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(210, 199);
            this.lista.TabIndex = 3;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listaLabel
            // 
            this.listaLabel.AutoSize = true;
            this.listaLabel.Location = new System.Drawing.Point(228, 15);
            this.listaLabel.Name = "listaLabel";
            this.listaLabel.Size = new System.Drawing.Size(36, 13);
            this.listaLabel.TabIndex = 4;
            this.listaLabel.Text = "Telas:";
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(13, 15);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 5;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 258);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.listaLabel);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.reboot);
            this.Name = "options";
            this.Text = "Opções";
            this.Load += new System.EventHandler(this.request_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reboot;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label listaLabel;
        private System.Windows.Forms.Button voltar;
    }
}