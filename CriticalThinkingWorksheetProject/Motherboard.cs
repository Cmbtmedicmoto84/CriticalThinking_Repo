using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheetProject
{
    class Motherboard
    {
        public string Manufacturer;
        public CPU Processor;
        public RAM TemporaryMemory;
        public HardDrive Storage;
        public GPU Graphics;

        public Motherboard(string manufacturer, CPU cpu, RAM ram, HardDrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturer;
            TemporaryMemory = ram;
            Processor = cpu;
            Storage = hardDrive;
            Graphics = gpu;
        }

        public void InstallApplication(string ApplicationName)
        {

        }
    }
}
