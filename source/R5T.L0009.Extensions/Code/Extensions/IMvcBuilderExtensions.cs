using System;

using R5T.L0009;


namespace Microsoft.Extensions.DependencyInjection
{
    public static class IMvcBuilderExtensions
    {
        /// <summary>
        /// Uses the <see cref="RazorPagesRootDirectory.Standard"/> root directory for Razor pages.
        /// This extension is available to ensure that all Rivet functionality uses the standard pages root directory.
        /// Note: this *will* cause problems using Razor pages from non-Rivet Razor Class Libraries (RCLs) since there can be only one root and chances are, those library developers did not use the Rivet standard.
        /// That is ok, since RCLs will generally be used for partials instead of pages, and the search paths for partials can be configured.
        /// </summary>
        public static IMvcBuilder WithStandardRazorPagesRoot(this IMvcBuilder builder)
        {
            // Since Razor pages allow the @page directive to specify their route, a special function, separate from configuring RazorViewEngineOptions.ViewLocationFormats, is needed.
            builder.WithRazorPagesRoot(RazorPagesRootDirectory.Standard);

            return builder;
        }
    }
}
