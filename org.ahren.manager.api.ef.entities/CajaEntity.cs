﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.ef.entities
{
    [Table("CAJA")]
    public class CajaEntity
    {       
        public String id { get; set; }

        public String denominacion { get; set; }
       
        public String abierto { get; set; }

        public virtual ISet<HistorialCajaEntity> historiales { get; set; }
    }
}
