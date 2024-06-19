namespace RifaApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConsultar = new Button();
            btnAlterar = new Button();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Green;
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(123, 54);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(129, 39);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += button1_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.Green;
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(258, 54);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(113, 39);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Green;
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(377, 54);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 39);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Green;
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(495, 54);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(118, 39);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Green;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(642, 106);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 39);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(724, 227);
            dataGridView1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(490, 23);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(123, 96);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 7;
            label1.Text = "Descrição";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 409);
            label2.Name = "label2";
            label2.Size = new Size(780, 32);
            label2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 90, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(btnAlterar);
            Controls.Add(btnConsultar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RIFA-App";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultar;
        private Button btnAlterar;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}
