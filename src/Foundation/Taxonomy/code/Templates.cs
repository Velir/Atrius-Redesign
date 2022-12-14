
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ReSharper disable All

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class ContentTypeItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("2dca937a-9634-4d0d-9a27-8b8d9ed3d99b");
							public static class FieldIds
		{
}

							public ContentTypeItem(Item innerItem) : base(innerItem) {}
public static implicit operator ContentTypeItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new ContentTypeItem(innerItem) : null;
	}
public static implicit operator Item(ContentTypeItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class ContentTypesItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("10a620aa-739d-448c-b0eb-f387a5287682");
							public static class FieldIds
		{
}

							public ContentTypesItem(Item innerItem) : base(innerItem) {}
public static implicit operator ContentTypesItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new ContentTypesItem(innerItem) : null;
	}
public static implicit operator Item(ContentTypesItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class LocationItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("410549bb-1134-4859-98ca-67125cee19a2");
							public static class FieldIds
		{
}

							public LocationItem(Item innerItem) : base(innerItem) {}
public static implicit operator LocationItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new LocationItem(innerItem) : null;
	}
public static implicit operator Item(LocationItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class LocationsItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("d7bbae50-0edd-4dd8-8489-97443f6e5b19");
							public static class FieldIds
		{
}

							public LocationsItem(Item innerItem) : base(innerItem) {}
public static implicit operator LocationsItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new LocationsItem(innerItem) : null;
	}
public static implicit operator Item(LocationsItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class PeopleItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("a814df8e-c530-48bd-b162-a75fea5f1e6a");
							public static class FieldIds
		{
}

							public PeopleItem(Item innerItem) : base(innerItem) {}
public static implicit operator PeopleItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new PeopleItem(innerItem) : null;
	}
public static implicit operator Item(PeopleItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class PersonItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("4c0a8d3e-48c5-4c24-8b59-8eab2ef0143a");
							public static class FieldIds
		{

			public static readonly string Description = "2423eb10-2089-4c54-85ac-02e31ccef1cf";

			public static readonly string Image = "88fb0e58-2fa9-447b-a556-0e3bbd9e5cde";

			public static readonly string FirstName = "978f1c21-f821-47d6-9245-2b986e26b2e1";

			public static readonly string LastName = "77f99da5-4928-495c-8eaf-27403ddc8ac6";

			public static readonly string MiddleName = "85e0d9a3-56a5-41d2-a624-b13a9b80f23c";

			public static readonly string Salutation = "bbc1e556-27bd-4eb0-ab98-a6fde5629b67";

			public static readonly string Suffix = "68b2e6bf-6d51-4874-b79c-b890940f3a0e";

			public static readonly string Occupation = "cc961a04-1406-4451-abe5-faeb9289ef26";
}

							public PersonItem(Item innerItem) : base(innerItem) {}
public static implicit operator PersonItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new PersonItem(innerItem) : null;
	}
public static implicit operator Item(PersonItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField Description => InnerItem.Fields[FieldIds.Description];

			public virtual ImageField Image => InnerItem.Fields[FieldIds.Image];

			public virtual TextField FirstName => InnerItem.Fields[FieldIds.FirstName];

			public virtual TextField LastName => InnerItem.Fields[FieldIds.LastName];

			public virtual TextField MiddleName => InnerItem.Fields[FieldIds.MiddleName];

			public virtual LookupField Salutation => InnerItem.Fields[FieldIds.Salutation];

			public virtual LookupField Suffix => InnerItem.Fields[FieldIds.Suffix];

			public virtual TextField Occupation => InnerItem.Fields[FieldIds.Occupation];

						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class TaxonomyFolderItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("61f2ddc5-111b-406a-af8b-e37cdc30ca8a");
							public static class FieldIds
		{
}

							public TaxonomyFolderItem(Item innerItem) : base(innerItem) {}
public static implicit operator TaxonomyFolderItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new TaxonomyFolderItem(innerItem) : null;
	}
public static implicit operator Item(TaxonomyFolderItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class TopicItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("9bbbc5f7-8322-4d98-966f-d1c3eb92bb3e");
							public static class FieldIds
		{
}

							public TopicItem(Item innerItem) : base(innerItem) {}
public static implicit operator TopicItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new TopicItem(innerItem) : null;
	}
