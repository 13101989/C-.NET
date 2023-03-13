using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopOOP
{
    class Program
    {
        public class MobilePhone
        {
            public string ModelName { get; set; }

            private string producer;
            public string Producer
            {
                get { return producer; }
                set
                { if (value == "Samsung")
                    {
                        producer = value;
                    }
                    else
                    {
                        producer = "";
                    }
                }
            }

            public Sim SimCard { get; set; }

            public void Call()
            {
                if (SimCard != null)
                {
                    Console.WriteLine("you can make a call");
                }
            }

            public override string ToString()
            {
                return ModelName;
            }

        }

        public class SmartPhone : MobilePhone
        {
            public string OperatingSystem { get; set; }

            public override string ToString()
            {
                return "this is smart phone" + base.ToString();
            }

            public void Camera()
            {
                Console.WriteLine("take a picture");
            }
        }

        public class SamsungS9 : SmartPhone, IProcessor
        {
            public string Processor { get { return "AMD seria 2"; } }

            public byte NoOfCameras { get { return 2; } }

            public void Camera(int cameraNo)
            {
                Console.WriteLine($"take a picture with {cameraNo}");
            }
        }

        public class SamsungS8 : SmartPhone, IProcessor
        {
            public string Processor { get { return "AMD seria 1"; } }
        }

        interface IProcessor
        {
            string Processor { get; }
        }

        public class Sim
        {
            public string Number { get; private set; }

            public string Provider { get; private set; }

            public Sim(string number, string providerName)
            {
                Number = number;
                Provider = providerName;
            }

        }

        static void Main(string[] args)
        {
            var sim1 = new Sim("+4090909090", "Orange");

            var sim2 = new Sim("+4090909033", "Orange");

            var mobilePhone = new MobilePhone();
            mobilePhone.ModelName = "Nokia 1310";
            mobilePhone.SimCard = sim1;
            mobilePhone.Producer = "Apple";

            Console.WriteLine(mobilePhone.Producer);

            var smartPhone = new SmartPhone { ModelName = "Samsung S9", SimCard = sim2, OperatingSystem = "Android" };

            var smartPhone2 = new SamsungS9 { ModelName = "Samsung S9", SimCard = sim2, OperatingSystem = "Android" };


            var phones = new MobilePhone[2];
            phones[0] = mobilePhone;
            phones[1] = smartPhone;

            foreach (MobilePhone p in phones)
            {
                Console.WriteLine(p.ToString());
                p.Call();
                // p.Camera();
            }
            smartPhone2.Camera(1);



            Console.ReadLine();
        }
    }
}
