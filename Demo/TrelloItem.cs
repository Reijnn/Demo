using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class TrelloItem
	{
		public string id { get; set; }
		public string name { get; set; }
		public string desc { get; set; }
		public object descData { get; set; }
		public bool closed { get; set; }
		public object idOrganization { get; set; }
		public bool pinned { get; set; }
		public string url { get; set; }
		public string shortUrl { get; set; }
		public Prefs prefs { get; set; }
		public Labelnames labelNames { get; set; }
		public Card[] cards { get; set; }
		public List[] lists { get; set; }
	}

	public class Prefs
	{
		public string permissionLevel { get; set; }
		public string voting { get; set; }
		public string comments { get; set; }
		public string invitations { get; set; }
		public bool selfJoin { get; set; }
		public bool cardCovers { get; set; }
		public string cardAging { get; set; }
		public bool calendarFeedEnabled { get; set; }
		public string background { get; set; }
		public object backgroundImage { get; set; }
		public object backgroundImageScaled { get; set; }
		public bool backgroundTile { get; set; }
		public string backgroundBrightness { get; set; }
		public string backgroundColor { get; set; }
		public bool canBePublic { get; set; }
		public bool canBeOrg { get; set; }
		public bool canBePrivate { get; set; }
		public bool canInvite { get; set; }
	}

	public class Labelnames
	{
		public string green { get; set; }
		public string yellow { get; set; }
		public string orange { get; set; }
		public string red { get; set; }
		public string purple { get; set; }
		public string blue { get; set; }
		public string sky { get; set; }
		public string lime { get; set; }
		public string pink { get; set; }
		public string black { get; set; }
	}

	public class Card
	{
		public string id { get; set; }
		public object checkItemStates { get; set; }
		public bool closed { get; set; }
		public DateTime dateLastActivity { get; set; }
		public string desc { get; set; }
		public object descData { get; set; }
		public string idBoard { get; set; }
		public string idList { get; set; }
		public object[] idMembersVoted { get; set; }
		public int idShort { get; set; }
		public object idAttachmentCover { get; set; }
		public bool manualCoverAttachment { get; set; }
		public object[] idLabels { get; set; }
		public string name { get; set; }
		public int pos { get; set; }
		public string shortLink { get; set; }
		public Badges badges { get; set; }
		public bool dueComplete { get; set; }
		public object due { get; set; }
		public object[] idChecklists { get; set; }
		public object[] idMembers { get; set; }
		public object[] labels { get; set; }
		public string shortUrl { get; set; }
		public bool subscribed { get; set; }
		public string url { get; set; }
	}

	public class Badges
	{
		public int votes { get; set; }
		public bool viewingMemberVoted { get; set; }
		public bool subscribed { get; set; }
		public string fogbugz { get; set; }
		public int checkItems { get; set; }
		public int checkItemsChecked { get; set; }
		public int comments { get; set; }
		public int attachments { get; set; }
		public bool description { get; set; }
		public object due { get; set; }
		public bool dueComplete { get; set; }
	}

	public class List
	{
		public string id { get; set; }
		public string name { get; set; }
		public bool closed { get; set; }
		public string idBoard { get; set; }
		public int pos { get; set; }
		public object subscribed { get; set; }
	}
}