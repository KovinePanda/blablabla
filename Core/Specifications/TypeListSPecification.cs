using System;
using Core.Entities;

namespace Core.Specifications;

public class TypeListSPecification : BaseSpecification<Product, string>
{
    public TypeListSPecification()
    {
        AddSelect(x => x.Type);
        ApplyDistinct();
    }
}
