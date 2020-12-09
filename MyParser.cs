// Decompiled with JetBrains decompiler
// Type: MwmBuilder.MyParser
// Assembly: MwmBuilder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47A6C2F8-C9D4-4065-959F-7D7436A7009C
// Assembly location: E:\Steam\SteamApps\common\SpaceEngineersModSDK\Tools\MwmBuilder\MwmBuilder.exe

using System;
using System.Globalization;

namespace MwmBuilder
{
  public class MyParser
  {
    public static T Parse<T>(object value) => typeof (T).IsEnum ? (T) Enum.Parse(typeof (T), (string) value) : (T) Convert.ChangeType(value, typeof (T), (IFormatProvider) CultureInfo.InvariantCulture);
  }
}
