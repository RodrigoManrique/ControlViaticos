﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlViaticosApp.Models
{
    public class Autorizar
    {
        public int CodigoSolicitud { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public Empleado empleado { get; set; }
        public Ubigeo ubigeoOrigen { get; set; }
        public Ubigeo ubigeoDestino { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaRetorno { get; set; }
        public String SustentoViaje { get; set; }
        public Double TotalSolicitado { get; set; }
        public String FlagAutorizar { get; set; }
        public DateTime FechaAutorizar { get; set; }
        public int CodigoEmpleadoAutorizar { get; set; }
    }
}