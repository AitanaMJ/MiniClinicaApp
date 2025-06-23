namespace WinFormsApp1.Desktop
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            comboBoxMedicos = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            reciboDeCitaToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            button5 = new Button();
            button3 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(422, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(411, 151);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(422, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(411, 169);
            dataGridView2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(38, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 84);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre y Apellido";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(72, 58);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(73, 87);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 7;
            label3.Text = "DNI";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.Location = new Point(6, 126);
            button1.Name = "button1";
            button1.Size = new Size(75, 42);
            button1.TabIndex = 8;
            button1.Text = "Registrar Paciente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(117, 31);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 23);
            textBox4.TabIndex = 9;
            // 
            // comboBoxMedicos
            // 
            comboBoxMedicos.FormattingEnabled = true;
            comboBoxMedicos.Items.AddRange(new object[] { "1. Dr Castillo", "2. Dra Hernandez", "3. Dr  Molina" });
            comboBoxMedicos.Location = new Point(117, 60);
            comboBoxMedicos.Name = "comboBoxMedicos";
            comboBoxMedicos.Size = new Size(121, 23);
            comboBoxMedicos.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(118, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(103, 23);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.Value = new DateTime(2025, 6, 18, 0, 0, 0, 0);
            // 
            // textBox5
            // 
            textBox5.Location = new Point(116, 122);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 14;
            label4.Text = "Motivo de Consulta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(57, 67);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 15;
            label5.Text = "Medicos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(71, 93);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 16;
            label6.Text = "Fecha";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(72, 124);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 18;
            label8.Text = "Total";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button2.Location = new Point(6, 177);
            button2.Name = "button2";
            button2.Size = new Size(86, 26);
            button2.TabIndex = 19;
            button2.Text = "Registrar Cita";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { reciboDeCitaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(863, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // reciboDeCitaToolStripMenuItem
            // 
            reciboDeCitaToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reciboDeCitaToolStripMenuItem.Name = "reciboDeCitaToolStripMenuItem";
            reciboDeCitaToolStripMenuItem.Size = new Size(98, 20);
            reciboDeCitaToolStripMenuItem.Text = "Recibo de Cita";
            reciboDeCitaToolStripMenuItem.Click += reciboDeCitaToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(839, 174);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pacientes";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button5.Location = new Point(160, 126);
            button5.Name = "button5";
            button5.Size = new Size(70, 42);
            button5.TabIndex = 25;
            button5.Text = "Editar Paciente";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button3.Location = new Point(84, 126);
            button3.Name = "button3";
            button3.Size = new Size(70, 42);
            button3.TabIndex = 23;
            button3.Text = "Eliminar Paciente";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(comboBoxMedicos);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(839, 209);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "CitaMedica";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button4.Location = new Point(98, 177);
            button4.Name = "button4";
            button4.Size = new Size(96, 26);
            button4.TabIndex = 24;
            button4.Text = "Eliminar Cita";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button6.Location = new Point(199, 177);
            button6.Name = "button6";
            button6.Size = new Size(96, 26);
            button6.TabIndex = 26;
            button6.Text = "Editar Cita";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaption;
            button7.Location = new Point(236, 142);
            button7.Name = "button7";
            button7.Size = new Size(10, 10);
            button7.TabIndex = 26;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // CitasDesktop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 452);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CitasDesktop";
            Text = "Form1";
            Load += CitasDesktop_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox4;
        private ComboBox comboBoxMedicos;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem reciboDeCitaToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
