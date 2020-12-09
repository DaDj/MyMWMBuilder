// Decompiled with JetBrains decompiler
// Type: MwmBuilder.Configuration.MyModelParameter
// Assembly: MwmBuilder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47A6C2F8-C9D4-4065-959F-7D7436A7009C
// Assembly location: E:\Steam\SteamApps\common\SpaceEngineersModSDK\Tools\MwmBuilder\MwmBuilder.exe

using System.Xml.Serialization;

namespace MwmBuilder.Configuration
{
  public class MyModelParameter
  {
    [XmlAttribute("Name")]
    public string Name;
    [XmlText]
    public string Value;

    public override int GetHashCode() => this.Name.GetHashCode() * (!string.IsNullOrEmpty(this.Value) ? this.Value.GetHashCode() : 1);
  }
}
