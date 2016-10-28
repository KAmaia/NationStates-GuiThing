using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationStates.XmlResponses {
	[XmlRoot( ElementName = "DISPATCH" )]
	public class DISPATCH {
		[XmlElement( ElementName = "TITLE" )]
		public string Title { get; set; }
		[XmlElement( ElementName = "AUTHOR" )]
		public string Author { get; set; }
		[XmlElement( ElementName = "CATEGORY" )]
		public string Category { get; set; }
		[XmlElement( ElementName = "SUBCATEGORY" )]
		public string SubCategory { get; set; }
		[XmlElement( ElementName = "CREATED" )]
		public string Created { get; set; }
		[XmlElement( ElementName = "EDITED" )]
		public string Edited { get; set; }
		[XmlElement( ElementName = "VIEWS" )]
		public string Views { get; set; }
		[XmlElement( ElementName = "SCORE" )]
		public string Score { get; set; }
		[XmlAttribute( AttributeName = "id" )]
		public string Id { get; set; }
	}

	[XmlRoot( ElementName = "DISPATCHLIST" )]
	public class DISPATCHLIST {
		[XmlElement( ElementName = "DISPATCH" )]
		public List<DISPATCH> DispatchList { get; set; }
	}
}
