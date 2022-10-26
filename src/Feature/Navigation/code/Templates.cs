
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

					namespace Thread.Feature.Navigation
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class BreadcrumbConfigurationItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("14e2f690-2849-45f2-9b1f-8741fd0606d0");
							public static class FieldIds
		{

			public static readonly string SvgDelimiterName = "a94cf3ac-75ea-4f48-8299-082a9a1aa413";
}

							public BreadcrumbConfigurationItem(Item innerItem) : base(innerItem) {}
public static implicit operator BreadcrumbConfigurationItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new BreadcrumbConfigurationItem(innerItem) : null;
	}
public static implicit operator Item(BreadcrumbConfigurationItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField SvgDelimiterName => InnerItem.Fields[FieldIds.SvgDelimiterName];

						}
					}
				

					namespace Thread.Feature.Navigation
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class FooterNavigationLinksColumnsFolderItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("9112014d-54d5-4c5e-b696-92ac51ebb15a");
							public static class FieldIds
		{
}

							public FooterNavigationLinksColumnsFolderItem(Item innerItem) : base(innerItem) {}
public static implicit operator FooterNavigationLinksColumnsFolderItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new FooterNavigationLinksColumnsFolderItem(innerItem) : null;
	}
public static implicit operator Item(FooterNavigationLinksColumnsFolderItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Feature.Navigation
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class FooterNavigationLinksFolderItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("ed05b776-d15c-47f6-9bb7-887a65cf227d");
							public static class FieldIds
		{
}

							public FooterNavigationLinksFolderItem(Item innerItem) : base(innerItem) {}
public static implicit operator FooterNavigationLinksFolderItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new FooterNavigationLinksFolderItem(innerItem) : null;
	}
public static implicit operator Item(FooterNavigationLinksFolderItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Feature.Navigation
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class LinkItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("d5745f91-8fa1-457f-be87-875a029c7b69");
							public static class FieldIds
		{

			public static readonly string Link = "ca902061-ead1-441e-a6d5-90612ce27830";
}

							public LinkItem(Item innerItem) : base(innerItem) {}
public static implicit operator LinkItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new LinkItem(innerItem) : null;
	}
public static implicit operator Item(LinkItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual LinkField Link => InnerItem.Fields[FieldIds.Link];

						}
					}
				

					namespace Thread.Feature.Navigation
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class LinkColumnHeaderItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("e17a5c79-ed0a-4f95-8a47-ca76322a3c2c");
							public static class FieldIds
		{

			public static readonly string NumberOfColumns = "da90ba19-124b-4385-9bdf-455464b3cee4";

			public static readonly string Title = "59cdc6e3-e52d-468d-b0f9-ede72fc373bd";

			public static readonly string Link = "ca902061-ead1-441e-a6d5-90612ce27830";
}

							public LinkColumnHeaderItem(Item innerItem) : base(innerItem) {}
public static implicit operator LinkColumnHeaderItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new LinkColumnHeaderItem(innerItem) : null;
	}
public static implicit operator Item(LinkColumnHeaderItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual LookupField NumberOfColumns => InnerItem.Fields[FieldIds.NumberOfColumns];

			public virtual TextField Title => InnerItem.Fields[FieldIds.Title];

			public virtual LinkField Link => InnerItem.Fields[FieldIds.Link];

						}
					}
				

					namespace Thread.Feature.Navigation
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class LinksFolderItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("056b6446-94d4-4c94-86bf-d0b10c384dbc");
							public static class FieldIds
		{
}

							public LinksFolderItem(Item innerItem) : base(innerItem) {}
public static implicit operator LinksFolderItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new LinksFolderItem(innerItem) : null;
	}
public static implicit operator Item(LinksFolderItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Feature.Navigation
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class NavigationConfigurationFolderItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("95e5e5ef-6382-4bf8-979e-65f9e46da42d");
							public static class FieldIds
		{
}

							public NavigationConfigurationFolderItem(Item innerItem) : base(innerItem) {}
public static implicit operator NavigationConfigurationFolderItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new NavigationConfigurationFolderItem(innerItem) : null;
	}
public static implicit operator Item(NavigationConfigurationFolderItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Feature.Navigation
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class PrimaryNavigationCategoryItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("e5acf52c-1e6b-4142-84f2-6d09b1ba1ab8");
							public static class FieldIds
		{

			public static readonly string Title = "efe41572-fbeb-4b09-814c-42c0ffe94dfb";
}

							public PrimaryNavigationCategoryItem(Item innerItem) : base(innerItem) {}
public static implicit operator PrimaryNavigationCategoryItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new PrimaryNavigationCategoryItem(innerItem) : null;
	}
