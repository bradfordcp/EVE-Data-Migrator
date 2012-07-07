using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data;

using EveMigrator.Models;
using EveMigrator.Processors;

namespace EveMigrator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Process the Agent Tables
            AgentProcessor agentProcessor = new AgentProcessor();
            Thread agentThread = new Thread(agentProcessor.process);

            // Process the Character Tables
            CharacterProcessor characterProcessor = new CharacterProcessor();
            Thread characterThread = new Thread(characterProcessor.process);

            // Process the Corporation Tables
            CorporationProcessor corporationProcessor = new CorporationProcessor();
            Thread corporationThread = new Thread(corporationProcessor.process);

            // Process the Certificate Tables
            CertificateProcessor certificateProcessor = new CertificateProcessor();
            Thread certificateThread = new Thread(certificateProcessor.process);

            // Process the Damage Tables
            DamageProcessor damageProcessor = new DamageProcessor();
            Thread damageThread = new Thread(damageProcessor.process);

            // Process the EVE Tables
            EveProcessor eveProcessor = new EveProcessor();
            Thread eveThread = new Thread(eveProcessor.process);

            // Process the War Tables
            WarProcessor warProcessor = new WarProcessor();
            Thread warThread = new Thread(warProcessor.process);

            // Fire up our threads
            //agentThread.Start();
            //characterThread.Start();
            //certificateThread.Start();
            //corporationThread.Start(); // Hold off on this one
            //damageThread.Start();
            eveThread.Start();
            warThread.Start();
            

            // Join all our threads
            //agentThread.Join();
            //characterThread.Join();
            //certificateThread.Join();
            //corporationThread.Join(); // Do not uncomment
            //damageThread.Join();
            eveThread.Join();
            warThread.Join();

            // Notify that we are done
            Console.WriteLine("Finished, press enter to close");
            Console.ReadLine();
        }
    }
}
