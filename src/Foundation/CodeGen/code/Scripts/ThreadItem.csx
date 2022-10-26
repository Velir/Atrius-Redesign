// Generates CustomItem models
using System.Linq;
Log.Debug($"Emitting CustomItem templates for {ConfigurationName}...");

public string RenderTemplates()
{
	var localCode = new System.Text.StringBuilder();

	foreach (var template in Templates)
	{
		if (!template.CodeName.EndsWith("_Parameters"))
		{
			localCode.AppendLine($@"
					namespace {template.Namespace}
					{{
						using Sitecore.Data;
						using Sitecore.Data.Fields;
						using Sitecore.Data.Items;
							
						public partial class {RenderTemplateName(template)} : CustomItem
						{{
							{RenderTemplateId(template)}
							{RenderFieldIds(template)}
							{RenderConstructors(template)}
							{RenderFieldProperties(template)}
						}}
					}}
				");
		}
	}

	return localCode.ToString();
}

Code.AppendLine($@"
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
{RenderTemplates()}
");

public string RenderTemplateName(TemplateCodeGenerationMetadata template)
{
	var origName = template.CodeName;
	var prefix = origName.StartsWith("_") ? "_" : string.Empty;
	var translatedName = origName.Replace("_", string.Empty);

	return $"{prefix}{translatedName}Item";
}

public string RenderTemplateId(TemplateCodeGenerationMetadata template)
{
	return $@"
			public static readonly ID TemplateId = new ID(""{template.Id}"");";
}

public string RenderFieldIds(TemplateCodeGenerationMetadata template)
{
	var localCode = new System.Text.StringBuilder();

	localCode.AppendLine($@"public static class FieldIds
		{{");
	foreach (var field in template.AllFields)
	{
		localCode.AppendLine($@"
			public static readonly string {GetFieldName(field)} = ""{field.Id}"";");
	}
	localCode.AppendLine("}");

	return localCode.ToString();
}

public string RenderConstructors(TemplateCodeGenerationMetadata template)
{
	var localCode = new System.Text.StringBuilder();

	localCode.AppendLine($@"public {RenderTemplateName(template)}(Item innerItem) : base(innerItem) {{}}");
	localCode.AppendLine($@"public static implicit operator {RenderTemplateName(template)}(Item innerItem)
	{{
		return innerItem != null && innerItem.DescendsFrom(TemplateId) ? new {RenderTemplateName(template)}(innerItem) : null;
	}}");
	localCode.AppendLine($@"public static implicit operator Item({RenderTemplateName(template)} customItem)
	{{
		return customItem?.InnerItem;
	}}");

	return localCode.ToString();
}

public string GetFieldName(TemplateFieldCodeGenerationMetadata field)
{
	var origName = field.CodeName;
	var prefix = origName.StartsWith("_") ? "_" : string.Empty;
	var translatedName = origName.Replace("_", string.Empty);

	return $"{prefix}{translatedName}";
}

public string RenderFieldProperties(TemplateCodeGenerationMetadata template)
{
	var localCode = new System.Text.StringBuilder();

	foreach (var field in template.AllFields)
	{
		localCode.AppendLine($@"
			public virtual {GetFieldType(field)} {GetFieldName(field)} => InnerItem.Fields[FieldIds.{GetFieldName(field)}];");
	}

	return localCode.ToString();
}

public string GetFieldType(TemplateFieldCodeGenerationMetadata field)
{
	switch (field.Type.ToLower())
	{
		case "tristate":
			return "Field";
		case "checkbox":
			return "CheckboxField";

		case "date":
		case "datetime":
			return "DateField";

		case "number":
			return "Field";

		case "integer":
			return "Field";

		case "treelist with search":
		case "treelist":
		case "treelistex":
		case "treelist descriptive":
		case "multitreelist":
		case "checklist":
		case "multilist with search":
		case "multilist":
			return "MultilistField";

		case "grouped droplink":
		case "droplink":
		case "lookup":
		case "droptree":
		case "reference":
		case "tree":
			return "LookupField";

		case "file":
			return "FileField";

		case "image":
			return "ImageField";

		case "general link":
		case "general link with search":
			return "LinkField";

		case "rules":
		case "password":
		case "icon":
		case "rich text":
		case "html":
		case "single-line text":
		case "multi-line text":
		case "frame":
		case "text":
		case "memo":
		case "droplist":
		case "grouped droplist":
		case "valuelookup":
			return "TextField";
		case "attachment":
		case "word document":
			return "Field";
		case "name lookup value list":
		case "name value list":
			return "Field";
		default:
			return "Field";
	}
}