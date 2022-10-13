using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    private MeshRenderer meshRenderer;
    private float Xscroll;
    // Start is called before the first frame update
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll(){
        Xscroll = Time.time * scrollSpeed;
        Vector2 offset = new Vector2(Xscroll,0f);
        meshRenderer.sharedMaterial.SetTextureOffset("_MainTex",offset);
    }
}
