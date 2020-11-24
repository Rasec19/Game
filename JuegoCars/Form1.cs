using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using Graphics3DS;

namespace JuegoCars
{
    public partial class Pista : Form
    {
        public Pista()
        {
            InitializeComponent();
        }
        //creamos las variablres y objetos globales de la clase
        #region Variables y Objetos globales
        // variables necesarias para detectar el objeto a la hora de la colision
        int inflateX = 2;
        int inflateY = 2;
        //Variable tipo enum para detectar el estado del auto
        enum estadoActualAuto
        {
            izquierdo,
            derecho
        }
        //Objeto para dibujar dentro del pictureBox
        Graphics camino;
        //se defien los Thread para el auto, que iniciaran la movilizacion del mismo
        Thread th_objCar;
        // Se define listar para lamacenar los objetos "Circulo" y "Cubo"
        List<Circulo> ListaCircCar1;
        List<Cubo> ListaCuboCar1;
        //Definicion de colores: RGB
        Color obj1 = Color.PaleVioletRed;
        Color obj2 = Color.CadetBlue;
        //Se definen las enumeraciones para controlar el estado del auto
        estadoActualAuto edoActualCar1;
        //Posicion inicial del auto (aparece del lado izquierdo)
        const int posicionIinicialCar1_X = 52;
        int puntaje = 0;
        Carro car1;
        #endregion
        #region Metodos del juego
        // Metodos para establecer el inicio del juego
        private void IniciarJuego()
        {
            //inicializacion del puntuaje en 0
            puntaje = 0;
            //en la etiqueta puntos establezco el valor de la variable puntaje
            puntos.Text = puntaje.ToString();
            //Se crean las listas para inicializar los objetos circulos y cubos
            ListaCircCar1 = new List<Circulo>();
            ListaCuboCar1 = new List<Cubo>();
            //Se crea el auto en la posicion correspondiente
            car1 = new Carro(posicionIinicialCar1_X, obj1);
            //Establecer la posicion inicial del auto
            edoActualCar1 = estadoActualAuto.izquierdo;
            //Genero el primer objeto caroo
            GenerarObjetoCar1();
            //Inicializar el juego con los Timers
            timerCar1.Start();
            timerGenObjCar1.Start();
            //Se le asignan los metodos a los hilos
            th_objCar = new Thread(new ThreadStart(colisionCar1));
            //Se inicializan los hilos para detectar la colision del auto
            th_objCar.Start();
        }
        //Metodo "perdio" establece las operaciones que hace el juego cuando choca con un obstaculo
        public void perdio()
        {
            //Se detienen los timers
            timerCar1.Stop();
            timerGenObjCar1.Stop();
            MessageBox.Show("Tu juego ha terminado. Presiona R para comenzar de nuevo", "Tu juego se termino", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //Metodo que me va a detectar las colisiones con los cubos
        private void InflateCubo(Cubo cubo)
        {
            //Escalar la figura cuando detecte una colision
            for (int i = 0; i < 5; i++) //Timer = 5ms
            {
                // reduce la posicion de X
                cubo.X -= (inflateX * i);
                //aumenta el ancho del objeto
                cubo.inflateX = 2 * (inflateX * i);
                //reduce la posicion de Y
                cubo.Y -= (inflateY * i);
                cubo.inflateY = 2 * (inflateY * i);
                //hacemos pausa de 5ms
                Thread.Sleep(5);
            }
        }

        //Metodo que me va a detectar las colisiones con los curculos
        private void InflateCirculo(Circulo circulo)
        {
            //Escalar la figura cuando detecte una colision
            for (int i = 0; i < 5; i++) //Timer = 5ms
            {
                // reduce la posicion de X
                circulo.X -= (inflateX * i);
                //aumenta el ancho del objeto
                circulo.inflateX = 2 * (inflateX * i);
                //reduce la posicion de Y
                circulo.Y -= (inflateY * i);
                circulo.inflateY = 2 * (inflateY * i);
                //hacemos pausa de 5ms
                Thread.Sleep(5);
            }
        }
        //Metodo para generar los objwtos de la clase
        private void GenerarObjetoCar1() 
        {
            //Variabe random para que aparezcan los objetos circulo y cubo
            Random rnd = new Random();
            /*La aparicion de objetos es muy probable que se cargue hacia un lado por la posicion inicial determinada
             para solucionarlos utilizamos la variable rnd para ampliar el rango y decidir si el numero es par o es impar
            (Colocar a la derecha o izquierda)*/
            if (rnd.Next(2, 11) % 2 == 0) //se crea un circulo
            {
                if (rnd.Next(2, 10) % 2 == 0)//es par y aparece a la izq
                {
                    ListaCircCar1.Add(new Circulo(new Point3D(52, 0, 0), obj1));
                }
                else
                {   //Es impar y aparece a la derecha
                    ListaCircCar1.Add(new Circulo(new Point3D(177, 0, 0), obj2));
                }
            }
            else 
            {   //Se crea un cubo
                if (rnd.Next(21, 33) % 2 == 0)
                {
                    ListaCuboCar1.Add(new Cubo(new Point3D(52, 0, 0), obj1));
                }
                else 
                {
                    ListaCuboCar1.Add(new Cubo(new Point3D(177 , 0, 0), obj2));
                }
            }
        }
        //Metodo para detectar las colisiones
        private void colisionCar1() 
        {
            //Mientras haya colision
            while (true) 
            {
                #region detectar la colision del auto
                try
                {
                    //Se hace una pausa de 10 ms cuando se detecta la colision con el cubo
                    Thread.Sleep(10);
                    if (car1.x == ListaCuboCar1.ElementAt(0).X && ListaCuboCar1.ElementAt(0).Y >= 390 && ListaCuboCar1.ElementAt(0).Y <= 470)
                    {
                        //Colision con cubo = pierde
                        InflateCubo(ListaCuboCar1.ElementAt(0));
                        perdio();
                        //Se cancelan los hilos para volver a ejecutar si comienza el juego de nuevo
                        th_objCar.Abort();
                    } else if (ListaCuboCar1.ElementAt(0).Y > 475) {
                        ListaCuboCar1.RemoveAt(0);
                    }
                }
                catch (ArgumentOutOfRangeException) 
                {

                }
                #endregion
                #region detectar alimento "circulo"
                try
                {
                    if (car1.x == ListaCircCar1.ElementAt(0).X && ListaCircCar1.ElementAt(0).Y >= 390 && ListaCircCar1.ElementAt(0).Y <= 470)
                    {
                        //Collision circulo aumenta los puntos
                        InflateCirculo(ListaCircCar1.ElementAt(0));
                        ListaCircCar1.RemoveAt(0);
                        puntaje++;
                        
                    }
                    else if (ListaCircCar1.ElementAt(0).Y > 475)
                    {
                        //No colision con el circulo (pierde)
                        InflateCirculo(ListaCircCar1.ElementAt(0));
                        perdio();
                        th_objCar.Abort();
                    }
                }
                catch (ArgumentOutOfRangeException)
                {

                }
                #endregion
            }
        }

        private void Dibujar_Carretera(PaintEventArgs e) 
        {
            
            camino = e.Graphics;
            Graphics3D g3 = new Graphics3D(camino);
            camino.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pluma = new Pen(Color.Black, 4);
            //Lineas del 1 a 3
            g3.DrawLine3D(pluma, new Point3D(125,0,35), new Point3D(125, Carretera.Width, 35));
            g3.DrawLine3D(pluma, new Point3D(140, 0, 35), new Point3D(140, Carretera.Width, 35));
            g3.DrawLine3D(pluma, new Point3D(142, 0, 35), new Point3D(123, 0, 35));
            g3.DrawLine3D(pluma, new Point3D(142, 385, 35), new Point3D(123, 385, 35));
            //Imprime el puntaje en el label
            puntos.Text = puntaje.ToString();
        }
        #endregion
        private void Pista_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        private void Pista_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) 
            {
                case Keys.Space:
                    timerAnimationCar1.Start();
                    break;
                case Keys.R:
                    th_objCar.Abort();
                    IniciarJuego();
                    break;
                case Keys.Q:
                    th_objCar.Abort();
                    Application.Exit();
                    break;
            }
        }

