using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;

public class DirectoryDemo : MonoBehaviour
{
    public string m_SourceDirectory = @"C:\Users\user\Desktop\Current";
    public string m_ArchiveDirectory = @"C:\Users\user\Desktop\Archive";
    // Start is called before the first frame update
    void Start()
    {
        var files = from retrievedFile in Directory.EnumerateFiles(m_ArchiveDirectory, "*.txt", SearchOption.AllDirectories)
                    from line in File.ReadLines(retrievedFile)
                    where line.Contains("Example")
                    select new
                    {
                        File = retrievedFile,
                        Line = line
                    };

        foreach (var f in files)
        {
            Debug.Log($"{f.File} contains {f.Line}");
        }
        Debug.Log($"{files.Count()} lines found");

    }


    void Start1()
    {
        try
        {
            var txtFiles = Directory.EnumerateFiles(m_SourceDirectory, "*.txt");
            foreach(string currentFile in txtFiles)
            {
                string fileName = currentFile.Substring(m_SourceDirectory.Length +1);
                Directory.Move(currentFile, Path.Combine(m_ArchiveDirectory, fileName));
            }
        }
        catch(Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
