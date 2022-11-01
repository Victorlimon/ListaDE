namespace ListaDE
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
            this.button_insertar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_primero = new System.Windows.Forms.Button();
            this.button_anterior = new System.Windows.Forms.Button();
            this.button_siguiente = new System.Windows.Forms.Button();
            this.button_Ultimo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_insertarInicio = new System.Windows.Forms.Button();
            this.button_inser_medio = new System.Windows.Forms.Button();
            this.text_insertar = new System.Windows.Forms.TextBox();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_insertar
            // 
            this.button_insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insertar.Location = new System.Drawing.Point(21, 22);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(159, 59);
            this.button_insertar.TabIndex = 0;
            this.button_insertar.Text = "Insertar FInal";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.button_insertar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(482, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(482, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.Location = new System.Drawing.Point(38, 13);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(159, 59);
            this.button_eliminar.TabIndex = 3;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_primero
            // 
            this.button_primero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_primero.Location = new System.Drawing.Point(197, 17);
            this.button_primero.Name = "button_primero";
            this.button_primero.Size = new System.Drawing.Size(159, 59);
            this.button_primero.TabIndex = 4;
            this.button_primero.Text = "Primero";
            this.button_primero.UseVisualStyleBackColor = true;
            this.button_primero.Click += new System.EventHandler(this.button_primero_Click);
            // 
            // button_anterior
            // 
            this.button_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_anterior.Location = new System.Drawing.Point(530, 17);
            this.button_anterior.Name = "button_anterior";
            this.button_anterior.Size = new System.Drawing.Size(159, 59);
            this.button_anterior.TabIndex = 5;
            this.button_anterior.Text = "Anterior";
            this.button_anterior.UseVisualStyleBackColor = true;
            this.button_anterior.Click += new System.EventHandler(this.button_anterior_Click);
            // 
            // button_siguiente
            // 
            this.button_siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_siguiente.Location = new System.Drawing.Point(362, 17);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(159, 59);
            this.button_siguiente.TabIndex = 6;
            this.button_siguiente.Text = "Siguiente";
            this.button_siguiente.UseVisualStyleBackColor = true;
            this.button_siguiente.Click += new System.EventHandler(this.button_siguiente_Click);
            // 
            // button_Ultimo
            // 
            this.button_Ultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ultimo.Location = new System.Drawing.Point(32, 17);
            this.button_Ultimo.Name = "button_Ultimo";
            this.button_Ultimo.Size = new System.Drawing.Size(159, 59);
            this.button_Ultimo.TabIndex = 7;
            this.button_Ultimo.Text = "Ultimo";
            this.button_Ultimo.UseVisualStyleBackColor = true;
            this.button_Ultimo.Click += new System.EventHandler(this.button_Ultimo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de la Asignatura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cantidad de Horas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lista de Asignaturas";
            // 
            // button_insertarInicio
            // 
            this.button_insertarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insertarInicio.Location = new System.Drawing.Point(186, 22);
            this.button_insertarInicio.Name = "button_insertarInicio";
            this.button_insertarInicio.Size = new System.Drawing.Size(159, 59);
            this.button_insertarInicio.TabIndex = 11;
            this.button_insertarInicio.Text = "Insertar Inicio";
            this.button_insertarInicio.UseVisualStyleBackColor = true;
            this.button_insertarInicio.Click += new System.EventHandler(this.button_insertarInicio_Click);
            // 
            // button_inser_medio
            // 
            this.button_inser_medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_inser_medio.Location = new System.Drawing.Point(351, 23);
            this.button_inser_medio.Name = "button_inser_medio";
            this.button_inser_medio.Size = new System.Drawing.Size(185, 58);
            this.button_inser_medio.TabIndex = 12;
            this.button_inser_medio.Text = "Insertar en la posicion ->";
            this.button_inser_medio.UseVisualStyleBackColor = true;
            this.button_inser_medio.Click += new System.EventHandler(this.button_inser_medio_Click);
            // 
            // text_insertar
            // 
            this.text_insertar.Location = new System.Drawing.Point(542, 41);
            this.text_insertar.Name = "text_insertar";
            this.text_insertar.Size = new System.Drawing.Size(100, 22);
            this.text_insertar.TabIndex = 16;
            this.text_insertar.TextChanged += new System.EventHandler(this.text_insertar_TextChanged);
            // 
            // Asignatura
            // 
            this.Asignatura.HeaderText = "Nombre de la Asignatura";
            this.Asignatura.MinimumWidth = 6;
            this.Asignatura.Name = "Asignatura";
            this.Asignatura.Width = 125;
            // 
            // horas
            // 
            this.horas.HeaderText = "Cantidad de Horas";
            this.horas.MinimumWidth = 6;
            this.horas.Name = "horas";
            this.horas.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.button_eliminar);
            this.panel1.Location = new System.Drawing.Point(284, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 91);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.button_siguiente);
            this.panel2.Controls.Add(this.button_Ultimo);
            this.panel2.Controls.Add(this.button_anterior);
            this.panel2.Controls.Add(this.button_primero);
            this.panel2.Location = new System.Drawing.Point(44, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 98);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.text_insertar);
            this.panel3.Controls.Add(this.button_insertar);
            this.panel3.Controls.Add(this.button_inser_medio);
            this.panel3.Controls.Add(this.button_insertarInicio);
            this.panel3.Location = new System.Drawing.Point(76, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 102);
            this.panel3.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(799, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(406, 202);
            this.dataGridView1.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1246, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "FormLDE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_primero;
        private System.Windows.Forms.Button button_anterior;
        private System.Windows.Forms.Button button_siguiente;
        private System.Windows.Forms.Button button_Ultimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_insertarInicio;
        private System.Windows.Forms.Button button_inser_medio;
        private System.Windows.Forms.TextBox text_insertar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

