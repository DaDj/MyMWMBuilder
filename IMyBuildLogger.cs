// Decompiled with JetBrains decompiler
// Type: MwmBuilder.IMyBuildLogger
// Assembly: MwmBuilder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47A6C2F8-C9D4-4065-959F-7D7436A7009C
// Assembly location: E:\Steam\SteamApps\common\SpaceEngineersModSDK\Tools\MwmBuilder\MwmBuilder.exe

namespace MwmBuilder
{
  public interface IMyBuildLogger
  {
    void LogMessage(MessageType messageType, string message, string filename = "");

    void Close();
  }
}
