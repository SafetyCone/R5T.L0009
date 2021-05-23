using System;


namespace R5T.L0009
{
    public static class RazorPagesRootDirectory
    {
        /// <summary>
        /// This is the default ASP.NET Core Razor pages root directory everywhere outside of Rivet.
        /// </summary>
        public const string AspNetCoreDefault = "/Pages";

        /// <summary>
        /// The standard Razor pages root directory for all Rivet-related pages and partials is different from the
        /// NOTE! This *will* cause trouble using external Razor Class Libraries (RCLs), since they will assume a certain root (probably the ASP.NET Core default), and this root is different.
        /// Since there can (at the moment) be only one Razor pages root directory (there should be the capability for one-per-assembly), Razor pages in other RCL assemblies will not work.
        /// However, this should be ok, since mostly those RCLs will mostly supply partials, and partial view search locations *can* be configured.
        /// </summary>
        public const string Standard = "/Razor/Pages";
    }
}
