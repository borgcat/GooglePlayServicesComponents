﻿using System.Reflection;
using System.Runtime.CompilerServices;
using Android.App;

// Information about this assembly is defined by the following attributes.
// Change them to the values specific to your project.

[assembly: AssemblyTitle ("Xamarin.GooglePlayServices.Clearcut")]
[assembly: AssemblyDescription ("")]
[assembly: AssemblyConfiguration ("")]
[assembly: AssemblyCompany ("Microsoft Corporation")]
[assembly: AssemblyProduct ("")]
[assembly: AssemblyCopyright ("Copyright © Microsoft Corporation")]
[assembly: AssemblyTrademark ("")]
[assembly: AssemblyCulture ("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion ("1.0.0")]

// The following attributes are used to specify the signing key for the assembly,
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

[assembly: Java.Interop.JavaLibraryReference ("classes.jar",
    PackageName = __GpsConsts.PackageName,
    SourceUrl = __GpsConsts.Url,
    EmbeddedArchive = __Consts.AarPath,
    Version = __GpsConsts.Version,
    Sha1sum = __GpsConsts.Sha1sum)]
// AppCompat-v7 resources
[assembly: Android.IncludeAndroidResourcesFromAttribute ("./",
    PackageName = __GpsConsts.PackageName,
    SourceUrl   = __GpsConsts.Url,
    EmbeddedArchive = __Consts.AarPath,
    Version     = __GpsConsts.Version,
    Sha1sum = __GpsConsts.Sha1sum)]

// Google Addon feed with GPS in it:
//      https://dl-ssl.google.com/android/repository/addon.xml

static class __Consts {
    public const string AarPath = "m2repository/com/google/android/gms/play-services-clearcut/" + __GpsConsts.Version + "/play-services-clearcut-" + __GpsConsts.Version + ".aar";
}
