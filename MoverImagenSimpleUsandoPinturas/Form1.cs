// Espacio de nombres como nombre del proyecto a crear.

namespace MoverImagenSimpleUsandoPinturas
{
    // Clase completa de la interfaz.
    public partial class Form1 : Form
    {
        // Variables a declarar.

        Image carta; // Carta de un mazo como imagen.
        Point posicion = new Point(200, 200); // Posici�n en donde se encuentra la carta dibujada.
        bool arrastrar; // Verifica si se arrastra una carta o no.
        Rectangle rectangulo; // Rect�ngulo como para dibujar una carta.
        int altura = 200, ancho = 100; // Altura y ancho de la carta respectivamente, que se calcula de la siguiente manera: 200 * 100.

        // Creado por MARSFOREVER472.
        // Solamente para objetivos educacionales.

        // Clase de la interfaz.
        public Form1()
        {
            InitializeComponent(); // M�todo inicial.
        }

        // M�todo para apretar el bot�n del mouse.

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            // EN INSTANTES...
        }

        // M�todo para mover el mouse en distintas direcciones.

        private void FormMouseMove(object sender, MouseEventArgs e)
        {
            // EN INSTANTES...
        }

        // M�todo para soltar el bot�n del mouse.

        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            // EN INSTANTES...
        }

        // M�todo para ilustrar im�genes mediante eventos.

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            // EN INSTANTES...
        }

        // M�todo para el temporizador mediante eventos.

        private void FormTimerEvent(object sender, EventArgs e)
        {
            // EN INSTANTES...
        }
    }
}