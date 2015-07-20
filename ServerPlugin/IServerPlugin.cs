﻿using ServerPlugin.InterfaceHandle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLRat.Server
{
    public interface IServerPlugin
    {
        MLPluginInfomation PluginInfomation { get; }
        void OnClientConnect(IClient client);
        void OnClientDisconnect(IClient client);
        void OnDataRetrieved(IClient client, object[] data);
        void OnPluginLoad(IServerUIHandler UIHost);
    }
}
