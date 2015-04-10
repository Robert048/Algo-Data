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

        private object _lock = new object();
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Timing"/> class.
        /// </summary>
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
        
        /// <summary>
        /// Starts the timer.
        /// </summary>
        public void Start()
        {
            lock (_lock)
            {
                QueryPerformanceCounter(out startTime);
            }
        }
        
        /// <summary>
        /// Stops the timer.
        /// </summary>
        public void Stop()
        {
            lock (_lock)
            {
                QueryPerformanceCounter(out stopTime);
            }
        }

        /// <summary>
        /// Gets the duration in seconds.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public double Duration
        {
            get
            {
                return (double)(stopTime - startTime) / (double)frequence;
            }
        }
    }
}
