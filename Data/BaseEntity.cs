﻿

using System;

namespace SchoolApp
{

    public abstract class BaseEntity
    {
        public DateTime InsertedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        

    }
}
