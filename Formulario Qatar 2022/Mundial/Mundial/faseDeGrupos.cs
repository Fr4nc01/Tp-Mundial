
using Mundial.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mundial
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class faseDeGrupos : Form
	{

        SqlConnection bd = new SqlConnection();
		public faseDeGrupos()
		{
			InitializeComponent();
            lbPais.Text = "";

			
			
		}

        private void MainForm_Load(object sender, EventArgs e)
        {
			
        }

		private void ElegirGrupo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ElegirGrupo.SelectedIndex == 0) // GRUPO A
            {
				ElegirPais.Items.Clear();
				ElegirPais.Items.Add("Qatar");
                ElegirPais.Items.Add("Ecuador");
                ElegirPais.Items.Add("Senegal");
                ElegirPais.Items.Add("Paises Bajos");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
				ElegirPais.Visible = true;
			}
			if (ElegirGrupo.SelectedIndex == 1) // GRUPO B
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("Inglaterra");
                ElegirPais.Items.Add("Iràn");
                ElegirPais.Items.Add("Estados Unidos");
                ElegirPais.Items.Add("Gales");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
				ElegirPais.Visible = true;
			}
            if (ElegirGrupo.SelectedIndex == 2) // GRUPO C
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("Argentina");
                ElegirPais.Items.Add("Arabia Saudita");
                ElegirPais.Items.Add("Mexico");
                ElegirPais.Items.Add("Polonia");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
                ElegirPais.Visible = true;
            }
            if (ElegirGrupo.SelectedIndex == 3) // GRUPO D
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("Francia");
                ElegirPais.Items.Add("Australia");
                ElegirPais.Items.Add("Dinamarca");
                ElegirPais.Items.Add("Tùnez");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
                ElegirPais.Visible = true;
            }
            if (ElegirGrupo.SelectedIndex == 4) // GRUPO E
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("España");
                ElegirPais.Items.Add("Costa Rica");
                ElegirPais.Items.Add("Alemania");
                ElegirPais.Items.Add("Japón");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
                ElegirPais.Visible = true;
            }
            if (ElegirGrupo.SelectedIndex == 5) // GRUPO F
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("Bélgica");
                ElegirPais.Items.Add("Canadá");
                ElegirPais.Items.Add("Marruecos");
                ElegirPais.Items.Add("Croacia");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
                ElegirPais.Visible = true;
            }
            if (ElegirGrupo.SelectedIndex == 6) // GRUPO G
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("Brasil");
                ElegirPais.Items.Add("Serbia");
                ElegirPais.Items.Add("Suiza");
                ElegirPais.Items.Add("Camerún");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
                ElegirPais.Visible = true;
            }
            if (ElegirGrupo.SelectedIndex == 7) // GRUPO H
            {
                ElegirPais.Items.Clear();
                ElegirPais.Items.Add("Portugal");
                ElegirPais.Items.Add("Ghana");
                ElegirPais.Items.Add("Uruguay");
                ElegirPais.Items.Add("Corea del Sur");
                pictureBox1.Image = Resources.bandera_blanca;
                lbPais.Text = "";
                lbSpais.Visible = true;
                ElegirPais.Visible = true;
            }

        }

        private void ElegirPais_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ElegirPais.SelectedIndex == 0) // Primer opcion del ComboBox
            {
                if (ElegirPais.Items.Contains("Qatar"))
                {
                    lbPais.Text = "Qatar";
                    pictureBox1.Image = Resources.BanQatar;

                }
                if (ElegirPais.Items.Contains("Inglaterra"))
                {
                    lbPais.Text = "Inglaterra";
                    pictureBox1.Image = Resources.BanInglaterra;

                }
                if (ElegirPais.Items.Contains("Argentina"))
                {
                    lbPais.Text = "Argentina";
                    pictureBox1.Image = Resources.BanArgentina;

                }
                if (ElegirPais.Items.Contains("Francia"))
                {
                    lbPais.Text = "Francia";
                    pictureBox1.Image = Resources.BanFrancia;

                }
                if (ElegirPais.Items.Contains("España"))
                {
                    lbPais.Text = "España";
                    pictureBox1.Image = Resources.BanEspaña;

                }
                if (ElegirPais.Items.Contains("Bélgica"))
                {
                    lbPais.Text = "Bélgica";
                    pictureBox1.Image = Resources.BanBelgica;

                }
                if (ElegirPais.Items.Contains("Brasil"))
                {
                    lbPais.Text = "Brasil";
                    pictureBox1.Image = Resources.BanBrasil;

                }
                if (ElegirPais.Items.Contains("Portugal"))
                {
                    lbPais.Text = "Portugal";
                    pictureBox1.Image = Resources.BanPortugal;

                }

            }

            if (ElegirPais.SelectedIndex == 1) // Segunda opcion del ComboBox
            {
                if (ElegirPais.Items.Contains("Ecuador"))
                {
                    lbPais.Text = "Ecuador";
                    pictureBox1.Image = Resources.BanEcuador;

                }
                if (ElegirPais.Items.Contains("Iràn"))
                {
                    lbPais.Text = "Iràn";
                    pictureBox1.Image = Resources.BanIràn;

                }
                if (ElegirPais.Items.Contains("Arabia Saudita"))
                {
                    lbPais.Text = "Arabia Saudita";
                    pictureBox1.Image = Resources.BanArabiaSaudita;

                }
                if (ElegirPais.Items.Contains("Australia"))
                {
                    lbPais.Text = "Australia";
                    pictureBox1.Image = Resources.BanAustralia;

                }
                if (ElegirPais.Items.Contains("Costa Rica"))
                {
                    lbPais.Text = "Costa Rica";
                    pictureBox1.Image = Resources.BanCostaRica;

                }
                if (ElegirPais.Items.Contains("Canadá"))
                {
                    lbPais.Text = "Canadá";
                    pictureBox1.Image = Resources.BanCanada;

                }
                if (ElegirPais.Items.Contains("Serbia"))
                {
                    lbPais.Text = "Serbia";
                    pictureBox1.Image = Resources.BanSerbia;

                }
                if (ElegirPais.Items.Contains("Ghana"))
                {
                    lbPais.Text = "Ghana";
                    pictureBox1.Image = Resources.BanGhana;

                }

            }

            if (ElegirPais.SelectedIndex == 2) // Tercer opcion del ComboBox
            {
                if (ElegirPais.Items.Contains("Senegal"))
                {
                    lbPais.Text = "Senegal";
                    pictureBox1.Image = Resources.BanSenegal;

                }
                if (ElegirPais.Items.Contains("Estados Unidos"))
                {
                    lbPais.Text = "Estados Unidos";
                    pictureBox1.Image = Resources.BanEEUU;

                }
                if (ElegirPais.Items.Contains("Mexico"))
                {
                    lbPais.Text = "Mexico";
                    pictureBox1.Image = Resources.BanMex;

                }
                if (ElegirPais.Items.Contains("Dinamarca"))
                {
                    lbPais.Text = "Dinamarca";
                    pictureBox1.Image = Resources.BanDinamarca;

                }
                if (ElegirPais.Items.Contains("Alemania"))
                {
                    lbPais.Text = "Alemania";
                    pictureBox1.Image = Resources.BanAlemania;

                }
                if (ElegirPais.Items.Contains("Marruecos"))
                {
                    lbPais.Text = "Marruecos";
                    pictureBox1.Image = Resources.BanMarruecos;

                }
                if (ElegirPais.Items.Contains("Suiza"))
                {
                    lbPais.Text = "Suiza";
                    pictureBox1.Image = Resources.BanSuiza;

                }
                if (ElegirPais.Items.Contains("Uruguay"))
                {
                    lbPais.Text = "Uruguay";
                    pictureBox1.Image = Resources.BanUruguay;

                }

            }

            if (ElegirPais.SelectedIndex == 3) // Cuarta opcion del ComboBox
            {
                if (ElegirPais.Items.Contains("Paises Bajos"))
                {
                    lbPais.Text = "Paises Bajos";
                    pictureBox1.Image = Resources.BanPaisesBajos;

                }
                if (ElegirPais.Items.Contains("Gales"))
                {
                    lbPais.Text = "Gales";
                    pictureBox1.Image = Resources.BanGales;

                }
                if (ElegirPais.Items.Contains("Polonia"))
                {
                    lbPais.Text = "Polonia";
                    pictureBox1.Image = Resources.BanPolonia;

                }
                if (ElegirPais.Items.Contains("Tùnez"))
                {
                    lbPais.Text = "Túnez";
                    pictureBox1.Image = Resources.BanTunez;

                }
                if (ElegirPais.Items.Contains("Japón"))
                {
                    lbPais.Text = "Japón";
                    pictureBox1.Image = Resources.BanJapon;

                }
                if (ElegirPais.Items.Contains("Croacia"))
                {
                    lbPais.Text = "Croacia";
                    pictureBox1.Image = Resources.BanCroacia;

                }
                if (ElegirPais.Items.Contains("Camerún"))
                {
                    lbPais.Text = "Camerún";
                    pictureBox1.Image = Resources.BanCamerun;

                }
                if (ElegirPais.Items.Contains("Corea del Sur"))
                {
                    lbPais.Text = "Corea del Sur";
                    pictureBox1.Image = Resources.BanCoreaDelSur;

                }

            }

        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BtnAyuda.Visible = true;
            btnCargaDatos.Visible = true;
            groupBoxCarga.Visible = true;
            btnCargar.Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnVolver.Visible = true;



        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            BtnAyuda.Visible = false;
            btnCargaDatos.Visible = false;
            groupBoxCarga.Visible = false;
            btnCargar.Visible = true;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;
            btnVolver.Visible = false;
        }

        private void btnCargaDatos_Click(object sender, EventArgs e)
        {
            BtnAyuda.Visible = false;
            btnCargaDatos.Visible = false;
            groupBoxCarga.Visible = false;
            btnCargar.Visible = true;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;
            btnVolver.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           panelSeguroEliminar.Visible = true;
        }

        private void btnEliminarNo_Click(object sender, EventArgs e)
        {
            panelSeguroEliminar.Visible = false;
        }

        private void btnEliminarSi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos eliminados correctamente!");
            panelSeguroEliminar.Visible = false;
        }
    }
}
