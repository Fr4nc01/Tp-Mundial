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
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ControlSection = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbSgrupo = new System.Windows.Forms.Label();
            this.ElegirGrupo = new System.Windows.Forms.ComboBox();
            this.lbSpais = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.Label();
            this.ElegirPais = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ControlSection.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlSection
            // 
            this.ControlSection.Controls.Add(this.tabPage1);
            this.ControlSection.Controls.Add(this.tabPage2);
            this.ControlSection.Controls.Add(this.tabPage3);
            this.ControlSection.Location = new System.Drawing.Point(12, 12);
            this.ControlSection.Name = "ControlSection";
            this.ControlSection.SelectedIndex = 0;
            this.ControlSection.Size = new System.Drawing.Size(1024, 570);
            this.ControlSection.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Brown;
            this.tabPage1.Controls.Add(this.lbSgrupo);
            this.tabPage1.Controls.Add(this.ElegirGrupo);
            this.tabPage1.Controls.Add(this.lbSpais);
            this.tabPage1.Controls.Add(this.lbPais);
            this.tabPage1.Controls.Add(this.ElegirPais);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carga Equipos";
            // 
            // lbSgrupo
            // 
            this.lbSgrupo.AutoSize = true;
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
            this.lbPais.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPais.Location = new System.Drawing.Point(301, 42);
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Brown;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carga Partidos";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Brown;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1016, 544);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Posiciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Mundial.Properties.Resources.bandera_blanca;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1048, 594);
            this.Controls.Add(this.ControlSection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mundial";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ControlSection.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		public System.Windows.Forms.TabPage tabPage3;
		public System.Windows.Forms.TabPage tabPage2;
		public System.Windows.Forms.TabPage tabPage1;
		public System.Windows.Forms.TabControl ControlSection;
        private System.Windows.Forms.ComboBox ElegirPais;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Label lbSpais;
        private System.Windows.Forms.Label lbSgrupo;
        private System.Windows.Forms.ComboBox ElegirGrupo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
