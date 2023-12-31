﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelo
{
    public class Orden
    {
        [Key]
        public int Id{ get; set; }

        public string UsuarioAplicacionId { get; set; }

        [ForeignKey("UsuarioAplicacionId")]
        public UsuarioAplicacion UsuarioAplicacion { get; set; }

        public DateTime FechaOrden { get; set; }

        public DateTime FechaEnvio { get; set; }

        public string NumeroEnvio { get; set; }

        public string Carier { get; set; }

        [Required]
        public double TotalOrden { get; set; }

        [Required]
        public string EstadoOrden { get; set; }

        public string EstadoPago { get; set; }

        public DateTime FechaPago { get; set; }

        public DateTime FechaMaximoPago { get; set; }

        public  string TransaccionId { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }
        public string Pais { get; set; }

        public string NombreCliente { get; set; }


    }
}
