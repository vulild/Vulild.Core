using System;
using System.Collections.Generic;
using System.Text;

namespace Vulild.Core.Orm
{
    public interface IDbInsert : IDbOpt
    {
        bool Insert();
    }
}
