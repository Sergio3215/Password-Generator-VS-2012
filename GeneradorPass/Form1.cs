using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneradorPass;
using System.IO;

namespace GeneradorPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generar()
        {
            Generator_Password g = new Generator_Password();
            txtCodigo.Text = g.GeneratePassword(txtCodigo.Text);
            lblMensaje.Text = "El codigo o contraseña es...";
            btnGenerar.Enabled = false;
            btnLimpiar.Enabled = true;
            btnCopiar.Enabled = true;

            string contents = "";
            try
            {
                contents = File.ReadAllText("Contraseña Usada.txt");
                contents += DateTime.Now +":\t  "+txtCodigo.Text;
                contents += System.Environment.NewLine;
                File.WriteAllText("Contraseña Usada.txt", contents, Encoding.Unicode);
            }
            catch
            {
                File.WriteAllText("Contraseña Usada.txt", contents, Encoding.Unicode);
            }
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            lblMensaje.Text = "";
            btnGenerar.Enabled = true;
            btnLimpiar.Enabled = false;
            btnCopiar.Enabled = false;
        }

        private void Copiar()
        {
            Clipboard.SetText(txtCodigo.Text);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Generar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }


    }
}
