﻿namespace Analizador_Multiplos_de_3
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
            this.SuspendLayout();
            // 
            // LabIngrese
            // 
            this.LabIngrese.AutoSize = true;
            this.LabIngrese.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabIngrese.Location = new System.Drawing.Point(26, 16);
            this.LabIngrese.Name = "LabIngrese";
            this.LabIngrese.Size = new System.Drawing.Size(95, 13);
            this.LabIngrese.TabIndex = 0;
            this.LabIngrese.Text = "Ingrese un número";
            this.LabIngrese.Click += new System.EventHandler(this.LabIngrese_Click);
            // 
            // tBIngNum
            // 
            this.tBIngNum.Location = new System.Drawing.Point(20, 46);
            this.tBIngNum.Name = "tBIngNum";
            this.tBIngNum.Size = new System.Drawing.Size(159, 20);
            this.tBIngNum.TabIndex = 1;
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(114, 91);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(151, 32);
            this.Iniciar.TabIndex = 2;
            this.Iniciar.Text = "Analizar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // labSalida
            // 
            this.labSalida.AutoSize = true;
            this.labSalida.Location = new System.Drawing.Point(214, 49);
            this.labSalida.Name = "labSalida";
            this.labSalida.Size = new System.Drawing.Size(62, 13);
            this.labSalida.TabIndex = 3;
            this.labSalida.Text = "Sin Analizar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estatus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 152);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labSalida);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.tBIngNum);
            this.Controls.Add(this.LabIngrese);
            this.Name = "Form1";
            this.Text = "Detector Multiplos 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabIngrese;
        private System.Windows.Forms.TextBox tBIngNum;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Label labSalida;
        private System.Windows.Forms.Label label1;
    }
}

