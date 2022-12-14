using NUnit.Framework;
using Sitecore.Data;
using Sitecore.FakeDb;
using Thread.Feature.Events.Services;
using Thread.Foundation.Enumerations;

namespace Thread.Feature.Events.Tests.Services
{
	[TestFixture]
	public class MapQuestServiceTests
	{
		private Db _db;
		private IEventMappable _mapService;

		[SetUp]
		public void SetUp()
		{
			ID stateId = ID.NewID;
			_db = new Db("web")
			{
				new DbTemplate(_EventDetailsItem.TemplateId) { Fields = { _EventDetailsItem.FieldIds.State,_EventDetailsItem.FieldIds.Address1, _EventDetailsItem.FieldIds.Address2, _EventDetailsItem.FieldIds.City, _EventDetailsItem.FieldIds.ZipCode }},
				new DbTemplate(StateItem.TemplateId) { Fields = { StateItem.FieldIds.Value }},
				new DbItem("Event Item", ID.NewID, _EventDetailsItem.TemplateId)
				{
					{_EventDetailsItem.FieldIds.Address1, "212 Elm St" },
					{ _EventDetailsItem.FieldIds.City, "Somerville" },
					{_EventDetailsItem.FieldIds.State, stateId.ToString() },
					{_EventDetailsItem.FieldIds.ZipCode, "02144" }
				},
				new DbItem("MA", stateId, StateItem.TemplateId)
				{
					{ StateItem.FieldIds.Value, "MA" }
				}
			};

			_mapService = new MapQuestService();
		}

		[TearDown]
		public void TearDown()
		{
			_db.Dispose();
		}

		[Test]
		public void GetEmbeddableMapLink_Address_ReturnsMapLink()
		{
			_EventDetailsItem location = _db.GetItem("/sitecore/content/Event Item");

			Assert.AreEqual("https://www.mapquest.com/embed/us/ma/somerville/02144/212-elm-st?zoom=15&maptype=map", _mapService.GetEmbeddableMapLink(location));
		}

		[Test]
		public void GetEmbeddableMapLink_AddressIsNull_ReturnsNull()
		{
			Assert.IsNull(_mapService.GetEmbeddableMapLink(null));
		}
	}
}
