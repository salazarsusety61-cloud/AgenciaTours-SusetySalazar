namespace AgenciaTours
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
            lblTitulo = new Label();
            lblFecha = new Label();
            dgvReservas = new DataGridView();
            btnNuevo = new Button();
            btnDetalle = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            lblIngresos = new Label();
            lblResumen = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(294, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(407, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Naturaleza y Aventura CR";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(12, 68);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 20);
            lblFecha.TabIndex = 1;
            // 
            // dgvReservas
            // 
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.GridColor = Color.SkyBlue;
            dgvReservas.Location = new Point(695, 68);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.ReadOnly = true;
            dgvReservas.RowHeadersWidth = 51;
            dgvReservas.Size = new Size(697, 322);
            dgvReservas.TabIndex = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(21, 459);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(144, 60);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nueva Reserva";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNueva_Click;
            // 
            // btnDetalle
            // 
            btnDetalle.Location = new Point(184, 461);
            btnDetalle.Name = "btnDetalle";
            btnDetalle.Size = new Size(142, 56);
            btnDetalle.TabIndex = 4;
            btnDetalle.Text = "Ver Datalle";
            btnDetalle.UseVisualStyleBackColor = true;
            btnDetalle.Click += btnDetalle_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(353, 464);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 51);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(520, 464);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 51);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Location = new Point(21, 116);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(0, 20);
            lblIngresos.TabIndex = 7;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(14, 154);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(0, 20);
            lblResumen.TabIndex = 8;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1522, 759);
            Controls.Add(lblResumen);
            Controls.Add(lblIngresos);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnDetalle);
            Controls.Add(btnNuevo);
            Controls.Add(dgvReservas);
            Controls.Add(lblFecha);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Naturaleza y Aventura CR";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblFecha;
        private DataGridView dgvReservas;
        private Button btnNuevo;
        private Button btnDetalle;
        private Button btnEliminar;
        private Button btnSalir;
        private Label lblIngresos;
        private Label lblResumen;
    }
}
