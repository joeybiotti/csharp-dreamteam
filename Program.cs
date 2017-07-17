using System;
using System.Collections.Generic;

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
        
          Joey joey = new Joey();
          Karl malone = new Karl();
          Larry bird = new Larry();
          Magic johnson = new Magic();
          Michael jordan = new Michael();
          Patrick ewing = new Patrick();

          List<IDreamteam> serverSide = new List<IDreamteam>();
          serverSide.Add(joey);
          serverSide.Add(malone);
          serverSide.Add(bird);

          List <IDreamteam> clientSide = new List<IDreamteam>();
          clientSide.Add(johnson);
          clientSide.Add(jordan);
          clientSide.Add(ewing);

        
          foreach(var server in serverSide)
          {
              server.work();
          }
          foreach(var client in clientSide)
          {
              client.work();
          }
        }
    }
}
