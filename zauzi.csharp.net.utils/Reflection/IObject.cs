﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zauzi.csharp.net.utils.Reflection
{
    public interface IObject
    {
        Object GetValue(Object obj, String methodName, params Object[] param);
    }
}
