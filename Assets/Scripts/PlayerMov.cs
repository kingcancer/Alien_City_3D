using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour

{   
    Rigidbody rigid;
    Animator anim;
    float movimento;
    public float puloF;
    public float velocidade;
    float giro;
    public float sensitividade;

    bool podePular;
    public float verificaDistancia;
    public Transform verificaChao;
    public LayerMask mascaraChao;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        podePular = Physics.CheckSphere(verificaChao.position,verificaDistancia,mascaraChao);
        Move();
        GiraCamera();
        AnimationCtrl();
    }

    void Move(){
        movimento = Input.GetAxis("Vertical");
        rigid.transform.Translate(Vector3.forward*movimento*velocidade*Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) && podePular)
        rigid.AddForce(Vector3.up * puloF);
    }
    void GiraCamera(){
        giro = Input.GetAxis("Horizontal");
        rigid.transform.Rotate(Vector3.up*giro*sensitividade*Time.deltaTime);
 }

 void AnimationCtrl(){
     if(movimento == 0){
        anim.SetBool("isWalking", false);
     }
    else{
         if(movimento > 0){
             anim.SetBool("isWalking", true);
              anim.SetFloat("speed", 1.0f);
             }
     else{
          if(movimento < 0){
             anim.SetBool("isWalking", true);
             anim.SetFloat("speed", -1.0f);
             }
           }
         }
     

    if(Input.GetKey(KeyCode.Space)){
         anim.SetBool("jump", true);
     }

     if(podePular){
          anim.SetBool("jump", false);
     }

 }
}
