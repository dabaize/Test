using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;

public class testscript : MonoBehaviour
{
    // Start is called before the first frame update
    [MenuItem("tool/test1")]
    static void test()
    {
        string str = "02.01.01.01.01.12&高一粒";
        string str1 = "15936226706";
        //str.IndexOf
        string s = "1abc23abc2abc";
        //Debug.Log(str.Substring(0, 8)+str.Substring(9));
        //Debug.Log(str.Remove(8,1));

        //02.83.02.02.11.12&围巾
        string pattern = "^[0][([0-9])\\.][([0-9]{2})\\.]{5}[&][.]+$";
        Regex regex = new Regex(@"^0[0-9\.][0-9\.]{5}&[.]+?$");
        var isok=regex.IsMatch(str);
        //var isok = Regex.IsMatch(str, @"^[0][0-9\.][0-9\.]{5}[&][.]+?$");


         var aa= Regex.IsMatch(str, @"^([0][0-9]\.)(?:[0-9]{2}\.){5}[&]+?[\w]+$");
        Debug.Log( isok);
        Debug.Log(aa);

    }


    // Update is called once per frame
    void Update()
    {
        
    }


    private  void CalcMul(int a, int b)
    {
    }
}



