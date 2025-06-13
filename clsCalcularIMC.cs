using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_IMC
{
    internal class clsCalcularIMC
    {
        //propiedades
        private float imc;
        private string tipoImc;
        private float kmRecorridos;
        private string pasosRecorridos;

        public double Imc
        {
            get { return imc; }
        }
        public string TipoImc
        {
            get { return tipoImc; }
        }
        public float KmRecorridos
        {
            get { return kmRecorridos; }
            set { kmRecorridos = value; }
        }
        public string PasosRecorridos
        {
            get { return pasosRecorridos; }
        }
        //metodo constructor
        public clsCalcularIMC()
        {
            imc = 0;
            tipoImc = "";
            kmRecorridos = 0;
            pasosRecorridos = "";
        }
        //Metodo que calcula e indica el IMC
        public string calcularIMC(float altura, float peso)
        {
            imc = peso / (altura * altura);
            if (imc < 18.50)
            {
                tipoImc = "Bajo";
            }
            else if (imc >= 18.50 && imc < 25)
            {
                tipoImc = "Normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                tipoImc =  "Sobrepeso";
            }
            else
            {
                tipoImc = "IMC Obesidad";
            }
            return tipoImc;
        }
        //Metodo que calcula la distancia recorrida en kilometros
        public float calcularKm(float zancada, float pasos)
        {
            kmRecorridos = (pasos * zancada) / 1000;
            return kmRecorridos;
        }
        //metodo que evalua la cantidad de pasos que diste e indica si estas cumpliendo debidamente con una meta
        public string evaluarPasos(float pasos)
        {
            if (pasos >= 10000)
            {
                pasosRecorridos = "Usted esta cumpliendo bien con su cantidad de pasos";
            }
            else if (pasos >= 5000)
            {
                pasosRecorridos = "Usted esta cumpliendo bien, pero intente aumentar hasta los 10,000 pasos";
            }
            else
            {
                pasosRecorridos = "Usted deberia caminar más, intente caminar 5,000 pasos";
            }
            return pasosRecorridos;
        }
        //Metodo que muestra los resultados y los manda a la MessageBox
        public string resultados()
        {
            return "Su IMC es de " + Imc.ToString("F2") + " lo que indica que su clasificación es de " + TipoImc + "\ncaminaste " + KmRecorridos + "Km." + "\n" + PasosRecorridos;
        }
    }
}
