/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 14/11/2022
 * Time: 10:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Mundial
{
	partial class faseDeGrupos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(faseDeGrupos));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelSeguroEliminar = new System.Windows.Forms.Panel();
            this.btnEliminarNo = new System.Windows.Forms.Button();
            this.btnEliminarSi = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCargaDatos = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnAyuda = new System.Windows.Forms.Button();
            this.panelAyuda = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxCarga = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTAmarilla = new System.Windows.Forms.TextBox();
            this.txtTRojas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPartidosGanados = new System.Windows.Forms.TextBox();
            this.txtDifGoles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGolesAfavor = new System.Windows.Forms.TextBox();
            this.txtPerdidos = new System.Windows.Forms.TextBox();
            this.txtEmpate = new System.Windows.Forms.TextBox();
            this.txtGolesEnContra = new System.Windows.Forms.TextBox();
            this.txtPartJugado = new System.Windows.Forms.TextBox();
            this.lbSgrupo = new System.Windows.Forms.Label();
            this.ElegirGrupo = new System.Windows.Forms.ComboBox();
            this.lbSpais = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.Label();
            this.ElegirPais = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ControlSection = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultarFdG = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            this.panelSeguroEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelAyuda.SuspendLayout();
            this.groupBoxCarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ControlSection.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Brown;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.btnMostrar);
            this.tabPage1.Controls.Add(this.panelSeguroEliminar);
            this.tabPage1.Controls.Add(this.btnVolver);
            this.tabPage1.Controls.Add(this.btnCargaDatos);
            this.tabPage1.Controls.Add(this.btnCargar);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnModificar);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.BtnAyuda);
            this.tabPage1.Controls.Add(this.panelAyuda);
            this.tabPage1.Controls.Add(this.groupBoxCarga);
            this.tabPage1.Controls.Add(this.lbSgrupo);
            this.tabPage1.Controls.Add(this.ElegirGrupo);
            this.tabPage1.Controls.Add(this.lbSpais);
            this.tabPage1.Controls.Add(this.lbPais);
            this.tabPage1.Controls.Add(this.ElegirPais);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1040, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Partidos Fase de grupos";
            // 
            // panelSeguroEliminar
            // 
            this.panelSeguroEliminar.BackColor = System.Drawing.Color.DarkGray;
            this.panelSeguroEliminar.Controls.Add(this.btnEliminarNo);
            this.panelSeguroEliminar.Controls.Add(this.btnEliminarSi);
            this.panelSeguroEliminar.Controls.Add(this.label19);
            this.panelSeguroEliminar.Location = new System.Drawing.Point(340, 192);
            this.panelSeguroEliminar.Name = "panelSeguroEliminar";
            this.panelSeguroEliminar.Size = new System.Drawing.Size(293, 159);
            this.panelSeguroEliminar.TabIndex = 15;
            this.panelSeguroEliminar.Visible = false;
            // 
            // btnEliminarNo
            // 
            this.btnEliminarNo.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarNo.Location = new System.Drawing.Point(187, 81);
            this.btnEliminarNo.Name = "btnEliminarNo";
            this.btnEliminarNo.Size = new System.Drawing.Size(58, 31);
            this.btnEliminarNo.TabIndex = 2;
            this.btnEliminarNo.Text = "NO";
            this.btnEliminarNo.UseVisualStyleBackColor = false;
            this.btnEliminarNo.Click += new System.EventHandler(this.btnEliminarNo_Click);
            // 
            // btnEliminarSi
            // 
            this.btnEliminarSi.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarSi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarSi.Location = new System.Drawing.Point(43, 81);
            this.btnEliminarSi.Name = "btnEliminarSi";
            this.btnEliminarSi.Size = new System.Drawing.Size(58, 31);
            this.btnEliminarSi.TabIndex = 1;
            this.btnEliminarSi.Text = "SI";
            this.btnEliminarSi.UseVisualStyleBackColor = false;
            this.btnEliminarSi.Click += new System.EventHandler(this.btnEliminarSi_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(71, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "¿Estas seguro?";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(592, 13);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 28);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "<- Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCargaDatos
            // 
            this.btnCargaDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnCargaDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargaDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaDatos.Location = new System.Drawing.Point(642, 310);
            this.btnCargaDatos.Name = "btnCargaDatos";
            this.btnCargaDatos.Size = new System.Drawing.Size(145, 35);
            this.btnCargaDatos.TabIndex = 5;
            this.btnCargaDatos.Text = "CARGA";
            this.btnCargaDatos.UseVisualStyleBackColor = false;
            this.btnCargaDatos.Visible = false;
            this.btnCargaDatos.Click += new System.EventHandler(this.btnCargaDatos_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Transparent;
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(120, 340);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(296, 67);
            this.btnCargar.TabIndex = 13;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(120, 413);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(296, 67);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "CONSULTAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(120, 486);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(296, 67);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(381, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.BtnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAyuda.Location = new System.Drawing.Point(935, 13);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(90, 28);
            this.BtnAyuda.TabIndex = 9;
            this.BtnAyuda.Text = "Ayuda";
            this.BtnAyuda.UseVisualStyleBackColor = false;
            this.BtnAyuda.Visible = false;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // panelAyuda
            // 
            this.panelAyuda.BackColor = System.Drawing.Color.Transparent;
            this.panelAyuda.Controls.Add(this.btnCerrar);
            this.panelAyuda.Controls.Add(this.label17);
            this.panelAyuda.Controls.Add(this.label14);
            this.panelAyuda.Controls.Add(this.label18);
            this.panelAyuda.Controls.Add(this.label15);
            this.panelAyuda.Controls.Add(this.label16);
            this.panelAyuda.Controls.Add(this.label10);
            this.panelAyuda.Controls.Add(this.label11);
            this.panelAyuda.Controls.Add(this.label12);
            this.panelAyuda.Controls.Add(this.label13);
            this.panelAyuda.Location = new System.Drawing.Point(461, 384);
            this.panelAyuda.Name = "panelAyuda";
            this.panelAyuda.Size = new System.Drawing.Size(573, 157);
            this.panelAyuda.TabIndex = 8;
            this.panelAyuda.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.Location = new System.Drawing.Point(541, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(382, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 20);
            this.label17.TabIndex = 26;
            this.label17.Text = "TR: Tarjetas rojas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(187, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "DG: Dif. de goles";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(382, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 20);
            this.label18.TabIndex = 24;
            this.label18.Text = "TA: Tarjetas amarillas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(188, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "GC: Goles en contra";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(188, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 20);
            this.label16.TabIndex = 25;
            this.label16.Text = "GF: Goles a favor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-1, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "PG: Partidos Ganados";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-1, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "PJ: Partidos jugados";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "P: Perdido";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "E: Empate";
            // 
            // groupBoxCarga
            // 
            this.groupBoxCarga.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCarga.Controls.Add(this.label8);
            this.groupBoxCarga.Controls.Add(this.label9);
            this.groupBoxCarga.Controls.Add(this.txtTAmarilla);
            this.groupBoxCarga.Controls.Add(this.txtTRojas);
            this.groupBoxCarga.Controls.Add(this.label7);
            this.groupBoxCarga.Controls.Add(this.label6);
            this.groupBoxCarga.Controls.Add(this.label4);
            this.groupBoxCarga.Controls.Add(this.label1);
            this.groupBoxCarga.Controls.Add(this.label3);
            this.groupBoxCarga.Controls.Add(this.label5);
            this.groupBoxCarga.Controls.Add(this.txtPartidosGanados);
            this.groupBoxCarga.Controls.Add(this.txtDifGoles);
            this.groupBoxCarga.Controls.Add(this.label2);
            this.groupBoxCarga.Controls.Add(this.txtGolesAfavor);
            this.groupBoxCarga.Controls.Add(this.txtPerdidos);
            this.groupBoxCarga.Controls.Add(this.txtEmpate);
            this.groupBoxCarga.Controls.Add(this.txtGolesEnContra);
            this.groupBoxCarga.Controls.Add(this.txtPartJugado);
            this.groupBoxCarga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxCarga.Location = new System.Drawing.Point(592, 47);
            this.groupBoxCarga.Name = "groupBoxCarga";
            this.groupBoxCarga.Size = new System.Drawing.Size(433, 257);
            this.groupBoxCarga.TabIndex = 6;
            this.groupBoxCarga.TabStop = false;
            this.groupBoxCarga.Text = "CARGA";
            this.groupBoxCarga.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(252, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "TR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(144, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "TA";
            // 
            // txtTAmarilla
            // 
            this.txtTAmarilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTAmarilla.Location = new System.Drawing.Point(131, 205);
            this.txtTAmarilla.Name = "txtTAmarilla";
            this.txtTAmarilla.Size = new System.Drawing.Size(64, 22);
            this.txtTAmarilla.TabIndex = 14;
            // 
            // txtTRojas
            // 
            this.txtTRojas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRojas.Location = new System.Drawing.Point(239, 205);
            this.txtTRojas.Name = "txtTRojas";
            this.txtTRojas.Size = new System.Drawing.Size(64, 22);
            this.txtTRojas.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "DG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "PG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "GC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "PJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "GF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "P";
            // 
            // txtPartidosGanados
            // 
            this.txtPartidosGanados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartidosGanados.Location = new System.Drawing.Point(129, 59);
            this.txtPartidosGanados.Name = "txtPartidosGanados";
            this.txtPartidosGanados.Size = new System.Drawing.Size(64, 22);
            this.txtPartidosGanados.TabIndex = 6;
            // 
            // txtDifGoles
            // 
            this.txtDifGoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDifGoles.Location = new System.Drawing.Point(289, 137);
            this.txtDifGoles.Name = "txtDifGoles";
            this.txtDifGoles.Size = new System.Drawing.Size(64, 22);
            this.txtDifGoles.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "E";
            // 
            // txtGolesAfavor
            // 
            this.txtGolesAfavor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGolesAfavor.Location = new System.Drawing.Point(79, 137);
            this.txtGolesAfavor.Name = "txtGolesAfavor";
            this.txtGolesAfavor.Size = new System.Drawing.Size(64, 22);
            this.txtGolesAfavor.TabIndex = 4;
            // 
            // txtPerdidos
            // 
            this.txtPerdidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerdidos.Location = new System.Drawing.Point(334, 59);
            this.txtPerdidos.Name = "txtPerdidos";
            this.txtPerdidos.Size = new System.Drawing.Size(64, 22);
            this.txtPerdidos.TabIndex = 3;
            // 
            // txtEmpate
            // 
            this.txtEmpate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpate.Location = new System.Drawing.Point(237, 59);
            this.txtEmpate.Name = "txtEmpate";
            this.txtEmpate.Size = new System.Drawing.Size(64, 22);
            this.txtEmpate.TabIndex = 2;
            // 
            // txtGolesEnContra
            // 
            this.txtGolesEnContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGolesEnContra.Location = new System.Drawing.Point(186, 137);
            this.txtGolesEnContra.Name = "txtGolesEnContra";
            this.txtGolesEnContra.Size = new System.Drawing.Size(64, 22);
            this.txtGolesEnContra.TabIndex = 1;
            // 
            // txtPartJugado
            // 
            this.txtPartJugado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartJugado.Location = new System.Drawing.Point(26, 59);
            this.txtPartJugado.Name = "txtPartJugado";
            this.txtPartJugado.Size = new System.Drawing.Size(64, 22);
            this.txtPartJugado.TabIndex = 0;
            // 
            // lbSgrupo
            // 
            this.lbSgrupo.AutoSize = true;
            this.lbSgrupo.BackColor = System.Drawing.Color.Transparent;
            this.lbSgrupo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSgrupo.Location = new System.Drawing.Point(39, 232);
            this.lbSgrupo.Name = "lbSgrupo";
            this.lbSgrupo.Size = new System.Drawing.Size(248, 24);
            this.lbSgrupo.TabIndex = 5;
            this.lbSgrupo.Text = "seleccione el grupo";
            this.lbSgrupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElegirGrupo
            // 
            this.ElegirGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElegirGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElegirGrupo.FormattingEnabled = true;
            this.ElegirGrupo.Items.AddRange(new object[] {
            "Grupo A",
            "Grupo B",
            "Grupo C",
            "Grupo D",
            "Grupo E",
            "Grupo F",
            "Grupo G",
            "Grupo H"});
            this.ElegirGrupo.Location = new System.Drawing.Point(43, 259);
            this.ElegirGrupo.Name = "ElegirGrupo";
            this.ElegirGrupo.Size = new System.Drawing.Size(313, 28);
            this.ElegirGrupo.TabIndex = 4;
            this.ElegirGrupo.SelectedIndexChanged += new System.EventHandler(this.ElegirGrupo_SelectedIndexChanged);
            // 
            // lbSpais
            // 
            this.lbSpais.AutoSize = true;
            this.lbSpais.BackColor = System.Drawing.Color.Transparent;
            this.lbSpais.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpais.Location = new System.Drawing.Point(39, 316);
            this.lbSpais.Name = "lbSpais";
            this.lbSpais.Size = new System.Drawing.Size(224, 24);
            this.lbSpais.TabIndex = 3;
            this.lbSpais.Text = "seleccione el pais";
            this.lbSpais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSpais.Visible = false;
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.BackColor = System.Drawing.Color.Transparent;
            this.lbPais.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPais.Location = new System.Drawing.Point(353, 66);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(151, 24);
            this.lbPais.TabIndex = 2;
            this.lbPais.Text = "SELECCIÒN";
            this.lbPais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElegirPais
            // 
            this.ElegirPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElegirPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElegirPais.FormattingEnabled = true;
            this.ElegirPais.Items.AddRange(new object[] {
            "Qatar",
            "Ecuador",
            "Senegal",
            "Paises Bajos"});
            this.ElegirPais.Location = new System.Drawing.Point(43, 343);
            this.ElegirPais.Name = "ElegirPais";
            this.ElegirPais.Size = new System.Drawing.Size(313, 28);
            this.ElegirPais.TabIndex = 1;
            this.ElegirPais.Visible = false;
            this.ElegirPais.SelectedIndexChanged += new System.EventHandler(this.ElegirPais_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Mundial.Properties.Resources.bandera_blanca;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ControlSection
            // 
            this.ControlSection.Controls.Add(this.tabPage1);
            this.ControlSection.Controls.Add(this.tabPage2);
            this.ControlSection.Location = new System.Drawing.Point(12, 12);
            this.ControlSection.Name = "ControlSection";
            this.ControlSection.SelectedIndex = 0;
            this.ControlSection.Size = new System.Drawing.Size(1048, 580);
            this.ControlSection.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Brown;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnConsultarFdG);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1040, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(822, 224);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnConsultarFdG
            // 
            this.btnConsultarFdG.Location = new System.Drawing.Point(756, 17);
            this.btnConsultarFdG.Name = "btnConsultarFdG";
            this.btnConsultarFdG.Size = new System.Drawing.Size(85, 23);
            this.btnConsultarFdG.TabIndex = 1;
            this.btnConsultarFdG.Text = "CONSULTAR";
            this.btnConsultarFdG.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(699, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(816, 310);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(145, 35);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Visible = false;
            this.btnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(440, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(64, 22);
            this.txtID.TabIndex = 17;
            // 
            // faseDeGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1072, 605);
            this.Controls.Add(this.ControlSection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "faseDeGrupos";
            this.Text = "Mundial";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelSeguroEliminar.ResumeLayout(false);
            this.panelSeguroEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelAyuda.ResumeLayout(false);
            this.panelAyuda.PerformLayout();
            this.groupBoxCarga.ResumeLayout(false);
            this.groupBoxCarga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ControlSection.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCargaDatos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnAyuda;
        private System.Windows.Forms.Panel panelAyuda;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBoxCarga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTAmarilla;
        private System.Windows.Forms.TextBox txtTRojas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPartidosGanados;
        private System.Windows.Forms.TextBox txtDifGoles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGolesAfavor;
        private System.Windows.Forms.TextBox txtPerdidos;
        private System.Windows.Forms.TextBox txtEmpate;
        private System.Windows.Forms.TextBox txtGolesEnContra;
        private System.Windows.Forms.TextBox txtPartJugado;
        private System.Windows.Forms.Label lbSgrupo;
        private System.Windows.Forms.ComboBox ElegirGrupo;
        private System.Windows.Forms.Label lbSpais;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.ComboBox ElegirPais;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TabControl ControlSection;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelSeguroEliminar;
        private System.Windows.Forms.Button btnEliminarNo;
        private System.Windows.Forms.Button btnEliminarSi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultarFdG;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtID;
    }
}
