namespace ProbMegaSEna
{
    partial class Form1
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
            this.btnFrequencia = new System.Windows.Forms.Button();
            this.dtgDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFrequencia
            // 
            this.btnFrequencia.Location = new System.Drawing.Point(12, 12);
            this.btnFrequencia.Name = "btnFrequencia";
            this.btnFrequencia.Size = new System.Drawing.Size(75, 23);
            this.btnFrequencia.TabIndex = 0;
            this.btnFrequencia.Text = "Frequencia";
            this.btnFrequencia.UseVisualStyleBackColor = true;
            this.btnFrequencia.Click += new System.EventHandler(this.btnFrequencia_Click);
            // 
            // dtgDados
            // 
            this.dtgDados.AllowUserToOrderColumns = true;
            this.dtgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Location = new System.Drawing.Point(12, 41);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.Size = new System.Drawing.Size(618, 392);
            this.dtgDados.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 445);
            this.Controls.Add(this.dtgDados);
            this.Controls.Add(this.btnFrequencia);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFrequencia;
        private System.Windows.Forms.DataGridView dtgDados;
    }
}

