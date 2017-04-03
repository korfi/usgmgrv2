﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace USG_tablet_UI
{
    class TCPconnection
    {

        private String IPaddr;
        private int port;
        TcpClient client;
        NetworkStream ns;
        StreamWriter streamWriter;

        public TCPconnection(String IP, int po)
        {
            this.IPaddr = IP;
            this.port = po;
            client = new TcpClient();
            connect();
        }

        private void connect()
        {
            client.Connect(this.IPaddr, this.port);
            ns = client.GetStream();
            streamWriter = new StreamWriter(ns);
            streamWriter.AutoFlush = true;
        }

        public void disconnect()
        {
            client.GetStream().Close();
            client.Close();
        }

        public void send(String msg)
        {       
            //byte[] byteData = System.Text.Encoding.ASCII.GetBytes(msg);
            streamWriter.WriteLine(msg);
        }


    }
}   
