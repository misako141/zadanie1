using System;
public class lib1 {
   static public string rev(string a) {
     string na = "";
            for (int i = a.Length-1; i >= 0; i--) 
            {
              na = na + a[i] ;
            }    
            return na;
  }
}