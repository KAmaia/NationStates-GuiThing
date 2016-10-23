using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NationStates.XmlResponses {
	class RegionXmlResponse {

		[XmlRoot( ElementName = "NATION" )]
		public class NATION {
			[XmlElement( ElementName = "NAME" )]
			public string Name { get; set; }
			[XmlElement( ElementName = "RANK" )]
			public string Rank { get; set; }
			[XmlElement( ElementName = "SCORE" )]
			public string Score { get; set; }
		}

		[XmlRoot( ElementName = "NATIONS" )]
		public class NATIONS {
			[XmlElement( ElementName = "NATION" )]
			public List<NATION> Nations { get; set; }
		}

		[XmlRoot( ElementName = "CENSUSRANKS" )]
		public class CENSUSRANKS {
			[XmlElement( ElementName = "NATIONS" )]
			public NATIONS Nations { get; set; }
			[XmlAttribute( AttributeName = "id" )]
			public string Id { get; set; }
		}

		[XmlRoot( ElementName = "EMBASSY" )]
		public class EMBASSY {
			[XmlAttribute( AttributeName = "type" )]
			public string Type { get; set; }
			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot( ElementName = "EMBASSIES" )]
		public class EMBASSIES {
			[XmlElement( ElementName = "EMBASSY" )]
			public List<EMBASSY> Embassy { get; set; }
		}

		[XmlRoot( ElementName = "GAVOTE" )]
		public class GaVote {
			[XmlElement( ElementName = "FOR" )]
			public string For { get; set; }
			[XmlElement( ElementName = "AGAINST" )]
			public string Against { get; set; }
		}
		[XmlRoot( ElementName = "HISTORY" )]
		public class HISTORY {
			[XmlElement( ElementName = "EVENT" )]
			public List<EVENT> EVENT { get; set; }
		}
		[XmlRoot( ElementName = "MESSAGES" )]
		public class MESSAGES {
			[XmlElement( ElementName = "POST" )]
			public List<POST> Posts { get; set; }
		}
		[XmlRoot( ElementName = "POST" )]
		public class POST {
			[XmlElement( ElementName = "TIMESTAMP" )]
			public string TimeStamp { get; set; }
			[XmlElement( ElementName = "NATION" )]
			public string Nation { get; set; }
			[XmlElement( ElementName = "STATUS" )]
			public string Status { get; set; }
			[XmlElement( ElementName = "LIKES" )]
			public string Likes { get; set; }
			[XmlElement( ElementName = "MESSAGE" )]
			public string Message { get; set; }
			[XmlAttribute( AttributeName = "id" )]
			public string Id { get; set; }
			[XmlElement( ElementName = "LIKERS" )]
			public string Likers { get; set; }
			[XmlElement( ElementName = "EMBASSY" )]
			public string Embassy { get; set; }
		}

		[XmlRoot( ElementName = "OFFICER" )]
		public class OFFICER {
			[XmlElement( ElementName = "NATION" )]
			public string Nation { get; set; }
			[XmlElement( ElementName = "OFFICE" )]
			public string Office { get; set; }
			[XmlElement( ElementName = "AUTHORITY" )]
			public string Authority { get; set; }
			[XmlElement( ElementName = "TIME" )]
			public string Time { get; set; }
			[XmlElement( ElementName = "BY" )]
			public string By { get; set; }
			[XmlElement( ElementName = "ORDER" )]
			public string Order { get; set; }
		}

		[XmlRoot( ElementName = "OFFICERS" )]
		public class OFFICERS {
			[XmlElement( ElementName = "OFFICER" )]
			public List<OFFICER> Officers { get; set; }
		}
		[XmlRoot( ElementName = "SCVOTE" )]
		public class SCVOTE {
			[XmlElement( ElementName = "FOR" )]
			public string For { get; set; }
			[XmlElement( ElementName = "AGAINST" )]
			public string Against { get; set; }
		}

		[XmlRoot( ElementName = "TAGS" )]
		public class TAGS {
			[XmlElement( ElementName = "TAG" )]
			public List<string> Tags { get; set; }
		}

		[XmlRoot( ElementName = "REGION" )]
		public class REGION {
			[XmlElement( ElementName = "CENSUSRANKS" )]
			public CENSUSRANKS CensusRanks { get; set; }
			[XmlElement( ElementName = "CENSUS" )]
			public Census rCensus { get; set; }
			[XmlElement( ElementName = "DELEGATE" )]
			public string Delegate { get; set; }
			[XmlAttribute( AttributeName = "id" )]
			public string Id { get; set; }
			[XmlElement( ElementName = "DELEGATEAUTH" )]
			public string DelegateAuth { get; set; }
			[XmlElement( ElementName = "DELEGATEVOTES" )]
			public string DelegateVotes { get; set; }
			[XmlElement( ElementName = "EMBASSIES" )]
			public EMBASSIES Embassaies { get; set; }
			[XmlElement( ElementName = "EMBASSYRMB" )]
			public string EmbassyRmb { get; set; }
			[XmlElement( ElementName = "FACTBOOK" )]
			public string FactBook { get; set; }
			[XmlElement( ElementName = "FLAG" )]
			public string Flag { get; set; }
			[XmlElement( ElementName = "FOUNDED" )]
			public string Founded { get; set; }
			[XmlElement( ElementName = "FOUNDEDTIME" )]
			public string FoundedTime { get; set; }
			[XmlElement( ElementName = "FOUNDER" )]
			public string Founder { get; set; }
			[XmlElement( ElementName = "FOUNDERAUTH" )]
			public string FounderAuth { get; set; }
			[XmlElement( ElementName = "GAVOTE" )]
			public GaVote rGaVote { get; set; }
			[XmlElement( ElementName = "HAPPENINGS" )]
			public Happenings Happenings { get; set; }
			[XmlElement( ElementName = "HISTORY" )]
			public HISTORY History { get; set; }
			[XmlElement( ElementName = "MESSAGES" )]
			public MESSAGES Messages { get; set; }
			[XmlElement( ElementName = "NAME" )]
			public string Name { get; set; }
			[XmlElement(ElementName = "NATIONS")]
			public string Nations { get; set; }
			[XmlElement(ElementName = "NUMNATIONS")]
			public string NumNations { get; set; }
			[XmlElement( ElementName = "OFFICERS" )]
			public OFFICERS Officers{ get; set; }
			[XmlElement( ElementName = "POLL" )]
			public POLL Poll { get; set; }
			[XmlElement( ElementName = "SCVOTE" )]
			public SCVOTE ScVote { get; set; }
			[XmlElement( ElementName = "TAGS" )]
			public TAGS Tags{ get; set; }
			[XmlElement( ElementName = "ZOMBIE" )]
			public ZOMBIE Zombie { get; set; }

		}
	}
}
