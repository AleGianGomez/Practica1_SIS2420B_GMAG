namespace EJERCICIO_6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Numero = new System.Windows.Forms.TextBox();
            this.comboBox_Operaciones = new System.Windows.Forms.ComboBox();
            this.Btn_Generar = new System.Windows.Forms.Button();
            this.listBox_Numeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE VALOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOS NÚMEROS SON:";
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Numero.Location = new System.Drawing.Point(189, 86);
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Size = new System.Drawing.Size(113, 26);
            this.Txt_Numero.TabIndex = 3;
            // 
            // comboBox_Operaciones
            // 
            this.comboBox_Operaciones.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Operaciones.FormattingEnabled = true;
            this.comboBox_Operaciones.Location = new System.Drawing.Point(344, 85);
            this.comboBox_Operaciones.Name = "comboBox_Operaciones";
            this.comboBox_Operaciones.Size = new System.Drawing.Size(197, 27);
            this.comboBox_Operaciones.TabIndex = 4;
            // 
            // Btn_Generar
            // 
            this.Btn_Generar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generar.Location = new System.Drawing.Point(610, 86);
            this.Btn_Generar.Name = "Btn_Generar";
            this.Btn_Generar.Size = new System.Drawing.Size(97, 28);
            this.Btn_Generar.TabIndex = 5;
            this.Btn_Generar.Text = "GENERAR";
            this.Btn_Generar.UseVisualStyleBackColor = true;
            this.Btn_Generar.Click += new System.EventHandler(this.Btn_Generar_Click);
            // 
            // listBox_Numeros
            // 
            this.listBox_Numeros.FormattingEnabled = true;
            this.listBox_Numeros.ItemHeight = 15;
            this.listBox_Numeros.Location = new System.Drawing.Point(234, 175);
            this.listBox_Numeros.Name = "listBox_Numeros";
            this.listBox_Numeros.Size = new System.Drawing.Size(387, 199);
            this.listBox_Numeros.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(836, 445);
            this.Controls.Add(this.listBox_Numeros);
            this.Controls.Add(this.Btn_Generar);
            this.Controls.Add(this.comboBox_Operaciones);
            this.Controls.Add(this.Txt_Numero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "OPERACIÓN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Numero;
        private System.Windows.Forms.ComboBox comboBox_Operaciones;
        private System.Windows.Forms.Button Btn_Generar;
        private System.Windows.Forms.ListBox listBox_Numeros;
    }
}

