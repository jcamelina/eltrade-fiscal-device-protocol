﻿using System;

namespace EltradeProtocol.Requests
{
    public class SetDateTime : EltradeFiscalDeviceRequestPackage
    {
        public SetDateTime() : this(DateTime.Now) { }
        public SetDateTime(DateTime dateTime) : base(0x3d, DateTime.Now.ToString("dd-MM-y HH:mm:ss")) { }
    }
}
