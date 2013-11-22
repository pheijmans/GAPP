﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAPPSF.Core
{
    public interface ISettingsStorage: IDisposable
    {
        void StoreSetting(string name, string value);
        Hashtable LoadSettings();
    }
}