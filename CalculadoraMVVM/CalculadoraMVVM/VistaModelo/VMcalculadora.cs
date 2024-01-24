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
        private bool sumarSeleccionado;
        private bool restarSeleccionado;
        private bool multiplicarSeleccionado;
        private bool dividirSeleccionado;
        #endregion
        #region OBJETOS

        
        public bool SumarSeleccionado
        {
            get { return sumarSeleccionado; }
            set
            {
                if (sumarSeleccionado != value)
                {
                    SetValue(ref multiplicarSeleccionado, value);
                    OnPropertyChanged(nameof(SumarSeleccionado));
                }
            }
        }
        public bool RestarSeleccionado
        {
            get { return restarSeleccionado; }
            set
            {
                if (restarSeleccionado != value)
                {
                    SetValue(ref restarSeleccionado, value);
                    OnPropertyChanged(nameof(RestarSeleccionado));
                }
            }
        }
        public bool MultiplicarSeleccionado
        {
            get { return multiplicarSeleccionado; }
            set
            {
                if (multiplicarSeleccionado != value)
                {
                    multiplicarSeleccionado = value;
                    OnPropertyChanged(nameof(MultiplicarSeleccionado));
                }
            }
        }

        public bool DividirSeleccionado
        {
            get { return dividirSeleccionado; }
            set
            {
                if (dividirSeleccionado != value)
                {
                    dividirSeleccionado = value;
                    OnPropertyChanged(nameof(DividirSeleccionado));
                }
            }
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
            operador += "+";
            Actualizar();
       


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
            NumeroAdd("7");
            SumarSeleccionado = false;
            RestarSeleccionado = false;
            DividirSeleccionado = false;
            MultiplicarSeleccionado = false;


        }

        private void Num8()
        {
            NumeroAdd("8");
            SumarSeleccionado = false;
            RestarSeleccionado = false;
            DividirSeleccionado = false;
            MultiplicarSeleccionado = false;
        }

        private void Num9()
        {
            NumeroAdd("9");
            SumarSeleccionado = false;
            RestarSeleccionado = false;
            DividirSeleccionado = false;
            MultiplicarSeleccionado = false;
        }

        private void Num4()
        {
            NumeroAdd("4");
            SumarSeleccionado = false;
            RestarSeleccionado = false;
            DividirSeleccionado = false;
            MultiplicarSeleccionado = false;
        }

        private void Num5()
        {
            NumeroAdd("5");
            SumarSeleccionado = false;
            RestarSeleccionado = false;
            DividirSeleccionado = false;
            MultiplicarSeleccionado = false;
        }

        private void Num6()
        {
            NumeroAdd("6");
            SumarSeleccionado = false;
            RestarSeleccionado = false;
            DividirSeleccionado = false;
            MultiplicarSeleccionado = false;
        }

        private void Num1()
        {
            NumeroAdd("1");
            SumarSeleccionado = false;
            RestarSeleccionado = false;
            DividirSeleccionado = false;
            MultiplicarSeleccionado = false;
        }

        private void Num2()
        {
            NumeroAdd("2");
            SumarSeleccionado = false;
            RestarSeleccionado = false;
            DividirSeleccionado = false;
            MultiplicarSeleccionado = false;
        }

        private void Num3()
        {
            NumeroAdd("3");
            SumarSeleccionado = false;
            RestarSeleccionado = false;
            DividirSeleccionado = false;
            MultiplicarSeleccionado = false;
        }

        private void Num0()
        {

            NumeroAdd("0");
            SumarSeleccionado = false;
            RestarSeleccionado = false;
            DividirSeleccionado = false;
            MultiplicarSeleccionado = false;
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

        private void NumeroAdd(string numero)
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
                SumarSeleccionado = false;
                RestarSeleccionado = false;
                DividirSeleccionado = false;
                MultiplicarSeleccionado = false;
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
            SumarSeleccionado = false;
            RestarSeleccionado = false;
            DividirSeleccionado = false;
            MultiplicarSeleccionado = false;
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