        private void Carretera_Paint(object sender, PaintEventArgs e)
        {
            Dibujar_Carretera(e);
            car1.Dibujar(e);
            try
            {
                foreach (Circulo item in ListaCircCar1)
                {
                    item.Dibujar(e);
                }
                foreach (Cubo item in ListaCuboCar1)
                {
                    item.Dibujar(e);
                }
            }
            catch (InvalidOperationException) 
            {

            }
        }

        private void timerCar1_Tick(object sender, EventArgs e)
        {
            foreach (Circulo item in ListaCircCar1)
            {
                item.Y += 6;
            }
            foreach (Cubo item in ListaCuboCar1)
            {
                item.Y += 6;
            }
            Carretera.Refresh();
        }

        private void timerAnimationCar1_Tick(object sender, EventArgs e)
        {
            switch (edoActualCar1) 
            {
                case estadoActualAuto.izquierdo:
                    if (car1.x < posicionIinicialCar1_X + 125)
                    {
                        car1.x += 9;
                    }
                    else 
                    {
                        edoActualCar1 = estadoActualAuto.derecho;
                        car1.x = posicionIinicialCar1_X + 125;
                        timerAnimationCar1.Stop();
                    }
                    break;
                case estadoActualAuto.derecho:
                    if (car1.x < posicionIinicialCar1_X)
                    {
                        car1.x += 9;
                    }
                    else
                    {
                        edoActualCar1 = estadoActualAuto.izquierdo;
                        car1.x = posicionIinicialCar1_X;
                        timerAnimationCar1.Stop();
                    }
                    Carretera.Refresh();
                    break;
            }
        }

        private void timerGenObjCar1_Tick(object sender, EventArgs e)
        {
            GenerarObjetoCar1();
        }
        
    }
}
