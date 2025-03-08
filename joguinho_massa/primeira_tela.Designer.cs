namespace joguinho_massa
{
    partial class primeira_tela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(primeira_tela));
            this.aaaa = new System.Windows.Forms.Label();
            this.buttonCela = new System.Windows.Forms.Button();
            this.buttonCorredor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aaaa
            // 
            this.aaaa.AutoSize = true;
            this.aaaa.BackColor = System.Drawing.Color.Transparent;
            this.aaaa.Font = new System.Drawing.Font("MS PGothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaaa.ForeColor = System.Drawing.SystemColors.Control;
            this.aaaa.Location = new System.Drawing.Point(44, 36);
            this.aaaa.Name = "aaaa";
            this.aaaa.Size = new System.Drawing.Size(709, 29);
            this.aaaa.TabIndex = 0;
            this.aaaa.Text = "Você vê um corredor e uma cela aberta, o que você faz?";
            // 
            // buttonCela
            // 
            this.buttonCela.BackColor = System.Drawing.Color.Transparent;
            this.buttonCela.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCela.Location = new System.Drawing.Point(257, 279);
            this.buttonCela.Name = "buttonCela";
            this.buttonCela.Size = new System.Drawing.Size(75, 23);
            this.buttonCela.TabIndex = 1;
            this.buttonCela.Text = "Cela";
            this.buttonCela.UseVisualStyleBackColor = false;
            this.buttonCela.Click += new System.EventHandler(this.buttonCela_Click);
            // 
            // buttonCorredor
            // 
            this.buttonCorredor.BackColor = System.Drawing.Color.Transparent;
            this.buttonCorredor.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCorredor.Location = new System.Drawing.Point(432, 260);
            this.buttonCorredor.Name = "buttonCorredor";
            this.buttonCorredor.Size = new System.Drawing.Size(101, 23);
            this.buttonCorredor.TabIndex = 2;
            this.buttonCorredor.Text = "Corredor";
            this.buttonCorredor.UseVisualStyleBackColor = false;
            // 
            // primeira_tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCorredor);
            this.Controls.Add(this.buttonCela);
            this.Controls.Add(this.aaaa);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "primeira_tela";
            this.Text = "primeira_tela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aaaa;
        private System.Windows.Forms.Button buttonCela;
        private System.Windows.Forms.Button buttonCorredor;
    }
}