﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RudeFox.Enums
{
    public enum UpdateStatus
    {
        Idle,
        CheckingForUpdate,
        DownloadingUpdate,
        UpdateDownloaded,
        LatestVersion
    }
}