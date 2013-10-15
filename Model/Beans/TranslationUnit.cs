using System;
using System.Collections.Generic;
using System.Text;

namespace MachineTranslator.Model
{ 
    /// <summary>
    /// Egy fordítási egységet reprezentáló osztály. Hasonlóan a Java bean osztályoknál itt is minden
    /// adattag privát és van hozzá getter/setter. C#-ban van nyelvi szinten erre külön támogatás
    /// az ún. property-k személyében, amelyek általában azonos nevûek mint az adattagok csak nagy
    /// kezdõbetûvel!
    /// </summary>
    public class TranslationUnit
    {
        public String Angol { get; set; }
        public String Magyar { get; set; }

        /// <summary>
        /// C#-ban is minden objektumnak van ToString() (nagybetûs!!!) metódusa, amit célszerû
        /// felüldefiniálnunk ha egyedi szöveget szeretnénk kiíratni.
        /// 
        /// Felüldefiniálásnál az "override" kulcsszót kötelezõ használni!
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return String.Format("{0} - {1}", Angol, Magyar);
        }
    }
}