// Espacio de nombres como nombre del proyecto a crear.

namespace MoverImagenSimpleUsandoPinturas
{
    // Clase completa de la interfaz.
    public partial class Form1 : Form
    {
        // Variables a declarar.

        Image carta; // Carta de un mazo como imagen.
        Point posicion = new Point(200, 200); // Posición en donde se encuentra la carta dibujada.
        bool arrastrar; // Verifica si se arrastra una carta o no.
        Rectangle rectangulo; // Rectángulo como para dibujar una carta.
        int altura = 200, ancho = 135; // Altura y ancho de la carta respectivamente, que se calcula de la siguiente manera: 200 * 100.

        // Creado por MARSFOREVER472.
        // Solamente para objetivos educacionales.

        // Clase de la interfaz.
        public Form1()
        {
            InitializeComponent(); // Método inicial.

            carta = Image.FromFile("card.png"); // Carta normal.
            // carta = Image.FromFile("guts.jpg"); // Carta especial, que será con comentario hasta ahora, debido a que solamente utilizaremos en la interfaz 1 carta a la vez.
            rectangulo = new Rectangle(posicion.X, posicion.Y, ancho, altura); // Rectángulo dividido en 4 dimensiones.
        }

        // Método para apretar el botón del mouse.

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            Point posicionMouse = new Point(e.X, e.Y); // Posición en donde se encuentra el mouse al presionar el botón.

            // Vamos a declarar mediante un "if" sobre cómo se va arrastrando la carta al presionar el botón del mouse.

            if (rectangulo.Contains(posicionMouse))
            {
                arrastrar = true; // Se va a arrastrar la carta.
                txtDragOrDrop.Text = "Arrastrando la imagen.";
            }
        }

        // Método para mover el mouse en distintas direcciones.

        private void FormMouseMove(object sender, MouseEventArgs e)
        {
            // Lo vamos a probar ahora con un algoritmo básico al mover el mouse por ahora.

            if (arrastrar) // Si se está arrastrando la carta.
            {
                posicion = e.Location; // Se va posicionando a medida que arrastre una carta mientras se mueve el mouse.
            }
        }

        // Método para soltar el botón del mouse.

        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            // Haremos el mismo procedimiento pero soltando el botón del mouse.

            if (arrastrar)
            {
                arrastrar = false; // Al soltar el botón, la carta dejará de arrastrar y lo suelta.
                rectangulo.Location = new Point(e.X, e.Y); // Ubicación del rectángulo al soltar la carta.
                txtDragOrDrop.Text = "Imagen soltada @ " + rectangulo.Location.ToString(); // Mediante texto con la misma variable se va grabando de distinta forma al soltar la carta.
            }
        }

        // Método para ilustrar imágenes mediante eventos.

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            // Para comenzar debemos elegir un tipo de lápiz para dibujar la carta.

            Pen outline; // Tipo de lápiz para dibujar el borde de la carta.

            // Cuando arrastra una carta, el borde de ella será naranja.

            if (arrastrar)
            {
                outline = new Pen(Color.Orange, 6); // Para hacer el borde naranja de la carta ya arrastrada.
            }
            else // En caso contrario cuando suelta la carta, el borde de ella será dorada.
            {
                outline = new Pen(Color.Gold, 6);
            }

            e.Graphics.DrawRectangle(outline, rectangulo); // Características al dibujar un rectángulo.
            e.Graphics.DrawImage(carta, posicion.X, posicion.Y, ancho, altura); // Características de la carta a dibujar.
        }

        // Método para el temporizador mediante eventos.

        private void FormTimerEvent(object sender, EventArgs e)
        {
            // Se fijarán las posiciones del rectángulo en X e Y.

            rectangulo.X = posicion.X; // Distancia en X.
            rectangulo.Y = posicion.Y; // Distancia en Y.

            this.Invalidate(); // Esto sería infinito :/ ... 
        }
    }
}