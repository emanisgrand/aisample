﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public enum PathDisplayMode{None, Connections, Paths}

public class AIWaypointNetwork : MonoBehaviour
{
   public PathDisplayMode DisplayMode = PathDisplayMode.Connections;
   public int UIStart = 0;
   public int UIEnd = 0;
   
   public List<Transform> Waypoints = new List<Transform>();
}
