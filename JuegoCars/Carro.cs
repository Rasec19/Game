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
    class Carro
    {
        // variable para saber en que posisicion de la "carretera" esta el carro
        public int x { get; set; }
        Color RGB; //Para pintar el auto del color que deseemos
        //Metodo constructor con los parametros de posicion y color del carro
        public Carro(int x, Color RGB) 
        {
            this.x = x;
            this.RGB = RGB;
        }
        //Metodo para dibujar el auto en la carretera (lado izquierdo, derecho, ventana superior, inferior, etc)
        public void Dibujar(PaintEventArgs e) 
        {
            Graphics g = e.Graphics;
            Graphics3D g3 = new Graphics3D(g);
            // Definir la calidad y textura de la imagen
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            #region estructura de los puntos del auto (en donde voy a dibujar el form)
            Point[] auto =
            {
                //Cuando este del lado izquiero de la carretera
                new Point(x,425),
                new Point(x-3,441),
                new Point(x-3,454),
                new Point(x,470),
                // Cundo este en la parte inferior de la carretera
                new Point(x+8,473),
                new Point(x+16,473),
                new Point(x,470),
                //Cuando el auto este en la parte derecha
                new Point(x+27,454),
                new Point(x+27,441),
                new Point(x+24,470),
                //Cuando el auto este en la parte superior de la carretera
                new Point(x+16,422),
                new Point(x+6,422),
                new Point(x,425),
            };
            //Puntos para dibujar el techo del auto de manera "curva"
            Point[] ventSuperior = 
            {
                //puntos para curva superior
                new Point(x+4,433),
                new Point(x+21,433),
                new Point(x+19,440),
                new Point(x+6,440),
            };
            //puntos para dibujar la parte inferior del carro
            Point[] ventInferior = 
            {
                new Point(x+4,463),
                new Point(x+21,463),
                new Point(x+19,453),
                new Point(x+6,453),
            };
            Rectangle techo = new Rectangle(x + 6, 440, 13, 16);
            #endregion
            #region colores
            Pen pluma = new Pen(RGB,4);
            Brush tech = new SolidBrush(RGB);
            Brush paraBrisas = new SolidBrush(Color.Black);
            #endregion
            #region dibuja figuras
            g.FillClosedCurve(Brushes.White, auto);
            //contorno del auto
            g.DrawClosedCurve(pluma, auto);
            //relleno el techo del auto
            g.FillRectangle(tech, techo);
            //rellenar para brisas frontal
            g.FillPolygon(Brushes.Black, ventSuperior);
            //rellenar para brisas trasero
            g.FillPolygon(paraBrisas,ventInferior);
            #endregion
        }
    }
}
