using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace inf2c
{
    //http://www.codeproject.com/Articles/2635/High-Performance-Timer-in-C
    public class Timing
    {
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(
            out long lpPerformanceCount);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(
            out long lpFrequency);

        private long startTime;
        private long stopTime;
        private long frequence;

        public Timing()
        {
            startTime = 0;
            stopTime = 0;
            frequence = 0;

            // check if counter is supported
            if (QueryPerformanceFrequency(out frequence) == false)
            {
                throw new Win32Exception();
            }
        }

        public void Start()
        {
            Thread.Sleep(0);
            QueryPerformanceCounter(out startTime);
        }

        public void Stop()
        {
            QueryPerformanceCounter(out stopTime);
        }

        public double Duration
        {
            get
            {
                return (double)(stopTime - startTime) / (double)freq;
            }
        }
    }
}
