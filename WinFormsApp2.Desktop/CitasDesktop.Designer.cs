using MiniClinicaaApp2.Desktop;

namespace MiniClinicaaApp2.Desktop
{
    partial class CitasDesktop
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
            dataGridView2 = new DataGridView();
            textBox4 = new TextBox();
            comboBoxMedicos = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            button2 = new Button();
            label7 = new Label();
            button3 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker2 = new DateTimePicker();
            button4 = new Button();
            button6 = new Button();
            Pacientes = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            button7 = new Button();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            label11 = new Label();
            comboBoxPacientes = new ComboBox();
            tabPage3 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            btnGenerarReporte = new Button();
            lblTotalFacturado = new Label();
            lblTotalCitas = new Label();
            cmbFiltroMedico = new ComboBox();
            dtpFiltroFecha = new DateTimePicker();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Pacientes.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(33, 213);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(725, 169);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(131, 27);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 21);
            textBox4.TabIndex = 9;
            // 
            // comboBoxMedicos
            // 
            comboBoxMedicos.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxMedicos.FormattingEnabled = true;
            comboBoxMedicos.Items.AddRange(new object[] { "1. Dr Castillo", "2. Dra Hernandez", "3. Dr  Molina" });
            comboBoxMedicos.Location = new Point(131, 66);
            comboBoxMedicos.Name = "comboBoxMedicos";
            comboBoxMedicos.Size = new Size(121, 21);
            comboBoxMedicos.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(331, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(103, 21);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.Value = new DateTime(2025, 6, 18, 0, 0, 0, 0);
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(521, 26);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 21);
            textBox5.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 33);
            label4.Name = "label4";
            label4.Size = new Size(115, 13);
            label4.TabIndex = 14;
            label4.Text = "Motivo de Consulta";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(73, 69);
            label5.Name = "label5";
            label5.Size = new Size(52, 13);
            label5.TabIndex = 15;
            label5.Text = "Medicos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(286, 33);
            label6.Name = "label6";
            label6.Size = new Size(40, 13);
            label6.TabIndex = 16;
            label6.Text = "Fecha";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(480, 30);
            label8.Name = "label8";
            label8.Size = new Size(35, 13);
            label8.TabIndex = 18;
            label8.Text = "Total";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            button2.Location = new Point(132, 124);
            button2.Name = "button2";
            button2.Size = new Size(120, 26);
            button2.TabIndex = 19;
            button2.Text = "Registrar Cita";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(288, 70);
            label7.Name = "label7";
            label7.Size = new Size(34, 13);
            label7.TabIndex = 28;
            label7.Text = "Hora";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            button3.Location = new Point(564, 314);
            button3.Name = "button3";
            button3.Size = new Size(140, 25);
            button3.TabIndex = 23;
            button3.Text = "Eliminar Paciente";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            button5.Location = new Point(564, 273);
            button5.Name = "button5";
            button5.Size = new Size(140, 25);
            button5.TabIndex = 25;
            button5.Text = "Editar Paciente";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(523, 183);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(331, 66);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(93, 21);
            dateTimePicker2.TabIndex = 27;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            button4.Location = new Point(429, 124);
            button4.Name = "button4";
            button4.Size = new Size(120, 26);
            button4.TabIndex = 24;
            button4.Text = "Eliminar Cita";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            button6.Location = new Point(285, 124);
            button6.Name = "button6";
            button6.Size = new Size(120, 26);
            button6.TabIndex = 26;
            button6.Text = "Editar Cita";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Pacientes
            // 
            Pacientes.Controls.Add(tabPage1);
            Pacientes.Controls.Add(tabPage2);
            Pacientes.Controls.Add(tabPage3);
            Pacientes.Location = new Point(18, 0);
            Pacientes.Name = "Pacientes";
            Pacientes.SelectedIndex = 0;
            Pacientes.Size = new Size(818, 427);
            Pacientes.TabIndex = 23;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(810, 399);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pacientes";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(26, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 144);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaption;
            button7.Location = new Point(235, 99);
            button7.Name = "button7";
            button7.Size = new Size(10, 10);
            button7.TabIndex = 26;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 8.25F, FontStyle.Italic);
            label2.Location = new Point(102, 66);
            label2.Name = "label2";
            label2.Size = new Size(35, 13);
            label2.TabIndex = 6;
            label2.Text = "Edad";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Verdana", 8.25F);
            textBox3.Location = new Point(164, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(66, 21);
            textBox3.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Verdana", 8.25F);
            textBox1.Location = new Point(164, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 21);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 8.25F, FontStyle.Italic);
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(112, 13);
            label1.TabIndex = 5;
            label1.Text = "Nombre y Apellido";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 8.25F, FontStyle.Italic);
            label3.Location = new Point(105, 98);
            label3.Name = "label3";
            label3.Size = new Size(28, 13);
            label3.TabIndex = 7;
            label3.Text = "DNI";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Verdana", 8.25F);
            textBox2.Location = new Point(164, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(66, 21);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            button1.Location = new Point(564, 232);
            button1.Name = "button1";
            button1.Size = new Size(140, 25);
            button1.TabIndex = 8;
            button1.Text = "Registrar Paciente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(810, 399);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Citas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(comboBoxPacientes);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(comboBoxMedicos);
            groupBox2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(33, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(725, 165);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(463, 70);
            label11.Name = "label11";
            label11.Size = new Size(55, 13);
            label11.TabIndex = 30;
            label11.Text = "Paciente";
            // 
            // comboBoxPacientes
            // 
            comboBoxPacientes.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPacientes.FormattingEnabled = true;
            comboBoxPacientes.Location = new Point(521, 66);
            comboBoxPacientes.Name = "comboBoxPacientes";
            comboBoxPacientes.Size = new Size(121, 21);
            comboBoxPacientes.TabIndex = 29;
            comboBoxPacientes.SelectedIndexChanged += comboBoxPacientes_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(btnGenerarReporte);
            tabPage3.Controls.Add(lblTotalFacturado);
            tabPage3.Controls.Add(lblTotalCitas);
            tabPage3.Controls.Add(cmbFiltroMedico);
            tabPage3.Controls.Add(dtpFiltroFecha);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(810, 399);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reporte";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 8.25F);
            label10.Location = new Point(76, 285);
            label10.Name = "label10";
            label10.Size = new Size(116, 13);
            label10.TabIndex = 7;
            label10.Text = "Seleccionar Medico";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 8.25F);
            label9.Location = new Point(76, 253);
            label9.Name = "label9";
            label9.Size = new Size(110, 13);
            label9.TabIndex = 6;
            label9.Text = "Seleccionar Fecha";
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarReporte.Location = new Point(340, 340);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(127, 23);
            btnGenerarReporte.TabIndex = 5;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // lblTotalFacturado
            // 
            lblTotalFacturado.AutoSize = true;
            lblTotalFacturado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalFacturado.Location = new Point(545, 290);
            lblTotalFacturado.Name = "lblTotalFacturado";
            lblTotalFacturado.Size = new Size(88, 15);
            lblTotalFacturado.TabIndex = 4;
            lblTotalFacturado.Text = "Total Facturado";
            // 
            // lblTotalCitas
            // 
            lblTotalCitas.AutoSize = true;
            lblTotalCitas.Location = new Point(547, 252);
            lblTotalCitas.Name = "lblTotalCitas";
            lblTotalCitas.Size = new Size(77, 15);
            lblTotalCitas.TabIndex = 3;
            lblTotalCitas.Text = "Total de Citas";
            // 
            // cmbFiltroMedico
            // 
            cmbFiltroMedico.FormattingEnabled = true;
            cmbFiltroMedico.Location = new Point(202, 281);
            cmbFiltroMedico.Name = "cmbFiltroMedico";
            cmbFiltroMedico.Size = new Size(121, 23);
            cmbFiltroMedico.TabIndex = 2;
            // 
            // dtpFiltroFecha
            // 
            dtpFiltroFecha.Location = new Point(202, 244);
            dtpFiltroFecha.Name = "dtpFiltroFecha";
            dtpFiltroFecha.Size = new Size(200, 23);
            dtpFiltroFecha.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.ButtonFace;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(55, 29);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(672, 175);
            dataGridView3.TabIndex = 0;
            // 
            // CitasDesktop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 452);
            Controls.Add(Pacientes);
            Name = "CitasDesktop";
            Text = "Form1";
            Load += CitasDesktop_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Pacientes.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView2;
        private TextBox textBox4;
        private ComboBox comboBoxMedicos;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button button2;
        private Button button4;
        private Button button6;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private Button button7;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private Button button1;
        private Button button5;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabControl Pacientes;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TabPage tabPage3;
        private ComboBox cmbFiltroMedico;
        private DateTimePicker dtpFiltroFecha;
        private DataGridView dataGridView3;
        private Button btnGenerarReporte;
        private Label lblTotalFacturado;
        private Label lblTotalCitas;
        private Label label10;
        private Label label9;
        private Label label11;
        private ComboBox comboBoxPacientes;
    }
}
