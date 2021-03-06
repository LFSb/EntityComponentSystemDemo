﻿using ECS.Base;
using ECS.Interfaces;

namespace ECS.Components.Product
{
  public class Price : BaseComponent
  {
    public Price(IEntity parent) : base(parent) { parent.Set<Price>(this); }

    public decimal UnitPrice { get; set; }
    public decimal CostPrice { get; set; }
  }
}
