using System;

    public abstract class Persona
    {
        private int id;
        private string nombre;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Persona (int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public abstract void MostrarInformacion();
    }