﻿using KoobookServiceConsoleApp.Amazon;
using KoobookServiceConsoleApp.GoodReadsApi;
using KoobookServiceConsoleApp.GoogleBooksApi;
using KoobookServiceConsoleApp.TCP;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KoobookServiceConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {


            TCPServer server = new TCPServer();
            server.Listen();



            //BookDataController bookDataController = new BookDataController();
            //bookDataController.CollectDataFromSources("9780007354771");

            //AmazonWebScraper amazonWebScraper = new AmazonWebScraper();
            //amazonWebScraper.CollectDataForBook("9780007354771");
  
        }
    }
}
