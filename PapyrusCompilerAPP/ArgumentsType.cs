using System.ComponentModel;

namespace LightPapyrusCompiler
{
    internal enum CompilerArguments
    {
        [Description("Turns on compiler debugging, outputting dev information to the screen.")]
        @Debug = 1,
        [Description("Turns on optimization of scripts.")]
        @Optimize = 2,
        [Description("Invokes the compiler against all psc files in the specified directory(interprets object as the folder).")]
        @All = 3,
        [Description("Does not report progress or success (only failures).")]
        @Quiet = 4,
        [Description("Does not generate an assembly file and does not run the assembler.")]
        @Noasm = 5,
        [Description("Keeps the assembly file after running the assembler.")]
        @Keepasm = 6,
        [Description("Generates an assembly file but does not run the assembler.")]
        @Asmonly = 7,
        [Description("Prints usage information.")]
        @_ = 8
    }

    internal enum AssemblerArguments
    {
        [Description("Disassembles the object, instead of assembling it.")]
        @D = 1,
        [Description("Turns on verbose mode.")]
        @V = 2,
        [Description("Turns on quiet mode. (No status messages, only errors)")]
        @Q = 3,
        [Description("Do not assemble/disassemble the file, just load and analyze.")]
        @A = 4,
        [Description("Strips debugging info from a compiled file. Cannot be used with -A or - D")]
        @S = 5,
        [Description("Prints this usage information")]
        @_ = 6
    }
}
