﻿using System;

namespace Course.Devices {
    class Scanner : Device {

        public override void ProcessDoc(string document) {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan() {
            return "Scanner scan result";
        }
    }
}