public static implicit operator Item(TopicItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class TopicsItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("eb1141d0-72e9-4c69-91d2-4ea395f3574b");
							public static class FieldIds
		{
}

							public TopicsItem(Item innerItem) : base(innerItem) {}
public static implicit operator TopicsItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new TopicsItem(innerItem) : null;
	}
public static implicit operator Item(TopicsItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _AgeBaseItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("01c8443e-71f4-4dc0-87fe-dc0ab6b18eb0");
							public static class FieldIds
		{

			public static readonly string Age = "0cdf6c63-6c8b-4203-9077-207cd6694813";
}

							public _AgeBaseItem(Item innerItem) : base(innerItem) {}
public static implicit operator _AgeBaseItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _AgeBaseItem(innerItem) : null;
	}
public static implicit operator Item(_AgeBaseItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual Field Age => InnerItem.Fields[FieldIds.Age];

						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _ContactBaseItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("95cb8785-255d-4c7e-be48-b040264938f2");
							public static class FieldIds
		{

			public static readonly string Address1 = "d134c2cd-48d2-4045-98d8-7639f20b5dad";

			public static readonly string Address2 = "5e374cf3-f6b2-4a2e-a73e-44aaaa145fcf";

			public static readonly string City = "0001c858-31af-4b4b-ab86-7a1ff3e4414f";

			public static readonly string Email = "5ec74ffc-2f8a-4540-b945-ef2f74234a5a";

			public static readonly string Phone = "7512d3c1-c222-4e26-ab75-1d2575a05cf9";

			public static readonly string State = "d0230198-ef80-4d21-a324-1b56852e44ed";

			public static readonly string ZipCode = "961d7653-407a-4fb1-a7ff-e17723fd4cc8";
}

							public _ContactBaseItem(Item innerItem) : base(innerItem) {}
public static implicit operator _ContactBaseItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _ContactBaseItem(innerItem) : null;
	}
public static implicit operator Item(_ContactBaseItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField Address1 => InnerItem.Fields[FieldIds.Address1];

			public virtual TextField Address2 => InnerItem.Fields[FieldIds.Address2];

			public virtual TextField City => InnerItem.Fields[FieldIds.City];

			public virtual TextField Email => InnerItem.Fields[FieldIds.Email];

			public virtual TextField Phone => InnerItem.Fields[FieldIds.Phone];

			public virtual LookupField State => InnerItem.Fields[FieldIds.State];

			public virtual TextField ZipCode => InnerItem.Fields[FieldIds.ZipCode];

						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _ContentTypeBaseItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("0b715d4d-34e3-4cc6-ad5f-1cde18ede95d");
							public static class FieldIds
		{

			public static readonly string ContentType = "d7b9c27c-79e3-42a7-9b46-bff652ef0981";
}

							public _ContentTypeBaseItem(Item innerItem) : base(innerItem) {}
public static implicit operator _ContentTypeBaseItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _ContentTypeBaseItem(innerItem) : null;
	}
public static implicit operator Item(_ContentTypeBaseItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual LookupField ContentType => InnerItem.Fields[FieldIds.ContentType];

						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _GenderBaseItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("0901baea-4e2a-4a81-89e5-964b6e80230f");
							public static class FieldIds
		{

			public static readonly string Gender = "b90b5ae1-4520-45f3-862e-7a2a69643183";
}

							public _GenderBaseItem(Item innerItem) : base(innerItem) {}
public static implicit operator _GenderBaseItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _GenderBaseItem(innerItem) : null;
	}
public static implicit operator Item(_GenderBaseItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual LookupField Gender => InnerItem.Fields[FieldIds.Gender];

						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _LocationBaseItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("ddee891f-6247-4f90-8f7f-aff0c8c3c89d");
							public static class FieldIds
		{

			public static readonly string Locations = "7928f523-5727-4843-ba3d-60874d4e6f6b";
}

							public _LocationBaseItem(Item innerItem) : base(innerItem) {}
public static implicit operator _LocationBaseItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _LocationBaseItem(innerItem) : null;
	}
