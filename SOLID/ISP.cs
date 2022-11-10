using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // Зачем так больно
    internal class ISP
    {

        interface ICar
        {
            void DriveForward();
            void DriveBackward();
            void Drift();
            void Parcing();
        }
        class PeteaDriver : ICar
        {
            public void DriveForward() { }
            public void DriveBackward() { }
            public void Drift() 
            {
                Console.WriteLine("Жестко давать боком");
            }
            public void Parcing() { }
        }
    }

    
    // А так не больно

    interface IDriveForward
    {
        void DriveForward();
    }
    interface IDriveBackward
    {
        void DriveBackward();
    }
    interface IDrift
    {
        void Drift();
    }
    interface IParcing
    {
        void Parcing();
    }

    class Drifter : IDrift
    {
        public void Drift()
        {
            Console.WriteLine("Даёт боком");
        }
    }
}
