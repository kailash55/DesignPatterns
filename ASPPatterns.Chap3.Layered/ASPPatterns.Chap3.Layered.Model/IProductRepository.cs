﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model
{
    public interface IProductRepository
    {
        IList<Product> FindAll();
    }
}