public static implicit operator Item(_LocationBaseItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual MultilistField Locations => InnerItem.Fields[FieldIds.Locations];

						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _NameBaseItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("7137b868-ee08-4e39-910d-5ca8ee58ebd7");
							public static class FieldIds
		{

			public static readonly string FirstName = "978f1c21-f821-47d6-9245-2b986e26b2e1";

			public static readonly string LastName = "77f99da5-4928-495c-8eaf-27403ddc8ac6";

			public static readonly string MiddleName = "85e0d9a3-56a5-41d2-a624-b13a9b80f23c";

			public static readonly string Salutation = "bbc1e556-27bd-4eb0-ab98-a6fde5629b67";

			public static readonly string Suffix = "68b2e6bf-6d51-4874-b79c-b890940f3a0e";
}

							public _NameBaseItem(Item innerItem) : base(innerItem) {}
public static implicit operator _NameBaseItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _NameBaseItem(innerItem) : null;
	}
public static implicit operator Item(_NameBaseItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField FirstName => InnerItem.Fields[FieldIds.FirstName];

			public virtual TextField LastName => InnerItem.Fields[FieldIds.LastName];

			public virtual TextField MiddleName => InnerItem.Fields[FieldIds.MiddleName];

			public virtual LookupField Salutation => InnerItem.Fields[FieldIds.Salutation];

			public virtual LookupField Suffix => InnerItem.Fields[FieldIds.Suffix];

						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _OccupationBaseItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("62175606-0ba7-427e-ab34-a2f859a31a26");
							public static class FieldIds
		{

			public static readonly string Occupation = "cc961a04-1406-4451-abe5-faeb9289ef26";
}

							public _OccupationBaseItem(Item innerItem) : base(innerItem) {}
public static implicit operator _OccupationBaseItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _OccupationBaseItem(innerItem) : null;
	}
public static implicit operator Item(_OccupationBaseItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField Occupation => InnerItem.Fields[FieldIds.Occupation];

						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _PeopleBaseItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("958038af-b23a-4f67-bbf7-879e709d83d2");
							public static class FieldIds
		{

			public static readonly string People = "bef10252-ea97-4433-a7e3-d924796e3950";
}

							public _PeopleBaseItem(Item innerItem) : base(innerItem) {}
public static implicit operator _PeopleBaseItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _PeopleBaseItem(innerItem) : null;
	}
public static implicit operator Item(_PeopleBaseItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual MultilistField People => InnerItem.Fields[FieldIds.People];

						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _TaxonomyBaseItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("2507ca55-c349-4c83-85c6-13db1d6a5428");
							public static class FieldIds
		{

			public static readonly string ContentType = "d7b9c27c-79e3-42a7-9b46-bff652ef0981";

			public static readonly string Topics = "027f5e1e-d0e5-4afd-9b7a-90a563504d47";

			public static readonly string Locations = "7928f523-5727-4843-ba3d-60874d4e6f6b";

			public static readonly string People = "bef10252-ea97-4433-a7e3-d924796e3950";
}

							public _TaxonomyBaseItem(Item innerItem) : base(innerItem) {}
public static implicit operator _TaxonomyBaseItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _TaxonomyBaseItem(innerItem) : null;
	}
public static implicit operator Item(_TaxonomyBaseItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual LookupField ContentType => InnerItem.Fields[FieldIds.ContentType];

			public virtual MultilistField Topics => InnerItem.Fields[FieldIds.Topics];

			public virtual MultilistField Locations => InnerItem.Fields[FieldIds.Locations];

			public virtual MultilistField People => InnerItem.Fields[FieldIds.People];

						}
					}
				

					namespace Thread.Foundation.Taxonomy
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _TopicBaseItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("d8017f32-92a9-44f2-b461-1c38d7a5d75d");
							public static class FieldIds
		{

			public static readonly string Topics = "027f5e1e-d0e5-4afd-9b7a-90a563504d47";
}

							public _TopicBaseItem(Item innerItem) : base(innerItem) {}
public static implicit operator _TopicBaseItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _TopicBaseItem(innerItem) : null;
	}
public static implicit operator Item(_TopicBaseItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual MultilistField Topics => InnerItem.Fields[FieldIds.Topics];

						}
					}
				







// Thread.Foundation.Taxonomy.Content_Type (/sitecore/templates/Foundation/Taxonomy/Items/Content Type 2dca937a-9634-4d0d-9a27-8b8d9ed3d99b)

