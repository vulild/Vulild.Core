﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vulild.Core.Orm
{
    public interface IDbDelete : IDbOpt
    {
        int Delete();
    }
}
