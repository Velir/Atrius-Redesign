
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

					namespace Thread.Feature.Global
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _FooterConnectItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("afc79bd2-9d91-49e5-8bdc-ca4bf73c7b44");
							public static class FieldIds
		{

			public static readonly string ConnectLink = "9658ac80-64d8-4cc2-a466-bd3c3568d11b";

			public static readonly string ConnectStatement = "addd3394-07c6-4f96-b2a2-354c4b9022a1";

			public static readonly string PhoneNumber = "68b134b1-19e5-4664-8fdb-0da0c1750a45";

			public static readonly string TouchToCallPhoneNumber = "96f8b3dc-22dd-4a48-b40c-b3f5f9f32fef";
}

							public _FooterConnectItem(Item innerItem) : base(innerItem) {}
public static implicit operator _FooterConnectItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _FooterConnectItem(innerItem) : null;
	}
public static implicit operator Item(_FooterConnectItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual LinkField ConnectLink => InnerItem.Fields[FieldIds.ConnectLink];

			public virtual TextField ConnectStatement => InnerItem.Fields[FieldIds.ConnectStatement];

			public virtual TextField PhoneNumber => InnerItem.Fields[FieldIds.PhoneNumber];

			public virtual TextField TouchToCallPhoneNumber => InnerItem.Fields[FieldIds.TouchToCallPhoneNumber];

						}
					}
				

					namespace Thread.Feature.Global
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _FooterCopyrightItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("553420cc-2da2-448a-bc94-6364ef2f768c");
							public static class FieldIds
		{

			public static readonly string CopyrightStatement = "ddbaec9a-cd44-44f2-91db-c8f997a279f5";
}

							public _FooterCopyrightItem(Item innerItem) : base(innerItem) {}
public static implicit operator _FooterCopyrightItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _FooterCopyrightItem(innerItem) : null;
	}
public static implicit operator Item(_FooterCopyrightItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField CopyrightStatement => InnerItem.Fields[FieldIds.CopyrightStatement];

						}
					}
				

					namespace Thread.Feature.Global
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _FooterLogoItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("ca21bb62-10b5-46d5-a713-683c56333fef");
							public static class FieldIds
		{

			public static readonly string FooterBrandingTitle = "a96facc6-3890-4e57-bb5a-1770a5115cca";

			public static readonly string FooterLogo = "ea671236-6b49-48cf-a30a-c18cc97b3be2";
}

							public _FooterLogoItem(Item innerItem) : base(innerItem) {}
public static implicit operator _FooterLogoItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _FooterLogoItem(innerItem) : null;
	}
public static implicit operator Item(_FooterLogoItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField FooterBrandingTitle => InnerItem.Fields[FieldIds.FooterBrandingTitle];

			public virtual ImageField FooterLogo => InnerItem.Fields[FieldIds.FooterLogo];

						}
					}
				

					namespace Thread.Feature.Global
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _HeaderLogoItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("c5e2c715-1397-4ba4-8ebd-ac8e038736d4");
							public static class FieldIds
		{

			public static readonly string HeaderBrandingTitle = "21ce934b-783b-4864-a152-eeeaf3a6d121";

			public static readonly string HeaderLogoLarge = "a0ca1737-a0d7-4878-9f81-49c1759dc482";

			public static readonly string HeaderLogoSmall = "9afdea09-3395-4ca4-b068-b09b0b0033b2";
}

							public _HeaderLogoItem(Item innerItem) : base(innerItem) {}
public static implicit operator _HeaderLogoItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _HeaderLogoItem(innerItem) : null;
	}
public static implicit operator Item(_HeaderLogoItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField HeaderBrandingTitle => InnerItem.Fields[FieldIds.HeaderBrandingTitle];

			public virtual ImageField HeaderLogoLarge => InnerItem.Fields[FieldIds.HeaderLogoLarge];

			public virtual ImageField HeaderLogoSmall => InnerItem.Fields[FieldIds.HeaderLogoSmall];

						}
					}
				







// Thread.Feature.Global._Footer_Connect (/sitecore/templates/Feature/Global/Footer/_Footer Connect afc79bd2-9d91-49e5-8bdc-ca4bf73c7b44)
	// Connect_Link (9658ac80-64d8-4cc2-a466-bd3c3568d11b)
		// Type: General Link
		// Section: Footer
		// Sort Order: 300
		// Source: 
	// Connect_Statement (addd3394-07c6-4f96-b2a2-354c4b9022a1)
		// Type: Single-Line Text
		// Section: Footer
		// Sort Order: 400
		// Source: 
	// Phone_Number (68b134b1-19e5-4664-8fdb-0da0c1750a45)
		// Type: Single-Line Text
		// Section: Footer
		// Sort Order: 500
		// Source: 
	// Touch_To_Call_Phone_Number (96f8b3dc-22dd-4a48-b40c-b3f5f9f32fef)
		// Type: Single-Line Text
		// Section: Footer
		// Sort Order: 600
		// Source: 

// Thread.Feature.Global._Footer_Copyright (/sitecore/templates/Feature/Global/Footer/_Footer Copyright 553420cc-2da2-448a-bc94-6364ef2f768c)
	// Copyright_Statement (ddbaec9a-cd44-44f2-91db-c8f997a279f5)
		// Type: Single-Line Text
		// Section: Footer
		// Sort Order: 100
		// Source: 

// Thread.Feature.Global._Footer_Logo (/sitecore/templates/Feature/Global/Footer/_Footer Logo ca21bb62-10b5-46d5-a713-683c56333fef)
	// Footer_Branding_Title (a96facc6-3890-4e57-bb5a-1770a5115cca)
		// Type: Single-Line Text
		// Section: Footer
		// Sort Order: 200
		// Source: 
	// Footer_Logo (ea671236-6b49-48cf-a30a-c18cc97b3be2)
		// Type: Image
		// Section: Footer
		// Sort Order: 100
		// Source: 

// Thread.Feature.Global._Header_Logo (/sitecore/templates/Feature/Global/Header/_Header Logo c5e2c715-1397-4ba4-8ebd-ac8e038736d4)
	// Header_Branding_Title (21ce934b-783b-4864-a152-eeeaf3a6d121)
		// Type: Single-Line Text
		// Section: Header
		// Sort Order: 300
		// Source: 
	// Header_Logo_Large (a0ca1737-a0d7-4878-9f81-49c1759dc482)
		// Type: Image
		// Section: Header
		// Sort Order: 100
		// Source: 
	// Header_Logo_Small (9afdea09-3395-4ca4-b068-b09b0b0033b2)
		// Type: Image
		// Section: Header
		// Sort Order: 200
		// Source: 

