﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class PersonaDTO
    {
        private string correo;
        private string ci;
        private string nombre;
        private string apellido;
        private string contra;
        private DateTime fechanac;
        private string nrocelular;
        private string foto;
        private int idcliente;

        public PersonaDTO(string correo, string ci, string nombre, string apellido, string contra, DateTime fechanac, string nrocelular, string foto)
        {
            this.correo = correo;
            this.ci = ci;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contra = contra;
            this.fechanac = fechanac;
            this.nrocelular = nrocelular;
            this.foto = foto;
        }
            public PersonaDTO(string correo, string ci, string nombre, string apellido, DateTime fechanac, string nrocelular, string foto, int idcliente)
            {
                this.correo = correo;
                this.ci = ci;
                this.nombre = nombre;
                this.apellido = apellido;
                this.fechanac = fechanac;
                this.nrocelular = nrocelular;
                this.foto = foto;
                this.idcliente = idcliente;
            }

        public string Correo { get { return this.correo; } }
        public string Ci { get { return this.ci; } }
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public string Contra { get { return this.contra; } }
        public DateTime Fechanac { get { return this.fechanac; } }
        public string Nrocelular { get { return this.nrocelular; } }
        public string Foto { get { return this.foto; } }
        public int Idcliente { get { return this.idcliente; } }
    }
}
