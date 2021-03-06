﻿using System.Diagnostics;
using CommandLine;
using Urho3DNet;

namespace rbfxSample
{
    public class ApplicationOptions
    {
        public ApplicationOptions()
        {
            Windowed = Debugger.IsAttached;
        }

        [Option('w', "windowed", Required = false, HelpText = "Windowed mode")] 
        public bool Windowed { get; set; }

        [Option("width", Required = false, HelpText = "Window width")]
        public int? Width { get; set; }

        [Option("height", Required = false, HelpText = "Window height")]
        public int? Height { get; set; }

        [Option('h', "highdpi", Required = false, HelpText = "High DPI mode")]
        public bool HighDpi { get; set; } = false;

        [Option("renderpath", Required = false, HelpText = "Render path")]
        public string RenderPath { get; set; } = "RenderPaths/ForwardHWDepth.xml";
    }
}