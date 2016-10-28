using System;
using System.Xml.Serialization;
using System.Collections.Generic;


namespace NationStates.XmlResponses {
	[XmlRoot( ElementName = "WORLD" )]
	public class WORLD {
		[XmlElement( ElementName = "DISPATCHLIST" )]
		public DISPATCHLIST DispatchList { get; set; }
		[XmlElement( ElementName = "HAPPENINGS" )]
		public HAPPENINGS Happenings { get; set; }
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
