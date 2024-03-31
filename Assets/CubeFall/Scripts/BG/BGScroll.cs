using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float scrool_Speed = 0.3f;

    private MeshRenderer mesh_Renderer;

    void Awake()
    {

        mesh_Renderer = GetComponent<MeshRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        Vector2 offset = mesh_Renderer.sharedMaterial.GetTextureOffset(TextureOffsets.MAIN_TEXT_TAG);
        offset.y += Time.deltaTime * scrool_Speed;

        mesh_Renderer.sharedMaterial.SetTextureOffset(TextureOffsets.MAIN_TEXT_TAG, offset);
    }
}
