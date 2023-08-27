﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtmBuilder.Core.Extensions
{
    //static vai existir quando a aplicação for iniciada
    public static class ListExtensions
    {
        public static void AddIfNotNull(
            this List<string> list,
            string key,
            string? value)
        {
            //usando this automaticamente eu ja criei um metodo de extensão
            
            if (!string.IsNullOrEmpty(value))
                list.Add($"{key}={value}");
        }
    }
}
