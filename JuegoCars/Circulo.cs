using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Graphics3DS;

namespace JuegoCars
{
    class Circulo
    {
        //variables globales
        // X y Y ---saber coordenadas donde se encuntran los circulos
        //Inflate X y Y ---aumentar el tamaño de las figuras para que se muestren "activas"
        //color del circulo
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int inflateX = 0;
        public int inflateY = 0;
        Color RGB;
        //Metodo contructor de la clase
        public Circulo(Point3D ubicacion, Color RGB)
        {
            X = ubicacion.X;//Tomamos la ubicacion actual en el eje X
            Y = ubicacion.Y;//Tomamos la ubicacion actual en el eje Y
            Z = ubicacion.Z;
            this.RGB = RGB;// pinta el circulo del color especificado
        }
        Point3D[] puntos = new Point3D[4];
        public void Dibujar(PaintEventArgs e) 
        {
            Graphics g = e.Graphics;
            Graphics3D g3 = new Graphics3D(g);
            //Aplico el efecto de "burbuja" y mejorar la calidad de la img
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //creo un objeto para dibujar contorno del circulo
            Pen contorno = new Pen(RGB,4);
            //Creamos una brocha para rellenar el circulo
            Brush relleno = new SolidBrush(RGB);
            //Dibujo el circulo que sera alimento del auto
            //g.DrawEllipse(contorno, X, Y, 27+inflateX, 27+inflateY);

            /*puntos[0] = new Point3D(X + 10, Y, Z);
            puntos[1] = new Point3D(X + 20, Y+ -10, Z);
            puntos[2] = new Point3D(X - 20, Y + 10, Z);
            puntos[3] = new Point3D(X - 10, Y, Z);*/
            g3.DrawBezier3D(contorno, new Point3D(X+15,Y+30,Z+10), new Point3D(X+95,Y-10,Z), new Point3D(X-75,Y-20,Z), new Point3D(X+15,Y+30,Z+10));
            //circulo relleno dentro del circulo "grande"
            g.FillEllipse(relleno, X+6, Y+6, 15 + inflateX, 15 + inflateY);
        }
    }
}
