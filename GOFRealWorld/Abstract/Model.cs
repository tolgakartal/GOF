using System;

namespace GOFRealWorld.Abstract
{
    public abstract class Computer
    {
        public abstract void RunSystemInfo();
    }

    public abstract class ComputerFactory
    {
        public abstract GamingComputer CreateGamingComputerFactory();
        public abstract OfficeHighendComputer CreateOfficeHighendComputerFactory();
    }
 
    public class InsuranceAgencyOfficeComputerFactory : ComputerFactory
    {
        public override GamingComputer CreateGamingComputerFactory()
        {
            throw new NotImplementedException();
        }

        public override OfficeHighendComputer CreateOfficeHighendComputerFactory()
        {
            throw new NotImplementedException();
        }
    }
    
    public class GamingComputer : Computer
    {
        public override void RunSystemInfo()
        {
            Console.WriteLine("8 core i7 4200 GHz, GTX 9999 - 32000MB DDR6 at 2800 MHz with GPU at 4000 GHz");
        }
    }
    
    public class OfficeHighendComputer : Computer
    {
        public override void RunSystemInfo()
        {
            Console.WriteLine("Dual core i3 2200 GHz, Intel Builtin with GPU at 700 GHz 1000MB");
        }
    }
}