// Thread.Foundation.Taxonomy.Content_Types (/sitecore/templates/Foundation/Taxonomy/Folders/Content Types 10a620aa-739d-448c-b0eb-f387a5287682)

// Thread.Foundation.Taxonomy.Location (/sitecore/templates/Foundation/Taxonomy/Items/Location 410549bb-1134-4859-98ca-67125cee19a2)

// Thread.Foundation.Taxonomy.Locations (/sitecore/templates/Foundation/Taxonomy/Folders/Locations d7bbae50-0edd-4dd8-8489-97443f6e5b19)

// Thread.Foundation.Taxonomy.People (/sitecore/templates/Foundation/Taxonomy/Folders/People a814df8e-c530-48bd-b162-a75fea5f1e6a)

// Thread.Foundation.Taxonomy.Person (/sitecore/templates/Foundation/Taxonomy/Items/Person 4c0a8d3e-48c5-4c24-8b59-8eab2ef0143a)
	// Description (2423eb10-2089-4c54-85ac-02e31ccef1cf)
		// Type: Multi-Line Text
		// Section: Text
		// Sort Order: 100
		// Source: 
	// Image (88fb0e58-2fa9-447b-a556-0e3bbd9e5cde)
		// Type: Image
		// Section: Image
		// Sort Order: 100
		// Source: 

// Thread.Foundation.Taxonomy.Taxonomy_Folder (/sitecore/templates/Foundation/Taxonomy/Folders/Taxonomy Folder 61f2ddc5-111b-406a-af8b-e37cdc30ca8a)

// Thread.Foundation.Taxonomy.Topic (/sitecore/templates/Foundation/Taxonomy/Items/Topic 9bbbc5f7-8322-4d98-966f-d1c3eb92bb3e)

// Thread.Foundation.Taxonomy.Topics (/sitecore/templates/Foundation/Taxonomy/Folders/Topics eb1141d0-72e9-4c69-91d2-4ea395f3574b)

// Thread.Foundation.Taxonomy._Age_Base (/sitecore/templates/Foundation/Taxonomy/Base/_Age Base 01c8443e-71f4-4dc0-87fe-dc0ab6b18eb0)
	// Age (0cdf6c63-6c8b-4203-9077-207cd6694813)
		// Type: Integer
		// Section: Personal Details
		// Sort Order: 100
		// Source: 

// Thread.Foundation.Taxonomy._Contact_Base (/sitecore/templates/Foundation/Taxonomy/Base/_Contact Base 95cb8785-255d-4c7e-be48-b040264938f2)
	// Address_1 (d134c2cd-48d2-4045-98d8-7639f20b5dad)
		// Type: Single-Line Text
		// Section: Contact Details
		// Sort Order: 300
		// Source: 
	// Address_2 (5e374cf3-f6b2-4a2e-a73e-44aaaa145fcf)
		// Type: Single-Line Text
		// Section: Contact Details
		// Sort Order: 400
		// Source: 
	// City (0001c858-31af-4b4b-ab86-7a1ff3e4414f)
		// Type: Single-Line Text
		// Section: Contact Details
		// Sort Order: 500
		// Source: 
	// Email (5ec74ffc-2f8a-4540-b945-ef2f74234a5a)
		// Type: Single-Line Text
		// Section: Contact Details
		// Sort Order: 100
		// Source: 
	// Phone (7512d3c1-c222-4e26-ab75-1d2575a05cf9)
		// Type: Single-Line Text
		// Section: Contact Details
		// Sort Order: 200
		// Source: 
	// State (d0230198-ef80-4d21-a324-1b56852e44ed)
		// Type: Droplink
		// Section: Contact Details
		// Sort Order: 600
		// Source: 
	// Zip_Code (961d7653-407a-4fb1-a7ff-e17723fd4cc8)
		// Type: Single-Line Text
		// Section: Contact Details
		// Sort Order: 700
		// Source: 

// Thread.Foundation.Taxonomy._Content_Type_Base (/sitecore/templates/Foundation/Taxonomy/Base/_Content Type Base 0b715d4d-34e3-4cc6-ad5f-1cde18ede95d)
	// Content_Type (d7b9c27c-79e3-42a7-9b46-bff652ef0981)
		// Type: Droplink
		// Section: Taxonomy
		// Sort Order: 100
		// Source: query:ancestor-or-self::*[@@name='Home']/Taxonomy/Content Types/*

