using System.Text.Json;
using System.Text;
using Clase2.Entidad;

namespace Clase2
{
    public partial class frmResultados : Form
    {
        public frmResultados()
        {
            InitializeComponent();
            LimpiarControles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            resultado.fecha = dtpFechaResultados.Value.ToString("dd/MM/yyyy");
            resultado.nombre = txtLocal.Text;
            resultado.pais = cboGolesLocal.SelectedItem.ToString();

            EnviarResultadosAAPI(resultado);
            LimpiarControles();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvResultados.Rows.Clear();
            ObtenerResultadosDeAPI();
        }

        private void CargarGrillaResultados(Resultado resultado)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvResultados);
            row.Cells[0].Value = resultado.fecha;
            row.Cells[1].Value = resultado.nombre;
            row.Cells[2].Value = resultado.pais;

            dgvResultados.Rows.Add(row);

        }

        private void LimpiarControles()
        {
            txtLocal.Text = "";
            cboGolesLocal.SelectedIndex = 0;
        }

        private async Task EnviarResultadosAAPI(Resultado resultado)
        {
            var jsonContento = JsonSerializer.Serialize(resultado);
            var content = new StringContent(jsonContento, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7120/api/");
                var response = await client.PostAsync("resultados", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Resultado registrado en la API.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el resultado en la API.");
                }
            }
        }

        private async Task ObtenerResultadosDeAPI()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7120/api/");
                var response = await client.GetAsync("resultados");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var resultados = JsonSerializer.Deserialize<List<Resultado>>(jsonResponse);
                    foreach (var resultado in resultados)
                    {
                        CargarGrillaResultados(resultado);
                    }
                }
                else
                {
                    MessageBox.Show("Error al obtener los resultados de la API.");
                }
            }

        }


    }
}