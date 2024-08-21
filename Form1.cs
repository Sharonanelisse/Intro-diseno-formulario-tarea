using RegistroContactosApp.Clases;
using System.Diagnostics.Contracts;

namespace RegistroContactosApp
{
    public partial class RegistroContactosApp : Form
    {
        List<Datos> Datos = new List<Datos>();
        public RegistroContactosApp()
        {
            InitializeComponent();
        }

        private void RegistroContactosApp_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(TextBoxTelefono.Text) ||
                 string.IsNullOrWhiteSpace(TextBoxEmail.Text))
            {
                LabelEstado.Text = "Por favor, complete todos los campos.";
                return;
            }
            Datos nuevoDato = new Datos(TextBoxNombre.Text, TextBoxTelefono.Text, TextBoxEmail.Text);
            ListBoxContactos.Items.Add(nuevoDato);

            LabelEstado.Text = "Contacto agregado exitosamente.";

        }



        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            TextBoxNombre.Clear();
            TextBoxTelefono.Clear();
            TextBoxEmail.Clear();

            LabelEstado.Text = string.Empty;
        }

    }
}

