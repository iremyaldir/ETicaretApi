﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Common
{
    public class EntityBase: IEntityBase
     {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}