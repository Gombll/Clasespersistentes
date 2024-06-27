namespace Clasespersistentes_1
{
    partial class FormularioRegistro
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
            labelNombre = new Label();
            labelEdad = new Label();
            textBoxNombre = new TextBox();
            textBoxEdad = new TextBox();
            buttonGuardar = new Button();
            buttonDatos = new Button();
            buttonListar = new Button();
            buttonLimpiar = new Button();
            labelGenero = new Label();
            textBoxGenero = new TextBox();
            labelDireccion = new Label();
            textBoxDireccion = new TextBox();
            buttonSalir = new Button();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(109, 51);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(57, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre: ";
            labelNombre.Click += label1_Click;
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(127, 83);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(39, 15);
            labelEdad.TabIndex = 1;
            labelEdad.Text = "Edad: ";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(193, 51);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(148, 23);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(193, 80);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(148, 23);
            textBoxEdad.TabIndex = 3;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(66, 237);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(100, 56);
            buttonGuardar.TabIndex = 4;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonDatos
            // 
            buttonDatos.Location = new Point(182, 237);
            buttonDatos.Name = "buttonDatos";
            buttonDatos.Size = new Size(100, 56);
            buttonDatos.TabIndex = 5;
            buttonDatos.Text = "Mostrar Datos";
            buttonDatos.UseVisualStyleBackColor = true;
            // 
            // buttonListar
            // 
            buttonListar.Location = new Point(299, 238);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(100, 56);
            buttonListar.TabIndex = 6;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(182, 299);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(100, 56);
            buttonLimpiar.TabIndex = 7;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(118, 112);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(48, 15);
            labelGenero.TabIndex = 8;
            labelGenero.Text = "Genero:";
            labelGenero.Click += label3_Click;
            // 
            // textBoxGenero
            // 
            textBoxGenero.Location = new Point(193, 109);
            textBoxGenero.Name = "textBoxGenero";
            textBoxGenero.Size = new Size(148, 23);
            textBoxGenero.TabIndex = 9;
            textBoxGenero.TextChanged += textBox3_TextChanged;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(103, 141);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(63, 15);
            labelDireccion.TabIndex = 10;
            labelDireccion.Text = "Direccion: ";
            labelDireccion.Click += label4_Click;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(193, 138);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(148, 23);
            textBoxDireccion.TabIndex = 11;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(182, 361);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(100, 56);
            buttonSalir.TabIndex = 12;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            // 
            // FormularioRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 459);
            Controls.Add(buttonSalir);
            Controls.Add(textBoxDireccion);
            Controls.Add(labelDireccion);
            Controls.Add(textBoxGenero);
            Controls.Add(labelGenero);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonListar);
            Controls.Add(buttonDatos);
            Controls.Add(buttonGuardar);
            Controls.Add(textBoxEdad);
            Controls.Add(textBoxNombre);
            Controls.Add(labelEdad);
            Controls.Add(labelNombre);
            Name = "FormularioRegistro";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private Label labelEdad;
        private TextBox textBoxNombre;
        private TextBox textBoxEdad;
        private Button buttonGuardar;
        private Button buttonDatos;
        private Button buttonListar;
        private Button buttonLimpiar;
        private Label labelGenero;
        private TextBox textBoxGenero;
        private Label labelDireccion;
        private TextBox textBoxDireccion;
        private Button buttonSalir;
    }
}
