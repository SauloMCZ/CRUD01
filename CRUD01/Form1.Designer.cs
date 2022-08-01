namespace CRUD01
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
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnGrava = new System.Windows.Forms.Button();
            this.btnExibe = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(282, 25);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(62, 54);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificador";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(26, 44);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(127, 22);
            this.tbId.TabIndex = 2;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(26, 113);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(216, 22);
            this.tbNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(26, 187);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(216, 22);
            this.tbTelefone.TabIndex = 6;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(26, 241);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.Size = new System.Drawing.Size(455, 150);
            this.dgvDados.TabIndex = 7;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(379, 113);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(62, 55);
            this.btnIncluir.TabIndex = 8;
            this.btnIncluir.Text = "Alterar";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGrava
            // 
            this.btnGrava.Location = new System.Drawing.Point(282, 113);
            this.btnGrava.Name = "btnGrava";
            this.btnGrava.Size = new System.Drawing.Size(62, 55);
            this.btnGrava.TabIndex = 9;
            this.btnGrava.Text = "Grava";
            this.btnGrava.UseVisualStyleBackColor = true;
            this.btnGrava.Click += new System.EventHandler(this.btnGrava_Click);
            // 
            // btnExibe
            // 
            this.btnExibe.Location = new System.Drawing.Point(379, 25);
            this.btnExibe.Name = "btnExibe";
            this.btnExibe.Size = new System.Drawing.Size(62, 54);
            this.btnExibe.TabIndex = 10;
            this.btnExibe.Text = "Exibe";
            this.btnExibe.UseVisualStyleBackColor = true;
            this.btnExibe.Click += new System.EventHandler(this.btnExibe_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(282, 187);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(159, 31);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnExibe);
            this.Controls.Add(this.btnGrava);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnGrava;
        private System.Windows.Forms.Button btnExibe;
        private System.Windows.Forms.Button btnDeletar;
    }
}

