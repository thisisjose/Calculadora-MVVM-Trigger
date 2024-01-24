using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculadoraMVVM.VistaModelo
{
    public class VMcalculadora : BaseViewModel
    {
        #region VARIABLES
        private string num1 = "";
        private string num2 = "";
        private string operador = "";
        private string mensaje = "";
        private bool activationButton;
        private string backgroundColor;
        private string textColor;
        #endregion
        #region OBJETOS
        public string TextColor
        {
            get { return textColor; }
            set { SetValue(ref textColor, value); }
        }
        public string BackgroundColor
        {
            get { return backgroundColor; }
            set { SetValue(ref backgroundColor, value); }
        }
        public bool ActivationButton
        {
            get { return activationButton; }
            set { SetValue(ref activationButton, value); }
        }
        public string N1
        {
            get { return num1; }
            set { SetValue(ref num1, value); }
        }
        public string N2
        {
            get { return num2; }
            set { SetValue(ref num2, value); }
        }
        public string Operador
        {
            get { return operador; }
            set { SetValue(ref operador, value); }
        }
        public string Mensaje
        {
            get { return mensaje; }
            set { SetValue(ref mensaje, value); }
        }
        #endregion
        #region PROCESOS
        private void Actualizar()
        {
            Mensaje = N1 + Operador + N2;
        }

        private void Btn_sumar()
        {
            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(num1) && !string.IsNullOrEmpty(num2))
            {
                SacarResultado();
            }
            operador = "+";
            Actualizar();
            BackgroundColor = "#ffffff";
            textColor = "#000000";
        }

        private void Btn_restar()
        {

            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(num1) && !string.IsNullOrEmpty(num2))
            {
                SacarResultado();
            }
            operador += "-";
            Actualizar();

        }

        private void Btn_Multiplicar()
        {
            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(num1) && !string.IsNullOrEmpty(num2))
            {
                SacarResultado();
            }
            operador += "x";
            Actualizar();

        }

        private void Btn_dividir()
        {
            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(num1) && !string.IsNullOrEmpty(num2))
            {
                SacarResultado();
            }
            operador += "÷";
            Actualizar();

        }
        private void SacarResultado()
        {
            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(num1) && !string.IsNullOrEmpty(num2))
            {
                double numero1 = double.Parse(num1);
                double numero2 = double.Parse(num2);
                double resultado = 0;

                switch (operador)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "x":
                        resultado = numero1 * numero2;
                        break;
                    case "÷":
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                        }
                        else
                        {
                            Mensaje = "Error";
                            return;
                        }
                        break;
                }

                Mensaje = resultado.ToString();
                num1 = resultado.ToString();
                num2 = "";
                operador = "";
            }
        }
        private void Btn_C()
        {
            num1 = "";
            num2 = "";
            operador = "";
            Mensaje = "0";
        }
        private void Num7()
        {
            AgregarNumero("7");
        }

        private void Num8()
        {
            AgregarNumero("8");
        }

        private void Num9()
        {
            AgregarNumero("9");
        }

        private void Num4()
        {
            AgregarNumero("4");
        }

        private void Num5()
        {
            AgregarNumero("5");
        }

        private void Num6()
        {
            AgregarNumero("6");
        }

        private void Num1()
        {
            AgregarNumero("1");
        }

        private void Num2()
        {
            AgregarNumero("2");
        }

        private void Num3()
        {
            AgregarNumero("3");
        }

        private void Num0()
        {

            AgregarNumero("0");
        }

        private void Click_punto()
        {
            if (!Mensaje.Contains("."))
            {
                Mensaje += ".";
                if (string.IsNullOrEmpty(operador))
                {
                    num1 += ".";
                }
                else
                {
                    num2 += ".";
                }
            }
        }

        private void AgregarNumero(string numero)
        {
            if (string.IsNullOrEmpty(operador))
            {
                num1 += numero;
            }
            else
            {
                num2 += numero;
            }

            Actualizar();
        }

        private void Btn_igual()
        {
            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(num1) && !string.IsNullOrEmpty(num2))
            {
                double numero1 = double.Parse(num1);
                double numero2 = double.Parse(num2);
                double resultado = 0;

                switch (operador)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "x":
                        resultado = numero1 * numero2;
                        break;
                    case "÷":
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                        }
                        else
                        {
                            Mensaje = "Error";
                            return;
                        }
                        break;
                }

                Mensaje = resultado.ToString();
                num1 = resultado.ToString();
                num2 = "";
                operador = "";
            }
        }
        private void Click_D()
        {
            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(num2))
            {
                num2 = num2.Remove(num2.Length - 1);
            }
            else if (!string.IsNullOrEmpty(num1))
            {
                num1 = num1.Remove(num1.Length - 1);
            }

            Actualizar();
        }
        public void Selected()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ActualizarPantallaCommand => new Command(Actualizar);
        public ICommand SumarCommand => new Command(Btn_sumar);
        public ICommand RestarCommand => new Command(Btn_restar);
        public ICommand MultiplicarCommand => new Command(Btn_Multiplicar);
        public ICommand DividirCommand => new Command(Btn_dividir);
        public ICommand LimpiarCommand => new Command(Btn_C);
        public ICommand Numero1Command => new Command(Num1);
        public ICommand Numero2Command => new Command(Num2);
        public ICommand Numero3Command => new Command(Num3);
        public ICommand Numero4Command => new Command(Num4);
        public ICommand Numero5Command => new Command(Num5);
        public ICommand Numero6Command => new Command(Num6);
        public ICommand Numero7Command => new Command(Num7);
        public ICommand Numero8Command => new Command(Num8);
        public ICommand Numero9Command => new Command(Num9);
        public ICommand Numero0Command => new Command(Num0);
        public ICommand PuntitoCommand => new Command(Click_punto);
        public ICommand IgualCommand => new Command(Btn_igual);
        public ICommand ReturnCommand => new Command(Click_D);
        #endregion
    }
}