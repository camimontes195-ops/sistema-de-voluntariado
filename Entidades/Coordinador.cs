using System;
    public class Coordinador : Persona
    {
        private string area;
        private int personasACargo;

        public string Area
        {
            get { return area; }
            set { area = value; }
        }

        public int PersonasACargo
        {
            get { return personasACargo; }
            set { personasACargo = value; }
        }

        public Coordinador(int id, string nombre, string area, int personasACargo)
            : base(id, nombre)
        {
            Area = area;
            PersonasACargo = personasACargo;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("\n--- COORDINADOR ---");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Área: " + Area);
            Console.WriteLine("Personas a cargo: " + PersonasACargo);
        }
    }