using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TextControler : MonoBehaviour {
    public Text text; //StateText, ChoiseText;
    private enum States { State0, State1, State2, State3, State4, State5, State6, State7, State8, State9, State10,
        State11, State12, State13, State14, State15, State16, State17, State18, State19, State20,
        State21, State22, State23, State24, State25, State26, State27, State28, State29, State30,
        State31, State32, State33, State34, State35, State36, State37, State38, State39, State40,
        State41, State42, State43, State44, State45, State46, State47, State48, State49, State50,
        State51, State52, State53, State54, State55, State56, State57, State58, State59, State60,
        State61, State62, State63, State64, State65, State66, State67, State68, State69, State70,
        State71, State72, State73, State74, State75, State76, State77, State78, State79, State80,
        State81, State82, State83, State84, State85, State86, State87, State88, State89, State90,
        State91, State92, State93, State94, State95, State96, State97, State98, State99, State100,
        State101, State102, State103, State104, State105, State106, State107, State108
    }
    private States myState;
    private int Choise;
    public Button One, Two, Three, Four, Five;
    public GameObject star, germanCross, sovietStar, PPSH, MP40, TNT, TNTSwitch, map,  mesageTNT;

    private string mashinegun = "ППШ", eqipe = "Soviet", tntPlant = "None";
    private bool tntHave = false, haveMap = false;
    
    // 13 - переоделся в форму ??? и там же выбор взять ППШ или МП40  54 ставите фугас если взяли если он есть то при переходе сюда должен быть вариант поставить 
    //58 ветка в  немецкой форме. 82 83 - 2 варианта взрыва например заминирова что-то далеко. 70 если в руках ППШ смерть

    // Use this for initialization
    void Start() {
        myState = States.State0;
        Choise = 0;
        One.gameObject.SetActive(false);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        MP40.gameObject.SetActive(false);
        germanCross.gameObject.SetActive(false);
        TNT.gameObject.SetActive(false);
        TNTSwitch.gameObject.SetActive(false);
        mesageTNT.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ShowState();
        if (myState == States.State0 )
        {
            Quest_State0();
        }else
        if (myState == States.State1)
        {
            Quest_State1();
        }
        else
        if (myState == States.State2 )
        {
            Quest_State2();
        }
        else
        if (myState == States.State3)
        {
            Quest_State3();
        }
        else
        if (myState == States.State4)
        {
            Quest_State4();
        }
        else
        if (myState == States.State5)
        {
            Quest_State5();
        }
        else
        if (myState == States.State6)
        {
            Quest_State6();
        }
        else
        if (myState == States.State7)
        {
            Quest_State7();
        }
        else
        if (myState == States.State8)
        {
            Quest_State8();
        }
        else
        if (myState == States.State9)
        {
            Quest_State9();
        }
        else
        if (myState == States.State10)
        {
            Quest_State10();
        }
        else
        if (myState == States.State11)
        {
            Quest_State11();
        }
        else
        if (myState == States.State12)
        {
            Quest_State12();
        }
        else
        if (myState == States.State13)
        {
            Quest_State13();
        }
        else
        if (myState == States.State14)
        {
            Quest_State14();
        }
        else
        if (myState == States.State15)
        {
            Quest_State15();
        }
        else
        if (myState == States.State16)
        {
            Quest_State16();
        }
        else
        if (myState == States.State17)
        {
            Quest_State17();
        }
        else
        if (myState == States.State18)
        {
            Quest_State18();
        }
        else
        if (myState == States.State19)
        {
            Quest_State19();
        }
        else
        if (myState == States.State20)
        {
            Quest_State20();
        }
        else
        if (myState == States.State21)
        {
            Quest_State21();
        }
        else
        if (myState == States.State22)
        {
            Quest_State22();
        }
        else
        if (myState == States.State23)
        {
            Quest_State23();
        }
        else
        if (myState == States.State24)
        {
            Quest_State24();
        }
        else
        if (myState == States.State25)
        {
            Quest_State25();
        }
        else
        if (myState == States.State26)
        {
            Quest_State26();
        }
        else
        if (myState == States.State27)
        {
            Quest_State27();
        }
        else
        if (myState == States.State28)
        {
            Quest_State28();
        }
        else
        if (myState == States.State29)
        {
            Quest_State29();
        }
        else
        if (myState == States.State30)
        {
            Quest_State30();
        }
        else
        if (myState == States.State31)
        {
            Quest_State31();
        }
        else
        if (myState == States.State32)
        {
            Quest_State32();
        }
        else
        if (myState == States.State33)
        {
            Quest_State33();
        }
        else
        if (myState == States.State34)
        {
            Quest_State34();
        }
        else
        if (myState == States.State35)
        {
            Quest_State35();
        }
        else
        if (myState == States.State36)
        {
            Quest_State36();
        }
        else
        if (myState == States.State37)
        {
            Quest_State37();
        }
        else
        if (myState == States.State38)
        {
            Quest_State38();
        }
        else
        if (myState == States.State39)
        {
            Quest_State39();
        }
        else
        if (myState == States.State40)
        {
            Quest_State40();
        }
        else
        if (myState == States.State41)
        {
            Quest_State41();
        }
        else
        if (myState == States.State42)
        {
            Quest_State42();
        }
        else
        if (myState == States.State43)
        {
            Quest_State43();
        }
        else
        if (myState == States.State44)
        {
            Quest_State44();
        }
        else
        if (myState == States.State45)
        {
            Quest_State45();
        }
        else
        if (myState == States.State46)
        {
            Quest_State46();
        }
        else
        if (myState == States.State47)
        {
            Quest_State47();
        }
        else
        if (myState == States.State48)
        {
            Quest_State48();
        }
        else
        if (myState == States.State49)
        {
            Quest_State49();
        }
        else
        if (myState == States.State50)
        {
            Quest_State50();
        }
        else
        if (myState == States.State51)
        {
            Quest_State51();
        }
        else
        if (myState == States.State52)
        {
            Quest_State52();
        }
        else
        if (myState == States.State53)
        {
            Quest_State53();
        }
        else
        if (myState == States.State54)
        {
            Quest_State54();
        }
        else
        if (myState == States.State55)
        {
            Quest_State55();
        }
        else
        if (myState == States.State56)
        {
            Quest_State56();
        }
        else
        if (myState == States.State57)
        {
            Quest_State57();
        }
        else
        if (myState == States.State58)
        {
            Quest_State58();
        }
        else
        if (myState == States.State59)
        {
            Quest_State59();
        }
        else
        if (myState == States.State60)
        {
            Quest_State60();
        }
        else
        if (myState == States.State61)
        {
            Quest_State61();
        }
        else
        if (myState == States.State62)
        {
            Quest_State62();
        }
        else
        if (myState == States.State63)
        {
            Quest_State63();
        }
        else
        if (myState == States.State64)
        {
            Quest_State64();
        }
        else
        if (myState == States.State65)
        {
            Quest_State65();
        }
        else
        if (myState == States.State66)
        {
            Quest_State66();
        }
        else
        if (myState == States.State67)
        {
            Quest_State67();
        }
        else
        if (myState == States.State68)
        {
            Quest_State68();
        }
        else
        if (myState == States.State69)
        {
            Quest_State69();
        }
        else
        if (myState == States.State70)
        {
            Quest_State70();
        }
        else
        if (myState == States.State71)
        {
            Quest_State71();
        }
        else
        if (myState == States.State72)
        {
            Quest_State72();
        }
        else
        if (myState == States.State73)
        {
            Quest_State73();
        }
        else
        if (myState == States.State74)
        {
            Quest_State74();
        }
        else
        if (myState == States.State75)
        {
            Quest_State75();
        }
        else
        if (myState == States.State76)
        {
            Quest_State76();
        }
        else
        if (myState == States.State77)
        {
            Quest_State77();
        }
        else
        if (myState == States.State78)
        {
            Quest_State78();
        }
        else
        if (myState == States.State79)
        {
            Quest_State79();
        }
        else
        if (myState == States.State80)
        {
            Quest_State80();
        }
        else
        if (myState == States.State81)
        {
            Quest_State81();
        }
        else
        if (myState == States.State82)
        {
            Quest_State82();
        }
        else
        if (myState == States.State83)
        {
            Quest_State83();
        }
        else
        if (myState == States.State84)
        {
            Quest_State84();
        }
        else
        if (myState == States.State85)
        {
            Quest_State85();
        }
        else
        if (myState == States.State86)
        {
            Quest_State86();
        }
        else
        if (myState == States.State87)
        {
            Quest_State87();
        }
        else
        if (myState == States.State88)
        {
            Quest_State88();
        }
        else
        if (myState == States.State89)
        {
            Quest_State89();
        }
        else
        if (myState == States.State90)
        {
            Quest_State90();
        }
        else
        if (myState == States.State91)
        {
            Quest_State91();
        }
        else
        if (myState == States.State92)
        {
            Quest_State92();
        }
        else
        if (myState == States.State93)
        {
            Quest_State93();
        }
        else
        if (myState == States.State94)
        {
            Quest_State94();
        }
        else
        if (myState == States.State95)
        {
            Quest_State95();
        }
        else
        if (myState == States.State96)
        {
            Quest_State96();
        }
        else
        if (myState == States.State97)
        {
            Quest_State97();
        }
        else
        if (myState == States.State98)
        {
            Quest_State98();
        }
        else
        if (myState == States.State99)
        {
            Quest_State99();
        }
        else
        if (myState == States.State100)
        {
            Quest_State100();
        }
        else
        if (myState == States.State101)
        {
            Quest_State101();
        }
        else
        if (myState == States.State102)
        {
            Quest_State102();
        }
        else
        if (myState == States.State103)
        {
            Quest_State103();
        }
        else
        if (myState == States.State104)
        {
            Quest_State104();
        }
        else
        if (myState == States.State105)
        {
            Quest_State105();
        }
        else
        if (myState == States.State106)
        {
            Quest_State106();
        }
        else
        if (myState == States.State107)
        {
            Quest_State107();
        }
        else
        if (myState == States.State108)
        {
            Quest_State108();
        }
    }
    void ShowState()
      {
          print("Состояние: " + myState.ToString());
          print("Выбор: " + Choise);
          print("Заряд заложен в: " + tntPlant);
          print(tntHave);
    }
    public void Choce(int sh)
    {
        switch (sh)
        {
            case 1:
                Choise = 1;
                break;
            case 2:
                Choise = 2;
                break;
            case 3:
                Choise = 3;
                break;
            case 4:
                Choise = 4;
                break;
            case 5:
                Choise = 5;
                break;
            case 6:
                Choise = 6;
                break;
            case 7:
                Choise = 7;
                break;
               
            default:
                Choise = 0;
                break;
        }
    }
    public void BlowSet()
    {
        tntPlant = myState.ToString();
    }
    #region Quests

    void Quest_State0()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Для начала нажмите кнопку один. Для ознакомления с правилами нжмите кнопку информации. ";
        
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State1;
        }
    }
    void Quest_State1()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "   Звуки выстрелов за спиной давно стихли. Сигнальные ракеты уже не взмывают в воздух, освещая передний край обороны. " +
                      "Вы все дальше и дальше удаляетесь от своих войск. И все глубже пробираетесь в глубь обороны противника.  Уже позади " +
                      "проволочные заграждения и вражеские окопы. Вам удалось преодолеть их незамеченным.  Многим не удавалось и этого. Но цель" +
                      " ваша еще впереди. \n " +
                      "   Командование поставило практически невыполнимую задачу: проникнуть в тыл к противнику и нанести на карту все стратегически" +
                      " важные объекты.Ваша экипировка состоит из автомата ППШ и ножа разведчика.Это все, что может помочь вам в выполнении вашего" +
                      " задания.\n    Вот он небольшой лесок, отмеченный на карте. Именно за ним находится деревня, занятая немцами. Вокруг ни души." +
                      "Ничто не нарушает ночной тишины.Но это впечатление обманчиво. Враг где-то рядом.Вы максимально тихо пробираетесь дальше.\n" +
                      "Далее нажмите -1.";
        if (Choise == 1 )
        {
            Choise = 0;
            myState = States.State2;

        }
    }
    void Quest_State2()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(true);
        Five.gameObject.SetActive(false);

        text.text = " Вы выходите лесную дорогу. Идете некоторое время по ней и упираетесь в развилку. На дороге, " +
                     "уходящей влево, отчетливо видны следы гусениц и автомобильных шин. Скорее всего здесь не так давно " +
                     "прошла вражеская техника. Дорога, уходящая прямо, теряется где-то в лесу. Вправо от дороги уходит " +
                     "ничем не приметная тропинка.\n" +
                     "Свернете налево – 1;  Пойдете прямо – 2;  Свернете на тропинку – 3; \n Пойдете в обратном направлении и попытаетесь вернуться к своим – 4";

        if (Choise == 1 )
        {
            myState = States.State4;
            Choise = 0;

        }
        else if (Choise == 2 )
        {
            Choise = 0;
            myState = States.State44;
        }
        else if (Choise == 3)
        {
            myState = States.State27;
            Choise = 0;
        }
        else if (Choise == 4 )
        {
            myState = States.State3;
            Choise = 0;
        }
    }
    void Quest_State3()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "   Гоните от себя эту предательскую мысль! Разведданные, за которыми вас послали, " +
                    "очень важны для командования и для предстоящего наступления. Вы не можете вернуться " +
                    "без них. На вашу карту нанесены пока что далеко не все немецкие объекты.\n" +
                    "А потому вернитесь в  обратно– 1";
        if (Choise == 1)
        {
            myState = States.State2;
            Choise = 0;
        }
    }
    void Quest_State4()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы крадетесь вдоль дороги. Так и есть! Вы вышли на небольшую поляну, "+
                    "на которой стоят грузовые машины. На их двери нанесены черные фашистские кресты. "+
                    "Вдоль машин ходит часовой с автоматом. Дорога заворачивает вправо, мимо поляны.\n"+
                    " Подкрадетесь поближе к машинам – 1 , Пойдете дальше по дороге – 2, Вернетесь на развилку – 3";
        if (Choise == 1 )
        {
            if (eqipe == "Soviet")
            {
                Choise = 0;
                myState = States.State5;
            }
            if (eqipe == "German")
            {
                Choise = 0;
                myState = States.State108;
            }
        }
        if (Choise == 2 )
        {
            Choise = 0;
            myState = States.State16;
        }
        if (Choise == 3 )
        {
            Choise = 0;
            myState = States.State2;
        }
    }
    void Quest_State5()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(true);
        Five.gameObject.SetActive(true);
        text.text = " Вы подползаете ближе к машинам. Все. Дальше нельзя. В противном случае вас может заметить часовой. Хорошо бы "+
                    "сосчитать сколько здесь грузовиков. Но с того места, где вы лежите, сделать это невозможно.  Мешают кусты и ветки "+
                    "деревьев.\n Попытаетесь подползти ближе и посчитать количество машин – 1; «Снимите» часового точным выстрелом из автомата – 2\n"+
                    "Подкрадетесь к часовому с ножом – 3; Отползете на безопасное расстояние и продолжите движение по дороге - 4; Вернетесь на развилку – 5";
        if (Choise == 1 )
        {
            Choise = 0;
            myState = States.State6;
        }
        if (Choise == 2 )
        {
            Choise = 0;
            myState = States.State8;
        }
        if (Choise == 3 )
        {
            Choise = 0;
            myState = States.State11;
        }
        if (Choise == 4)
        {
            Choise = 0;
            myState = States.State16;
        }
        if (Choise == 5 )
        {
            Choise = 0;
            myState = States.State2;
        }
    }
    void Quest_State6()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы подползаете еще на несколько метров. Но часового привлек шорох. Он передергивает затвор автомата и движется "+
                    "в вашу сторону.\n Броситесь на часового с ножом – 1; Дадите по нему очередь из автомата – 2; \n"+
                    "Затаитесь в надежде, что он все - таки вас не заметит – 3 ";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State7;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State8;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State10;
        }
    }
    void Quest_State7()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы выхватываете нож и бросаетесь на часового. Но разделяющее вас расстояние слишком велико. Фашист вскидывает "+
            "автомат и делает несколько прицельных выстрелов. \n Перейти далее – 1";
        if (Choise == 1 )
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State8()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы переключаете автомат на режим стрельбы одиночными выстрелами. Приклад плотно прижат к плечу. Долго целитесь "+
                    "и нажимаете на спусковой крючок. Раздается оглушительный выстрел. Немец хватается за грудь и падает в траву."+
                    "Но на звуки выстрела со всех сторон бежит подмога.Кругом слышны выстрелы и лай собак. Вы принимаете бой.Но силы "+
                    "слишком не равны.\n Перейти далее – 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State9()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(true);
        text.text = "Через несколько дней ваше командование, так и не получив необходимых разведданных, все-таки предпринимает попытку "+
                    "наступления. Но наши войска попадают в окружение и несут огромные потери. В результате чего фашистские захватчики "+
                    "все дальше продвигаются вглубь советской территории.\n Начать с начала - 1 \n Выйти в меню - 5";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State0;
        }
        if (Choise == 5)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        }
    }
    void Quest_State10()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Часовой проходит буквально в шаге от вас. Но высокая трава не дала ему вас заметить. Вы лежите затаив дыхание. "+
                    "Сердце стучит так громко, что кажется удивительным, что немец не слышит его биения. \n  Потоптавшись немного возле "+
                    "вас и так и не поняв, что же все - таки привлекло его внимание, немец возвращается к машинам. \n Перейти далее – 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State5;
        }
    }
    //Возможность сменить форму. в 11 и 12. А в 13 автомат
    void Quest_State11()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(true);
        Five.gameObject.SetActive(false);
        text.text = "Вы откладываете в сторону автомат и вынимаете из ножен нож. Хорошее оружие – нож разведчика.\n"+  
                    "Еще в 1940 году стало очевидно, что разведывательно-диверсионная деятельность и контрразведка станет одним "+
                    "из главных направлений боевых действий. На основе финского национального ножа «пуукко» советское военное командование "+
                    "разработало новый универсальный нож, который получил аббревиатуру – НР(нож разведчика).Его можно было использовать не "+
                    "только как оружие, но и как универсальный бытовой инструмент.\n Но сейчас вам пригодятся только его боевые свойства. "+
                    "При колющем ударе нож достаточно легко поражает противника, одетого даже в зимнее толстое обмундирование. Вы подкрадываетесь"+
                    " к часовому. Один точный резкий взмах. Острое лезвие блеснуло в свете луны, и немец бесшумно упал на землю.Вы подхватываете "+
                    "его под руки и оттаскиваете в кусты.Теперь можно и осмотреться.\n Осмотрите стоянку машин – 1; Пойдете дальше по дороге – 2;\n"+
                    "Вернетесь на развилку – 3; Переоденетесь в форму убитого немца – 4";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State12;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State16;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State2;
        }
        if (Choise == 4)
        {
            Choise = 0;
            myState = States.State13;
            germanCross.gameObject.SetActive(true);
            sovietStar.gameObject.SetActive(false);
            eqipe = "German";

        }
    }
    void Quest_State12()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        if (eqipe == "Soviet")
        {
            Three.gameObject.SetActive(true);
        }

        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        if (tntHave && tntPlant == "None")
        {
            TNT.gameObject.SetActive(true);
        }
        text.text = " Вы осматриваете  стоянку машин. Пятнадцать, шестнадцать, семнадцать, восемнадцать… Восемнадцать тяжелых грузовиков." +
                    " Вам хорошо знакомы эти машины. Это «Mercedes-Benz L 4500 S». Вам рассказывали о них в разведшколе. Немцы широко" +
                    " используют их как для перевозки грузов, так и личного состава. Интересно, для чего они здесь?\n" +
                    "Вы наносите новые данные на свою карту. \n Пойдете дальше по дороге – 1; Вернетесь на развилку – 2; \n";
        if (eqipe == "Soviet") {
            text.text += "Переоденетесь в форму убитого немца – 3";
        }
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State16;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State2;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State13;
            germanCross.gameObject.SetActive(true);
            sovietStar.gameObject.SetActive(false);
            eqipe = "German";
        }
    }
    void Quest_State13()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы снимаете форму с убитого немца и переодеваетесь в нее.\n Стоит ли брать немецкий автомат? Вы с сомнением "+
                    "смотрите на МП - 40.Многим он знаком под названием Шмайсер.Весит чуть меньше вашего пистолета - пулемета Шпагина.Но "+
                    "и магазин вмещает всего 32 патрона, против 71 - го патрона в диске ППШ. Немецкий солдат с русским автоматом не должен "+
                    "ни у кого вызвать подозрений. Немцы довольно-таки часто использовали из в качестве трофейных.  Но два автомата вы точно "+
                    "не можете себе позволить.Уж слишком они будут сковывать ваши движения.Нужно сделать выбор.\n Возьмете немецкий МП - 40 – 1;"+
                    "Останетесь при своем ППШ – 2";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State14;
            MP40.gameObject.SetActive(true);
            PPSH.gameObject.SetActive(false);

        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State15;
            MP40.gameObject.SetActive(false);
            PPSH.gameObject.SetActive(true);
        }
    }
    void Quest_State14()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Поколебавшись немного, вы берете немецкий автомат и вынимаете из него магазин. Полный. Отлично! Одев его на плечо, "+
                    "вы кладете свой ППШ рядом с убитым немцем. \n Осмотрите стоянку машин – 1; Пойдете дальше по дороге – 2; Вернетесь на развилку – 3";
        mashinegun = "MP40";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State12;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State16;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State2;
        }
    }
    void Quest_State15()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "И все-таки отечественный пистолет-пулемет Шпагина вам ближе. Оставив МП-40 рядом с убитым "+
                    "немцем, вы идете дальше.\n Осмотрите стоянку машин – 1; Пойдете дальше по дороге – 2; Вернетесь на развилку – 3";
        mashinegun = "ППШ";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State12;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State16;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State2;
        }
    }
    void Quest_State16()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы снова оказались на развилке. Одна дорога уходит налево. Кажется, там виднеется какой-то "+
                    "ангар. Странно… Его нет на вашей карте. С дороги, уходящей направо, слышны невнятные голоса.\n"+
                    "Пойдете налево к ангару – 1; Пойдете направо – 2; Вернетесь к поляне – 3";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State21;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State17;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State4;
        }
    }
    void Quest_State17()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы подкрадываетесь ближе. Четко слышна немецкая речь. Внимательно прислушиваетесь. Ничего "+
                    "интересного. Трое немецких солдат перемывают кости своему начальству. А что там виднеется "+
                    "за их спинами?! Кажется замаскированные танки!\n Подкрадетесь поближе – 1; Атакуете немцев – 2"+
                    " Вернетесь на развилку – 3";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State20;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State18;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State16;
        }
    }
    void Quest_State18()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Главное – элемент неожиданности. Немцы никак не ожидают, что здесь, в глубоком тылу, может "+
                    "находиться советский диверсант. Вы кладете палец на спусковой крючок. Пот застилает глаза. "+
                    "Сейчас или никогда! Вы делаете несколько очередей из автомата. Двое немцев с криками падают "+
                    "на землю.Но один успевает спрятаться за гусеницей танка и дает ответную очередь по кустам рядом"+
                    " с вами. Завязывается перестрелка. Нужно уходить. Через несколько минут здесь будет подкрепление.\n"+
                    "Кинетесь бежать в обратном направлении – 1; Продолжите перестрелку с немцем – 2";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State19;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State8;
        }
    }
    void Quest_State19()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Шум погони все ближе. За спиной слышны выстрелы и лай собак. Пули свистят буквально у вас "+
                    "над головой. Впереди болото. Нужно попробовать уйти от преследования через него. Это ваш "+
                    "единственный шанс.\n Выберете – 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State20()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы подползаете к немцам совсем близко. Так и есть. За их спинами стоят затянутые "+
                    "маскировочной сетью немецкие танки Тигр. Вы поднимаете голову, чтобы осмотреться получше. "+
                    "Этого оказывается вполне достаточно для того, чтобы один из немцев вас заметил.Он поднимает "+
                    "тревогу.Вы принимаете бой.Но силы слишком не равны.\n Перейдите далее – 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State21()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Действительно в лесу откуда-то появился огромный металлический ангар. Интересно, что же "+
                    "там внутри? Перед входом сидит часовой и играет на губной гармошке какую-то известную "+
                    "мелодию.\n Попытаетесь отвлечь внимание часового и проскользнуть внутрь ангара-1; "+
                    "«Снимите» часового точным выстрелом – 2; Подкрадетесь к нему с ножом – 3";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State23;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State8;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State22;
        }
    }
    void Quest_State22()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы откладываете автомат в сторону и достаете нож из ножен. Пригнувшись, все ближе подкрадываетесь к часовому."+ 
                    " Но тут под вашей ногой предательски хрустнула ветка. Немец вскакивает на ноги и хватается за автомат. "+
                    "На секунду ваши взгляды встречаются.Наполненные злобой глаза фашиста – последнее, что осталось у вас в памяти.\n"+
                    " Перейти далее – 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State23()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы берете с земли небольшой камень и кидаете его в сторону от ангара. Немец вскакивает на ноги, хватается за "+
                    "автомат и медленно отходит в сторону, откуда раздался шорох.\n Проскользнете внутрь ангара – 1; Вернетесь на развилку от греха – 2";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State24;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State16;
        }
    }
    void Quest_State24()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы проскальзываете внутрь ангара. Глаза постепенно привыкают к темноте. Все внутреннее пространство от пола "+
                    "до потолка занимают ящики. Похоже, боеприпасы. Видимо, здесь оборудован немецкий склад. В дальнем конце склада "+
                    "какие-то ящики накрыты брезентом. Нужно уходить. Часовой может вернуться в любую секунду. \n"+
                    "Выскользнете из ангара и вернетесь на развилку – 1; Посмотрите, что в ящиках, накрытых брезентом – 2";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State25;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State26;
        }
    }
    void Quest_State25()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы незамеченным покидаете ангар. Удалось добыть очень важную информацию. Нанеся на карту немецкий склад боеприпасов, "+
                    "вы возвращаетесь на развилку. \n Перейдите далее – 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State16;
        }
    }
    //Теперь для того, чтобы заложить радиоуправляемый фугас, вам нужно брибавить +8 к номеру той главы, где вы захотите это сделать.
    void Quest_State26()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        if (tntHave && tntPlant == "None")
        {
            TNT.gameObject.SetActive(true);
        }
        text.text = " Вы сдергиваете брезент. Ящики плотно забиты гвоздями. С помощью ножа без особого труда удается вскрыть их. " +
                    "Замечательная находка! В одном из них, аккуратно проложенные промасленной бумагой, советские радиоуправляемые" +
                    " фугасы Ф-10.  В другом - радиовзрыватели к ним.Фашистам так и не удалось наладить серийное производство своих " +
                    "радиоуправляемых фугасов.Советский союз далеко опередил их в этом.И по-этому они пользуются в основном трофейными." +
                    "Прихватив с собой один комплект, вы направляетесь к выходу.  \n Перейдите далее – 1";
        if (Choise == 1)
        {
            tntHave = true;
            Choise = 0;
            myState = States.State25;
        }
    }
    void Quest_State27()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы сворачиваете на тропинку. Постепенно она все больше расширяется. Похоже, здесь "+
            "довольно-таки часто ходят люди. В воздухе повеяло запахом каши. Эх, перекусить бы сейчас… "+
            "Живот неприятно свело. Проглотив слюну, вы идете дальше."+
            "Тропинка упирается в палаточный городок.Видимо, здесь располагаются основные силы немцев.\n"+
            "Пойдете через палаточный городок – 1; Попытаетесь обогнуть его лесом – 2; ";
        if (Choise == 1 )
        {
            Choise = 0;
            myState = States.State28;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State31;
        }
    }
    void Quest_State28()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы проскальзываете между палаток. Кое-где горят костры. Немецкие солдаты греются возле них, лениво переговариваясь между"+
                    " собой. Один отделился от общей массы, отошел в сторону и закурил. Вот бы взять языка и хорошенько расспросить его о том,"+
                    " как расположились немецкие войска! \n"+
                    " Попытаетесь оглушить немца - 1; Пойдете дальше через палаточный городок – 2; Вернетесь на развилку – 3";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State29;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State30;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State27;
        }
    }
    void Quest_State29()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Подкравшись к солдату, вы сбиваете его с ног, прижимаете к земле и закрываете рот ладонью. Но падающий солдат"+
                    " наделал столько шума, что незамеченным это не осталось. Со всех сторон к вам бегут вооруженные немцы. Ведь "+
                    "сказано же было вам: «без лишнего шума произвести разведку и вернуться в расположение части». Ваша инициатива "+
                    "дорого вам обошлась. Перейдите далее - 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State30()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы бесшумно крадетесь дальше. Палаточный городок остался позади. Тропинка уходит дальше в лес.\n"+
                    "Перейдите далее - 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State32;
        }
    }
    void Quest_State31()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы забираетесь поглубже в лес и обходите палаточный городок стороной. Сквозь деревья видны отблески костров, "+
                    "слышны голоса немцев. Постепенно, по мере того, как вы уходите все дальше, они стихают. Вы снова выходите на "+
                    "тропинку.\n Перейдите далее - 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State32;
        }
    }
    void Quest_State32()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(true);
        Five.gameObject.SetActive(false);
        text.text = "Через некоторое время вы снова оказались на развилке. Со стороны тропинки, которая уходит влево, отчетливо "+
                    "чувствуется запах еды. Справа виднеется какой-то брезентовый навес над землей. Тропинка, уходящая прямо, "+
                    "ничем не примечательна.\n Вернетесь назад – 1; Свернете налево – 2; Пойдете к навесу – 3; Пойдете прямо – 4";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State2;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State35;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State33;
        }
        if (Choise == 4)
        {
            myState = States.State37;
        }
    }
    void Quest_State33()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы подкрадываетесь ближе. Под навесом стоят несколько деревянных столов. За одним из них сидят два немца "+
                    "и едят кашу из котелков. К дереву прибит металлический рукомойник. Видимо, здесь у них оборудовано место "+
                    "для приема пищи. Да-а-а… Хорошо окопались. Ничего не скажешь.\n Значит, где - то рядом должна быть полевая кухня."+
                    "Подкрадетесь к немцам – 1; Вернетесь назад - 2";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State34;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State32;
        }
    }
    void Quest_State34()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы подползаете ближе к немцам в надежде услышать из их разговора какую-нибудь полезную информацию. Слишком "+
                    "близко! Они заметили вас. Один из них выронил ложку и схватился за автомат. Вы вскидываете свой ППШ, но не "+
                    "успеваете сделать ни единого выстрела.\n Перейдите далее - 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State35()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы сворачиваете налево. Вот она, полевая кухня! Толстый немец в белом фартуке что-то мешает в огромном котле."+
                    " Вот бы заглянуть туда! Повар закрыл котел и отошел в ближайшие кусты. Видимо у него какие-то дела там.\n"+
                    "Вернетесь на развилку – 1; Подбежите к котлу – 2";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State32;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State36;
        }
    }
    void Quest_State36()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Пока повара нет рядом, вы подбегаете к котлу, снимаете крышку и заглядываете в него. Ах, какая вкуснота!"+
                    " Схватив со стола килограммовую пачку соли, вы всю, без остатка, высыпаете ее в котел. Жрите, фрицы!\n"+
                    "После чего, закрыв крышку, скрываетесь в лесу\n Перейдите далее -1;";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State32;
        }
    }
    void Quest_State37()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы проходите дальше по ни чем не приметной тропинке, все дальше удаляясь от аппетитного запаха. Через "+
                    "некоторое время выходите на деревенское кладбище. Покосившиеся кресты, уханье филина… Жутковато. До "+
                    "рассвета еще далеко. Не лучше ли вернуться?\n Вернетесь на развилку – 1; Пойдете дальше – 2";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State32;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State38;
        }
    }
    void Quest_State38()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Миновав кладбище, вы все дальше углубляетесь в лес. Неожиданно впереди появляется какой-то просвет. "+
                    "Это просека. В центре нее железнодорожная насыпь. Вы вскарабкиваетесь на нее. Вправо и влево уходят в"+
                    " бесконечную даль рельсы.\n Вернетесь назад – 1; Пойдете влево по рельсам – 2; Пойдете вправо по рельсам – 3";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State32;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State41;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State39;
        }
    }
    void Quest_State39()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы бежите по шпалам, стараясь не спотыкаться. Все дальше и дальше. Ничего нет. Только рельсы, уходящие вдаль."+
                    " Не пора ли вернуться? Столько драгоценного времени потеряно!\n Вернетесь и пойдете налево по рельсам – 1; "+
                    "Продолжите идти в том же направлении – 2; Сойдете с путей и вернетесь на развилку – 3";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State41;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State40;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State32;
        }
    }
    void Quest_State40()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Пробежав еще несколько километров, вы понимаете, что ничего здесь не найдете. Пот ручьем течет по лицу."+
                    " Вы разворачиваетесь и бежите в обратном направлении. Светает. Нужно торопиться.\n Вернетесь и пойдете "+
                    "налево по рельсам – 1; Сойдете с путей и вернетесь на развилку – 2";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State41;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State32;
        }
    }
    void Quest_State41()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы бежите по шпалам. Все дальше и дальше. И все больше сомнений появляется в вашей голове. Может все-таки " +
                    "стоило повернуть в другую сторону? \n Вернетесь и пойдете направо по рельсам – 1; Продолжите идти в том же" +
                    " направлении – 2; Сойдете с путей и вернетесь на развилку – 3";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State39;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State42;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State32;
        }
    }
    void Quest_State42()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Впереди показалось множество огней. Вы сбавляете темп. Рельсы вывели вас к краю ярко освещенной железнодорожной"+
                    " платформы. Туда-сюда снуют суетливые немецкие солдаты. Идет разгрузка каких-то вагонов. На рельсах стоит огромная"+
                    " пушка. Длина ее ствола кажется просто невероятной. Неужели это та самая секретная сверхтяжелая пушка «Дора», о"+
                    " которой так много говорили в разведшколе?!\n Нужно срочно передать эту информацию командованию. Вы наносите положение"+
                    " пушки к себе на карту.\n Вернетесь на развилку – 1; Подползете ближе к пушке – 2";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State32;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State43;
        }
        
    }
    void Quest_State43()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        if (tntHave && tntPlant == "None")
        {
           Four.gameObject.SetActive(true);
        }
        Five.gameObject.SetActive(false);
        text.text = "Когда Советский союз оправился от первых поражений в боях с фашистскими захватчиками, и в тылу удалось" +
                    " наладить массовое и качественное производство всевозможной боевой техники, немцы потеряли свое преимущество" +
                    " в количестве танков, самолетов, орудий и другого вооружения, которым обладали в первые месяцы войны. Они поняли," +
                    " что уже не смогут угнаться за нами. И решили пойти другим путем. Победить не количеством, а качеством. Начались" +
                    " разработки принципиально новых образцов техники и вооружения. Ходят слухи, что они, даже, пытались создать что-то" +
                    " типа летающей тарелки – круглый самолет, который может вертикально взлетать и развивать огромную скорость – и " +
                    "достигли небывалых успехов в этой области.\n Жмите 1 и 2 что бы увидеть продолжение текста или 3 для возврата";
                    
        if (Choise == 1)
        {
            
            text.text = "Именно тогда и была создана уникальная пушка, которая получила название «Дора», в честь жены главного конструктора, " +
                        "которую так звали.\n Она располагалась на железнодорожной платформе и была так велика, что нужно было два мощных " +
                        "тягача, чтобы сдвинуть ее с места. \n Один ее снаряд весил, приблизительно, как девять современных легковых " +
                        "автомобилей вместе взятых.\n Однако поговаривают, что на испытаниях она показала себя не так, как этого все ожидали." +
                        " Снаряд ее был настолько тяжел, что после выстрела он ушел в землю на несколько метров и только там разорвался, не " +
                        "причинив особого вреда ничему, что находилось на поверхности земли. \n Но при прямом попадани какое - либо укрепление" +
                        " снаряд не оставлял от него и следа.\n Жмите 2 увидеть продолжение текста";
                    
        }
        if (Choise == 2)
        {
            
            text.text = "Вы ползете между рельс, не поднимая головы, и подползаете вплотную к пушке. Рядом с ней стоят огромные ящики со " +
                        "снарядами.\n Вы возвращаетесь на развилку – 3 \n ";
            if (tntHave) { text.text +="Заложить радио управляемую взрывчатку - 4"; }
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State32;
        }
        if (Choise == 4)
        {
            mesageTNT.SetActive(true);
            tntPlant = "State43";
            Choise = 0;
            myState = States.State51;
        }

    }
    void Quest_State44()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы идете по лесной дороге и через некоторое время снова оказываетесь на развилке. Дорога, уходящая влево,"+
                    " углубляется дальше в лес. В конце дороги, уходящей вправо, виден просвет. Похоже на выход из леса.\n"+
                    " Пойдете налево – 1; Пойдете направо – 2; Вернетесь назад – 3";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State45;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State49;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State2;
        }
    }
    void Quest_State45()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Через некоторое время вы выходите на опушку леса. На ней стоят зенитные орудия немцев.\n"+
                    " Пойдете к зениткам – 1; Пойдете дальше – 2";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State46;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State47;
        }
    }
    //Возможность заложыть взрывчатку
    void Quest_State46()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
       // if (tntHave) { TNT.gameObject.SetActive(true); }
        text.text = "Вроде бы никого нет рядом. Странно, что немцы не выставили здесь охрану. Эти зенитные орудия надежно"+
                    " охраняют лес и деревню от советской авиации. Эх, рвануть бы все это!\n"+
                    "Пойдете дальше – 1; Вернетесь на развилку – 2";
        
        if (tntHave && tntPlant == "None")
        {
            Three.gameObject.SetActive(true);
            text.text += "\n Заложить радио взрывчатку - 3. ";
            if (Choise == 3)
            {
                Choise = 0;
                myState = States.State54;
            }
        }
            if (Choise == 1)
        {
            Choise = 0;
            myState = States.State47;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State44;
        }
    }
    void Quest_State47()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Миновав зенитные орудия, вы уходите дальше в лес. Постепенно он редеет и, вскоре, вовсе расступается в стороны."+
                    " Вы выходите на большое поле. Здесь вполне можно расположить целый военный аэродром.\n"+
                    "В нескольких десятках метров лежит мертвая лошадь.Рядом с ней в земле небольшая черная воронка. Похоже, животное"+
                    " погибло от разрыва артиллерийского снаряда. \n Пойдете дальше – 1; Вернетесь на развилку – 2";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State48;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State44;
        }
    }
    void Quest_State48()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы успеваете сделать всего несколько шагов. Под ногами раздается легкий щелчок, и через долю секунды"+
                    " оглушительный взрыв. Вы наступили на противопехотную мину.\n"+
                    "Ведь обо всем можно было догадаться только взглянув на мертвую лошадь.\n Перейти далее - 1"; 
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State49()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(true);
        Five.gameObject.SetActive(true);
        text.text = "Через несколько сотен шагов лес расступается, и вы выходите на дорогу, ведущую в деревню. Посреди" +
                    " дороги стоит немец с собакой. Похоже, охраняет вход в деревню.\n" +
                    "Вернетесь на развилку – 1; Попробуете обойти часового – 2; Выйдете прямо на него – 3; Снимите его точным выстрелом – 4" +
                    " Подкрадетесь к часовому с ножом – 5";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State44;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State52;
        }
        if (Choise == 3)
        {
            if (eqipe == "German")
            {
                Choise = 0;
                myState = States.State58;
            }
            if (eqipe == "Soviet")
            {
                Choise = 0;
                myState = States.State53;
            }
        }
        if (Choise == 4)
        {
            Choise = 0;
            myState = States.State8;
        }
        if (Choise == 5)
        {
            Choise = 0;
            myState = States.State50;
        }
    }
    void Quest_State50()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Отложив автомат в сторону, вы вынимаете нож из ножен и крадетесь к часовому. Но собаку не обманешь."+
                    "Она учуяла вас, подняла лай и кинулась в вашу сторону. Вы сцепились с ней в смертельной схватке и "+
                    "катаетесь по земле. Животное повержено. Вы поднимаете голову и видите ствол немецкого автомата, направленный"+
                    " в вашу сторону\n Перейти далее - 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State51()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы достаете радиоуправляемый фугас и устанавливаете его на ящики со снарядами. Отползаете в сторону"+
                    " и с трудом подавляете в себе желание нажать на кнопку взрывателя. Еще не время.\n"+ 
                    "\n Вы возвращаетесь на развилку – 1";
        if (Choise == 1)
        {
            tntHave = false;
            tntPlant = "State51";
            Choise = 0;
            myState = States.State32;
        }

    }
    void Quest_State52()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы ползком движетесь вдоль дороги. Кажется часовой вас не заметил. Но собаку не обмануть. "+
                    "Она подняла лай и рванулась в вашу сторону. Вы обнаружены. Со всех сторон к вам бегут немцы."+
                    "Вы принимаете бой. Но силы слишком не равны.\n Перейти далее - 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State53()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы выходите прямо на часового. Он передергивает затвор автомата и направляет на вас луч фонаря.\n"+
                    "Перейти далее - 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State55;
        }
    }
    //Закладка фугаса
    void Quest_State54()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы достаете радиоуправляемый фугас и устанавливаете его на одно из зенитных орудий. Отойдя в сторону, "+
                    "с трудом подавляете в себе желание нажать на кнопку взрывателя. Еще не время.\n"+
                    " Вы возвращаетесь на развилку – 1";
        if (Choise == 1)
        {
            tntPlant = "State54";
            mesageTNT.SetActive(true);
            Choise = 0;
            myState = States.State44;
        }
    }
    void Quest_State55()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "«Привет! Я тут мимо проходил…» - не успев договорить, вы падаете на землю, изрешеченный пулями."+
                    " Идти прямо напролом – было не самой лучшей идеей. \n Перейти далее - 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State56()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы поворачиваете в сторону церкви. Кажется, что-то блеснуло в свете луны на куполе, рядом с крестом. "+
                    "Впрочем, может быть вам и показалось.\n Дорога огибает церковь и уходит на задний двор."+
                    " Пойдете к церкви – 1; Обойдете ее – 2";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State69;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State57;
        }
    }
    void Quest_State57()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(true);
        Five.gameObject.SetActive(false);
        text.text = "Обогнув церковь, вы оказываетесь на заднем дворе. Услышав голоса, вы прячетесь за угол здания. Вашему взору "+
                    "представилась страшная картина: несколько оборванных, изможденных, окровавленных мужчин, раздетых по пояс и "+
                    "босых стоят возле стены, на которой отчетливо видны следы пуль. Напротив них – шеренга немецких солдат с ружьями."+
                    " Командует расстрелом молодой офицер в до зеркального блеска начищенных сапогах.\n"+
                    " Посмотрите, что будет дальше – 1; Развернетесь и пойдете к церкви – 2; Вернетесь на лесную развилку – 3; Попытаетесь освободить людей – 4 ";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State67;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State65;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State66;
        }
        if (Choise == 4)
        {
            Choise = 0;
            myState = States.State68;
        }
    }
    void Quest_State58()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " «Stehe! Wer geht?» - часовой внимательно осматривает вас с ног до головы. Хорошо, что вы догадались"+
                    " надеть форму убитого немца. Но с этим все нормально. А вот на немецкий язык нужно было получше налегать"+
                    " в разведшколе. Кажется, он сказал что-то вроде: «Стой! Кто идет?». Что вы ответите ему?\n"+
                    " Wer ist notwendig, jener und geht – 1; Die!Ich aus der wirtschaftlichen Gliederung – 2; Der russische Diversant – 3";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State59;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State60;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State61;
        }
    }
    void Quest_State59()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "«Кто надо, тот и идет»,- отвечаете вы ему. Опрометчиво было так грубить. Немец приказывает вам поднять руки вверх."+
                    " Вы вскидываете автомат, но не успеваете сделать ни единого выстрела.\n Перейти далее - 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State60()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " «Свои! Я из хозподразделения»,- отвечаете вы немцу. Он заметно расслабился и отвел от вас ствол автомата в сторону.\n"+
                    "«Sie bewirten Sie mich von der Zigarette nicht?» -снова спросил немец. Слово за вами.\n"+
                    " Bleibe zurück!Das deutsche Schwein! – 1; Verzeihen Sie. Ich rauche nicht – 2; Ich werde dir die Zigarette geben,"+
                    " nachdem ich die rote Fahne über Rejchstagom aufpflanzen werde – 3";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State62;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State63;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State64;
        }
    }
    void Quest_State61()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Прямолинейности вам не занимать. Немец опешил от такого ответа. Он никак не ожидал услышать: «русский"+
                    " диверсант идет». Но он моментально пришел в себя и нажал на курок автомата.\n"+
                    "Перейти далее - 1";
      
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State62()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "«Отвали! Немецкая свинья!» - отвечаете вы ему и вскидываете автомат. Двумя короткими очередями вы поражаете часового и собаку."+
                    " Но на шум выстрелов со всех сторон бегут немцы. Слышны звуки выстрелов и лай собак. Вы принимаете бой. Но силы слишком не равны.\n"+
                    "Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State63()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "«Простите, я не курю»,- отвечаете вы часовому и с невозмутимым видом проходите мимо него. Уф… Пронесло. Вы идете "+
                    "дальше по дороге и через некоторое время оказываетесь на перекрестке. Дорога прямо уходит в сторону нескольких изб."+
                    "Дорога направо поворачивает в сторону церкви.\n Пойдете прямо – 1; Повернете направо – 2; Вернетесь на лесную развилку – 3";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State74;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State56;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State44;
        }
    }
    void Quest_State64()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "«Я дам тебе прикурить после того, как водружу красный флаг на крыше Рейхстага»,-  отвечаете вы ему и вскидываете автомат."+
                    " Двумя короткими очередями вы поражаете часового и собаку. Но на шум выстрелов со всех сторон бегут немцы. Слышны звуки "+
                    "выстрелов и лай собак. Вы принимаете бой. Но силы слишком не равны. \n Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State65()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы разворачиваетесь и крадетесь в обратном направлении. За вашей спиной раздается серия неровных выстрелов, "+
                    "вскрики и стоны людей. Вы стискиваете зубы. Не вините себя. Им ничем нельзя было помочь.\n"+
                    " Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State69;
        }
    }
    void Quest_State66()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы пятитесь назад. Вдруг за углом звучит серия неровных выстрелов. Раздаются вскрики и стоны людей. Не вините себя. Им ничем нельзя было помочь.\n " +
                    " Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State44;
        }
    }
    void Quest_State67()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы, притаившись, смотрите, что же будет дальше. По команде немцы, все как один, вскидывают ружья. Раздается "+
                    "серия неровных выстрелов. Люди с вскриками и стонами падают на землю. Слезы наворачиваются на глаза. Не вините"+
                    " себя. Что вы могли сделать один? Им ничем нельзя было помочь.\n Вернетесь на лесную развилку – 1"+
                    "Пойдете к церкви – 2";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State44;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State69;
        }
    }
    void Quest_State68()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы даете очередь из автомата по шеренге немцев. Некоторые из них падают на землю без движения. "+
                    "Другие – разбегаются в стороны в поисках убежища. Завязывается ожесточенная перестрелка. Безоружные"+
                    " люди погибают в первые же секунды, так и не успев завладеть оружием убитых немцев.\n"+
                    " На звуки выстрелов со всех сторон бегут фашисты. Вокруг слышны выстрелы и лай собак. Вы обречены.\n Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    // Если в руках МП-40 то одно ППШ другое
    void Quest_State69()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы подходите к церкви и осторожно заглядываете в окно. Внутри стоят несколько столов. За одним из них сидят"+
                    " пятеро немцев и играют в карты. За другим – немец в наушниках что-то настраивает на приборе, стоящем перед"+
                    " ним. Радиостанция! Вот что блеснуло на куполе. Антенна. Точно. Ведь это самое высокое место в деревне. "+
                    "Отсюда без помех летят во все концы радиограммы и сигналы управления немецкими подразделениями. Вы наносите"+
                    " на карту свою находку. \n Вернетесь на лесную развилку – 1; Ворветесь в церковь – 2; Обойдете церковь – 3";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State44;
        }
        if (Choise == 2)
        {
            if (mashinegun == "ППШ")
            {
                Choise = 0;
                myState = States.State70;
            }
            if (mashinegun == "MP40")
            {
                Choise = 0;
                myState = States.State81;
            }
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State57;
        }
    }
    void Quest_State70()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Вы распахиваете ногой дверь и врываетесь внутрь с автоматом наизготовку. Нажимаете несколько раз на курок и"+
                    " слышите только сухие щелчки. Осечка, еще осечка… \n Немцы опомнились и схватились за свое оружие. "+
                    "«Подвел хваленый ППШ»,-пронеслось в голове. Это была последняя ваша мысль.\n Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State71()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы кидаетесь к окну. Слишком поздно. Немцы сомкнули кольцо. Вы начинаете отстреливаться. Они подходят все ближе. Что же делать?!\n"+
                    "Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State81;
        }
    }
    void Quest_State72()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Первая пуля бьет вас в плечо. Вторая – в грудь. Вы падаете на пол и теряете сознание. Хуже смерти для вас мог быть только немецкий плен\n" +
                    "Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State72;
        }
    }
    void Quest_State73()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Советская авиация наносит сокрушительный удар по близлежащему лесу, не причиняя при этом никакого урона"+
                    " фашистским войскам.\n В результате, советские войска, перешедшие в наступление, попадают в окружение и"+
                    " несут огромные потери.Немецкие войска все дальше продвигаются вглубь советской территории.\n" +
                    "Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State0;
        }
    }
    void Quest_State74()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(true);
        Five.gameObject.SetActive(false);
        text.text = " Несколько небольших изб. Из труб идет дым. Из одного из окон доносятся звуки патефона. Какой-то"+
                    " немецкий марш. Видимо, здесь расположились вражеские офицеры. В стороне от изб довольно большое"+
                    " строение с наглухо заколоченными окнами. Похоже на сарай.\n"+
                    " Пойдете к избам – 1; Пойдете к сараю – 2; Вернетесь и повернете направо в сторону церкви – 3;"+
                    "Вернетесь на лесную развилку – 4";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State85;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State75;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State56;
        }
        if (Choise == 4)
        {
            Choise = 0;
            myState = States.State44;
        }
    }
    void Quest_State75()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Подкравшись к сараю, вы замечаете тянущиеся по земле к нему несколько проводов. Похоже, они идут"+
                    "сюда от церкви. Внутри слышны голоса.\n Ворветесь в сарай – 1; Заглянете в щель – 2; Вернетесь назад – 3";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State78;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State79;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State74;
        }
    }
    void Quest_State76()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы достаете из-за пазухи и бережно разворачиваете трофейную немецкую карту. Положив ее перед собой, вы "+
                    "одеваете наушники и настраиваете рацию на нашу волну. Постепенно треск статических помех стихает. Вы "+
                    "выходите в радиоэфир под известным только вам и вашему командованию позывным и начинаете передавать  "+
                    "координаты немецких объектов.  Благодаря позывному, у них не будет сомнений в том, что передаете "+
                    "радиограмму именно вы.\n Немцы услышали выстрелы в церкви и теперь стягиваются со всех сторон, "+
                    "образуя кольцо. Еще немного, и вам не удастся выбраться из окружения. Но переданы еще не все "+
                    "координаты. Еще несколько минут.Вот теперь все.\n" +
                    "Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State71;
        }
    }
    void Quest_State77()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Немцы долго пытают вас. В забытье вы выдаете им свой позывной, под которым выходили в радиоэфир."+
                    " К сожалению, вы не догадались уничтожить радиостанцию. Фашисты выходят в радиоэфир на нашей"+
                    " частоте и передают коррективы к координатам, указанным вами.  "+
                    "Перейти далее - 1";
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State73;
        }
    }
    void Quest_State78()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Распахнув ногой дверь, вы врываетесь внутрь с криком: «Hände hoch!». Посреди помещения большой"+
                    " деревянный стол, на котором лежит карта. Вокруг, склонившись над ней, стоят пятеро немецких"+
                    " офицеров. Они молча поднимают руки вверх. \n Похоже, здесь расположен немецкий штаб, замаскированный"+
                    " под ни чем не приметный сарай. Вы мельком заглядываете в карту.Вот так подарок!На ней отмечено "+
                    "расположение всех немецких войск в деревне и близ лежащем лесу. И теперь она в ваших руках.\n"+
                    "В эйфории вы не заметили немца, вошедшего в штаб за вашей спиной.Он подкрадывается сзади и "+
                    "наносит вам сокрушительный удар прикладом автомата по голове. В глазах темнеет.Вы оседаете на пол.\n" +
                    "Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State79()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        if (tntPlant != "None"){ TNTSwitch.gameObject.SetActive(true); }
        text.text = " Вы припадаете к щели между досок. Внутренняя часть помещения хорошо освещена множеством керосиновых "+
                    "ламп. В центре стоит большой деревянный стол. Над ним склонились пятеро немецких офицеров. Они что-то "+
                    "рассматривают и негромко обсуждают. Что именно, расслышать никак не удается. Похоже, здесь расположен "+
                    "немецкий штаб, замаскированный под ни чем не приметный сарай. Вот бы выманить их оттуда! Но как?!\n" +
                    "Ворветесь в сарай – 1; Вернетесь назад – 2";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State78;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State74;
        }
      
        if (Choise == 6)
         {
                switch (tntPlant)
                {
                    case "State43":
                    TNTSwitch.gameObject.SetActive(false);
                    Choise = 0;
                        myState = States.State82;
                        break;
                    case "State46":
                    TNTSwitch.gameObject.SetActive(false);
                    Choise = 0;
                        myState = States.State83;
                        break;
                    case "State51":
                    TNTSwitch.gameObject.SetActive(false);
                    Choise = 0;
                        myState = States.State82;
                        break;
                    case "State54":
                    TNTSwitch.gameObject.SetActive(false);
                    Choise = 0;
                        myState = States.State83;
                        break;
                    case "State26":
                    TNTSwitch.gameObject.SetActive(false);
                    Choise = 0;
                        myState = States.State83;
                        break;
                    case "State12":
                    TNTSwitch.gameObject.SetActive(false);
                    Choise = 0;
                        myState = States.State83;
                        break;
                }
         }
    }
    void Quest_State80()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        if (haveMap) { map.gameObject.SetActive(true); }
        text.text = "Вы распахиваете ногой дверь и врываетесь внутрь с автоматом наизготовку. Несколько прицельных очередей."+
                    " В воздухе повисло облако пороховых газов. Постепенно дым рассеялся. Все мертвы. Вы подходите к "+
                    "радиостанции. Можно попробовать настроиться на нашу волну и передать координаты всех немецких объектов. "+
                    "Но на вашей карте отмечено пока еще далеко не все. Нужно уходить. Выстрелы могли услышать.\n"+
                    "Вернетесь на лесную развилку – 1; Обойдете церковь – 2";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State44;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State57;
        }
        if(Choise == 7) {
            Choise = 0;
            myState = States.State76;
        }
    }
    void Quest_State81()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " В последний раз вам предстоит использовать трофейный немецкий Шмайсер…\n"+
                    "После того, как сопротивление стихло, немцы еще долго не решались войти в церковь."+
                    "Когда же они, наконец, ворвались внутрь, то обнаружили разбитую радиостанцию и 7 трупов. "+
                    "Шесть из них принадлежали убитым вами фашистам.Седьмой – ваш.\n Ценой своей жизни вам удалось"+
                    " передать координаты немецких объектов.Через некоторое время советская авиация нанесла "+
                    "сокрушительный удар по силам противника, что помогло в дальнейшем наступлению советских войск. "+
                    "Фашисты были далеко отброшены с захваченных ими территорий. Вас же представили к званию Героя "+
                    "Советского союза.\n Перейти далее -1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State107;
        }
    }
    void Quest_State82()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Замечательная идея! Услышав взрыв, немцы наверняка выбегут оттуда. И тогда вы сможете проникнуть"+
                    " внутрь и все хорошенько обыскать.\n Вы достаете радиовзрыватель и нажимаете на кнопку.Оглушительный"+
                    " взрыв раздается со стороны леса. Дверь распахивается, и немцы с криками бросаются в сторону изб.В деревне"+
                    " начинается паника. Несколько машин с вооруженными людьми выезжают в сторону железной дороги, откуда"+
                    " поднимается столп дыма.\n Вы проскальзываете внутрь.\n"+
                     "Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State84;
        }
    }
    void Quest_State83()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Замечательная идея! Услышав взрыв, немцы наверняка выбегут оттуда. И тогда вы сможете проникнуть внутрь"+
                    " и все хорошенько обыскать.\n Вы достаете радиовзрыватель и нажимаете на кнопку.Но ничего не происходит."+
                    " Похоже, села батарея. Или расстояние слишком велико, и радиосигнал не доходит до фугаса.Вы снова и снова"+
                    " нажимаете на кнопку и не замечаете, что были обнаружены немцем.Он подкрадывается сзади и наносит"+
                    " сокрушительный удар прикладом автомата по голове.В глазах темнеет.Вы оседаете на землю.\n" +
                    "Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State84()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " На столе лежит карта. Вот так подарок! Похоже, на нее нанесены все немецкие объекты, расположенные в деревне"+
                    " и близлежащем лесу. Вот и танки, и зенитные орудия, и склад боеприпасов…\n"+
                    "Вы хватаете карту, складываете ее и засовываете запазуху.\n Поторопитесь!Очень скоро немцы поймут, что взрыв"+
                    " был не случайным.Вас начнут искать.Нужно выбираться отсюда\n Вы выходите из немецкого штаба и прячетесь в кустах,"+
                    " размышляя, что же делать дальше.\n Пойдете к избам – 1; Вернетесь на развилку и повернете в сторону церкви – 2;"+
                    "Вернетесь на лесную развилку – 3";
        haveMap = true;
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State85;
        }
        if (Choise == 56)
        {
            Choise = 0;
            myState = States.State56;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State44;
        }
    }
    void Quest_State85()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы крадетесь в сторону изб. Звуки марша на секунду прерываются. Вы затаили дыхание. Но через секунду они снова"+
                    " возобновляются. Похоже, кто-то перевернул пластинку.\n Пойдете к избе, в которой играет патефон – 1"+
                    "Пойдете дальше – 2";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State87;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State101;
        }
    }
    void Quest_State86()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State76;
        }
    }
    void Quest_State87()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Подкравшись к окну, вы осторожно заглядываете внутрь. На подоконнике действительно стоит патефон. На стуле,"+
                    " наслаждаясь музыкой, сидит и курит немецкий офицер. \n Хорошо бы перед тем, как возвращаться к своим, "+
                    "прихватить еще и немецкого языка.\n Ворветесь внутрь и застанете немца врасплох – 1; Пойдете дальше – 2";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State88;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State101;
        }
    }
    void Quest_State88()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы врываетесь внутрь и направляете на немца ствол автомата. От неожиданности он поперхнулся и выронил сигарету"+
                    " изо рта.\n Вставив в рот кляп и связав за спиной руки его же ремнем, вы приказываете ему встать и идти впереди вас.\n" +
                    "Попробуете через лес незаметно вернуться к своим – 1; Попытаетесь найти какой - нибудь транспорт – 2";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State89;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State93;
        }
    }
    void Quest_State89()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вместе с конвоируемым немцем вы беспрепятственно добираетесь до леса. Но фашисты очень быстро заметили"+
                    " исчезновение одного из своих. Они начинают прочесывать лес. К несчастью, из-за пленника вы не можете "+
                    "передвигаться быстро. В скором времени они нападают на ваш след, и начинается погоня. Все ближе слышны "+
                    "звуки выстрелов и лай собак.\n Бросите пленника и попытаетесь оторваться от погони – 1; Попытаетесь уйти от погони вместе с пленником – 2 ";
        if (Choise == 1)
        {
            myState = States.State92;
        }
        if (Choise == 2)
        {
            myState = States.State90;
        }
    }
    void Quest_State90()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Пленный немец, как будто специально, все время спотыкается и падает. Вы  тащите его за собой напролом через лес.\n"+
                    "Неожиданно, одна из немецких пуль настигает вас. Вы падаете на землю и теряете сознание.\n"+
                    "Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State91;
        }
    }
    void Quest_State91()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Фашисты долго пытают вас. Но им так и не удается узнать ни цели вашего задания, ни о планах военного"+
                    " командования. Вы геройски погибаете от мук, не сказав им ни слова\n Перейти далее -1";
        if (Choise == 1)
        {
            myState = States.State9;
        }
    }
    void Quest_State92()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Пленный немец, как будто специально, все время, спотыкается и падает. После очередного падения, вы решаете "+
                    "бросить его и попытаться оторваться от погони через болото. \n Постепенно шум погони остается далеко позади."+
                    " Немцы еще некоторое время ищут вас. Но потом прекращают свои поиски, решив, что вы утонули.Вам удается"+
                    " выбраться из болота.Но без разведданных вы не можете вернуться к своим.\n" +
                    "Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State2;
        }
    }
    void Quest_State93()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " За углом стоит легковой немецкий автомобиль. Кажется, рядом никого."+
                    "Воспользуетесь им – 1; Поищите что-нибудь другое – 2";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State94;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State95;
        }
    }
    void Quest_State94()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы заталкиваете пленного фашиста в кабину. Повозившись немного с машиной, удается ее завести. Вы садитесь"+
                    " за руль, вдавливаете педаль газа в пол и на полной скорости несетесь в сторону леса.\n"+
                    "В деревне начинается переполох. Несколько немецких автомобилей начинают погоню.Вот вы уже и на лесной дороге."+
                    "Но что там виднеется впереди ? !Одним из тяжелых грузовиков немцы перегородили дорогу.Дальше не проехать."+
                    "Приходится свернуть в чащу. Машина скачет на ухабах и в итоге застревает в яме.\n"+ 
                    "Вы вытаскиваете пленника из машины и тащите в лес.Погоня все ближе.За спиной слышны выстрелы и лай собак."+
                    "Бросите пленного немца и попытаетесь уйти от погони – 1; Попытаетесь уйти от погони вместе с пленником – 2";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State92;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State90;
        }
    }
    void Quest_State95()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Пройдя еще несколько метров, вы замечаете грузовик."+
                    "Поедете на нем – 1; Пойдете дальше – 2";
        if (Choise == 1)
        {
            myState = States.State97;
        }
        if (Choise == 2)
        {
            myState = States.State96;
        }
    }
    void Quest_State96()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(true);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы толкаете пленника в спину, чтобы он шел быстрее. Кажется, никакого подходящего транспорта больше нет.\n"+
                    " Пойдете пешком – 1; Вернетесь к легковому автомобилю – 2; Вернетесь к грузовику – 3";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State89;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State94;
        }
        if (Choise == 3)
        {
            Choise = 0;
            myState = States.State97;
        }
    }
    void Quest_State97()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы заталкиваете пленного фашиста в кабину. Повозившись немного с машиной, удается ее завести. Вы садитесь" +
                    " за руль, вдавливаете педаль газа в пол и на полной скорости несетесь в сторону леса.\n В деревне начинается" +
                    " переполох. Несколько немецких автомобилей начинают погоню.Вот вы уже и на лесной дороге.Но что там виднеется" +
                    " впереди ? !Одним из тяжелых грузовиков немцы перегородили дорогу.Дальше не проехать. \n Попытаетесь протаранить грузовик – 1; " +
                    " Свернете в лес – 2";
        if (Choise == 1)
        {
            myState = States.State100;
        }
        if (Choise == 2)
        {
            myState = States.State99;
        }
    }
    void Quest_State98()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Хотя почему без разведданных?! Вы суете руку запазуху. Внутри все похолодело. Карты нет! Похоже,"+
                    " вы потеряли ее во время погони. Придется вернуться.\n Вернутся обратно – 1";
        if (Choise == 1)
        {
            myState = States.State2;
        }
        
    }
    void Quest_State99()
    {
        text.text = " Вы сворачиваете в чащу. Машина скачет на ухабах, но легко преодолевает все ямы и канавы.\n"+
                    " Но тут пленнику удается дотянуться до дверной ручки и выпрыгнуть из кабины. Звуки погони близки. "+
                    "Останавливаться сейчас было бы самоубийством.Вы сильнее вдавливаете в пол педаль газа.Звуки погони "+
                    "остались далеко позади.Впереди болото. Дальше не проехать.Вы оставляете машину и идете пешком. Но вернуться "+
                    "к своим без разведданных вы не можете. Придется вернуться. Вернутся обратно – 1";
        if (Choise == 1)
            if (Choise == 1)
        {
            myState = States.State2;
        }
    }
    void Quest_State100()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " На полном ходу вы врезаетесь в грузовик. Обе машины разбиты. Вы ударились головой и потеряли сознание.\n" +
                    "Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State91;
        }
    }
    void Quest_State101()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы подкрадываетесь к следующему дому и заглядываете в окно. Кажется, никого нет. На столе разложены"+
                    " какие-то бумаги.\n Войдете в дом и обыщите его – 1; Пойдете дальше – 2";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State102;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State106;
        }
    }
    void Quest_State102()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(true);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы подходите к двери и дергаете дверную ручку. Заперто.\n"+
                    " Влезете в окно – 1; Пойдете дальше – 2";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State103;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State106;
        }
    }
    void Quest_State103()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Обогнув дом, вы залезаете в окно. Подходите к окну и перебираете бумаги. Кажется какие-то накладные"+
                    " на обмундирование. Похоже, в этом доме расположился кто-то из вещевой службы немцев.\n"+
                    " Обыщите другие комнаты – 1; Вылезете обратно в окно и пойдете дальше – 2";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State104;
        }
        if (Choise == 2)
        {
            Choise = 0;
            myState = States.State106;
        }
    }
    void Quest_State104()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы приступаете к обыску других комнат. За этим занятием вас и застал вернувшийся немецкий офицер."+
                    " Ваш автомат лежит на столе, куда вы его и положили, рассматривая документы.  Вы кидаетесь к оружию."+
                    " Но немец опередил вас. Он выхватывает из кобуры Вальтер и делает несколько точных выстрелов.\n"+
                    "Перейдите к главе - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State9;
        }
    }
    void Quest_State105()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Перейти далее - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State98;
        }
    }
    void Quest_State106()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = " Вы крадетесь к следующему дому. Стоп! Впереди двое немцев с собаками. Патруль. Лучше вернуться пока вас не заметили.\n"+
                     "Вернутся назад - 1";

        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State74;
        }
    }
    void Quest_State107()
    {
        One.gameObject.SetActive(true);
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        text.text = "Победа!!!";
        star.gameObject.SetActive(true);
        if (Choise == 1)
        {
            Choise = 0;
            myState = States.State0;
            star.gameObject.SetActive(false);

        }
    }
        void Quest_State108()
        {
            One.gameObject.SetActive(true);
            Two.gameObject.SetActive(true);
        if (tntHave && tntPlant == "None")
        {
            TNT.gameObject.SetActive(true);
        }
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
            Five.gameObject.SetActive(false);
        text.text = " Вы осматриваете  стоянку машин. Пятнадцать, шестнадцать, семнадцать, восемнадцать… Восемнадцать тяжелых грузовиков." +
                    " Вам хорошо знакомы эти машины. Это «Mercedes-Benz L 4500 S». Вам рассказывали о них в разведшколе. Немцы широко" +
                    " используют их как для перевозки грузов, так и личного состава. Интересно, для чего они здесь?\n" +
                    "Вы наносите новые данные на свою карту. \n Пойдете дальше по дороге – 1; Вернетесь на развилку – 2; \n";
        
        if (Choise == 1)
            {
                Choise = 0;
                myState = States.State16;
                TNT.gameObject.SetActive(false);
            }
            if (Choise == 2)
            {
                Choise = 0;
                myState = States.State2;
                TNT.gameObject.SetActive(false);
             }
       
        }
    #endregion
        
}

