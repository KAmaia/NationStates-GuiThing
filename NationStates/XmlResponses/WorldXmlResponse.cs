using System;
using System.Xml.Serialization;
using System.Collections.Generic;


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

	[XmlRoot( ElementName = "WORLD" )]
	public class WORLD {
		[XmlElement( ElementName = "DISPATCHLIST" )]
		public DISPATCHLIST DISPATCHLIST { get; set; }
		[XmlElement( ElementName = "HAPPENINGS" )]
		public Happenings Happenings { get; set; }
		[XmlElement( ElementName = "CENSUSID" )]
		public string CENSUSID { get; set; }
		[XmlElement( ElementName = "CENSUS" )]
		public Census wCensus { get; set; }
		[XmlElement( ElementName = "NEWNATIONS" )]
		public string NewNations { get; set; }
		[XmlElement( ElementName = "NUMNATIONS" )]
		public string NumNations { get; set; }
		[XmlElement( ElementName = "NUMREGIONS" )]
		public string NumRegions { get; set; }
		[XmlElement( ElementName = "POLL" )]
		public POLL Poll { get; set; }
		[XmlElement( ElementName = "REGIONS" )]
		public string Regions { get; set; }
		[XmlElement( ElementName = "POWER" )]
		public string Power { get; set; }
		}
}
