using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using UnityEditor;
using UnityEngine;

[ObsoleteAttribute]
public class SomeClass
{

}

public class SomeClass2
{
}


public class Program : MonoBehaviour
{
    StringBuilder builder = new StringBuilder();

    void FixedUpdate()
    {

    }

    public override int GetHashCode()
    {
        String str =  "";
        return base.GetHashCode();
    }

    public override string ToString() {
        return base.ToString();
    }

}
