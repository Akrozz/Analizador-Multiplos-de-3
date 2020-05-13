namespace Analizador_Multiplos_de_3
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
            this.LabIngrese = new System.Windows.Forms.Label();
            this.tBIngNum = new System.Windows.Forms.TextBox();
            this.Iniciar = new System.Windows.Forms.Button();
            this.labSalida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabIngrese
            // 
            this.LabIngrese.AutoSize = true;
            this.LabIngrese.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LabIngrese.Location = new System.Drawing.Point(80, 9);
            this.LabIngrese.Name = "LabIngrese";
            this.LabIngrese.Size = new System.Drawing.Size(95, 13);
            this.LabIngrese.TabIndex = 0;
            this.LabIngrese.Text = "Ingrese un número";
            // 
            // tBIngNum
            // 
            this.tBIngNum.Location = new System.Drawing.Point(49, 47);
            this.tBIngNum.Name = "tBIngNum";
            this.tBIngNum.Size = new System.Drawing.Size(159, 20);
            this.tBIngNum.TabIndex = 1;
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(49, 95);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(159, 32);
            this.Iniciar.TabIndex = 2;
            this.Iniciar.Text = "Analizar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // labSalida
            // 
            this.labSalida.AutoSize = true;
            this.labSalida.Location = new System.Drawing.Point(6, 38);
            this.labSalida.Name = "labSalida";
            this.labSalida.Size = new System.Drawing.Size(62, 13);
            this.labSalida.TabIndex = 3;
            this.labSalida.Text = "Sin Analizar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estatus";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labSalida);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(259, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 77);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Analizador_Multiplos_de_3.Properties.Resources._250px_Automata_finito;
            this.ClientSize = new System.Drawing.Size(549, 203);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.tBIngNum);
            this.Controls.Add(this.LabIngrese);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Detector Multiplos 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabIngrese;
        private System.Windows.Forms.TextBox tBIngNum;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Label labSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

