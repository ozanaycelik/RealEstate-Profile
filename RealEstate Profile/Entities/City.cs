using System.Collections.Generic;
using System.Xml.Serialization;

namespace RealEstate_Profile.Entities
{
    [XmlRoot(ElementName = "City")]
	public class City
	{
		[XmlElement(ElementName = "Code")]
		public int Code { get; set; }

		[XmlElement(ElementName = "Name")]
		public string Name { get; set; }

		[XmlElement(ElementName = "CountryCode")]
		public string CountryCode { get; set; }
	}

	[XmlRoot(ElementName = "Cities")]
	public class Cities
	{

		[XmlElement(ElementName = "City")]
		public List<City> City { get; set; }
	}
	[XmlRoot(ElementName = "Town")]
	public class Town
	{

		[XmlElement(ElementName = "CountryCode")]
		public string CountryCode { get; set; }

		[XmlElement(ElementName = "CityCode")]
		public string CityCode { get; set; }

		[XmlElement(ElementName = "Name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "Towns")]
	public class Towns
	{

		[XmlElement(ElementName = "Town")]
		public List<Town> Town { get; set; }
	}
}
