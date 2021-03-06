﻿// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Tsubaki.Test.Console
{
    using System;
    using System.Text;
    using Tsubaki.Addons.Contracts;
    using Tsubaki.Addons.Hosting; 
    using Tsubaki.Core;
    using Tsubaki.Test.MockAddon;
    using System.Numerics;
    using System.Diagnostics;
    using Tsubaki.Core.Intents;
    using Tsubaki.Tax;

    partial class Program
    { 
        private static void main()
        {
            var client = new DialogflowClient("e03ae972dbf44fc79274468c468bcbe0");
            var uia = new WsLocalhost(client);
            uia.CreateDebugClient();
        }

    }
}