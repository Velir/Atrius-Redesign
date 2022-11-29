
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

					namespace AtriusHealth.Feature.Social
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class SocialMediaIconItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("8b1e6df7-c1b5-410a-ab8a-10d16e3b3df4");
							public static class FieldIds
		{

			public static readonly string IconName = "60767e88-bdd6-4c21-bad7-5e338630d5ff";
}

							public SocialMediaIconItem(Item innerItem) : base(innerItem) {}
public static implicit operator SocialMediaIconItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new SocialMediaIconItem(innerItem) : null;
	}
public static implicit operator Item(SocialMediaIconItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField IconName => InnerItem.Fields[FieldIds.IconName];

						}
					}
				

					namespace AtriusHealth.Feature.Social
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class SocialMediaLinkItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("9744d172-190e-49ed-9d2f-b9f588bfeaf9");
							public static class FieldIds
		{

			public static readonly string Icon = "6c54a7e4-cb8b-4f5c-838e-b784517c4cb7";

			public static readonly string Link = "2651e5a4-14e4-4e0b-b089-0c67c6e0f02a";
}

							public SocialMediaLinkItem(Item innerItem) : base(innerItem) {}
public static implicit operator SocialMediaLinkItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new SocialMediaLinkItem(innerItem) : null;
	}
public static implicit operator Item(SocialMediaLinkItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual LookupField Icon => InnerItem.Fields[FieldIds.Icon];

			public virtual LinkField Link => InnerItem.Fields[FieldIds.Link];

						}
					}
				

					namespace AtriusHealth.Feature.Social
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class SocialMediaLinksFolderItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("707d5c9f-12ec-4ae5-80e2-c254134e6612");
							public static class FieldIds
		{

			public static readonly string SocialFollowHeader = "15df30a2-3a4c-428d-9c65-c9ee5cce4c4c";
}

							public SocialMediaLinksFolderItem(Item innerItem) : base(innerItem) {}
public static implicit operator SocialMediaLinksFolderItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new SocialMediaLinksFolderItem(innerItem) : null;
	}
public static implicit operator Item(SocialMediaLinksFolderItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField SocialFollowHeader => InnerItem.Fields[FieldIds.SocialFollowHeader];

						}
					}
				

					namespace AtriusHealth.Feature.Social
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _ShareConfigurationItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("66e6c75f-3e19-496d-82ec-cf7af4938722");
							public static class FieldIds
		{

			public static readonly string AddThisAccountID = "817b2a50-b4b3-4eb4-9313-9fa1565ab181";
}

							public _ShareConfigurationItem(Item innerItem) : base(innerItem) {}
public static implicit operator _ShareConfigurationItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _ShareConfigurationItem(innerItem) : null;
	}
public static implicit operator Item(_ShareConfigurationItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField AddThisAccountID => InnerItem.Fields[FieldIds.AddThisAccountID];

						}
					}
				







// AtriusHealth.Feature.Social.Social_Media_Icon (/sitecore/templates/Feature/Social/Social Media Icon 8b1e6df7-c1b5-410a-ab8a-10d16e3b3df4)
	// Icon_Name (60767e88-bdd6-4c21-bad7-5e338630d5ff)
		// Type: Single-Line Text
		// Section: Name
		// Sort Order: 100
		// Source: 

// AtriusHealth.Feature.Social.Social_Media_Link (/sitecore/templates/Feature/Social/Social Media Link 9744d172-190e-49ed-9d2f-b9f588bfeaf9)
	// Icon (6c54a7e4-cb8b-4f5c-838e-b784517c4cb7)
		// Type: Droplink
		// Section: Display Options
		// Sort Order: 200
		// Source: query:ancestor-or-self::*[@@templateid='{98AC8506-0017-4964-81A9-19B76FA9EE98}']/Configuration/Enumerations/Social Media Icons/*
	// Link (2651e5a4-14e4-4e0b-b089-0c67c6e0f02a)
		// Type: General Link
		// Section: Link
		// Sort Order: 100
		// Source: 

// AtriusHealth.Feature.Social.Social_Media_Links_Folder (/sitecore/templates/Feature/Social/Social Media Links Folder 707d5c9f-12ec-4ae5-80e2-c254134e6612)
	// Social_Follow_Header (15df30a2-3a4c-428d-9c65-c9ee5cce4c4c)
		// Type: Single-Line Text
		// Section: Social Configuration
		// Sort Order: 100
		// Source: 

// AtriusHealth.Feature.Social._Share_Configuration (/sitecore/templates/Feature/Social/_Share Configuration 66e6c75f-3e19-496d-82ec-cf7af4938722)
	// AddThis_Account_ID (817b2a50-b4b3-4eb4-9313-9fa1565ab181)
		// Type: Single-Line Text
		// Section: Share Configuration
		// Sort Order: 100
		// Source: 

