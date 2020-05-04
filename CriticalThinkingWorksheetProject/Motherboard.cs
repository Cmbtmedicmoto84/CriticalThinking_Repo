using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheetProject
{
    class Motherboard
    {
        public string manufacturer;
        public CPU processor;
        public RAM temporaryMemory;
        public HardDrive storage;
        public GPU graphics;

        public Motherboard(string manufacturers, CPU cpus, RAM rams, HardDrive hardDrives, GPU gpus)
        {
            manufacturer = manufacturers;
            temporaryMemory = rams;
            processor = cpus;
            storage = hardDrives;
            graphics = gpus;
        }

        
    }
}
