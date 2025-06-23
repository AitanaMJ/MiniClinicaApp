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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            reciboDeCitaToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(6, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 134);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre y Apellido";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Edad";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "DNI";
            Column4.Name = "Column4";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView2.Location = new Point(6, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(443, 127);
            dataGridView2.TabIndex = 1;
            // 
            // Column5
            // 
            Column5.HeaderText = "ID";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Motivo de Consulta";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Medico";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Fecha";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Hora";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Total";
            Column10.Name = "Column10";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(38, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 65);
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
            label2.Location = new Point(101, 101);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(104, 134);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 7;
            label3.Text = "DNI";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.Location = new Point(12, 174);
            button1.Name = "button1";
            button1.Size = new Size(123, 30);
            button1.TabIndex = 8;
            button1.Text = "Registrar Paciente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 224);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 23);
            textBox4.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1. Dr Castillo", "2. Dra Hernandez", "3. Dr  Molina" });
            comboBox1.Location = new Point(136, 253);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(54, 296);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(103, 23);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.Value = new DateTime(2025, 6, 18, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm tt";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(199, 294);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(103, 23);
            dateTimePicker2.TabIndex = 12;
            dateTimePicker2.Value = new DateTime(2025, 6, 18, 23, 52, 44, 0);
            // 
            // textBox5
            // 
            textBox5.Location = new Point(136, 340);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(24, 227);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 14;
            label4.Text = "Motivo de Consulta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(81, 257);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 15;
            label5.Text = "Medicos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(12, 300);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 16;
            label6.Text = "Fecha";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(163, 299);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 17;
            label7.Text = "Hora";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(101, 344);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 18;
            label8.Text = "Total";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button2.Location = new Point(12, 378);
            button2.Name = "button2";
            button2.Size = new Size(123, 26);
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
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(357, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 161);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pacientes";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(357, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(455, 160);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "CitaMedica";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 428);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem reciboDeCitaToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
