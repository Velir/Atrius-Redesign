
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

					namespace Thread.Feature.Promo
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class DynamicPromoItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("e1d1f8d7-36d5-4c92-a3e4-697127688f65");
							public static class FieldIds
		{

			public static readonly string Feature = "c55982ce-712e-4749-9be0-4851d12efe0d";
}

							public DynamicPromoItem(Item innerItem) : base(innerItem) {}
public static implicit operator DynamicPromoItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new DynamicPromoItem(innerItem) : null;
	}
public static implicit operator Item(DynamicPromoItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual LookupField Feature => InnerItem.Fields[FieldIds.Feature];

						}
					}
				

					namespace Thread.Feature.Promo
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class MultiPromoItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("e822a1e9-d502-463d-b38c-fdb84b3afabf");
							public static class FieldIds
		{

			public static readonly string Title = "e5a0df4d-4b8a-4fc5-b1b0-45962fe22b5a";
}

							public MultiPromoItem(Item innerItem) : base(innerItem) {}
public static implicit operator MultiPromoItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new MultiPromoItem(innerItem) : null;
	}
public static implicit operator Item(MultiPromoItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField Title => InnerItem.Fields[FieldIds.Title];

						}
					}
				

					namespace Thread.Feature.Promo
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class PromoItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("4dee566f-614c-4a89-8f0b-00f4b04beab9");
							public static class FieldIds
		{

			public static readonly string Description = "62ae03c9-f72c-4f43-9537-83f0f2c9616b";

			public static readonly string Image = "6b9e0b00-03c3-47e2-8b0f-8f5db2176d7d";

			public static readonly string Link = "198478f8-0191-446b-aa46-d770b540a2e3";

			public static readonly string Subtitle = "4d17936d-369e-4156-9308-abe4388454da";

			public static readonly string Title = "72c1bf85-d4e0-4c4a-822d-174391e1333e";

			public static readonly string ContentType = "d7b9c27c-79e3-42a7-9b46-bff652ef0981";
}

							public PromoItem(Item innerItem) : base(innerItem) {}
public static implicit operator PromoItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new PromoItem(innerItem) : null;
	}
public static implicit operator Item(PromoItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField Description => InnerItem.Fields[FieldIds.Description];

			public virtual ImageField Image => InnerItem.Fields[FieldIds.Image];

			public virtual LinkField Link => InnerItem.Fields[FieldIds.Link];

			public virtual TextField Subtitle => InnerItem.Fields[FieldIds.Subtitle];

			public virtual TextField Title => InnerItem.Fields[FieldIds.Title];

			public virtual LookupField ContentType => InnerItem.Fields[FieldIds.ContentType];

						}
					}
				

					namespace Thread.Feature.Promo
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class PullQuoteItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("755f251c-81ed-490c-81ae-c05dd3f6bd2f");
							public static class FieldIds
		{

			public static readonly string Company = "f5157f10-b660-40bf-9f93-ecefc38ca4cf";

			public static readonly string JobTitle = "372a8116-9d83-48a7-9539-fee6f2ae4920";

			public static readonly string Name = "058a56b2-57f9-448d-a9f7-3507ee1020ac";

			public static readonly string Quote = "be6dd7a7-ef9f-4ea9-b1d1-6c520cc7db1d";
}

							public PullQuoteItem(Item innerItem) : base(innerItem) {}
public static implicit operator PullQuoteItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new PullQuoteItem(innerItem) : null;
	}
public static implicit operator Item(PullQuoteItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField Company => InnerItem.Fields[FieldIds.Company];

			public virtual TextField JobTitle => InnerItem.Fields[FieldIds.JobTitle];

			public virtual TextField Name => InnerItem.Fields[FieldIds.Name];

			public virtual TextField Quote => InnerItem.Fields[FieldIds.Quote];

						}
					}
				





					namespace Thread.Feature.Promo
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
						using Sitecore.Mvc.Presentation;
						using Thread.Foundation.Orm;

						public partial class DynamicPromoRenderingParameters : ThreadRenderingParameters
						{
							public static class Fields
		{

			public static string DisplayContentTypeLabel = "Display Content Type Label";

			public static string DisplayLink = "Display Link";

			public static string DisplaySubtitle = "Display Subtitle";

			public static string DisplaySummary = "Display Summary";

			public static string ImageFormat = "Image Format";

			public static string ImageOrientation = "Image Orientation";
}

							public DynamicPromoRenderingParameters() : base(string.Empty) {}
public DynamicPromoRenderingParameters(string parametersAsQueryString) : base(parametersAsQueryString) {}

							
				public virtual bool DisplayContentTypeLabel => GetBoolValue(Fields.DisplayContentTypeLabel);

				public virtual bool DisplayLink => GetBoolValue(Fields.DisplayLink);

				public virtual bool DisplaySubtitle => GetBoolValue(Fields.DisplaySubtitle);

				public virtual bool DisplaySummary => GetBoolValue(Fields.DisplaySummary);

				public virtual Thread.Foundation.Enumerations.RatioItem ImageFormat => GetItemValue(Fields.ImageFormat);

				public virtual Thread.Foundation.Enumerations.OrientationItem ImageOrientation => GetItemValue(Fields.ImageOrientation);

						}
					}
				

					namespace Thread.Feature.Promo
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
						using Sitecore.Mvc.Presentation;
						using Thread.Foundation.Orm;

						public partial class PromoRenderingParameters : ThreadRenderingParameters
						{
							public static class Fields
		{

			public static string Orientation = "Orientation";
}

							public PromoRenderingParameters() : base(string.Empty) {}
public PromoRenderingParameters(string parametersAsQueryString) : base(parametersAsQueryString) {}

							
				public virtual Thread.Foundation.Enumerations.OrientationItem Orientation => GetItemValue(Fields.Orientation);

						}
					}
				



