using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc.Razor;


namespace Microsoft.Extensions.DependencyInjection
{
    public static class RazorViewEngineOptionsExtensions
    {
        /// <summary>
        /// Partial page views are added to the <see cref="RazorViewEngineOptions.PageViewLocationFormats"/>.
        /// </summary>
        public static RazorViewEngineOptions AddPartialViewLocationFormats(this RazorViewEngineOptions options, IEnumerable<string> partialPageViewLocationFormats)
        {
            partialPageViewLocationFormats.ForEach(partialPageViewLocationFormat =>
            {
                options.PageViewLocationFormats.Add(partialPageViewLocationFormat);
            });

            return options;
        }

        /// <summary>
        /// TagHelper views are added to the <see cref="RazorViewEngineOptions.ViewLocationFormats"/>.
        /// </summary>
        public static RazorViewEngineOptions AddTagHelperViewLocationFormats(this RazorViewEngineOptions options, IEnumerable<string> tagHelperViewLocationFormats)
        {
            tagHelperViewLocationFormats.ForEach(tagHelperViewLocationFormat =>
            {
                options.ViewLocationFormats.Add(tagHelperViewLocationFormat);
            });

            return options;
        }
    }
}
