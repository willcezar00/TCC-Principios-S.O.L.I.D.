﻿using System;
using SOLID._5___Dependency_Inversion_Principle.Solução.Models;

namespace SOLID._5___Dependency_Inversion_Principle.Solução.Interface
{

    public interface IPagamento 
    {
       void Pagar(Carrinho carrinho);
    }
}
