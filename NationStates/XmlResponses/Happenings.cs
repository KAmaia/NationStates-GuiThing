using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace NationStates.XmlResponses {

	[XmlRoot( ElementName = "EVENT" )]
	public class EVENT {
		[XmlElement( ElementName = "TIMESTAMP" )]
		public string TimeStamp { get; set; }
		[XmlElement( ElementName = "TEXT" )]
		public string Text { get; set; }
		[XmlAttribute( AttributeName = "id" )]
		public string Id { get; set; }
	}

	[XmlRoot( ElementName = "HAPPENINGS" )]
	public class HAPPENINGS {
		[XmlElement( ElementName = "EVENT" )]
		public List<EVENT> Events { get; set; }
	}
}