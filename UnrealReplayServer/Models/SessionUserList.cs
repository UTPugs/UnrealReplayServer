﻿/*
The MIT License (MIT)
Copyright (c) 2021 Henning Thoele
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnrealReplayServer.Models
{
    public class SessionUserList
    {
        public string[] Users { get; set; } = Array.Empty<string>();
    }
}
