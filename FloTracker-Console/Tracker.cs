﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloTracker_Console {

    /// <summary>
    /// Class to handle cycle class objects and save systems.
    /// </summary>
    internal class Tracker {

        public List<Cycle> cycles = new List<Cycle>();

        // -- Save & Load

        public void SaveData() {
            string data = JsonConvert.SerializeObject(cycles);
            File.WriteAllText("History.txt", data);
        }

        public void LoadData() {
            if (File.Exists("History.txt")) {
                string data = File.ReadAllText("History.txt");
                cycles = JsonConvert.DeserializeObject<List<Cycle>>(data);
            }
        }
    }
}
