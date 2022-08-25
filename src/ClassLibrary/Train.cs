//--------------------------------------------------------------------------------
// <copyright file="Train.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace ClassLibrary
{

    public class Train
    {
        public string Id {get; set; }
        private static int count = 0;
        public Train(string id)
        {
            this.Id = id;
            count ++;
            Console.WriteLine($"Estamos construyendo el tren: {this.Id}");
            Console.WriteLine($"Es el número: {count}");
        }
      
         ~Train()
        {
            count--;
            Console.WriteLine($"Se utiliza el método destructor, el contador ahora es {count}");
        } 

        public bool IsEngineStarted { get; private set; }


        public bool StartEngines()
        {
            if (this.IsEngineStarted)
            {
                Console.Write("The engines are already running");
                return false;
            }

            this.IsEngineStarted = true;
            Console.Write("Engines on ");
            return true;
        }

        public bool StopEngines()
        {
            if (this.IsEngineStarted)
            {
                this.IsEngineStarted = false;
                Console.Write("Engines off");
                return true;
            }

            Console.Write("The engines are already stopped");
            return this.IsEngineStarted;
        }
    }
}