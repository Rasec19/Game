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
    class Cubo : Form
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
        public Cubo(Point3D ubicacion, Color RGB)
        {
            X = ubicacion.X;//Tomamos la ubicacion actual en el eje X
            Y = ubicacion.Y;//Tomamos la ubicacion actual en el eje Y
            Z = ubicacion.Z;
            this.RGB = RGB;// pinta el cubo del color especificado
        }
        Point3D[] puntos = new Point3D[8];
        public void Dibujar(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Graphics3D g3 = new Graphics3D(g);
            //Aplico el efecto de "burbuja" y mejorar la calidad de la img
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //creo un objeto para dibujar contorno del cubo
            Pen contorno = new Pen(RGB, 4);
            //Creamos una brocha para rellenar el cubo
            Brush relleno = new SolidBrush(RGB);
            // Dibujar el controno del cubo (obstaculo que chocara con el auto)
            g.DrawRectangle(contorno, X, Y, 27+inflateX, 27+inflateY);
            
            puntos[0] = new Point3D(X, Y, Z + 10);
            puntos[1] = new Point3D(X, Y, Z + 10);
            puntos[2] = new Point3D(X, Y, Z);
            puntos[3] = new Point3D(X, Y, Z);
            puntos[4] = new Point3D(X, Y, Z);
            puntos[5] = new Point3D(X, Y, Z);
            puntos[6] = new Point3D(X, Y, Z);
            puntos[7] = new Point3D(X, Y, Z);
            g3.DrawPolygon(contorno, puntos);

           /* g3.DrawLine3D(contorno, puntos[0], puntos[1]);
            g3.DrawLine3D(contorno, puntos[1], puntos[2]);
            g3.DrawLine3D(contorno, puntos[2], puntos[3]);
            g3.DrawLine3D(contorno, puntos[3], puntos[0]);
            g3.DrawLine3D(contorno, puntos[4], puntos[5]);
            g3.DrawLine3D(contorno, puntos[5], puntos[6]);
            g3.DrawLine3D(contorno, puntos[6], puntos[7]);
            g3.DrawLine3D(contorno, puntos[7], puntos[4]);
            g3.DrawLine3D(contorno, puntos[0], puntos[4]);
            g3.DrawLine3D(contorno, puntos[1], puntos[5]);
            g3.DrawLine3D(contorno, puntos[2], puntos[6]);
            g3.DrawLine3D(contorno, puntos[3], puntos[7]);*/
            //Dibujar el relleno del cubo
            g.FillRectangle(Brushes.White, X + 2, Y + 2, 23 + inflateX, 23 + inflateY);
            //dibujar el cubo pequeño dentro del cubo
            g.FillRectangle(relleno, X + 6, Y + 6, 15 + inflateX, 15 + inflateY);
        }

        
    }
}
