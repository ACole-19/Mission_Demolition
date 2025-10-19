using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberBand : MonoBehaviour {
    static List<RubberBand> BANDLINES = new List<RubberBand>();

    void Start() {
        BANDLINES.Add(this);
    }

    private void OnDestroy() {
        BANDLINES.Remove(this);
    }

    static public void DESTROY_BANDLINES() {
        foreach (RubberBand r in BANDLINES)
        {
            Destroy(r.gameObject);
        }
    }

}
