﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ControlViaticosServices.Dominio;

namespace ControlViaticosServices.Persistencia
{
    public class ViaticoDAO : BaseDAO<Viatico, int>
    {
    }

    public class ViaticoDetalleDAO : BaseDAO<ViaticoDetalle, ViaticoDetallePK>
    {
    }
}