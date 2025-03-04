using System.IO;
using System.Runtime.CompilerServices;
using DiffEngine;
using VerifyTests;

namespace BililiveRecorder.Core.UnitTests
{
    public static class VerifyConfig
    {
        [ModuleInitializer]
        public static void Init()
        {
            VerifierSettings.DerivePathInfo(Expectations.Initialize);
            VerifierSettings.IgnoreMembersWithType<Stream>();
            DiffRunner.Disabled = false;
            DiffTools.UseOrder(DiffTool.VisualStudioCode, DiffTool.Rider, DiffTool.WinMerge, DiffTool.VisualStudio);
        }
    }
}
