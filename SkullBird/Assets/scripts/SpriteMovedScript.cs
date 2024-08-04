using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovedScript : MonoBehaviour
{
    [Range(0,2)]
    public float moveSpeed = 1;
    private MeshRenderer meshRenderer;
    private Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
        offset = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        // Apply the offset to the material's main texture
        offset.x += moveSpeed * Time.deltaTime;
        meshRenderer.material.mainTextureOffset = offset;
    }
}
