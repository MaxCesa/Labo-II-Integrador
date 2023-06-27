using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLabo_Intento2.Forms
{
    public partial class frmDiceBox : Form
    {
        private static int CANTIDAD_DE_GIROS = 20;
        private int resultado;
        Random rnd;
        private bool started = false;
        public frmDiceBox(int resultado)
        {
            InitializeComponent();
            this.resultado = resultado;
            this.rnd = new Random();

        }

        private void RollDice(int resultado)
        {
            for (int giroActual = 0; giroActual < CANTIDAD_DE_GIROS; giroActual++)
            {
                var t = Task.Run(async delegate
                {
                    await Task.Delay(TimeSpan.FromSeconds(giroActual * 0.01f));
                    return rnd.Next(1, 21).ToString(); ;
                });
                t.Wait();

                this.lblDiceBox.Text = t.Result;

                this.Refresh();
            }

            this.lblDiceBox.Text = resultado.ToString();

            this.Refresh();

            var c = Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(2));
            });
            c.Wait();

            this.Close();
        }

        private void frmDiceBox_Paint(object sender, PaintEventArgs e)
        {
            if (!started)
            {
                started = true;
                this.RollDice(resultado);
            }

        }
    }
}