
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

					namespace Thread.Foundation.Forms
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class EmailTemplateItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("1eb19b8d-905f-4fd3-bf38-0e50c5958954");
							public static class FieldIds
		{

			public static readonly string Bcc = "f2cbe66b-4a66-4bac-a010-ad66ca59996d";

			public static readonly string Body = "a730a8d9-d78e-47bf-ad75-8c7497337685";

			public static readonly string CC = "21abbc01-6231-4c14-861b-643ff454c7e7";

			public static readonly string From = "7745a7c0-dc40-485b-9ecf-7b805bcc7af2";

			public static readonly string Subject = "0c6784b4-bae1-4599-b0be-56b9a0fe48c1";

			public static readonly string To = "8a357639-4c0c-4a45-9f43-20ec687f4676";
}

							public EmailTemplateItem(Item innerItem) : base(innerItem) {}
public static implicit operator EmailTemplateItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new EmailTemplateItem(innerItem) : null;
	}
public static implicit operator Item(EmailTemplateItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual TextField Bcc => InnerItem.Fields[FieldIds.Bcc];

			public virtual TextField Body => InnerItem.Fields[FieldIds.Body];

			public virtual TextField CC => InnerItem.Fields[FieldIds.CC];

			public virtual TextField From => InnerItem.Fields[FieldIds.From];

			public virtual TextField Subject => InnerItem.Fields[FieldIds.Subject];

			public virtual TextField To => InnerItem.Fields[FieldIds.To];

						}
					}
				

					namespace Thread.Foundation.Forms
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class EmailTemplatesFolderItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("7419f6ee-dfa6-48a7-a73b-3166d9c36aa7");
							public static class FieldIds
		{
}

							public EmailTemplatesFolderItem(Item innerItem) : base(innerItem) {}
public static implicit operator EmailTemplatesFolderItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new EmailTemplatesFolderItem(innerItem) : null;
	}
public static implicit operator Item(EmailTemplatesFolderItem customItem)
	{
		return customItem?.InnerItem;
	}

							
						}
					}
				

					namespace Thread.Foundation.Forms
					{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class PasswordItem : CustomItem
						{
							
			public static readonly ID TemplateId = new ID("e8212336-f051-465f-a37e-6547515ce29e");
							public static class FieldIds
		{

			public static readonly string ShowHidePassword = "fd0350f6-d7ba-45da-a865-0c8fe0b48eb9";
}

							public PasswordItem(Item innerItem) : base(innerItem) {}
public static implicit operator PasswordItem(Item innerItem)
	{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new PasswordItem(innerItem) : null;
	}
public static implicit operator Item(PasswordItem customItem)
	{
		return customItem?.InnerItem;
	}

							
			public virtual CheckboxField ShowHidePassword => InnerItem.Fields[FieldIds.ShowHidePassword];

						}
					}
				







// Thread.Foundation.Forms.Email_Template (/sitecore/templates/Foundation/Forms/Email/Email Template 1eb19b8d-905f-4fd3-bf38-0e50c5958954)
	// Bcc (f2cbe66b-4a66-4bac-a010-ad66ca59996d)
		// Type: Single-Line Text
		// Section: Message
		// Sort Order: 88
		// Source: 
	// Body (a730a8d9-d78e-47bf-ad75-8c7497337685)
		// Type: Rich Text
		// Section: Message
		// Sort Order: 300
		// Source: 
	// CC (21abbc01-6231-4c14-861b-643ff454c7e7)
		// Type: Single-Line Text
		// Section: Message
		// Sort Order: 75
		// Source: 
	// From (7745a7c0-dc40-485b-9ecf-7b805bcc7af2)
		// Type: Single-Line Text
		// Section: Message
		// Sort Order: 100
		// Source: 
	// Subject (0c6784b4-bae1-4599-b0be-56b9a0fe48c1)
		// Type: Single-Line Text
		// Section: Message
		// Sort Order: 200
		// Source: 
	// To (8a357639-4c0c-4a45-9f43-20ec687f4676)
		// Type: Single-Line Text
		// Section: Message
		// Sort Order: 50
		// Source: 

// Thread.Foundation.Forms.Email_Templates_Folder (/sitecore/templates/Foundation/Forms/Email/Email Templates Folder 7419f6ee-dfa6-48a7-a73b-3166d9c36aa7)

// Thread.Foundation.Forms.Password (/sitecore/templates/Foundation/Forms/Fields/Password e8212336-f051-465f-a37e-6547515ce29e)
	// Show_Hide_Password (fd0350f6-d7ba-45da-a865-0c8fe0b48eb9)
		// Type: Checkbox
		// Section: Data
		// Sort Order: 100
		// Source: 

