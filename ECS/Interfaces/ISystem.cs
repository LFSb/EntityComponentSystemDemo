﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Interfaces
{
  public interface ISystem
  {
    void DoWork(IList<IEntity> set);
  }
}
