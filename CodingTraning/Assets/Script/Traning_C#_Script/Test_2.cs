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
    /// �}�E�X�̃N���b�N�ŃI�u�W�F�N�g�̌`���ς���R�[�h
    /// </summary>
    protected void ChangeMesh()
    {
        if (Input.GetMouseButtonDown(0))
        {
            meshFilter.mesh = CreateSphereMesh();// �V�������̃��b�V�����쐬
        }
        else if(Input.GetMouseButtonUp(0))
        {
            meshFilter.mesh = MeshSquareCreate();// �V�����l�p�̃��b�V�����쐬
        }
    }

    /// <summary>
    /// ���̃��b�V�����쐬����B
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
    /// �l�p�`�̃��b�V�����쐬����B
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
