using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationStates.XmlResponses {
	public class ZOMBIE {
		[XmlElement( ElementName = "SURVIVORS" )]
		public string Survivors { get; set; }
		[XmlElement( ElementName = "ZOMBIES" )]
		public string Zombies { get; set; }
		[XmlElement( ElementName = "DEAD" )]
		public string Dead { get; set; }
	}
}
