﻿namespace WindowsFormsApp3
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.dataGridViewrValores = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcularNuevaMedia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrValores)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_res
            // 
            this.txt_res.Location = new System.Drawing.Point(350, 317);
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(314, 20);
            this.txt_res.TabIndex = 2;
            // 
            // dataGridViewrValores
            // 
            this.dataGridViewrValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewrValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D});
            this.dataGridViewrValores.Location = new System.Drawing.Point(90, 62);
            this.dataGridViewrValores.Name = "dataGridViewrValores";
            this.dataGridViewrValores.Size = new System.Drawing.Size(473, 150);
            this.dataGridViewrValores.TabIndex = 3;
            this.dataGridViewrValores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.Name = "A";
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.Name = "B";
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            // 
            // D
            // 
            this.D.HeaderText = "D";
            this.D.Name = "D";
            // 
            // btnCalcularNuevaMedia
            // 
            this.btnCalcularNuevaMedia.Location = new System.Drawing.Point(90, 363);
            this.btnCalcularNuevaMedia.Name = "btnCalcularNuevaMedia";
            this.btnCalcularNuevaMedia.Size = new System.Drawing.Size(98, 45);
            this.btnCalcularNuevaMedia.TabIndex = 4;
            this.btnCalcularNuevaMedia.Text = "Calcular Nueva Media";
            this.btnCalcularNuevaMedia.UseVisualStyleBackColor = true;
            this.btnCalcularNuevaMedia.Click += new System.EventHandler(this.btnCalcularNuevaMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularNuevaMedia);
            this.Controls.Add(this.dataGridViewrValores);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrValores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.DataGridView dataGridViewrValores;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.Button btnCalcularNuevaMedia;
    }
}

