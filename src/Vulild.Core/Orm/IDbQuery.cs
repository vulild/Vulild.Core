﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vulild.Core.Orm
{
    public interface IDbQuery<T> : IDbOpt
    {
        T Query();
    }
}
