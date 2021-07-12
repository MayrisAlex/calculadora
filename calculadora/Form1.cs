using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {

        double pri;
        double seg;
      
        string operacionb=string.Empty;

        // public string numeros = string.Empty;


        public Form1()
        {
            InitializeComponent();
        }

        Clases.clasuma resultado1 = new Clases.clasuma();

        Clases.claresta resultado2 = new Clases.claresta();

        Clases.clamultiplicacion resultado3 = new Clases.clamultiplicacion();

        Clases.cladivision resultado4 = new Clases.cladivision();

        Clases.clapotencia resultado5 = new Clases.clapotencia();
        Clases.raiz resultado6 = new Clases.raiz();
        Clases.claporcentaje resultado7 = new Clases.claporcentaje();
        Clases.clapotencia resultado8 = new Clases.clapotencia();


        private void button1_Click(object sender, EventArgs e)
        {
            txtingreso.Text = txtingreso.Text + "1";
            txtvisual.Text = txtvisual.Text + "1";
        
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtingreso.Text = txtingreso.Text + "2";
            txtvisual.Text = txtvisual.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            txtingreso.Text = txtingreso.Text + "3";
            txtvisual.Text = txtvisual.Text + "3";


        }

        private void button4_Click(object sender, EventArgs e)
        {

            txtingreso.Text = txtingreso.Text + "4";
            txtvisual.Text = txtvisual.Text + "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtingreso.Text = txtingreso.Text + "5";
            txtvisual.Text = txtvisual.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {

            txtingreso.Text = txtingreso.Text + "6";
            txtvisual.Text = txtvisual.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {

            txtingreso.Text = txtingreso.Text + "7";
            txtvisual.Text = txtvisual.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {

            txtingreso.Text = txtingreso.Text + "8";
            txtvisual.Text = txtvisual.Text + "8";

        }
        private void button9_Click(object sender, EventArgs e)
        {

            txtingreso.Text = txtingreso.Text + "9";
            txtvisual.Text = txtvisual.Text + "9";

        }
        private void button0_Click(object sender, EventArgs e)
        {

            txtingreso.Text = txtingreso.Text + "0";
            txtvisual.Text = txtvisual.Text + "0";

        }
        private void btnpunto_Click(object sender, EventArgs e)
        {
            txtingreso.Text=txtingreso.Text + ",";
            txtvisual.Text = txtvisual.Text + ",";

            btnpunto.Enabled = false;
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            txtvisual.Text = txtvisual.Text + "+";
            operacionb = "+";
            pri = double.Parse(txtingreso.Text); 
            txtingreso.Clear();
            btnsuma.Enabled = false;
            btnpunto.Enabled = true;


        }



        private void btnigual_Click(object sender, EventArgs e)
        {
            seg = double.Parse(txtingreso.Text);

            double Sum;
            double Rest;
            double Multi;
            double Divi;
            double Pote;
            double Rai;
            double Por;
            double Pot;


                switch (operacionb)
            {
                case "+":
                    
                    Sum = resultado1.sumar((pri), (seg));
                    txtingreso.Text = Sum.ToString();
                    txtvisual.Text = "";
                    txtvisual.Text = Sum.ToString();
               
                    break;
                    

                case "-":
                    
                        Rest = resultado2.restar((pri), (seg));
                        txtingreso.Text = Rest.ToString();
                        txtvisual.Text = "";
                        txtvisual.Text = Rest.ToString();
                    break;
                    

                case "*":
                    
                        Multi = resultado3.multiplicar((pri), (seg));
                        txtingreso.Text = Multi.ToString();
                    txtvisual.Text = "";
                    txtvisual.Text = Multi.ToString();
                    break;
                    

                case "/":
                   

                        Divi = resultado4.dividir((pri), (seg));
                        txtingreso.Text = Divi.ToString();
                        txtvisual.Text = "";
                        txtvisual.Text = Divi.ToString();
                   
                    break;
                case "√2":

                    Rai = resultado6.raizz((pri), (seg));
                    txtingreso.Text = Rai.ToString();
                    txtvisual.Text = "";
                    txtvisual.Text = Rai.ToString();
                    break;

                case "%":

                  
                    Por = resultado7.porcentar((pri), (seg));
                    txtingreso.Text = Por.ToString();
                    txtvisual.Text = "";
                    txtvisual.Text = Por.ToString();
                    break;
                case "xⁿ":


                    Pot = resultado8.porcentar((pri), (seg));
                    txtingreso.Text = Pot.ToString();
                    txtvisual.Text = "";
                    txtvisual.Text = Pot.ToString();
                    break;
               
            }

            btnpunto.Enabled = true;
            btnsuma.Enabled = true;
            btnresta.Enabled = true;
            btnmultiplicar.Enabled = true;
            btndivision.Enabled = true;
            btnporcentaje.Enabled = true;
            btnsignos.Enabled = true;
            btnraiz.Enabled = true;
            btnpotencia.Enabled = true;


        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtingreso.Text = string.Empty;
            txtvisual.Text = string.Empty;
        
        }


        private void btnresta_Click_1(object sender, EventArgs e)
        {
            txtvisual.Text = txtvisual.Text + "-";
            operacionb = "-";
            pri = double.Parse(txtingreso.Text);
            txtingreso.Clear();
            btnresta.Enabled = false;
            btnpunto.Enabled = true;
        }


        private void btnmultiplicar_Click_1(object sender, EventArgs e)
        {
            txtvisual.Text = txtvisual.Text + "*";
            operacionb = "*";
            pri = double.Parse(txtingreso.Text);
            txtingreso.Clear();
            btnmultiplicar.Enabled = false;
            btnpunto.Enabled = true;
        }

        private void btndivision_Click_1(object sender, EventArgs e)
        {

            if ((txtingreso.Text != "0") && (txtvisual.Text != "0"))
             {
            txtvisual.Text = txtvisual.Text + "/";
            operacionb = "/";
            pri = double.Parse(txtingreso.Text);
            txtingreso.Clear();
            btndivision.Enabled = false;
             btnpunto.Enabled = true;

            }
            else
            {
                MessageBox.Show("por favor ingrese un numero diferente a 0");
                 txtingreso.Text = string.Empty;
                txtvisual.Text = string.Empty;
            }



        }

        private void txtregresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtingreso.Text)&& !string.IsNullOrEmpty(txtvisual.Text))
            {

                if (txtingreso.Text.Length == 1) 
                     {
                    txtingreso.Text = "";
                    txtvisual.Text = "";
                       }
                      else 
                         { 
                        txtingreso.Text = txtingreso.Text.Substring(0, txtingreso.Text.Length - 1);
                    txtvisual.Text = txtvisual.Text.Substring(0, txtvisual.Text.Length - 1);
                }
                }
            
            else
            {
                MessageBox.Show("los campos estan vacios, por favor ingresa valores ");
            }


        }

        private void btnpotencia_Click(object sender, EventArgs e)
        {
            txtvisual.Text = txtvisual.Text + "ⁿ";
            operacionb = "xⁿ";
            pri = double.Parse(txtingreso.Text);
            txtingreso.Clear();
            btnpotencia.Enabled = false;
            btnpunto.Enabled = true;

        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            txtvisual.Text = txtvisual.Text + "√2";
            operacionb = "√2";
            pri = double.Parse(txtingreso.Text);
            txtingreso.Clear();

            double Rai;
            Clases.raiz resultado6 = new Clases.raiz();
            Rai = resultado6.raizz((pri), (seg));
            txtingreso.Text = Rai.ToString();
            btnraiz.Enabled = false;
            btnpunto.Enabled = true;

        }

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            txtvisual.Text = txtvisual.Text + "%";
            operacionb = "%";
            pri = double.Parse(txtingreso.Text);
            txtingreso.Clear();
            btnporcentaje.Enabled = false;
            btnpunto.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("BIENVENIDOS AL PROYECTO FINAL");

        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txtingreso.Text = string.Empty;
            txtvisual.Text = string.Empty;

            btnpunto.Enabled = true;
            btnporcentaje.Enabled = true;
            btnsuma.Enabled = true;
            btnresta.Enabled = true;
            btnmultiplicar.Enabled = true;
            btndivision.Enabled = true;
           
            btnsignos.Enabled = true;
            btnraiz.Enabled = true;
            btnpotencia.Enabled = true;

        }

        private void btnsignos_Click(object sender, EventArgs e)
        {
            pri = Convert.ToDouble(txtvisual.Text);
            pri = pri * -1;
            txtingreso.Text = pri.ToString();
            txtvisual.Text = pri.ToString();

            btnsignos.Enabled = false;
        }
    }
}
