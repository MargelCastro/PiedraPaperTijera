using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JUEGO_piedra_papel_tijera
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        String[] gameItem = { "Piedra", "Papel", "Tijera" };
        int JugadorResult = 0;
        int cpResult = 0;
        string Jugador;
        string computer;
       
        public void computerChoice()
        {
            Random rnd = new Random();
            int RandomNr = rnd.Next(0,3);

            computer = gameItem[RandomNr];
            if (computer == "Piedra") picComputer.Image = picPiedra.Image;
            else if (computer == "Papel") picComputer.Image = picPapel.Image;
            else picComputer.Image = picTijera.Image;
        }         
        private void Jugador_click(object sender, EventArgs e)
        {
            if ( sender == picPiedra)
            {
                Jugador = "Piedra";
                picJugador.Image = picPiedra.Image;
            }
            else if (sender == picPapel)
            {
                Jugador = "Papel";
                picJugador.Image = picPapel.Image;
            }
            else 
            {
                Jugador = "Tijera";
                picJugador.Image = picTijera.Image;
            }
            computerChoice();
            checkResult();
        }

        public void checkResult()
        {
            if (Jugador == "Papel")
            {
                if (computer == "Piedra")
                {
                    JugadorResult++;
                   // lblResult.Text = ": " + JugadorResult.ToString();
                    MessageBox.Show("TU HAS GANADO");
                }
                else if (computer == "Tijera")
                {
                    cpResult++;
                    //lblComputerResult.Text = ": " + cpResult.ToString();
                MessageBox.Show("LA COMPUTADORA HA GANADO");
                }
            }

            else if (Jugador == "Piedra")
            {
                if (computer == "Tijera")
                {
                    JugadorResult++;
                    //lblResult.Text = ": " + JugadorResult.ToString();
                    MessageBox.Show("TU HAS GANADO");
                }
                else if (computer == "Papel")
                {
                    cpResult++;
                    //lblComputerResult.Text = " " + cpResult.ToString();
                    MessageBox.Show("LA COMPUTADORA HA GANADO");
                }
            }

            else if(Jugador == "Tijera")
            {
                if (computer == "Papel")
                {
                    JugadorResult++;
                    //lblResult.Text = ": " + JugadorResult.ToString();
                    MessageBox.Show("TU HAS GANADO");
                }
                else if (computer == "Piedra")
                {
                    cpResult++;
                    //lblComputerResult.Text = " " + cpResult.ToString();
                    MessageBox.Show("LA COMPUTADORA HA GANADO");
                }
            }
            if (Jugador == computer)
            { MessageBox.Show("Estan EMPATADOS"); }
        }
        private void RandomNr_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int RandomNr = rnd.Next(0, 3);

            computer = gameItem[RandomNr];
            if (computer == "Piedra") picComputer.Image = picPiedra.Image;
            else if (computer == "Papel") picComputer.Image = picPapel.Image;
            else picComputer.Image = picTijera.Image;                               
        }
        private void button1_Click(object sender, EventArgs e)
        {
            picJugador.Image = null;
            picComputer.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lblComputerResult_Click(object sender, EventArgs e)
        {

        }

        private void picPiedra_Click(object sender, EventArgs e)
        {

        }

        private void picJugador_Click(object sender, EventArgs e)
        {

        }       
    }
}
