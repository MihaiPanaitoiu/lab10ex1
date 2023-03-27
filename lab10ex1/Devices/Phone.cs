using lab10ex1.Interfaces;
using System;

namespace lab10ex1.Devices
{
        class Phone: IContactLessPayment
        {
            public void NearingDevice()
            {
                Console.WriteLine("Nearing the device to the POS");
            }

            public void Pay()
            {
                Console.WriteLine("Paying");
            }
        }
}
