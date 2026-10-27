
using MySql.Data.MySqlClient; //Para conectarse MySQL y hacer consultas SQL
using System;
using System.Collections.Generic; //Permite trabajar con colecciones de datos
using System.Drawing; //Para configurar el diseño de la interfaz (colores, fuentes...)
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Actividad_2__Interfaz_con_conexion_a_MySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //Se cargan los componentes

            CargarEmociones(); //Se ejecuta el método que permite cargar la base de datos con las emociones
        }

        // Método encargado de consultar y cargar las emociones en el ComboBox.
        private void CargarEmociones()
        {
            using (var conexion = new Conexion_BD().ObtenerConexion()) //Crea un objeto de conexión utilizando la clase "Conexión_BD"
            {
                conexion.Open(); //Abre la conexión a la BD

                string consulta = "SELECT id_emociones, nombre_emocion FROM tabla_emociones"; //Se hace una consulta SQL en la base de datos
                 
                using (var comando = new MySqlCommand(consulta, conexion)) // Crea el comando SQL que se ejecutará usando la conexión.
                using (var lector = comando.ExecuteReader()) 
                {
                    combo_emociones.Items.Clear(); //Elimina las emociones que ya este en el "ComboBox"

                    //Recorre cada linea devuelta en la consulta y agrega las emociones en el "ComboBox"
                    while (lector.Read())
                    {
                        combo_emociones.Items.Add(
                            new KeyValuePair<int, string>(
                                lector.GetInt32("id_emociones"),
                                lector.GetString("nombre_emocion")
                            )
                        );
                    }
                }
            }

            combo_emociones.DisplayMember = "Value"; //Nombre de la emoción
            combo_emociones.ValueMember = "Key"; //El valor de la emoción es igual a su identificador
        }


        //Método del bóton "buscar"
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //If para que muestre un mensaje de error si no se selecciona una emoción
            if (combo_emociones.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una emoción.");
                return;
            }
            // Obtiene el identificador de la emoción seleccionada.
            int id_emociones = ((KeyValuePair<int, string>)
                combo_emociones.SelectedItem).Key;

            // Limpiar las tarjetas anteriores
            flp_libros.Controls.Clear();

            //Try para ejecutar la búsqueda
            try
            {
                using (var conexion = new Conexion_BD().ObtenerConexion()) //Nuevo objeto para conexión a la BD
                {
                    conexion.Open();

                    string consulta = @"
                SELECT titulo_libro, autor_libro, descripción
                FROM tabla_libros
                WHERE id_emociones = @id_emociones";  //Consulta SQL para que devuelva el título del libro, el autor y la descripción 
                                                        //Según el id_emociones

                    using (var comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@id_emociones", id_emociones); //Asigna el id de la emoción seleccionada al parámetro de la consulta

                        //Ejecuta la consulta SQL utilizando la conexión
                        using (var adaptador = new MySqlDataAdapter(comando))
                        {
                            var tabla = new System.Data.DataTable(); // Crea una tabla para almacenar los resultados de la consulta
                            adaptador.Fill(tabla);

                            foreach (System.Data.DataRow fila in tabla.Rows) //Llena la tabla con los datos obtenidos en la consulta
                            {
                                MostrarTarjeta(
                                    fila["titulo_libro"].ToString(),
                                    fila["autor_libro"].ToString(),
                                    fila["descripción"].ToString()
                                );
                            }

                            
                        }
                    }
                }
            }
            catch (Exception ex) //Muestra un mensaje en caso de un error
            {
                MessageBox.Show(
                    "Error al buscar los libros: " + ex.Message);
            }
        }

        //Método para el estilo de formato de las tarjetas
        private void MostrarTarjeta(string titulo, string autor, string descripcion)
        {
            //Crea un panel para mostrar las tarjetas
            Panel tarjeta = new Panel();
            //Parámetros para estilizar el panel
            tarjeta.Width = 300;
            tarjeta.Height = 180;
            tarjeta.BackColor = Color.White;
            tarjeta.BorderStyle = BorderStyle.FixedSingle;
            tarjeta.Margin = new Padding(10);
            tarjeta.Padding = new Padding(12);

            //Crea una etiqueta para el nombre del libro
            Label lblLibro = new Label();
            //Parámetros para estilizar la etiqueta
            lblLibro.Text = titulo;
            lblLibro.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblLibro.ForeColor = Color.FromArgb(40, 76, 59);
            lblLibro.AutoSize = false;
            lblLibro.SetBounds(12, 10, 270, 35);

            // Crea una etiqueta para el autor 
            Label lblAutor = new Label();
            //Parámetros para estilizar la etiqueta
            lblAutor.Text = "Autor: " + autor;
            lblAutor.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            lblAutor.ForeColor = Color.FromArgb(82, 119, 92);
            lblAutor.SetBounds(12, 48, 270, 25);

            // Crea una etiqueta para la descripción
            Label lblDescripcion = new Label();
            //Parámetros para estilizar la etiqueta
            lblDescripcion.Text = descripcion;
            lblDescripcion.Font = new Font("Segoe UI", 9);
            lblDescripcion.ForeColor = Color.FromArgb(65, 65, 65);
            lblDescripcion.SetBounds(12, 78, 270, 85);

            tarjeta.Controls.Add(lblLibro); //Agrega el título a la tarjeta
            tarjeta.Controls.Add(lblAutor); //Agrega el autor a la tarjeta
            tarjeta.Controls.Add(lblDescripcion); //Agrega la descripción a la tarjeta

            flp_libros.Controls.Add(tarjeta); //Agrega la tarjeta al área donde se muestran los libros

            // Centrar la tarjeta si aparece sola en la fila
            int espacio = flp_libros.ClientSize.Width;
            int margenIzquierdo = Math.Max(10, (espacio - tarjeta.Width) / 2);

            tarjeta.Margin = new Padding(margenIzquierdo, 10, 10, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Centrar el título
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;

            // Centrar el selector de emociones
            combo_emociones.Left = (this.ClientSize.Width - combo_emociones.Width) / 2;

            // Centrar el botón Buscar
            btn_buscar.Left = (this.ClientSize.Width - btn_buscar.Width) / 2;

            label5.Left = (this.ClientSize.Width - label5.Width) / 2;
            label3.Left = (this.ClientSize.Width - label3.Width) / 2;

            // Centrar el área de las tarjetas
            panel_libros.Left = (this.ClientSize.Width - panel_libros.Width) / 2;
        }
    }
}
