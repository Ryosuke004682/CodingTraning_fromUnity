using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test_2 : MonoBehaviour
{
    MeshFilter meshFilter;

    private void Start()
    {
        meshFilter = this.GetComponent<MeshFilter>();

        if (meshFilter == null)
        {
            meshFilter = this.gameObject.AddComponent<MeshFilter>();
        }
    }

    private void Update() => ChangeMesh();


    /// <summary>
    /// マウスのクリックでオブジェクトの形状を変えるコード
    /// </summary>
    protected void ChangeMesh()
    {
        if (Input.GetMouseButtonDown(0))
        {
            meshFilter.mesh = CreateSphereMesh();// 新しい球のメッシュを作成
        }
        else if(Input.GetMouseButtonUp(0))
        {
            meshFilter.mesh = MeshSquareCreate();// 新しい四角のメッシュを作成
        }
    }

    /// <summary>
    /// 球のメッシュを作成する。
    /// </summary>
    /// <returns></returns>
    private Mesh CreateSphereMesh()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Mesh sphereMesh = sphere.GetComponent<MeshFilter>().mesh;
        Destroy(sphere);
        return sphereMesh;
    }

    /// <summary>
    /// 四角形のメッシュを作成する。
    /// </summary>
    /// <returns></returns>
    private Mesh MeshSquareCreate()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Mesh cubeMesh = cube.GetComponent<MeshFilter>().mesh;
        Destroy(cube);
        return cubeMesh;
    }
}
