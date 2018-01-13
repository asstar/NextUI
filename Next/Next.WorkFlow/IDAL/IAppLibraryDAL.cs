﻿using Next.Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Next.WorkFlow.Entity;

namespace Next.WorkFlow.IDAL
{
    public interface IAppLibraryDAL : IBaseDAL<AppLibrary>
    {
        List<AppLibrary> GetAllByType(string type);
        AppLibrary GetByCode(string code);
    }
}