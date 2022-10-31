using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseAnimal
{
    internal class Animal
    {
        public string nombre;
        public string raza;
        public short edad;
        public double peso;
        public double altura;
        public string familiaTaxonomica;
        public string tipoDeAlimentacion;
        public string mesesDeGestacion;
        public bool caminar;
        public bool saltar;
        public bool realizarUnSonido;

        public Animal()
        {
            nombre = "";
            raza = "";
            edad = 0;
            peso = 0;
            altura = 0;
            familiaTaxonomica = "";
            tipoDeAlimentacion = "";
            mesesDeGestacion = "";
            caminar = false;
            saltar = false;
            realizarUnSonido = false; 
        }
        public Animal(string nombre, string raza, short edad, double peso, double altura, string familiaTaxonomica, string tipoDeAlimentacion, string mesesDeGestacion,bool caminar,bool saltar,bool realizarUnSonido)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.edad = edad;
            this.peso = peso;
            this.altura = altura;
            this.familiaTaxonomica = familiaTaxonomica;
            this.tipoDeAlimentacion = tipoDeAlimentacion;
            this.mesesDeGestacion = mesesDeGestacion;
            this.caminar = caminar;
            this.saltar = saltar;
            this.realizarUnSonido = realizarUnSonido;
        }

        public bool PuedeCaminar()
        {
            if (caminar == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PuedeSaltar()
        {
            if (saltar == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PuedeEmitirSonidos()
        {
            if (realizarUnSonido == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
