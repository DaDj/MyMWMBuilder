// Decompiled with JetBrains decompiler
// Type: MwmBuilder.Configuration.MyLODConfiguration
// Assembly: MwmBuilder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47A6C2F8-C9D4-4065-959F-7D7436A7009C
// Assembly location: E:\Steam\SteamApps\common\SpaceEngineersModSDK\Tools\MwmBuilder\MwmBuilder.exe

using System.Xml.Serialization;

namespace MwmBuilder.Configuration
{
  [XmlRoot("LOD")]
  public class MyLODConfiguration
  {
    [XmlAttribute("Distance")]
    public float Distance;
    [XmlAttribute("RenderQuality")]
    public string RenderQuality;
    [XmlElement("Model")]
    public string Model;

    public override int GetHashCode()
    {
      int hashCode = this.Distance.GetHashCode();
      int num = hashCode | hashCode * 397 ^ (this.RenderQuality == null ? "".GetHashCode() : this.RenderQuality.GetHashCode());
      return num | num * 397 ^ (this.Model == null ? "".GetHashCode() : this.Model.GetHashCode());
    }
  }
}
