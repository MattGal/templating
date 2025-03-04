// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.TemplateEngine.Orchestrator.RunnableProjects.Abstractions;

namespace Microsoft.TemplateEngine.Orchestrator.RunnableProjects.Macros.Config
{
    internal class ConstantMacroConfig : IMacroConfig
    {
        internal ConstantMacroConfig(string dataType, string variableName, string value)
        {
            DataType = dataType;
            VariableName = variableName;
            Type = "constant";
            Value = value;
        }

        public string VariableName { get; private set; }

        public string Type { get; private set; }

        internal string DataType { get; }

        internal string Value { get; private set; }
    }
}
