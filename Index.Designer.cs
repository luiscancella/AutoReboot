namespace MonitorOMPH
{
    partial class Index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dflex = new System.Windows.Forms.FlowLayoutPanel();
            this.options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dflex
            // 
            this.dflex.Location = new System.Drawing.Point(8, 57);
            this.dflex.Name = "dflex";
            this.dflex.Size = new System.Drawing.Size(783, 339);
            this.dflex.TabIndex = 1;
            // 
            // options
            // 
            this.options.Location = new System.Drawing.Point(310, 12);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(164, 23);
            this.options.TabIndex = 0;
            this.options.Text = "Selecionar";
            this.options.UseVisualStyleBackColor = true;
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.options);
            this.Controls.Add(this.dflex);
            this.Name = "Index";
            this.Text = "Telas OMPH";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel dflex;
        private System.Windows.Forms.Button options;
    }
}

