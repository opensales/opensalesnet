﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.ef.entities
{
    [Table("HISTORIAL_BOVEDA")]
    public class HistorialBovedaEntity
    {
        [Column("id")]
        public String id { get; set; }

        [Column("fecha_apertura")]
        public DateTime fechaApertura { get; set; }

        [Column("fecha_cierre")]
        public DateTime fechaCierre { get; set; }

        [Column("estado")]
        public bool estado { get; set; }

        [Column("boveda_id")]
        public BovedaEntity boveda { get; set; }

    }
}
