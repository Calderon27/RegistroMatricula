namespace RegistroMatricula
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gridEstudiantes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFiltraMatricula = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEdadMayor = new System.Windows.Forms.TextBox();
            this.txtEdadMenor = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.gridEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo  :";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(141, 36);
            this.txtMatricula.MaxLength = 4;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(82, 20);
            this.txtMatricula.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(141, 88);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(199, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 140);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(141, 204);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(46, 20);
            this.txtEdad.TabIndex = 8;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(141, 258);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(125, 303);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 36);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lista de Matriculados";
            // 
            // gridEstudiantes
            // 
            this.gridEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEstudiantes.Location = new System.Drawing.Point(361, 130);
            this.gridEstudiantes.Name = "gridEstudiantes";
            this.gridEstudiantes.Size = new System.Drawing.Size(796, 209);
            this.gridEstudiantes.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Filtrar por matrícula   :";
            // 
            // txtFiltraMatricula
            // 
            this.txtFiltraMatricula.Location = new System.Drawing.Point(562, 36);
            this.txtFiltraMatricula.Name = "txtFiltraMatricula";
            this.txtFiltraMatricula.Size = new System.Drawing.Size(171, 20);
            this.txtFiltraMatricula.TabIndex = 15;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(730, 68);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(116, 30);
            this.btnFiltrar.TabIndex = 16;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(904, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "La edad mayor       :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(904, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "La edad menor       :";
            // 
            // txtEdadMayor
            // 
            this.txtEdadMayor.Location = new System.Drawing.Point(1088, 31);
            this.txtEdadMayor.Name = "txtEdadMayor";
            this.txtEdadMayor.Size = new System.Drawing.Size(69, 20);
            this.txtEdadMayor.TabIndex = 19;
            // 
            // txtEdadMenor
            // 
            this.txtEdadMenor.Location = new System.Drawing.Point(1088, 70);
            this.txtEdadMenor.Name = "txtEdadMenor";
            this.txtEdadMenor.Size = new System.Drawing.Size(69, 20);
            this.txtEdadMenor.TabIndex = 20;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(42, 366);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1115, 242);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Tag = "";
            this.ColumnHeader1.Text = "Matricula";
            this.ColumnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellidos";
            this.columnHeader2.Width = 359;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombres";
            this.columnHeader3.Width = 384;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Edad";
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sexo";
            this.columnHeader5.Width = 124;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 631);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtEdadMenor);
            this.Controls.Add(this.txtEdadMayor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltraMatricula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridEstudiantes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro de Matricula";
            ((System.ComponentModel.ISupportInitialize)(this.gridEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridEstudiantes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFiltraMatricula;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEdadMayor;
        private System.Windows.Forms.TextBox txtEdadMenor;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

