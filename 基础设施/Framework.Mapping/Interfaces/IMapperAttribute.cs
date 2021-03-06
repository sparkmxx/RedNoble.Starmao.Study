﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Mapping.Interfaces
{
    public interface IMapperAttribute
    {
        bool IsRunEachTime { get; }

        void Apply<TSource, TDestination>(IMappingExpression<TSource, TDestination> mappingExpression, string name);
    }
}
