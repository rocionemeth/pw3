namespace Clase2
{
    partial class frmResultados
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
            dtpFechaResultados = new DateTimePicker();
            cmd = new Button();
            lbNombre = new Label();
            lbPais = new Label();
            txtLocal = new TextBox();
            cboGolesLocal = new ComboBox();
            dgvResultados = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            cmdResfrecarGrilla = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // dtpFechaResultados
            // 
            dtpFechaResultados.Location = new Point(155, 22);
            dtpFechaResultados.Name = "dtpFechaResultados";
            dtpFechaResultados.Size = new Size(531, 23);
            dtpFechaResultados.TabIndex = 0;
            // 
            // cmd
            // 
            cmd.Location = new Point(312, 292);
            cmd.Name = "cmd";
            cmd.Size = new Size(75, 23);
            cmd.TabIndex = 2;
            cmd.Text = "Agregar";
            cmd.UseVisualStyleBackColor = true;
            cmd.Click += button1_Click;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(290, 130);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(51, 15);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre";
            // 
            // lbPais
            // 
            lbPais.AutoSize = true;
            lbPais.Location = new Point(299, 170);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(28, 15);
            lbPais.TabIndex = 1;
            lbPais.Text = "Pais";
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(356, 127);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(146, 23);
            txtLocal.TabIndex = 2;
            // 
            // cboGolesLocal
            // 
            cboGolesLocal.FormattingEnabled = true;
            cboGolesLocal.Items.AddRange(new object[] { "Argentina", "Brasil", "Colombia", "Ecuador", "Mexico", "Paraguay" });
            cboGolesLocal.Location = new Point(356, 170);
            cboGolesLocal.Name = "cboGolesLocal";
            cboGolesLocal.Size = new Size(140, 23);
            cboGolesLocal.TabIndex = 1;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { Column1, Nombre, Pais });
            dgvResultados.Location = new Point(239, 348);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(367, 115);
            dgvResultados.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "Fecha";
            Column1.Name = "Column1";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.Name = "Pais";
            // 
            // cmdResfrecarGrilla
            // 
            cmdResfrecarGrilla.Location = new Point(487, 292);
            cmdResfrecarGrilla.Name = "cmdResfrecarGrilla";
            cmdResfrecarGrilla.Size = new Size(75, 23);
            cmdResfrecarGrilla.TabIndex = 6;
            cmdResfrecarGrilla.Text = "Resfrecar";
            cmdResfrecarGrilla.UseVisualStyleBackColor = true;
            cmdResfrecarGrilla.Click += button1_Click_1;
            // 
            // frmResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 475);
            Controls.Add(cmdResfrecarGrilla);
            Controls.Add(cboGolesLocal);
            Controls.Add(dgvResultados);
            Controls.Add(txtLocal);
            Controls.Add(lbPais);
            Controls.Add(cmd);
            Controls.Add(lbNombre);
            Controls.Add(dtpFechaResultados);
            Name = "frmResultados";
            Text = "Equipos";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaResultados;
        private Button cmd;
        private Label lbNombre;
        private Label lbPais;
        private TextBox txtLocal;
        private ComboBox cboGolesLocal;
        private DataGridView dgvResultados;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Pais;
        private Button cmdResfrecarGrilla;
    }
}
