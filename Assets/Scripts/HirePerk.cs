using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HirePerk : MonoBehaviour
{
    public string Id { get; set; }
    public string GroupId {get;set;}
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Keyword> Keywords { get; set; }
}
