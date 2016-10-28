using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationStates.XmlResponses {
	class NationXmlResponse {
		[XmlRoot( ElementName = "FREEDOM" )]
		public class FREEDOM {
			[XmlElement( ElementName = "CIVILRIGHTS" )]
			public string CivilRights { get; set; }
			[XmlElement( ElementName = "ECONOMY" )]
			public string Economy { get; set; }
			[XmlElement( ElementName = "POLITICALFREEDOM" )]
			public string PoliticalFreedom { get; set; }
		}

		[XmlRoot( ElementName = "LEGISLATION" )]
		public class LEGISLATION {
			[XmlElement( ElementName = "LAW" )]
			public List<string> Law { get; set; }
		}

		[XmlRoot( ElementName = "SECTORS" )]
		public class SECTORS {
			[XmlElement( ElementName = "BLACKMARKET" )]
			public string BlackMarket { get; set; }
			[XmlElement( ElementName = "GOVERNMENT" )]
			public string GovernMent { get; set; }
			[XmlElement( ElementName = "INDUSTRY" )]
			public string Industry{ get; set; }
			[XmlElement( ElementName = "PUBLIC" )]
			public string Public { get; set; }
		}

		[XmlRoot( ElementName = "GOVT" )]
		public class GOVT {
			[XmlElement( ElementName = "ADMINISTRATION" )]
			public string Administration { get; set; }
			[XmlElement( ElementName = "DEFENCE" )]
			public string Defence { get; set; }
			[XmlElement( ElementName = "EDUCATION" )]
			public string Education { get; set; }
			[XmlElement( ElementName = "ENVIRONMENT" )]
			public string Environment { get; set; }
			[XmlElement( ElementName = "HEALTHCARE" )]
			public string HealthCare { get; set; }
			[XmlElement( ElementName = "COMMERCE" )]
			public string Commerce { get; set; }
			[XmlElement( ElementName = "INTERNATIONALAID" )]
			public string InternationalAid { get; set; }
			[XmlElement( ElementName = "LAWANDORDER" )]
			public string LawAndOrder { get; set; }
			[XmlElement( ElementName = "PUBLICTRANSPORT" )]
			public string PublicTransport { get; set; }
			[XmlElement( ElementName = "SOCIALEQUALITY" )]
			public string SocialEquality { get; set; }
			[XmlElement( ElementName = "SPIRITUALITY" )]
			public string Spirituality { get; set; }
			[XmlElement( ElementName = "WELFARE" )]
			public string Welfare { get; set; }
		}

		[XmlRoot( ElementName = "FREEDOMSCORES" )]
		public class FREEDOMSCORES {
			[XmlElement( ElementName = "CIVILRIGHTS" )]
			public string CivilRights { get; set; }
			[XmlElement( ElementName = "ECONOMY" )]
			public string Economy { get; set; }
			[XmlElement( ElementName = "POLITICALFREEDOM" )]
			public string PoliticalFreedom { get; set; }
		}

		[XmlRoot( ElementName = "CAUSE" )]
		public class CAUSE {
			[XmlAttribute( AttributeName = "type" )]
			public string Type { get; set; }
			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot( ElementName = "DEATHS" )]
		public class DEATHS {
			[XmlElement( ElementName = "CAUSE" )]
			public List<CAUSE> Causes { get; set; }
		}

		[XmlRoot( ElementName = "BANNERS" )]
		public class BANNERS {
			[XmlElement( ElementName = "BANNER" )]
			public List<string> Banners { get; set; }
		}

		[XmlRoot( ElementName = "NATION" )]
		public class NATION {
			[XmlElement( ElementName = "ADMIRABLE" )]
			public string Admirable { get; set; }
			[XmlElement( ElementName = "ANIMAL" )]
			public string Animal { get; set; }
			[XmlElement( ElementName = "ANIMALTRAIT" )]
			public string AnimalTrait { get; set; }
			[XmlElement( ElementName = "BANNERS" )]
			public BANNERS Banners { get; set; }
			[XmlElement( ElementName = "CRIME" )]
			public string Crime { get; set; }
			[XmlElement( ElementName = "DISPATCHES" )]
			public string Dispatches { get; set; }
			[XmlElement( ElementName = "DISPATCHLIST" )]
			public DISPATCHLIST DispatchList { get; set; }
			[XmlElement( ElementName = "ENDORSEMENTS" )]
			public string Endorsements { get; set; }
			[XmlElement( ElementName = "FACTBOOKS" )]
			public string Factbooks { get; set; }
			[XmlElement( ElementName = "FACTBOOKLIST" )]
			public string FactbookList { get; set; }
			[XmlElement( ElementName = "NAME" )]
			public string Name { get; set; }
			[XmlElement( ElementName = "GAVOTE" )]
			public string GaVote { get; set; }
			[XmlElement( ElementName = "GDP" )]
			public string GDP { get; set; }
			[XmlElement( ElementName = "TYPE" )]
			public string Type { get; set; }
			[XmlElement( ElementName = "FULLNAME" )]
			public string FullName { get; set; }
			[XmlElement( ElementName = "MOTTO" )]
			public string Motto { get; set; }
			[XmlElement( ElementName = "CATEGORY" )]
			public string Category { get; set; }
			[XmlElement( ElementName = "UNSTATUS" )]
			public string UnStatus { get; set; }
			[XmlElement( ElementName = "FREEDOM" )]
			public FREEDOM Freedom { get; set; }
			[XmlElement( ElementName = "REGION" )]
			public string Region { get; set; }
			[XmlElement( ElementName = "POPULATION" )]
			public string Population { get; set; }
			[XmlElement( ElementName = "TAX" )]
			public string Tax { get; set; }
			[XmlElement( ElementName = "CURRENCY" )]
			public string Currency { get; set; }
			[XmlElement( ElementName = "DEMONYM" )]
			public string Demonym { get; set; }
			[XmlElement( ElementName = "DEMONYM2" )]
			public string Demonym2 { get; set; }
			[XmlElement( ElementName = "DEMONYM2PLURAL" )]
			public string Demonym2Plural { get; set; }
			[XmlElement( ElementName = "FLAG" )]
			public string Flag { get; set; }
			[XmlElement( ElementName = "MAJORINDUSTRY" )]
			public string MajorIndustry { get; set; }
			[XmlElement( ElementName = "GOVTPRIORITY" )]
			public string GovtPriority { get; set; }
			[XmlElement( ElementName = "GOVT" )]
			public GOVT Govt { get; set; }
			[XmlElement( ElementName = "FOUNDED" )]
			public string Founded { get; set; }
			[XmlElement( ElementName = "FIRSTLOGIN" )]
			public string FirstLogin { get; set; }
			[XmlElement( ElementName = "LASTLOGIN" )]
			public string LastLogin { get; set; }
			[XmlElement( ElementName = "LASTACTIVITY" )]
			public string LastActivity { get; set; }
			[XmlElement( ElementName = "INFLUENCE" )]
			public string Influence { get; set; }
			[XmlElement( ElementName = "FREEDOMSCORES" )]
			public FREEDOMSCORES FreedomScores { get; set; }
			[XmlElement( ElementName = "PUBLICSECTOR" )]
			public string PublicSector { get; set; }
			[XmlElement( ElementName = "DEATHS" )]
			public DEATHS Deaths { get; set; }
			[XmlElement( ElementName = "LEADER" )]
			public string Leader { get; set; }
			[XmlElement( ElementName = "CAPITAL" )]
			public string Captial { get; set; }
			[XmlElement( ElementName = "RELIGION" )]
			public string Religion { get; set; }
			[XmlElement( ElementName = "GOVTDESC" )]
			public string GovtDesc { get; set; }
			[XmlElement( ElementName = "HAPPENINGS" )]
			public HAPPENINGS Happenings { get; set; }
			[XmlElement( ElementName = "INCOME" )]
			public string Income { get; set; }
			[XmlElement( ElementName = "INDUSTRYDESC" )]
			public string IndustryDesc { get; set; }
			[XmlElement( ElementName = "LEGISLATION" )]
			public LEGISLATION Legislation { get; set; }
			[XmlElement( ElementName = "NOTABLE" )]
			public string Notable { get; set; }
			[XmlElement( ElementName = "POOREST" )]
			public string Poorest { get; set; }
			[XmlElement( ElementName = "RICHEST" )]
			public string Richest { get; set; }
			[XmlElement (ElementName ="RCENSUS")]
			public string RCensus { get; set; }
			[XmlElement (ElementName ="SCVOTE")]
			public string SCVote { get; set; }
			[XmlElement(ElementName = "SECTORS")]
			public SECTORS Sectors { get; set; }
			[XmlElement( ElementName = "SENSIBILITIES" )]
			public string Sensibilities { get; set; }
			[XmlElement(ElementName = "TGCANRECRUIT")]
			public string TgCanRecruit { get; set; }
			[XmlElement ( ElementName ="TGCANCAMPAIGN")]
			public string TgCanCampaign { get; set; }
			[XmlElement (ElementName = "WA")]
			public string WA { get; set; }
			[XmlElement (ElementName = "WCENSUS")]
			public string WCensus { get; set; }
			[XmlElement (ElementName = "ZOMBIE")]
			public ZOMBIE Zombie { get; set; }
		}
	}
}