// Thread.Feature.Promo.Dynamic_Promo (/sitecore/templates/Feature/Promo/Dynamic Promo e1d1f8d7-36d5-4c92-a3e4-697127688f65)
	// Feature (c55982ce-712e-4749-9be0-4851d12efe0d)
		// Type: Droptree
		// Section: Configuration
		// Sort Order: 100
		// Source: 

// Thread.Feature.Promo.Dynamic_Promo_Rendering_Parameters (/sitecore/templates/Feature/Promo/Dynamic Promo Rendering Parameters 78188cec-8003-4f47-8dad-e68d6b7b9433)
	// Display_Content_Type_Label (4908e72e-a35a-4d3d-92ef-042d338cd82a)
		// Type: Checkbox
		// Section: Display Options
		// Sort Order: 300
		// Source: 
	// Display_Link (358a573f-230f-4a81-b5a1-479bd56b17e9)
		// Type: Checkbox
		// Section: Display Options
		// Sort Order: 600
		// Source: 
	// Display_Subtitle (0dc95fad-d1fa-4ec6-93b7-5780e5bdedc3)
		// Type: Checkbox
		// Section: Display Options
		// Sort Order: 400
		// Source: 
	// Display_Summary (8c5494a9-b8b4-49f5-880a-31359307d697)
		// Type: Checkbox
		// Section: Display Options
		// Sort Order: 500
		// Source: 
	// Image_Format (886360bf-3e31-4e30-b8b4-b440fab7525c)
		// Type: custom=Thread.Foundation.Enumerations.RatioItem
		// Section: Display Options
		// Sort Order: 200
		// Source: /sitecore/content/Global Configuration/Enumerations/Ratios
	// Image_Orientation (f26501b9-4ce7-4d6b-bbf6-605ff5865970)
		// Type: custom=Thread.Foundation.Enumerations.OrientationItem
		// Section: Display Options
		// Sort Order: 100
		// Source: /sitecore/content/Global Configuration/Enumerations/Orientation

// Thread.Feature.Promo.Multi_Promo (/sitecore/templates/Feature/Promo/Multi Promo e822a1e9-d502-463d-b38c-fdb84b3afabf)
	// Title (e5a0df4d-4b8a-4fc5-b1b0-45962fe22b5a)
		// Type: Single-Line Text
		// Section: Title
		// Sort Order: 100
		// Source: 

// Thread.Feature.Promo.Promo (/sitecore/templates/Feature/Promo/Promo 4dee566f-614c-4a89-8f0b-00f4b04beab9)
	// Description (62ae03c9-f72c-4f43-9537-83f0f2c9616b)
		// Type: Multi-Line Text
		// Section: Text
		// Sort Order: 100
		// Source: 
	// Image (6b9e0b00-03c3-47e2-8b0f-8f5db2176d7d)
		// Type: Image
		// Section: Image
		// Sort Order: 100
		// Source: 
	// Link (198478f8-0191-446b-aa46-d770b540a2e3)
		// Type: General Link
		// Section: Link
		// Sort Order: 100
		// Source: 
	// Subtitle (4d17936d-369e-4156-9308-abe4388454da)
		// Type: Single-Line Text
		// Section: Title
		// Sort Order: 200
		// Source: 
	// Title (72c1bf85-d4e0-4c4a-822d-174391e1333e)
		// Type: Single-Line Text
		// Section: Title
		// Sort Order: 100
		// Source: 

// Thread.Feature.Promo.Promo_Rendering_Parameters (/sitecore/templates/Feature/Promo/Promo Rendering Parameters 0e8d3193-6621-44f3-8b10-160e221fe41d)
	// Orientation (f1a3dbb2-63b6-45ce-a781-9dc3e122ab86)
		// Type: custom=Thread.Foundation.Enumerations.OrientationItem
		// Section: Display Options
		// Sort Order: 100
		// Source: /sitecore/content/Global Configuration/Enumerations/Orientation

// Thread.Feature.Promo.Pull_Quote (/sitecore/templates/Feature/Promo/Pull Quote 755f251c-81ed-490c-81ae-c05dd3f6bd2f)
	// Company (f5157f10-b660-40bf-9f93-ecefc38ca4cf)
		// Type: Single-Line Text
		// Section: Text
		// Sort Order: 400
		// Source: 
	// Job_Title (372a8116-9d83-48a7-9539-fee6f2ae4920)
		// Type: Single-Line Text
		// Section: Text
		// Sort Order: 300
		// Source: 
	// Name (058a56b2-57f9-448d-a9f7-3507ee1020ac)
		// Type: Single-Line Text
		// Section: Text
		// Sort Order: 200
		// Source: 
	// Quote (be6dd7a7-ef9f-4ea9-b1d1-6c520cc7db1d)
		// Type: Multi-Line Text
		// Section: Text
		// Sort Order: 100
		// Source: 

