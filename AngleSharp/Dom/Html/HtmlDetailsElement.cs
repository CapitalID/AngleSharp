﻿namespace AngleSharp.Dom.Html
{
    using AngleSharp.Extensions;
    using AngleSharp.Html;
    using System;

    /// <summary>
    /// Represents the HTML details element.
    /// </summary>
    sealed class HtmlDetailsElement : HtmlElement, IHtmlDetailsElement
    {
        #region ctor

        /// <summary>
        /// Creates a new HTML details element.
        /// </summary>
        public HtmlDetailsElement(Document owner, String prefix = null)
            : base(owner, TagNames.Details, prefix, NodeFlags.Special)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets if the details element is open.
        /// </summary>
        public Boolean IsOpen
        {
            get { return this.HasOwnAttribute(AttributeNames.Open); }
            set { this.SetOwnAttribute(AttributeNames.Open, value ? String.Empty : null); }
        }

        #endregion
    }
}
