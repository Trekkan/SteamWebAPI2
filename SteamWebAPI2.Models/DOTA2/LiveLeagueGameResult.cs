﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamWebAPI2.Models.DOTA2
{
    public class LiveLeagueGameResult
    {
        public IList<LiveLeagueGame> Games { get; set; }
        public int Status { get; set; }
    }
}