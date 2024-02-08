using System;
using System.Collections;
using System.Collections.Generic;
using Core.Pool.Ref;
using UnityEngine;

public class RefTest : MonoBehaviour
{
    void Start()
    {
        TeacherData teacherData1 = ReferencePool.Acquire<TeacherData>();
        teacherData1.Name = "zzs";
        teacherData1.Age = 20;
        ReferencePool.Release(teacherData1);
        TeacherData teacherData2 = ReferencePool.Acquire<TeacherData>();
        teacherData1.Name = "xxx";
        teacherData1.Age = 18;

        Console.WriteLine(ReferencePool.GetCurrUsingRefCount<TeacherData>());
        Console.WriteLine(ReferencePool.GetAcquireRefCount<TeacherData>());
        Console.WriteLine(ReferencePool.GetReleaseRefCount<TeacherData>());
        Console.WriteLine(ReferencePool.GetAddRefCount<TeacherData>());
        Console.WriteLine(ReferencePool.GetRemoveRefCount<TeacherData>());
        Console.ReadKey();
    }

}
public class TeacherData : IReference
{
    public string Name;
    public int Age;
    public void Clear()
    {
        Name = string.Empty;
        Age = 0;
    }
}
