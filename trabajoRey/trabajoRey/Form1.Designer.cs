namespace trabajoRey
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
            label1 = new Label();
            txtEmpleados = new TextBox();
            txtClientes = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtObjeto = new TextBox();
            btnCapturarEmpledos = new Button();
            btnCapturarClientes = new Button();
            btnCapturarObjeto = new Button();
            dtgTablaClientes = new DataGridView();
            dtgTablaObjetios = new DataGridView();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgTablaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgTablaObjetios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Empleados";
            // 
            // txtEmpleados
            // 
            txtEmpleados.Location = new Point(83, 17);
            txtEmpleados.Name = "txtEmpleados";
            txtEmpleados.Size = new Size(100, 23);
            txtEmpleados.TabIndex = 1;
            // 
            // txtClientes
            // 
            txtClientes.Location = new Point(70, 54);
            txtClientes.Name = "txtClientes";
            txtClientes.Size = new Size(100, 23);
            txtClientes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 98);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Objeto";
            // 
            // txtObjeto
            // 
            txtObjeto.Location = new Point(83, 98);
            txtObjeto.Name = "txtObjeto";
            txtObjeto.Size = new Size(100, 23);
            txtObjeto.TabIndex = 5;
            // 
            // btnCapturarEmpledos
            // 
            btnCapturarEmpledos.Location = new Point(219, 20);
            btnCapturarEmpledos.Name = "btnCapturarEmpledos";
            btnCapturarEmpledos.Size = new Size(75, 23);
            btnCapturarEmpledos.TabIndex = 6;
            btnCapturarEmpledos.Text = "Capturar";
            btnCapturarEmpledos.UseVisualStyleBackColor = true;
            btnCapturarEmpledos.Click += btnCapturarEmpledos_Click;
            // 
            // btnCapturarClientes
            // 
            btnCapturarClientes.Location = new Point(219, 57);
            btnCapturarClientes.Name = "btnCapturarClientes";
            btnCapturarClientes.Size = new Size(75, 23);
            btnCapturarClientes.TabIndex = 7;
            btnCapturarClientes.Text = "Capturar";
            btnCapturarClientes.UseVisualStyleBackColor = true;
            btnCapturarClientes.Click += btnCapturarClientes_Click;
            // 
            // btnCapturarObjeto
            // 
            btnCapturarObjeto.Location = new Point(219, 98);
            btnCapturarObjeto.Name = "btnCapturarObjeto";
            btnCapturarObjeto.Size = new Size(75, 23);
            btnCapturarObjeto.TabIndex = 8;
            btnCapturarObjeto.Text = "Capturar";
            btnCapturarObjeto.UseVisualStyleBackColor = true;
            btnCapturarObjeto.Click += btnCapturarObjeto_Click;
            // 
            // dtgTablaClientes
            // 
            dtgTablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTablaClientes.Location = new Point(12, 160);
            dtgTablaClientes.Name = "dtgTablaClientes";
            dtgTablaClientes.Size = new Size(240, 150);
            dtgTablaClientes.TabIndex = 9;
            // 
            // dtgTablaObjetios
            // 
            dtgTablaObjetios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTablaObjetios.Location = new Point(269, 160);
            dtgTablaObjetios.Name = "dtgTablaObjetios";
            dtgTablaObjetios.Size = new Size(240, 150);
            dtgTablaObjetios.TabIndex = 10;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(323, 47);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 42);
            btnMostrar.TabIndex = 11;
            btnMostrar.Text = "Mostrar Datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrar);
            Controls.Add(dtgTablaObjetios);
            Controls.Add(dtgTablaClientes);
            Controls.Add(btnCapturarObjeto);
            Controls.Add(btnCapturarClientes);
            Controls.Add(btnCapturarEmpledos);
            Controls.Add(txtObjeto);
            Controls.Add(label3);
            Controls.Add(txtClientes);
            Controls.Add(label2);
            Controls.Add(txtEmpleados);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgTablaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgTablaObjetios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmpleados;
        private TextBox txtClientes;
        private Label label2;
        private Label label3;
        private TextBox txtObjeto;
        private Button btnCapturarEmpledos;
        private Button btnCapturarClientes;
        private Button btnCapturarObjeto;
        private DataGridView dtgTablaClientes;
        private DataGridView dtgTablaObjetios;
        private Button btnMostrar;
    }
}
