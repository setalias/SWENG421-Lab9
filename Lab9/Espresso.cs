using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Espresso : AbstractOther
    {
        public override void run()
        {
            this.getICMM().setLEDNumber(13);
            this.getICMM().setGrindingTime(5);
            this.getICMM().setTemperature(200);
            this.getICMM().addCondiment(new Cream());
            this.getICMM().addCondiment(new Vanilla());
            this.getICMM().addCondiment(new Cream());
            this.getICMM().setLEDNumber(0);
        }
    }
}
