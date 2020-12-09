// Decompiled with JetBrains decompiler
// Type: MwmBuilder.ContentBuildLogger
// Assembly: MwmBuilder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47A6C2F8-C9D4-4065-959F-7D7436A7009C
// Assembly location: E:\Steam\SteamApps\common\SpaceEngineersModSDK\Tools\MwmBuilder\MwmBuilder.exe

namespace MwmBuilder
{
  internal abstract class ContentBuildLogger
  {
    public abstract void LogImportantMessage(string message, params object[] messageArgs);

    public abstract void LogMessage(string message, params object[] messageArgs);

    public abstract void LogWarning(string helpLink, string message, params object[] messageArgs);
  }
}
