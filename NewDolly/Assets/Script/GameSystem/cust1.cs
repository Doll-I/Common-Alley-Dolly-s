using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class cust1 : MonoBehaviour
{
    public static bool mission; //의뢰 받았는지 mission
    public bool quest = false; //들어온 quest가 있는지 (있으면 icon)
    public GameObject text, balloon, quest_i, quest_main, quest_cust, quest_doll, sign, quest_body;
    public TextMeshProUGUI txt;
    private Animation anim;
    public GameObject but; //quest내의 수락버튼 인식
    private Scene scene;


    void Start() {
        quest_body.SetActive(false);
        balloon.SetActive(false);
        text.SetActive(false);
        mission = false;
        quest_i.SetActive(false);
        quest_main.SetActive(false);
        but.SetActive(false);
        quest_cust.SetActive(false);
        quest_doll.SetActive(false);
        sign.SetActive(false);
        anim = GetComponent<Animation>();
        scene = SceneManager.GetActiveScene();
        Invoke("goBalloon", 4.6f);
    }

    void goBalloon(){ //처음 말풍선 나타내기
        balloon.SetActive(true); //말풍선
        text.SetActive(true); //글씨
        Invoke("SetBalloon", 3f);
    }

    void SetBalloon(){ //두번째 대사
        if (scene.name == "customerScene")
            txt.text ="인형 세탁과 수선 부탁드려요!!\n가능할까요?";
        else
            txt.text = "고마워요!";
        quest = true; //quest가 들어옴
    }

    public void quest_open(){ //퀘스트 아이콘 클릭
        text.SetActive(true); //대사 안보이게
        balloon.SetActive(false); //말풍선 안보임
        quest_main.SetActive(true); //대빵큰 퀘스트 종이 보이게
        quest_cust.SetActive(true);
        quest_doll.SetActive(true);
        quest_body.SetActive(true);
        if (scene.name == "customerSceneComplete")
            sign.SetActive(true);
        but.SetActive(true); //수락 버튼 활성화
    }

    public void quest_agree(){ //의뢰 수락시
        sign.SetActive(true);
        SoundManager.instance.PlaySign();
        Invoke("quest_main_disappear", 3f);
    }

    void quest_main_disappear(){
        quest_body.SetActive(false);
        quest_cust.SetActive(false);
        quest_doll.SetActive(false);
        quest_main.SetActive(false);
        mission = true;
    }

    void Update(){
        if (quest == true && scene.name!= "customerSceneComplete")
        { //들어온 의뢰가 있으면
            quest_i.SetActive(true); // 퀘스트 아이콘 활성화
        }

         if (Input.GetKeyDown(KeyCode.W)) { //지금은 되나 시범상 w누르면 나감
             balloon.SetActive(false);
             //text.SetActive(false);
             anim.Play("custOut"); // 걸어나가는 모션은 만들어두겠음
             //sign.SetActive(false);
             //quest_cust.SetActive(false);
             //quest_doll.SetActive(false);
             //quest_main.SetActive(false);
          } 
    }
}
