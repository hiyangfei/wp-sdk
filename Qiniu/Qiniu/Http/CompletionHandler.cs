﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qiniu.Http
{
    public interface CompletionHandler
    {
        void complete(ResponseInfo info, object response);
    }
}