// Thread.Foundation.Taxonomy._Gender_Base (/sitecore/templates/Foundation/Taxonomy/Base/_Gender Base 0901baea-4e2a-4a81-89e5-964b6e80230f)
	// Gender (b90b5ae1-4520-45f3-862e-7a2a69643183)
		// Type: Droplink
		// Section: Personal Details
		// Sort Order: 100
		// Source: 

// Thread.Foundation.Taxonomy._Location_Base (/sitecore/templates/Foundation/Taxonomy/Base/_Location Base ddee891f-6247-4f90-8f7f-aff0c8c3c89d)
	// Locations (7928f523-5727-4843-ba3d-60874d4e6f6b)
		// Type: Multilist with Search
		// Section: Taxonomy
		// Sort Order: 100
		// Source: StartSearchLocation=query:ancestor-or-self::*[@@templateid->'{98AC8506-0017-4964-81A9-19B76FA9EE98}']&Filter=+_templatename:Location

// Thread.Foundation.Taxonomy._Name_Base (/sitecore/templates/Foundation/Taxonomy/Base/_Name Base 7137b868-ee08-4e39-910d-5ca8ee58ebd7)
	// First_Name (978f1c21-f821-47d6-9245-2b986e26b2e1)
		// Type: Single-Line Text
		// Section: Personal Details
		// Sort Order: 200
		// Source: 
	// Last_Name (77f99da5-4928-495c-8eaf-27403ddc8ac6)
		// Type: Single-Line Text
		// Section: Personal Details
		// Sort Order: 300
		// Source: 
	// Middle_Name (85e0d9a3-56a5-41d2-a624-b13a9b80f23c)
		// Type: Single-Line Text
		// Section: Personal Details
		// Sort Order: 400
		// Source: 
	// Salutation (bbc1e556-27bd-4eb0-ab98-a6fde5629b67)
		// Type: Droplink
		// Section: Personal Details
		// Sort Order: 100
		// Source: query:ancestor-or-self::*[@@templateid='{98AC8506-0017-4964-81A9-19B76FA9EE98}']/Configuration/Enumerations/Salutation/*
	// Suffix (68b2e6bf-6d51-4874-b79c-b890940f3a0e)
		// Type: Droplink
		// Section: Personal Details
		// Sort Order: 500
		// Source: query:ancestor-or-self::*[@@templateid='{98AC8506-0017-4964-81A9-19B76FA9EE98}']/Configuration/Enumerations/Suffix/*

// Thread.Foundation.Taxonomy._Occupation_Base (/sitecore/templates/Foundation/Taxonomy/Base/_Occupation Base 62175606-0ba7-427e-ab34-a2f859a31a26)
	// Occupation (cc961a04-1406-4451-abe5-faeb9289ef26)
		// Type: Single-Line Text
		// Section: Personal Details
		// Sort Order: 100
		// Source: 

// Thread.Foundation.Taxonomy._People_Base (/sitecore/templates/Foundation/Taxonomy/Base/_People Base 958038af-b23a-4f67-bbf7-879e709d83d2)
	// People (bef10252-ea97-4433-a7e3-d924796e3950)
		// Type: Multilist with Search
		// Section: Taxonomy
		// Sort Order: 100
		// Source: StartSearchLocation=query:ancestor-or-self::*[@@templateid->'{98AC8506-0017-4964-81A9-19B76FA9EE98}']&Filter=+_templatename:Person

// Thread.Foundation.Taxonomy._Taxonomy_Base (/sitecore/templates/Foundation/Taxonomy/Base/_Taxonomy Base 2507ca55-c349-4c83-85c6-13db1d6a5428)

// Thread.Foundation.Taxonomy._Topic_Base (/sitecore/templates/Foundation/Taxonomy/Base/_Topic Base d8017f32-92a9-44f2-b461-1c38d7a5d75d)
	// Topics (027f5e1e-d0e5-4afd-9b7a-90a563504d47)
		// Type: Multilist with Search
		// Section: Taxonomy
		// Sort Order: 100
		// Source: StartSearchLocation=query:ancestor-or-self::*[@@templateid->'{98AC8506-0017-4964-81A9-19B76FA9EE98}']&Filter=+_templatename:Topic

