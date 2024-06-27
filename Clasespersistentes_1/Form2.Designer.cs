namespace Clasespersistentes_1
{
    partial class Form2
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
            labelNombre = new Label();
            labelEdad = new Label();
            labelGenero = new Label();
            labelDireccion = new Label();
            buttonSalir = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(99, 45);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(57, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre: ";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(117, 81);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(39, 15);
            labelEdad.TabIndex = 1;
            labelEdad.Text = "Edad: ";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(99, 119);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(51, 15);
            labelGenero.TabIndex = 2;
            labelGenero.Text = "Genero: ";
            labelGenero.Click += label3_Click;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(87, 161);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(63, 15);
            labelDireccion.TabIndex = 3;
            labelDireccion.Text = "Direccion: ";
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(149, 319);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(179, 101);
            buttonSalir.TabIndex = 4;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 45);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 5;
            label5.Text = "Nombre: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 81);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 6;
            label6.Text = "Nombre: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(202, 119);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 7;
            label7.Text = "Nombre: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 161);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 8;
            label8.Text = "Nombre: ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 471);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonSalir);
            Controls.Add(labelDireccion);
            Controls.Add(labelGenero);
            Controls.Add(labelEdad);
            Controls.Add(labelNombre);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private Label labelEdad;
        private Label labelGenero;
        private Label labelDireccion;
        private Button buttonSalir;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}