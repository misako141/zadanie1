using System;
public class lib1 {
   static public string remov (string str, string s) {
for (int i = 0; i < s.Length; i++) {
  string g = s[i].ToString();
      str = str.Replace(g, "");
}
     return str;
  }
}