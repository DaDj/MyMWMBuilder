// Decompiled with JetBrains decompiler
// Type: MwmBuilder.Configuration.MyMaterialConfiguration
// Assembly: MwmBuilder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47A6C2F8-C9D4-4065-959F-7D7436A7009C
// Assembly location: E:\Steam\SteamApps\common\SpaceEngineersModSDK\Tools\MwmBuilder\MwmBuilder.exe

using System.Xml.Serialization;

namespace MwmBuilder.Configuration
{
  [XmlRoot("Material")]
  public class MyMaterialConfiguration
  {
    [XmlAttribute("Name")]
    public string Name;
    [XmlElement("Parameter")]
    public MyModelParameter[] Parameters;

    public override int GetHashCode()
    {
      int hashCode = this.Name.GetHashCode();
      foreach (MyModelParameter parameter in this.Parameters)
        hashCode += parameter.GetHashCode();
      return hashCode;
    }
  }
}
