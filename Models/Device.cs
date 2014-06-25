
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfDC.Models
{
    class Device : Symbol.Barcode2.Design.Barcode2
    {
        // membri
        private string name;
        public bool readerStatus { get; set; }

        public Device(string name)
        {
            this.name = name;
        }

        /** restituisce il barcode letto */
        public string getBarcode()
        {
            return "123456789012";
        }

        /** abilita lo scanner barcode */ 
        public void enableReader()
        {
            this.readerStatus = true;
        }

        /** disabilita lo scanner barcode */
        public void disableReader()
        {
            this.readerStatus = false;
        }

        /// <summary>
        /// Restituisce lo stato del reader
        /// </summary>
        /// <returns>True: enabled</returns>
        public bool isReaderEnabled()
        {
            return this.readerStatus;
        }
    }
}
