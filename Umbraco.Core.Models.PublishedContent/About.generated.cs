//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.17.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Core.Models.PublishedContent
{
	/// <summary>About</summary>
	[PublishedModel("about")]
	public partial class About : PublishedContentModel, IAboutControls, IContentControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public new const string ModelTypeAlias = "about";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<About, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public About(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		[ImplementPropertyType("description")]
		public virtual global::System.Web.IHtmlString Description => global::Umbraco.Core.Models.PublishedContent.AboutControls.GetDescription(this);

		///<summary>
		/// Description Images
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		[ImplementPropertyType("descriptionImages")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.MediaWithCrops> DescriptionImages => global::Umbraco.Core.Models.PublishedContent.AboutControls.GetDescriptionImages(this);

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => global::Umbraco.Core.Models.PublishedContent.AboutControls.GetPageTitle(this);
	}
}
