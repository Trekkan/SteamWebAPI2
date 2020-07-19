﻿using Steam.Models.Utilities;
using System;

namespace Steam.Models
{
    public class SteamServerInfoModel
    {
        public ulong ServerTime { get; set; }
        public string ServerTimeString { get; set; }
        public DateTime ServerTimeDateTime { get { return ServerTime.ToDateTime(); } }
    }
}