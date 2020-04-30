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
            this.dataGridViewrValores = new System.Windows.Forms.DataGridView();
            this.btnLeerExcel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pgsBarDesarrollo = new System.Windows.Forms.ProgressBar();
            this.lblDesarrollo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrValores)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_res
            // 
            this.txt_res.Location = new System.Drawing.Point(589, 62);
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(522, 20);
            this.txt_res.TabIndex = 2;
            // 
            // dataGridViewrValores
            // 
            this.dataGridViewrValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewrValores.Location = new System.Drawing.Point(90, 62);
            this.dataGridViewrValores.Name = "dataGridViewrValores";
            this.dataGridViewrValores.Size = new System.Drawing.Size(473, 482);
            this.dataGridViewrValores.TabIndex = 3;
            this.dataGridViewrValores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnLeerExcel
            // 
            this.btnLeerExcel.Location = new System.Drawing.Point(691, 101);
            this.btnLeerExcel.Name = "btnLeerExcel";
            this.btnLeerExcel.Size = new System.Drawing.Size(75, 23);
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
            this.textBox1.Location = new System.Drawing.Point(868, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(803, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ruta";
            // 
            // pgsBarDesarrollo
            // 
            this.pgsBarDesarrollo.Location = new System.Drawing.Point(589, 147);
            this.pgsBarDesarrollo.Name = "pgsBarDesarrollo";
            this.pgsBarDesarrollo.Size = new System.Drawing.Size(443, 23);
            this.pgsBarDesarrollo.TabIndex = 7;
            // 
            // lblDesarrollo
            // 
            this.lblDesarrollo.AutoSize = true;
            this.lblDesarrollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesarrollo.Location = new System.Drawing.Point(1038, 150);
            this.lblDesarrollo.Name = "lblDesarrollo";
            this.lblDesarrollo.Size = new System.Drawing.Size(81, 20);
            this.lblDesarrollo.TabIndex = 8;
            this.lblDesarrollo.Text = "Desarrollo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 592);
            this.Controls.Add(this.lblDesarrollo);
            this.Controls.Add(this.pgsBarDesarrollo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLeerExcel);
            this.Controls.Add(this.dataGridViewrValores);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Calcular fórmula";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrValores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.DataGridView dataGridViewrValores;
        private System.Windows.Forms.Button btnLeerExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgsBarDesarrollo;
        private System.Windows.Forms.Label lblDesarrollo;
    }
}

