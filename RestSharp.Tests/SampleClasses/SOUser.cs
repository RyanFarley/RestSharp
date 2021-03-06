﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestSharp.Tests.SampleClasses
{
	public class SOUser
	{
		public int Id { get; set; }
		public int Reputation { get; set; }
		public string CreationDate { get; set; }
		public string DisplayName { get; set; }
		public string EmailHash { get; set; }
		public string Age { get; set; }
		public string LastAccessDate { get; set; }
		public string WebsiteUrl { get; set; }
		public string Location { get; set; }
		public string AboutMe { get; set; }
		public int Views { get; set; }
		public int UpVotes { get; set; }
		public int DownVotes { get; set; }
	}
}
