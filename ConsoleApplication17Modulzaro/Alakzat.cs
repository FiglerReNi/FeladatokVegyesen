using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17Modulzaro //projektek között class másolásnál a namespace-t javítani kell
{
     abstract class Alakzat  //ha egy osztályban van abstract függvény, metódus bármi, akkor az osztálynak is annak kell lennie.
                             //abstract osztályban lehet nem abstract dolog, de abstract osztály nem példányosítható
                             
    {
        public abstract double terulet(); //itt csak általánnosságban adjuk meg, mert minden child classnak van ilyen, de mindenhol máshogy számoljuk.
        public abstract int kerulet();

        
       
    }
}
