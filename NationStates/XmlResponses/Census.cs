using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace NationStates.XmlResponses {
	public class Census {
		[XmlElement( ElementName = "SCALE" )]
		public List<SCALE> Scale { get; set; }
	}

	[XmlRoot( ElementName = "SCALE" )]
	public class SCALE {
		[XmlElement( ElementName = "SCORE" )]
		public string Score { get; set; }
		[XmlElement( ElementName = "RANK" )]
		public string Rank { get; set; }
		[XmlAttribute( AttributeName = "id" )]
		public string Id { get; set; }
	}

}
