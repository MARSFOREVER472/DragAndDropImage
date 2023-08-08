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

            carta = Image.FromFile("card.png"); // Carta normal.
            // carta = Image.FromFile("guts.jpg"); // Carta especial, que ser� con comentario hasta ahora, debido a que solamente utilizaremos en la interfaz 1 carta a la vez.
            rectangulo = new Rectangle(posicion.X, posicion.Y, ancho, altura); // Rect�ngulo dividido en 4 dimensiones.
        }

        // M�todo para apretar el bot�n del mouse.

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            Point posicionMouse = new Point(e.X, e.Y); // Posici�n en donde se encuentra el mouse al presionar el bot�n.

            // Vamos a declarar mediante un "if" sobre c�mo se va arrastrando la carta al presionar el bot�n del mouse.

            if (rectangulo.Contains(posicionMouse))
            {
                arrastrar = true; // Se va a arrastrar la carta.
                txtDragOrDrop.Text = "Arrastrando la imagen.";
            }
        }

        // M�todo para mover el mouse en distintas direcciones.

        private void FormMouseMove(object sender, MouseEventArgs e)
        {
            // Lo vamos a probar ahora con un algoritmo b�sico al mover el mouse por ahora.

            if (arrastrar) // Si se est� arrastrando la carta.
            {
                posicion = e.Location; // Se va posicionando a medida que arrastre una carta mientras se mueve el mouse.
            }
        }

        // M�todo para soltar el bot�n del mouse.

        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            // Haremos el mismo procedimiento pero soltando el bot�n del mouse.

            if (arrastrar)
            {
                arrastrar = false; // Al soltar el bot�n, la carta dejar� de arrastrar y lo suelta.
                rectangulo.Location = new Point(e.X, e.Y); // Ubicaci�n del rect�ngulo al soltar la carta.
                txtDragOrDrop.Text = "Imagen soltada @ " + rectangulo.Location.ToString(); // Mediante texto con la misma variable se va grabando de distinta forma al soltar la carta.
            }
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