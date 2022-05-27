<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner
{
    internal interface ITestSettings : IDisposable
    {
        ScriptingImplementation? scriptingBackend { get; set; }

        string Architecture { get; set; }

        ApiCompatibilityLevel? apiProfile { get; set; }

        bool? appleEnableAutomaticSigning { get; set; }
        string appleDeveloperTeamID { get; set; }
        ProvisioningProfileType? iOSManualProvisioningProfileType { get; set; }
        string iOSManualProvisioningProfileID { get; set; }
        ProvisioningProfileType? tvOSManualProvisioningProfileType { get; set; }
        string tvOSManualProvisioningProfileID { get; set; }
        string[] playerGraphicsAPIs { get; set; }
        bool autoGraphicsAPIs { get; set; }

        void SetupProjectParameters();
    }
}
=======
using System;

namespace UnityEditor.TestTools.TestRunner
{
    internal interface ITestSettings : IDisposable
    {
        ScriptingImplementation? scriptingBackend { get; set; }

        string Architecture { get; set; }

        ApiCompatibilityLevel? apiProfile { get; set; }

        bool? appleEnableAutomaticSigning { get; set; }
        string appleDeveloperTeamID { get; set; }
        ProvisioningProfileType? iOSManualProvisioningProfileType { get; set; }
        string iOSManualProvisioningProfileID { get; set; }
        ProvisioningProfileType? tvOSManualProvisioningProfileType { get; set; }
        string tvOSManualProvisioningProfileID { get; set; }
        string[] playerGraphicsAPIs { get; set; }
        bool autoGraphicsAPIs { get; set; }

        void SetupProjectParameters();
    }
}
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
