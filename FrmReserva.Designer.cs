namespace AgenciaTours.Interfaz
{
    partial class FrmReserva
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
            components = new System.ComponentModel.Container();
            txtCliente = new TextBox();
            lstTours = new ListBox();
            lblTipo = new Label();
            lblPrecio = new Label();
            lblDificultad = new Label();
            txtPersonas = new TextBox();
            dtpFechaTour = new DateTimePicker();
            lstIdioma = new ListBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(27, 27);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(264, 27);
            txtCliente.TabIndex = 0;
            // 
            // lstTours
            // 
            lstTours.FormattingEnabled = true;
            lstTours.Location = new Point(347, 25);
            lstTours.Name = "lstTours";
            lstTours.Size = new Size(348, 224);
            lstTours.TabIndex = 1;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(27, 90);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(42, 20);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(23, 134);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio:";
            // 
            // lblDificultad
            // 
            lblDificultad.AutoSize = true;
            lblDificultad.Location = new Point(26, 183);
            lblDificultad.Name = "lblDificultad";
            lblDificultad.Size = new Size(77, 20);
            lblDificultad.TabIndex = 4;
            lblDificultad.Text = "Dificultad:";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(27, 226);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(93, 27);
            txtPersonas.TabIndex = 5;
            // 
            // dtpFechaTour
            // 
            dtpFechaTour.Location = new Point(12, 270);
            dtpFechaTour.Name = "dtpFechaTour";
            dtpFechaTour.Size = new Size(310, 27);
            dtpFechaTour.TabIndex = 6;
            // 
            // lstIdioma
            // 
            lstIdioma.FormattingEnabled = true;
            lstIdioma.Items.AddRange(new object[] { "Español", "Inglés" });
            lstIdioma.Location = new Point(23, 316);
            lstIdioma.Name = "lstIdioma";
            lstIdioma.Size = new Size(255, 144);
            lstIdioma.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(329, 447);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(136, 60);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(510, 447);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(138, 60);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lstIdioma);
            Controls.Add(dtpFechaTour);
            Controls.Add(txtPersonas);
            Controls.Add(lblDificultad);
            Controls.Add(lblPrecio);
            Controls.Add(lblTipo);
            Controls.Add(lstTours);
            Controls.Add(txtCliente);
            Name = "FrmReserva";
            Text = "FrmReserva";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private ListBox lstTours;
        private Label lblTipo;
        private Label lblPrecio;
        private Label lblDificultad;
        private TextBox txtPersonas;
        private DateTimePicker dtpFechaTour;
        private ListBox lstIdioma;
        private Button btnAceptar;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}