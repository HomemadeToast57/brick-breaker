﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeColliderHack : MonoBehaviour{
    private PolygonCollider2D poly;

    private void Awake() {
        poly = GetComponent<PolygonCollider2D>();
        if(poly == null){
            poly = gameObject.AddComponent<PolygonCollider2D>();
        }
        Vector2[] points = poly.points;
        EdgeCollider2D edge = gameObject.AddComponent<EdgeCollider2D>();
        edge.points = points;
        Destroy(poly);
    }
}
