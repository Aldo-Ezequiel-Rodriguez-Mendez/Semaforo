using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form1 : Form
    {
        int evento = 1;
        int contadorOff = 0;//Cuenta el parpadeo del semáforo
        int swDisplay = 0; //Lleva el control del display en forma default
        int swDisplayCont = 0; // Lleva el control del display cuando se establecen los tiempos
        bool swParpadeo = false;// Controla en el display el parpadeo del semáforo
        bool cicloVertical =true;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCargarIntermitentes_Click(object sender, EventArgs e)
        {
            tmrIntermitentes.Start();
            btnDetener.Enabled = true;
        }

        //Timer que controla los semáforos
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            switch(evento)
            {
                case 1:if (cicloVertical){ OnVerdeV(); OnRojoH(); } else { OnVerdeH(); OnRojoV(); }// Evento #1  Verde
                    timer1.Interval = (tiempoVerde-500); evento = 2;break;                
                case 2: if (cicloVertical) { OffV(); } else { OffH(); };            // Evento #2
                    timer1.Interval = 500;                                              //  |
                    if (contadorOff== tiempoVerdePrp / 1000)                                                 //  |Parpadeo
                    {                                                                   //  |del
                        timer1.Interval = 500; evento = 4; contadorOff = 0;             //  |semáforo
                    }                                                                   //  |en
                    else { evento = 3; }                                                //  |color  
                    break;                                                              //  |verde
                case 3: if (cicloVertical) { OnVerdeV(); } else { OnVerdeH(); }         //  |
                        timer1.Interval = 500; contadorOff++; evento = 2;break;      //Evento #2                                    //  Evento #2
                case 4: if (cicloVertical) { OnAmarilloV(); } else { OnAmarilloH(); }//Evento #3 Amarillo
                    timer1.Interval = (tiempoAmarillo-500); evento = 5;break;
                case 5: if (cicloVertical) { OffV(); } else { OffH(); }             //Evento #3 Amarillo apagado
                    timer1.Interval = 500; evento = 6;break;
                case 6: if (cicloVertical) { OnRojoV(); } else { OnRojoH(); }        // Evento #4 Rojo
                    timer1.Interval = (tiempoRojo-500); evento = 7; break;                      
                case 7: if (cicloVertical) { cicloVertical = false; OffH(); } else { cicloVertical = true; OffV(); }
                    //  
                    evento = 1;
                    timer1.Interval = 500; break;
            }
        }

        //Timer que controla el conteo del Display
        private void tmrDisplay_Tick(object sender, EventArgs e)
        {
            tmrDisplay.Interval = 1000;
            switch (swDisplayCont)
            {
                case 1: lblVerde9.Text = contarTiempos.ToString();
                    lblVerde9.ForeColor = Color.Green; lblVerde10.ForeColor = Color.Green;
                    if (contarTiempos == (tiempoVerde/1000)+1)
                       { 
                        swDisplayCont=2; contarTiempos = 1;
                        lblVerde9.Text = contarTiempos.ToString();
                        contarTiempos++;
                    }
                    else { contarTiempos++; }
                    break;
                case 2:
                    lblVerde9.Text = contarTiempos.ToString();
                    if (contarTiempos==(tiempoVerdePrp/1000)+1)
                    { 
                        swDisplayCont = 3;
                        contarTiempos = 1;
                        lblVerde9.Text = "0";
                        lblAmarillo.ForeColor = Color.FromArgb(241, 236, 37);
                        lblAmarillo.Text = contarTiempos.ToString();
                        contarTiempos++;
                    }
                    else { contarTiempos++; }                    
                    break;
                case 3:
                    lblAmarillo.Text = contarTiempos.ToString();
                    if (contarTiempos == (tiempoAmarillo/1000)+1)
                    { 
                        swDisplayCont = 4; contarTiempos = 1; 
                        lblAmarillo.Text = "0";
                        lblRojo.ForeColor = Color.FromArgb(136, 5, 6);
                        lblRojo.Text = contarTiempos.ToString();
                        contarTiempos++;
                    }
                    else { contarTiempos++; }                    
                    break;
                case 4:
                    lblRojo.Text = contarTiempos.ToString();
                    if (contarTiempos == (tiempoRojo/1000)+1)
                    { swDisplayCont = 1; contarTiempos = 1; lblRojo.Text = "0"; ApagarDisplays();
                      tmrDisplay.Interval = 1;
                    }
                    else { contarTiempos++; }                    
                    break;
                case 5:
                    {

                        break;
                    }
            }
        }

        #region Métodos para cambiar imágenes

            #region Sémaforos Verticales
        public void OnVerdeV() // Enciende los semáforos verdes verticales
        {
            pcbVLeft.Image = Properties.Resources.SMVLeftVe;
            pcbVRight.Image = Properties.Resources.SMVRightVe;
        }
        public void OnAmarilloV() // Enciende los semáforos amarillos verticales
        {
            pcbVLeft.Image = Properties.Resources.SMVLeftAm;
            pcbVRight.Image = Properties.Resources.SMVRightAm;
        }
        public void OnRojoV() // Enciende los semáforos rojos verticales
        {
            pcbVLeft.Image = Properties.Resources.SMVLeftRo;
            pcbVRight.Image = Properties.Resources.SMVRightRo;
        }
        public void OffV() // Apaga los semáforos verdes verticales
        {
            pcbVLeft.Image = Properties.Resources.SMVLeftOf;
            pcbVRight.Image = Properties.Resources.SMVRighOft;
        }
        #endregion

        void OnAllAmarrillos()//Enciende todos los amarillos
        {
            pcbHLeft.Image = Properties.Resources.SMHLeftAm1;
            pcbHRight.Image = Properties.Resources.SMHRightAm1;
            System.Threading.Thread.Sleep(200);
            pcbVLeft.Image = Properties.Resources.SMVLeftAm;
            pcbVRight.Image = Properties.Resources.SMVRightAm;
            System.Threading.Thread.Sleep(200);
        }
        void OffAll()//Apaga todos los semaforos 
        {
            pcbHLeft.Image = Properties.Resources.SMHLeftOf1;
            pcbHRight.Image = Properties.Resources.SMHRightOf1;
            System.Threading.Thread.Sleep(200);
            pcbVLeft.Image = Properties.Resources.SMVLeftOf;
            pcbVRight.Image = Properties.Resources.SMVRighOft;
            System.Threading.Thread.Sleep(200);
        }
            #region Semáforos Horizontales        
        public void OnVerdeH() // Enciende los semáforos verdes horizontales
        {
            pcbHLeft.Image = Properties.Resources.SMHLeftVe1;
            pcbHRight.Image = Properties.Resources.SMHRightVe2;
        }
        public void OnAmarilloH() // Enciende los semáforos amarillos horizontales
        {
            pcbHLeft.Image = Properties.Resources.SMHLeftAm1;
            pcbHRight.Image = Properties.Resources.SMHRightAm1;
        }
        public void OnRojoH() // Enciende los semáforos rojos horizontales
        {
            pcbHLeft.Image = Properties.Resources.SMHLeftRo1;
            pcbHRight.Image = Properties.Resources.SMHRightRo1;
        }
        public void OffH() // Apaga los semáforos verdes horizontales
        {
            pcbHLeft.Image = Properties.Resources.SMHLeftOf1;
            pcbHRight.Image = Properties.Resources.SMHRightOf1;
        }
            #endregion

        #endregion

        #region Panel de Control
     
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tiempoVerde = 15000;
            tiempoVerdePrp = 3000;
            tiempoAmarillo = 3000;
            tiempoRojo = 2000;
            Iniciar();
        }
    
        private void btnDetener_Click(object sender, EventArgs e)
        {
            Detener();
        }

        public void Iniciar()
        {
            swDisplayCont++;
            contarTiempos = 1;
            timer1.Start();
            tmrDisplay.Start();            
            tmrDisplay.Interval = 1;
            btnDetener.Enabled = true;
            btnIniciar.Enabled = false;
            btnCambioTiempo.Enabled = false;
        }
        public void ApagarDisplays()
        {
            lblVerde9.Text = "0"; lblVerde9.ForeColor = Color.DimGray;
            lblVerde10.Text = "0"; lblVerde10.ForeColor = Color.DimGray;
            lblAmarillo.Text = "0"; lblAmarillo.ForeColor = Color.DimGray;
            lblRojo.Text = "0"; lblRojo.ForeColor = Color.DimGray;
        }
        public void Detener()
        {
            timer1.Stop(); tmrDisplay.Stop();
            OffV(); OffH();
            ApagarDisplays();
            tmrIntermitentes.Stop();
            timer1.Interval = 10;
            evento = 1; // Control para el semáforo
            swDisplay = 0;//Control para el display 
            contadorOff = 0;//Contador para el display en los parpadeos del semáforo
            cicloVertical = true; // Comienza con los semáforos verticales
            swParpadeo = false;
            btnIniciar.Enabled = true;
            btnCambioTiempo.Enabled = true;
            btnDetener.Enabled = false;
            swDisplayCont = 0;
            contarTiempos = 0; total = 0;
            tiempoRojo = 0; tiempoAmarillo = 0; tiempoVerde = 0; tiempoVerdePrp = 0;
        }

        int tiempoRojo=0, tiempoAmarillo=0, tiempoVerde=0, tiempoVerdePrp=0;
        int total = 0;
        //int cambiarTiempos = 0;
        int contarTiempos = 0;

        bool bolIntermitentePrendida = false;
        private void tmrIntermitentes_Tick(object sender, EventArgs e)
        {
            if (bolIntermitentePrendida)
            {
                OffAll();
                ApagarDisplays();
                bolIntermitentePrendida = false;
            }
            else
            {
                OnAllAmarrillos();
                lblAmarillo.ForeColor = Color.FromArgb(241, 236, 37);
                lblAmarillo.Text = "0";
                bolIntermitentePrendida = true;
            }
        }

        private void lblControl_Click(object sender, EventArgs e)
        {

        }

        public void CambiarTiempos()
        {
            swDisplayCont=1;
            contarTiempos = 1;
            lblVerde9.Text = contarTiempos.ToString();
            tiempoRojo = int.Parse(txtRojo.Text)*1000;
            tiempoAmarillo = int.Parse(txtAmarilo.Text)*1000;
            tiempoVerde = int.Parse(txtVerde.Text)*1000;
            tiempoVerdePrp = int.Parse(txtVerdePrp.Text)*1000;
            total = (tiempoRojo + tiempoAmarillo + tiempoVerde + tiempoVerdePrp) / 1000;
            tmrDisplay.Interval = 1;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCambioTiempo_Click(object sender, EventArgs e)
        {
            CambiarTiempos();
            tmrDisplay.Start();
            timer1.Start();
            btnDetener.Enabled = true;
            btnIniciar.Enabled = false;
            btnCambioTiempo.Enabled = false;
        }
    }
}
