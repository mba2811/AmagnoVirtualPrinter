﻿using JetBrains.Annotations;

namespace VirtualPrinter.Agent.Core
{
    public interface IShell
    {
        void WriteIniEntry(string section, string key, string value, string iniFilePath);

        [NotNull]
        T ReadIniEntry<T>(string section, string key, string iniFilePath);

        void Execute(IJobInfo job, ISessionInfo session, string exe, string args);

        bool FileExists([NotNull]string path);
    }
}