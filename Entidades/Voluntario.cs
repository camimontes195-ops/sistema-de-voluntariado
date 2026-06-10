using System;
    public class Voluntario : Persona
    {
        private int horasTrabajadas;

        public int HorasTrabajadas
        {
            get { return horasTrabajadas; }
            set { horasTrabajadas = value; }
        }

        public Voluntario(int id, string nombre, int horasTrabajadas)
            : base(id, nombre)
        {
            HorasTrabajadas = horasTrabajadas;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("\n VOLUNTARIO ");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Horas trabajadas: " + HorasTrabajadas);
        }
    }