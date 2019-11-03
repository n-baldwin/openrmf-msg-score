using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace openrmf_msg_score.Models
{

    // this matches the VULN XML sections in the Checklist CKL file
    public class VULN {

        public VULN (){
            STIG_DATA = new List<STIG_DATA>();
        }

        [XmlElement("STIG_DATA")]
        public List<STIG_DATA> STIG_DATA { get; set;}
		public string STATUS { get; set;}
		public string FINDING_DETAILS { get; set;}
		public string COMMENTS { get; set;}
		public string SEVERITY_OVERRIDE { get; set;}
		public string SEVERITY_JUSTIFICATION { get; set;}
    }
}