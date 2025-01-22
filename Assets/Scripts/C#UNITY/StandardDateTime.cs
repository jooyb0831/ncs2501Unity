using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class StandardDateTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DateTime dt = DateTime.Now;
    
        Debug.Log(dt.ToString("d",CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),"한국 {0:d}", dt));
        Debug.Log($"한국 {dt.ToString("d",CultureInfo.CreateSpecificCulture("ko-KR"))}");

        Debug.Log(dt.ToString("D",CultureInfo.CreateSpecificCulture("ja-JP")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),"{0:D}", dt));
        Debug.Log($"한국 {dt.ToString("D",CultureInfo.CreateSpecificCulture("ko-KR"))}");

        Debug.Log(dt.ToString("F",CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),"{0:f}",dt));
        Debug.Log($"한국 {dt.ToString("F",CultureInfo.CreateSpecificCulture("ko-KR"))}");

        Debug.Log(dt.ToString("U", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), "{0:U}", dt));

        Debug.Log(string.Format("{0:yyyMMdd_HHmmss}",dt));
        Debug.Log($"{dt:yyyMMdd_HHmmss}");
        Debug.Log($"{dt:d} {dt:ddd}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
