using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationStates.XmlResponses {
	[XmlRoot( ElementName = "POLL" )]
	public class POLL {
		[XmlElement( ElementName = "TITLE" )]
		public string Title { get; set; }
		[XmlElement( ElementName = "REGION" )]
		public string Region { get; set; }
		[XmlElement( ElementName = "START" )]
		public string Start { get; set; }
		[XmlElement( ElementName = "STOP" )]
		public string Stop { get; set; }
		[XmlElement( ElementName = "AUTHOR" )]
		public string Author { get; set; }
		[XmlElement( ElementName = "OPTIONS" )]
		public OPTIONS Options { get; set; }
		[XmlAttribute( AttributeName = "id" )]
		public string Id { get; set; }
	}
	[XmlRoot( ElementName = "OPTION" )]
	public class OPTION {
		[XmlElement( ElementName = "OPTIONTEXT" )]
		public string OptionText { get; set; }
		[XmlElement( ElementName = "VOTES" )]
		public string Votes { get; set; }
		[XmlElement( ElementName = "VOTERS" )]
		public string Voters { get; set; }
		[XmlAttribute( AttributeName = "id" )]
		public string Id { get; set; }
	}
	[XmlRoot( ElementName = "OPTIONS" )]
	public class OPTIONS {
		[XmlElement( ElementName = "OPTION" )]
		public List<OPTION> Options { get; set; }
	}
}