public static implicit operator Item(PrimaryNavigationCategoryItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField Title => InnerItem.Fields[FieldIds.Title];

						}
					}
				

					namespace Thread.Feature.Navigation
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class PrimaryNavigationLinksFolderItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("8c5b5db5-85de-4b12-aaba-0c112cabfdd0");
							public static class FieldIds
		{
}

							public PrimaryNavigationLinksFolderItem(Item innerItem) : base(innerItem) {}
public static implicit operator PrimaryNavigationLinksFolderItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new PrimaryNavigationLinksFolderItem(innerItem) : null;
	}
public static implicit operator Item(PrimaryNavigationLinksFolderItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Feature.Navigation
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class _NavigationBaseItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("4da6ca42-ccf0-4af6-8671-26384ea21494");
							public static class FieldIds
		{

			public static readonly string SuppressInNavigation = "1ccdab5f-8819-4a04-a09a-4f66dfb65d12";
}

							public _NavigationBaseItem(Item innerItem) : base(innerItem) {}
public static implicit operator _NavigationBaseItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new _NavigationBaseItem(innerItem) : null;
	}
public static implicit operator Item(_NavigationBaseItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual CheckboxField SuppressInNavigation => InnerItem.Fields[FieldIds.SuppressInNavigation];

						}
					}
				







// Thread.Feature.Navigation.Breadcrumb_Configuration (/sitecore/templates/Feature/Navigation/Breadcrumb Configuration 14e2f690-2849-45f2-9b1f-8741fd0606d0)
	// Svg_Delimiter_Name (a94cf3ac-75ea-4f48-8299-082a9a1aa413)
		// Type: Single-Line Text
		// Section: Breadcrumb Configuration
		// Sort Order: 100
		// Source: 

// Thread.Feature.Navigation.Footer_Navigation_Links_Columns_Folder (/sitecore/templates/Feature/Navigation/Footer Navigation Links Columns Folder 9112014d-54d5-4c5e-b696-92ac51ebb15a)

// Thread.Feature.Navigation.Footer_Navigation_Links_Folder (/sitecore/templates/Feature/Navigation/Footer Navigation Links Folder ed05b776-d15c-47f6-9bb7-887a65cf227d)

// Thread.Feature.Navigation.Link (/sitecore/templates/Feature/Navigation/Link d5745f91-8fa1-457f-be87-875a029c7b69)
	// Link (ca902061-ead1-441e-a6d5-90612ce27830)
		// Type: General Link
		// Section: Link
		// Sort Order: 100
		// Source: /sitecore/content

// Thread.Feature.Navigation.Link_Column_Header (/sitecore/templates/Feature/Navigation/Link Column Header e17a5c79-ed0a-4f95-8a47-ca76322a3c2c)
	// Number_Of_Columns (da90ba19-124b-4385-9bdf-455464b3cee4)
		// Type: Droplink
		// Section: Presentation
		// Sort Order: 100
		// Source: query:../ancestor::*[@@name='Configuration']//*[@@templateid='{FBD8D65E-EA3B-413A-90DE-93F7FEDCA0BC}']//*
	// Title (59cdc6e3-e52d-468d-b0f9-ede72fc373bd)
		// Type: Single-Line Text
		// Section: Title
		// Sort Order: 100
		// Source: 

// Thread.Feature.Navigation.Links_Folder (/sitecore/templates/Feature/Navigation/Links Folder 056b6446-94d4-4c94-86bf-d0b10c384dbc)

// Thread.Feature.Navigation.Navigation_Configuration_Folder (/sitecore/templates/Feature/Navigation/Navigation Configuration Folder 95e5e5ef-6382-4bf8-979e-65f9e46da42d)

// Thread.Feature.Navigation.Primary_Navigation_Category (/sitecore/templates/Feature/Navigation/Primary Navigation Category e5acf52c-1e6b-4142-84f2-6d09b1ba1ab8)
	// Title (efe41572-fbeb-4b09-814c-42c0ffe94dfb)
		// Type: Single-Line Text
		// Section: Title
		// Sort Order: 100
		// Source: 

// Thread.Feature.Navigation.Primary_Navigation_Links_Folder (/sitecore/templates/Feature/Navigation/Primary Navigation Links Folder 8c5b5db5-85de-4b12-aaba-0c112cabfdd0)

// Thread.Feature.Navigation._Navigation_Base (/sitecore/templates/Feature/Navigation/_Navigation Base 4da6ca42-ccf0-4af6-8671-26384ea21494)
	// Suppress_In_Navigation (1ccdab5f-8819-4a04-a09a-4f66dfb65d12)
		// Type: Checkbox
		// Section: Navigation
		// Sort Order: 200
		// Source: 

