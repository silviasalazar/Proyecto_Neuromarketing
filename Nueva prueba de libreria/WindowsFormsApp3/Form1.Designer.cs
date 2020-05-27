namespace WindowsFormsApp3
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
            this.dataGridViewValores = new System.Windows.Forms.DataGridView();
            this.btnLeerExcel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pgsBarDesarrollo = new System.Windows.Forms.ProgressBar();
            this.lblDesarrollo = new System.Windows.Forms.Label();
            this.btnSalida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxOut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValores)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // txt_res
            // 
            this.txt_res.Location = new System.Drawing.Point(589, 62);
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(522, 20);
            this.txt_res.TabIndex = 2;
            // 
            // dataGridViewValores
            // 
            this.dataGridViewValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValores.Location = new System.Drawing.Point(90, 62);
            this.dataGridViewValores.Name = "dataGridViewValores";
            this.dataGridViewValores.Size = new System.Drawing.Size(473, 482);
            this.dataGridViewValores.TabIndex = 3;
            // 
            // btnLeerExcel
            // 
            this.btnLeerExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerExcel.Location = new System.Drawing.Point(589, 101);
            this.btnLeerExcel.Name = "btnLeerExcel";
            this.btnLeerExcel.Size = new System.Drawing.Size(98, 43);
            this.btnLeerExcel.TabIndex = 4;
            this.btnLeerExcel.Text = "Leer excel";
            this.btnLeerExcel.UseVisualStyleBackColor = true;
            this.btnLeerExcel.Click += new System.EventHandler(this.btnLeerExcel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(769, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(703, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ruta:";
            // 
            // pgsBarDesarrollo
            // 
            this.pgsBarDesarrollo.Location = new System.Drawing.Point(589, 283);
            this.pgsBarDesarrollo.Name = "pgsBarDesarrollo";
            this.pgsBarDesarrollo.Size = new System.Drawing.Size(443, 23);
            this.pgsBarDesarrollo.TabIndex = 7;
            // 
            // lblDesarrollo
            // 
            this.lblDesarrollo.AutoSize = true;
            this.lblDesarrollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesarrollo.Location = new System.Drawing.Point(1038, 283);
            this.lblDesarrollo.Name = "lblDesarrollo";
            this.lblDesarrollo.Size = new System.Drawing.Size(81, 20);
            this.lblDesarrollo.TabIndex = 8;
            this.lblDesarrollo.Text = "Desarrollo";
            // 
            // btnSalida
            // 
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(589, 150);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(98, 44);
            this.btnSalida.TabIndex = 9;
            this.btnSalida.Text = "Elegir archivo de salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(703, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ruta:";
            // 
            // txtBoxOut
            // 
            this.txtBoxOut.Location = new System.Drawing.Point(769, 161);
            this.txtBoxOut.Name = "txtBoxOut";
            this.txtBoxOut.Size = new System.Drawing.Size(243, 20);
            this.txtBoxOut.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 592);
            this.Controls.Add(this.txtBoxOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.lblDesarrollo);
            this.Controls.Add(this.pgsBarDesarrollo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLeerExcel);
            this.Controls.Add(this.dataGridViewValores);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Calcular fórmula";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.DataGridView dataGridViewValores;
        private System.Windows.Forms.Button btnLeerExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgsBarDesarrollo;
        private System.Windows.Forms.Label lblDesarrollo;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxOut;
    }
}

