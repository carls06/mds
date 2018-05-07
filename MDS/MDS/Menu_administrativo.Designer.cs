namespace MDS
{
    partial class Menu_administrativo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiliadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiliadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCancelar_TP3 = new System.Windows.Forms.Button();
            this.btnReservarTP3_Click = new System.Windows.Forms.Button();
            this.dtpHora_tp3 = new System.Windows.Forms.DateTimePicker();
            this.cmbDoctor_Cita = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Doctor = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Citas_Calendario = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbledad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblape = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.duitxt = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afiliadoToolStripMenuItem,
            this.afiliadorToolStripMenuItem,
            this.doctorToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // afiliadoToolStripMenuItem
            // 
            this.afiliadoToolStripMenuItem.Name = "afiliadoToolStripMenuItem";
            this.afiliadoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.afiliadoToolStripMenuItem.Text = "Afiliado";
            this.afiliadoToolStripMenuItem.Click += new System.EventHandler(this.afiliadoToolStripMenuItem_Click);
            // 
            // afiliadorToolStripMenuItem
            // 
            this.afiliadorToolStripMenuItem.Name = "afiliadorToolStripMenuItem";
            this.afiliadorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.afiliadorToolStripMenuItem.Text = "Doctor";
            this.afiliadorToolStripMenuItem.Click += new System.EventHandler(this.afiliadorToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.doctorToolStripMenuItem.Text = "Administracion";
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afiliadosToolStripMenuItem,
            this.administrativoToolStripMenuItem,
            this.doctorToolStripMenuItem1});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // afiliadosToolStripMenuItem
            // 
            this.afiliadosToolStripMenuItem.Name = "afiliadosToolStripMenuItem";
            this.afiliadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afiliadosToolStripMenuItem.Text = "Afiliados";
            this.afiliadosToolStripMenuItem.Click += new System.EventHandler(this.afiliadosToolStripMenuItem_Click);
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            this.administrativoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.administrativoToolStripMenuItem.Text = "Doctor";
            this.administrativoToolStripMenuItem.Click += new System.EventHandler(this.administrativoToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem1
            // 
            this.doctorToolStripMenuItem1.Name = "doctorToolStripMenuItem1";
            this.doctorToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.doctorToolStripMenuItem1.Text = "Administrativo";
            this.doctorToolStripMenuItem1.Click += new System.EventHandler(this.doctorToolStripMenuItem1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(662, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(47, 569);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(34, 19);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 197);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 360);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(677, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Solicitud de Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(6, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 159);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignación de Doctor";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCancelar);
            this.groupBox5.Controls.Add(this.btnAsignar);
            this.groupBox5.Location = new System.Drawing.Point(503, 36);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(156, 117);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Paso 3: Confirmar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(50, 67);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(50, 30);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 33);
            this.btnAsignar.TabIndex = 0;
            this.btnAsignar.Text = "Solicitar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbDoctor);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(196, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(301, 120);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Paso 2: Asignar Doctor";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(57, 37);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(238, 24);
            this.cmbDoctor.TabIndex = 2;
            this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbDoctor_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Doctor:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Location = new System.Drawing.Point(9, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 120);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paso 1: Tipo de Consulta";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Consulta General";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(167, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Consulta Especializada";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCancelar_TP3);
            this.tabPage3.Controls.Add(this.btnReservarTP3_Click);
            this.tabPage3.Controls.Add(this.dtpHora_tp3);
            this.tabPage3.Controls.Add(this.cmbDoctor_Cita);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.Doctor);
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Controls.Add(this.Citas_Calendario);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(677, 331);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reservar Consulta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCancelar_TP3
            // 
            this.btnCancelar_TP3.Location = new System.Drawing.Point(207, 265);
            this.btnCancelar_TP3.Name = "btnCancelar_TP3";
            this.btnCancelar_TP3.Size = new System.Drawing.Size(90, 34);
            this.btnCancelar_TP3.TabIndex = 7;
            this.btnCancelar_TP3.Text = "Cancelar";
            this.btnCancelar_TP3.UseVisualStyleBackColor = true;
            // 
            // btnReservarTP3_Click
            // 
            this.btnReservarTP3_Click.Location = new System.Drawing.Point(207, 225);
            this.btnReservarTP3_Click.Name = "btnReservarTP3_Click";
            this.btnReservarTP3_Click.Size = new System.Drawing.Size(90, 34);
            this.btnReservarTP3_Click.TabIndex = 6;
            this.btnReservarTP3_Click.Text = "Reservar";
            this.btnReservarTP3_Click.UseVisualStyleBackColor = true;
            this.btnReservarTP3_Click.Click += new System.EventHandler(this.btnReservarTP3_Click_Click);
            // 
            // dtpHora_tp3
            // 
            this.dtpHora_tp3.CustomFormat = "HH:mm";
            this.dtpHora_tp3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora_tp3.Location = new System.Drawing.Point(60, 229);
            this.dtpHora_tp3.Name = "dtpHora_tp3";
            this.dtpHora_tp3.ShowUpDown = true;
            this.dtpHora_tp3.Size = new System.Drawing.Size(54, 22);
            this.dtpHora_tp3.TabIndex = 5;
            // 
            // cmbDoctor_Cita
            // 
            this.cmbDoctor_Cita.FormattingEnabled = true;
            this.cmbDoctor_Cita.Location = new System.Drawing.Point(60, 190);
            this.cmbDoctor_Cita.Name = "cmbDoctor_Cita";
            this.cmbDoctor_Cita.Size = new System.Drawing.Size(237, 24);
            this.cmbDoctor_Cita.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Hora";
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.Location = new System.Drawing.Point(9, 193);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(48, 16);
            this.Doctor.TabIndex = 2;
            this.Doctor.Text = "Doctor";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Dia});
            this.listView1.Location = new System.Drawing.Point(341, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(302, 291);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hora";
            this.columnHeader1.Width = 105;
            // 
            // Dia
            // 
            this.Dia.Width = 201;
            // 
            // Citas_Calendario
            // 
            this.Citas_Calendario.Location = new System.Drawing.Point(12, 12);
            this.Citas_Calendario.MaxSelectionCount = 1;
            this.Citas_Calendario.Name = "Citas_Calendario";
            this.Citas_Calendario.TabIndex = 0;
            this.Citas_Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Citas_Calendario_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbledad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblape);
            this.groupBox1.Controls.Add(this.lblnom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información general";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(72, 61);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(0, 16);
            this.lbledad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Edad:";
            // 
            // lblape
            // 
            this.lblape.AutoSize = true;
            this.lblape.Location = new System.Drawing.Point(284, 28);
            this.lblape.Name = "lblape";
            this.lblape.Size = new System.Drawing.Size(0, 16);
            this.lblape.TabIndex = 3;
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(72, 28);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(0, 16);
            this.lblnom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(385, 54);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 24);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Verificar";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // duitxt
            // 
            this.duitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duitxt.Location = new System.Drawing.Point(294, 56);
            this.duitxt.Mask = "00000000-0";
            this.duitxt.Name = "duitxt";
            this.duitxt.Size = new System.Drawing.Size(85, 22);
            this.duitxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese DUI:";
            // 
            // Menu_administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 569);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.duitxt);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_administrativo";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Menu_administrativo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiliadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiliadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblape;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.MaskedTextBox duitxt;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MonthCalendar Citas_Calendario;
        private System.Windows.Forms.DateTimePicker dtpHora_tp3;
        private System.Windows.Forms.ComboBox cmbDoctor_Cita;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Doctor;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Dia;
        private System.Windows.Forms.Button btnCancelar_TP3;
        private System.Windows.Forms.Button btnReservarTP3_Click;
    }
}