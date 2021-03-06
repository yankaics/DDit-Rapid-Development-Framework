﻿using DDit.Core.Data.Entity;
using DDit.Core.Data.Entity.SystemEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDitApplicationFrame.Service
{
    public interface ILoginService
    {
        Tuple<bool, string> Login(User model, string IP);

        void Logon();
    }
}