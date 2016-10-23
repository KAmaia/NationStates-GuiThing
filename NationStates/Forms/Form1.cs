using System;
using System.Net;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NationStates.XmlResponses;

namespace NationStates {
	public partial class Nationstates : Form {
		public Nationstates( ) {
			InitializeComponent( );
		}

		private void btn_getHappenings_Click( object sender, EventArgs e ) {
			HttpWebRequest happeningsRequest = (HttpWebRequest) WebRequest.Create("http://www.nationstates.net/cgi-bin/api.cgi?q=happenings");
			happeningsRequest.UserAgent = "irnix@post.com";
			WebResponse happeningsResponse = happeningsRequest.GetResponse();
			XmlSerializer serial = new XmlSerializer(typeof(WORLD));
			string xmlDoc = new StreamReader(happeningsResponse.GetResponseStream()).ReadToEnd();
			
			WORLD w;
			w = (WORLD) serial.Deserialize( new StringReader(xmlDoc) ) as WORLD;
			
			foreach (EVENT happening in w.Happenings.Events ) {
				StringBuilder sb = new StringBuilder();
				sb.AppendLine( "============" );
				sb.Append( "Event ID: " );
				sb.Append( happening.Id );
				sb.AppendLine( );
				sb.Append( happening.TimeStamp );
				sb.AppendLine( );
				sb.Append( happening.Text );
				sb.AppendLine( );
				txt_result.Text += sb.ToString( );
			}
		}

		
	}
}
