﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Attributes;
public enum UNodeType { Text, Function, If, Start, GoTo,Error }
[System.Serializable]

public class UNode 
{
    [Header("Base")]
    public Rect rect;
    public UNodeType type = UNodeType.Error;
    public List<int> outs = new List<int>();
    public int id;
    [Header("Text")]
    [ConditionalField("type",UNodeType.Text)] public string characterName="[Character Name]";
    [ConditionalField("type", UNodeType.Text)] public string text = "[Text]";
    [ConditionalField("type",UNodeType.Text)] public List<string> responses = new List<string>();
    [Header("Func")]
    [ConditionalField("type", UNodeType.Function)] public string funcData;
    [Header("If")]
    [ConditionalField("type", UNodeType.If)] public string ifData;
    [Header("GoTo")]
    [ConditionalField("type", UNodeType.If)] public string UDNElink;
    public UNode(Vector2 pos, int id)
    {
       
        rect = new Rect(pos, Vector2.zero);
        type =UNodeType.Error;
        this.id = id; 
    }
    
   
}