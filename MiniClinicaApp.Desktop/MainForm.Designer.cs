namespace MiniClinicaApp.Desktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtDni = new TextBox();
            txtEdad = new TextBox();
            txtApellidoNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAgregar = new Button();
            grillaPacientes = new DataGridView();
            Column1ID = new DataGridViewTextBoxColumn();
            Column2NombreApellido = new DataGridViewTextBoxColumn();
            Column3Edad = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            button2 = new Button();
            comboBox1Medico = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            txtMotivoConsulta = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnAgendar = new Button();
            grillaCitas = new DataGridView();
            Column1IDPaciente = new DataGridViewTextBoxColumn();
            Column1Motivo = new DataGridViewTextBoxColumn();
            Column1Medico = new DataGridViewTextBoxColumn();
            Column1Fecha = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaPacientes).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaCitas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(txtApellidoNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(grillaPacientes);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(765, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(590, 64);
            button1.Name = "button1";
            button1.Size = new Size(133, 22);
            button1.TabIndex = 10;
            button1.Text = "Eliminar ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(432, 134);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 9;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(432, 89);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 8;
            // 
            // txtApellidoNombre
            // 
            txtApellidoNombre.Location = new Point(432, 48);
            txtApellidoNombre.Name = "txtApellidoNombre";
            txtApellidoNombre.Size = new Size(100, 23);
            txtApellidoNombre.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Italic);
            label3.Location = new Point(362, 134);
            label3.Name = "label3";
            label3.Size = new Size(28, 16);
            label3.TabIndex = 4;
            label3.Text = "DNI";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Italic);
            label2.Location = new Point(353, 89);
            label2.Name = "label2";
            label2.Size = new Size(37, 16);
            label2.TabIndex = 3;
            label2.Text = "Edad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Italic);
            label1.Location = new Point(311, 50);
            label1.Name = "label1";
            label1.Size = new Size(115, 16);
            label1.TabIndex = 2;
            label1.Text = "Nombre y Apellido";
            label1.Click += label1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ButtonFace;
            btnAgregar.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(590, 32);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 26);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agendar Paciente";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // grillaPacientes
            // 
            grillaPacientes.BackgroundColor = SystemColors.ButtonFace;
            grillaPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaPacientes.Columns.AddRange(new DataGridViewColumn[] { Column1ID, Column2NombreApellido, Column3Edad, Column4 });
            grillaPacientes.Location = new Point(22, 22);
            grillaPacientes.Name = "grillaPacientes";
            grillaPacientes.Size = new Size(246, 150);
            grillaPacientes.TabIndex = 0;
            grillaPacientes.CellContentClick += grillaPacientes_CellContentClick;
            // 
            // Column1ID
            // 
            Column1ID.HeaderText = "ID";
            Column1ID.Name = "Column1ID";
            // 
            // Column2NombreApellido
            // 
            Column2NombreApellido.HeaderText = "Nombre y Apellido";
            Column2NombreApellido.Name = "Column2NombreApellido";
            // 
            // Column3Edad
            // 
            Column3Edad.HeaderText = "Edad";
            Column3Edad.Name = "Column3Edad";
            // 
            // Column4
            // 
            Column4.HeaderText = "DNI";
            Column4.Name = "Column4";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(comboBox1Medico);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtMotivoConsulta);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnAgendar);
            groupBox2.Controls.Add(grillaCitas);
            groupBox2.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Italic);
            groupBox2.Location = new Point(12, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(765, 199);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(590, 53);
            button2.Name = "button2";
            button2.Size = new Size(150, 24);
            button2.TabIndex = 11;
            button2.Text = "Eliminar ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1Medico
            // 
            comboBox1Medico.FormattingEnabled = true;
            comboBox1Medico.Items.AddRange(new object[] { "Jorge Iñigo Clinico", "Hernan Ramirez Clinico", "Fabiana Castillo Clinica" });
            comboBox1Medico.Location = new Point(432, 81);
            comboBox1Medico.Name = "comboBox1Medico";
            comboBox1Medico.Size = new Size(121, 24);
            comboBox1Medico.TabIndex = 15;
            comboBox1Medico.SelectedIndexChanged += comboBox1Medico_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(432, 127);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 26);
            dateTimePicker1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Italic);
            label8.Location = new Point(353, 134);
            label8.Name = "label8";
            label8.Size = new Size(40, 16);
            label8.TabIndex = 13;
            label8.Text = "Fecha";
            label8.Click += label8_Click;
            // 
            // txtMotivoConsulta
            // 
            txtMotivoConsulta.Location = new Point(432, 40);
            txtMotivoConsulta.Name = "txtMotivoConsulta";
            txtMotivoConsulta.Size = new Size(100, 26);
            txtMotivoConsulta.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Italic);
            label7.Location = new Point(349, 89);
            label7.Name = "label7";
            label7.Size = new Size(48, 16);
            label7.TabIndex = 8;
            label7.Text = "Medico";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Italic);
            label6.Location = new Point(311, 50);
            label6.Name = "label6";
            label6.Size = new Size(116, 16);
            label6.TabIndex = 7;
            label6.Text = "Motivo de Consulta";
            label6.Click += label6_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = SystemColors.ButtonFace;
            btnAgendar.Location = new Point(590, 22);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(150, 25);
            btnAgendar.TabIndex = 2;
            btnAgendar.Text = "Agendar Cita";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // grillaCitas
            // 
            grillaCitas.BackgroundColor = SystemColors.ButtonFace;
            grillaCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCitas.Columns.AddRange(new DataGridViewColumn[] { Column1IDPaciente, Column1Motivo, Column1Medico, Column1Fecha });
            grillaCitas.Location = new Point(6, 22);
            grillaCitas.Name = "grillaCitas";
            grillaCitas.Size = new Size(283, 150);
            grillaCitas.TabIndex = 1;
            // 
            // Column1IDPaciente
            // 
            Column1IDPaciente.HeaderText = "IDPaciente";
            Column1IDPaciente.Name = "Column1IDPaciente";
            // 
            // Column1Motivo
            // 
            Column1Motivo.HeaderText = "Motivo de Consulta";
            Column1Motivo.Name = "Column1Motivo";
            // 
            // Column1Medico
            // 
            Column1Medico.HeaderText = "Medico";
            Column1Medico.Name = "Column1Medico";
            // 
            // Column1Fecha
            // 
            Column1Fecha.HeaderText = "Fecha Agendada";
            Column1Fecha.Name = "Column1Fecha";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(789, 453);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaPacientes).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaCitas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnAgregar;
        private DataGridView grillaPacientes;
        private Button btnAgendar;
        private DataGridView grillaCitas;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDni;
        private TextBox txtEdad;
        private TextBox txtApellidoNombre;
        private Label label8;
        private TextBox txtMotivoConsulta;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Column1ID;
        private DataGridViewTextBoxColumn Column2NombreApellido;
        private DataGridViewTextBoxColumn Column3Edad;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1IDPaciente;
        private DataGridViewTextBoxColumn Column1Motivo;
        private DataGridViewTextBoxColumn Column1Medico;
        private DataGridViewTextBoxColumn Column1Fecha;
        private ComboBox comboBox1Medico;
        private Button button1;
        private Button button2;
    }
}