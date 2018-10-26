using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CON1 : MonoBehaviour
{
    static CON1 _instance;
    public static CON1 Instance()
    {
        return _instance;
    }
    Camera came;
    public GameObject tagetObj;
    public GameObject selObj;
    public bool tep;
    public float whitetun;
    public bool pw;
    public bool bs;
    public bool bbs;
    public bool rk;
    public bool q;
    public bool kn;
    public bool k;
    public float limt;
    public float wklog;
    public float wqlog;
    public float wblog;
    public float wnlog;
    public float wrlog;
    public float wplog;
    public float bklog;
    public float bqlog;
    public float bblog;
    public float bnlog;
    public float brlog;
    public float bplog;
    public bool en;
    public float timew;
    public float timeb;
    public float limttime;
    public GameObject soundObj;
    public GameObject wwin;
    public GameObject bwin;
    public GameObject draw;
    public GameObject menu;
    public GameObject wlog;
    public GameObject blog;
    public GameObject trun;
    public UILabel nlogl;
    public UILabel blogl;
    public UILabel qlogl;
    public UILabel plogl;
    public UILabel rlogl;
    public UILabel bnlogl;
    public UILabel bblogl;
    public UILabel bqlogl;
    public UILabel bplogl;
    public UILabel brlogl;
    public GameObject pc;
    public GameObject qc;
    public GameObject rc;
    public GameObject nc;
    public GameObject kc;
    public GameObject bc;
    public GameObject redpc;
    public GameObject blackpc;
    public GameObject ep;
    public bool ckobjc;

    void Start()
    {
        came = GetComponent<Camera>();
        whitetun = 1;       
    }
    void Update()
    {        
        if (bklog == 1)
        {
            Winwhigt();
        }
        if (wklog == 1)
        {
            Winblack();
        }
        if (whitetun==-1)
        {
            timeb += Time.deltaTime;            
        }
        if (whitetun == 1)
        {
            timew += Time.deltaTime * 0.1f;           
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = came.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                tagetObj = hit.transform.gameObject;
                ckobjc = false;
                if (tagetObj.tag == "pawn"&& tep == true&&whitetun==1)
                {
                    Instantiate(ep,new Vector3(-0.5f,4.5f,-3.5f),Quaternion.Euler(0,0,0));
                    Instantiate(pc, new Vector3(-3, -0.4f, -7.5f), Quaternion.Euler(0, 26, 0));                  
                    soundObj.GetComponent<SoundMain>().pselsep.Play();
                    pw = true;
                    tep = false;
                    tagetObj.GetComponent<Pawn>().pOnOff = true;                    
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "pointmove"&&pw==true && whitetun == 1)
                {
                    soundObj.GetComponent<SoundMain>().pmovesep.Play();
                    pw = false;
                    selObj.GetComponent<Pawn>().moveObj = true;
                    selObj.GetComponent<EpCon>().MoveEp();
                    tep = true;
                    whitetun *= -1;
                    Trunck();
                }
                if (tagetObj.tag == "atbox" && pw == true && whitetun == 1)
                {
                    soundObj.GetComponent<SoundMain>().pmovesep.Play();
                    whitetun *= -1;
                    Trunck();
                    pw = false;
                    soundObj.GetComponent<SoundMain>().pat.Play();
                    selObj.GetComponent<Pawn>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxp>().Delete();
                }
                if (tagetObj.tag == "bishop" && tep == true && whitetun == 1)
                {
                    Instantiate(ep, new Vector3(-0.5f, 4.5f, -3.5f), Quaternion.Euler(0, 0, 0));
                    Instantiate(bc, new Vector3(-3, -0.4f, -7.5f), Quaternion.Euler(0, 26, 0));
                    soundObj.GetComponent<SoundMain>().bselsep.Play();
                    bs = true;
                    tep = false;
                    tagetObj.GetComponent<Bishop>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "pointmove"&&bs==true && whitetun == 1)
                {
                    soundObj.GetComponent<SoundMain>().bmovesep.Play();
                    whitetun *= -1;
                    Trunck();
                    bs = false;
                    selObj.GetComponent<EpCon>().MoveEp();
                    selObj.GetComponent<Bishop>().moveObj = true;
                    tep = true;                   
                }
                if (tagetObj.tag == "atbox" && bs == true && whitetun == 1)
                {
                    soundObj.GetComponent<SoundMain>().bmovesep.Play();
                    whitetun *= -1;
                    Trunck();
                    bs = false;
                    soundObj.GetComponent<SoundMain>().bat.Play();
                    selObj.GetComponent<Bishop>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxp>().Delete();
                }
                if (tagetObj.tag == "queen" && tep == true && whitetun == 1)
                {
                    Instantiate(ep, new Vector3(-0.5f, 4.5f, -3.5f), Quaternion.Euler(0, 0, 0));
                    Instantiate(qc, new Vector3(-3, -0.4f, -7.5f), Quaternion.Euler(0, 26, 0));
                    soundObj.GetComponent<SoundMain>().qselsep.Play();
                    q = true;
                    limt = 0;
                    tep = false;
                    tagetObj.GetComponent<Queen>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && q == true && whitetun == 1)
                {
                    soundObj.GetComponent<SoundMain>().qmovesep.Play();
                    q = false;
                    selObj.GetComponent<EpCon>().MoveEp();
                    selObj.GetComponent<Queen>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                    Trunck();
                }
                if (tagetObj.tag == "atbox" && q == true && whitetun == 1)
                {
                    soundObj.GetComponent<SoundMain>().qmovesep.Play();
                    whitetun *= -1;
                    Trunck();
                    q = false;
                    soundObj.GetComponent<SoundMain>().qAt.Play();
                    selObj.GetComponent<Queen>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxp>().Delete();
                }
                if (tagetObj.tag == "knight" && tep == true && whitetun == 1)
                {
                    Instantiate(ep, new Vector3(-0.5f, 4.5f, -3.5f), Quaternion.Euler(0, 0, 0));
                    Instantiate(nc, new Vector3(-3, -0.4f, -7.5f), Quaternion.Euler(0, 26, 0));
                    soundObj.GetComponent<SoundMain>().nselsep.Play();
                    kn = true;
                    limt = 0;
                    tep = false;
                    tagetObj.GetComponent<Knight>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "pointmove" && kn == true && whitetun == 1)
                {
                    soundObj.GetComponent<SoundMain>().nmovesep.Play();
                    kn = false;
                    selObj.GetComponent<EpCon>().MoveEp();
                    selObj.GetComponent<Knight>().moveObj = true;
                    tep = true;
                    Trunck();
                    whitetun *= -1;
                }
                if (tagetObj.tag == "atbox" && kn == true && whitetun == 1)
                {
                    soundObj.GetComponent<SoundMain>().nmovesep.Play();
                    whitetun *= -1;
                    Trunck();
                    kn = false;
                    soundObj.GetComponent<SoundMain>().nat.Play();
                    selObj.GetComponent<Knight>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxp>().Delete();
                }
                if (tagetObj.tag == "rook" && tep == true && whitetun == 1)
                {
                    Instantiate(ep, new Vector3(-0.5f, 4.5f, -3.5f), Quaternion.Euler(0, 0, 0));
                    Instantiate(rc, new Vector3(-3, -0.4f, -7.5f), Quaternion.Euler(0, 26, 0));
                    soundObj.GetComponent<SoundMain>().rselsep.Play();
                    rk = true;
                    tep = false;
                    tagetObj.GetComponent<Rook>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "pointmove" && rk == true && whitetun == 1)
                {
                    soundObj.GetComponent<SoundMain>().rmovesep.Play();
                    rk = false;
                    selObj.GetComponent<EpCon>().MoveEp();
                    selObj.GetComponent<Rook>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                    Trunck();
                }
                if (tagetObj.tag == "atbox" && rk == true && whitetun == 1)
                {
                    soundObj.GetComponent<SoundMain>().rmovesep.Play();
                    whitetun *= -1;
                    Trunck();
                    rk = false;
                    soundObj.GetComponent<SoundMain>().rat.Play();
                    soundObj.GetComponent<SoundMain>().ratv.Play();
                    selObj.GetComponent<Rook>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxp>().Delete();
                }
                if (tagetObj.tag == "king" && tep == true && whitetun == 1)
                {
                    Instantiate(ep, new Vector3(-0.5f, 4.5f, -3.5f), Quaternion.Euler(0, 0, 0));
                    Instantiate(kc, new Vector3(-3, -0.4f, -7.5f), Quaternion.Euler(0, 26, 0));
                    soundObj.GetComponent<SoundMain>().kselsep.Play();
                    k = true;
                    tep = false;
                    tagetObj.GetComponent<King>().pOnOff = true;
                    selObj = tagetObj;                    
                }
                if (tagetObj.tag == "lcbox" && k == true && whitetun == 1)
                {
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;
                    selObj.GetComponent<King>().lcas.GetComponent<Rook>().csObj1 = true;                  
                    whitetun *= -1;
                    Trunck();
                    tep = true;
                }
                if (tagetObj.tag == "rcbox" && k == true && whitetun == 1)
                {
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;
                    selObj.GetComponent<King>().rcas.GetComponent<Rook>().csObj = true;                   
                    whitetun *= -1;
                    Trunck();
                    tep = true;
                }
                if (tagetObj.tag == "pointmove" && k == true && whitetun == 1)
                {
                    soundObj.GetComponent<SoundMain>().kmovesep.Play();
                    k = false;
                    selObj.GetComponent<EpCon>().MoveEp();
                    selObj.GetComponent<King>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                    Trunck();
                }
                if (tagetObj.tag == "atbox" && k == true && whitetun == 1)
                {
                    soundObj.GetComponent<SoundMain>().kmovesep.Play();
                    whitetun *= -1;
                    Trunck();
                    k = false;
                    soundObj.GetComponent<SoundMain>().kat.Play();
                    selObj.GetComponent<King>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxp>().Delete();
                }
                if (tagetObj.tag == "Board"|| tagetObj.tag == "wall")
                {
                    soundObj.GetComponent<SoundMain>().beck.Play();
                    pw = false;
                    bs = false;
                    bbs = false;
                    rk = false;
                    q = false;
                    kn = false;
                    k = false;
                    tep = true;
                    ckobjc = true;
                }
                if (tagetObj.tag == "bpawn" && tep == true && whitetun == -1)
                {
                    Instantiate(ep, new Vector3(2,3, 1), Quaternion.Euler(0, 0, 0));
                    Instantiate(pc, new Vector3(3, -0.4f, 3), Quaternion.Euler(0, -140, 0));
                    soundObj.GetComponent<SoundMain>().pselsep.Play();
                    pw = true;
                    tep = false;
                    tagetObj.GetComponent<Bpawn>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && pw == true&&whitetun == -1)
                {
                    soundObj.GetComponent<SoundMain>().pmovesep.Play();
                    pw = false;
                    selObj.GetComponent<EpCon>().MoveEp();
                    selObj.GetComponent<Bpawn>().moveObj = true;
                    tep = true;
                    Trunck();
                    whitetun *= -1;
                }
                if (tagetObj.tag == "atbox" && pw == true && whitetun == -1)
                {
                    soundObj.GetComponent<SoundMain>().pmovesep.Play();
                    whitetun *= -1;
                    Trunck();
                    pw = false;
                    soundObj.GetComponent<SoundMain>().pat.Play();
                    selObj.GetComponent<Bpawn>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
                if (tagetObj.tag == "bbishop" && tep == true && whitetun == -1)
                {
                    Instantiate(ep, new Vector3(2, 3, 1), Quaternion.Euler(0, 0, 0));
                    Instantiate(bc, new Vector3(3, -0.4f, 3), Quaternion.Euler(0, -140, 0));
                    soundObj.GetComponent<SoundMain>().bselsep.Play();
                    bbs = true;
                    tep = false;
                    tagetObj.GetComponent<Bishop>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && bbs == true && whitetun == -1)
                {
                    soundObj.GetComponent<SoundMain>().bmovesep.Play();
                    bbs = false;
                    selObj.GetComponent<EpCon>().MoveEp();
                    selObj.GetComponent<Bishop>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                    Trunck();
                }
                if (tagetObj.tag == "atbox" && bbs == true && whitetun == -1)
                {
                    soundObj.GetComponent<SoundMain>().bmovesep.Play();
                    whitetun *= -1;
                    Trunck();
                    bbs = false;
                    soundObj.GetComponent<SoundMain>().bat.Play();
                    selObj.GetComponent<Bishop>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
                if (tagetObj.tag == "bqueen" && tep == true && whitetun == -1)
                {
                    Instantiate(ep, new Vector3(2, 3, 1), Quaternion.Euler(0, 0, 0));
                    Instantiate(qc, new Vector3(3, -0.4f, 3), Quaternion.Euler(0, -140, 0));
                    soundObj.GetComponent<SoundMain>().qselsep.Play();
                    q = true;
                    tep = false;
                    tagetObj.GetComponent<Queen>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && q == true && whitetun == -1)
                {
                    soundObj.GetComponent<SoundMain>().qmovesep.Play();
                    q = false;
                    selObj.GetComponent<EpCon>().MoveEp();
                    selObj.GetComponent<Queen>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                    Trunck();
                }
                if (tagetObj.tag == "atbox" && q == true && whitetun == -1)
                {
                    soundObj.GetComponent<SoundMain>().qmovesep.Play();
                    whitetun *= -1;
                    q = false;
                    soundObj.GetComponent<SoundMain>().qAt.Play();
                    selObj.GetComponent<Queen>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                    Trunck();
                }
                if (tagetObj.tag == "bknight" && tep == true && whitetun == -1)
                {
                    Instantiate(ep, new Vector3(2, 3, 1), Quaternion.Euler(0, 0, 0));
                    Instantiate(nc, new Vector3(3, -0.4f, 3), Quaternion.Euler(0, -140, 0));
                    soundObj.GetComponent<SoundMain>().nselsep.Play();
                    kn = true;
                    tep = false;
                    tagetObj.GetComponent<Knight>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && kn == true && whitetun == -1)
                {
                    soundObj.GetComponent<SoundMain>().nmovesep.Play();
                    kn = false;
                    selObj.GetComponent<EpCon>().MoveEp();
                    selObj.GetComponent<Knight>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                    Trunck();
                }
                if (tagetObj.tag == "atbox" && kn == true && whitetun == -1)
                {
                    soundObj.GetComponent<SoundMain>().nmovesep.Play();
                    whitetun *= -1;
                    kn = false;
                    soundObj.GetComponent<SoundMain>().nat.Play();
                    selObj.GetComponent<Knight>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                    Trunck();
                }
                if (tagetObj.tag == "brook" && tep == true && whitetun == -1)
                {
                    Instantiate(ep, new Vector3(2, 3, 1), Quaternion.Euler(0, 0, 0));
                    Instantiate(rc, new Vector3(3, -0.4f, 3), Quaternion.Euler(0, -140, 0));
                    soundObj.GetComponent<SoundMain>().rselsep.Play();
                    rk = true;
                    tep = false;
                    tagetObj.GetComponent<Rook>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && rk == true && whitetun == -1)
                {
                    soundObj.GetComponent<SoundMain>().rmovesep.Play();
                    rk = false;
                    selObj.GetComponent<EpCon>().MoveEp();
                    selObj.GetComponent<Rook>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                    Trunck();
                }
                if (tagetObj.tag == "atbox" && rk == true && whitetun == -1)
                {
                    soundObj.GetComponent<SoundMain>().rmovesep.Play();
                    whitetun *= -1;
                    rk = false;
                    soundObj.GetComponent<SoundMain>().rat.Play();
                    soundObj.GetComponent<SoundMain>().ratv.Play();
                    selObj.GetComponent<Rook>().moveObj = true;
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                    Trunck();
                }
                if (tagetObj.tag == "bking" && tep == true && whitetun == -1)
                {
                    Instantiate(ep, new Vector3(2, 3, 1), Quaternion.Euler(0, 0, 0));
                    Instantiate(kc, new Vector3(3, -0.4f, 3), Quaternion.Euler(0, -140, 0));
                    soundObj.GetComponent<SoundMain>().kselsep.Play();
                    k = true;
                    tep = false;
                    tagetObj.GetComponent<King>().pOnOff = true;
                    selObj = tagetObj;
                }
                if (tagetObj.tag == "pointmove" && k == true && whitetun == -1)
                {
                    soundObj.GetComponent<SoundMain>().kmovesep.Play();
                    k = false;
                    selObj.GetComponent<EpCon>().MoveEp();
                    selObj.GetComponent<King>().moveObj = true;
                    tep = true;
                    whitetun *= -1;
                    Trunck();
                }
                if (tagetObj.tag == "lcbox" && k == true && whitetun == -1)
                {
                    soundObj.GetComponent<SoundMain>().kmovesep.Play();
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;
                    selObj.GetComponent<King>().lcas.GetComponent<Rook>().csObj1 = true;                    
                    whitetun *= -1;
                    Trunck();
                    tep = true;
                }
                if (tagetObj.tag == "rcbox" && k == true && whitetun == -1)
                {
                    k = false;
                    selObj.GetComponent<King>().moveObj = true;
                    selObj.GetComponent<King>().rcas.GetComponent<Rook>().csObj = true;                   
                    whitetun *= -1;
                    Trunck();
                    tep = true;
                }
                if (tagetObj.tag == "atbox" && k == true && whitetun == -1)
                {
                    whitetun *= -1;
                    Trunck();
                    k = false;
                    soundObj.GetComponent<SoundMain>().kat.Play();
                    selObj.GetComponent<King>().moveObj = true;                    
                    tep = true;
                    tagetObj.GetComponent<ATboxb>().Delete();
                }
            }
        }        
    }
    public void Drawck()
    {
        if (whitetun == 1)
        {
            Winblack();
        }
        if (whitetun == -1)
        {
            Winwhigt();
        }
    }
    public void Winwhigt()
    {
        soundObj.GetComponent<SoundMain>().win.Play();
        menu.SetActive(false);
        wwin.SetActive(true);
    }
    public void Winblack()
    {
        soundObj.GetComponent<SoundMain>().win.Play();
        menu.SetActive(false);
        bwin.SetActive(true);
    }
    public void Drawtext()
    {
        soundObj.GetComponent<SoundMain>().draw.Play();
        menu.SetActive(false);
        draw.SetActive(true);
    }
    public void MenuText()
    {
        menu.SetActive(true);
    }
    public void MenuTextExit()
    {
        menu.SetActive(false);
    }
    public void Mutesoundon()
    {
        soundObj.SetActive(true);
    }
    public void Mutesoundoff()
    {
        soundObj.SetActive(false);
    }
    public void WQin()
    {
        soundObj.GetComponent<SoundMain>().lv.Play();
        selObj.GetComponent<Pawn>().Qn();
    }
    public void WBin()
    {
        soundObj.GetComponent<SoundMain>().lv.Play();
        selObj.GetComponent<Pawn>().Bs();
    }
    public void WRin()
    {
        soundObj.GetComponent<SoundMain>().lv.Play();
        selObj.GetComponent<Pawn>().Rk();
    }
    public void WNin()
    {
        soundObj.GetComponent<SoundMain>().lv.Play();
        selObj.GetComponent<Pawn>().Nk();
    }
    public void BQin()
    {
        soundObj.GetComponent<SoundMain>().lv.Play();
        selObj.GetComponent<Bpawn>().Qn();
    }
    public void BBin()
    {
        soundObj.GetComponent<SoundMain>().lv.Play();
        selObj.GetComponent<Bpawn>().Bs();
    }
    public void BRin()
    {
        soundObj.GetComponent<SoundMain>().lv.Play();
        selObj.GetComponent<Bpawn>().Rk();
    }
    public void BNin()
    {
        soundObj.GetComponent<SoundMain>().lv.Play();
        selObj.GetComponent<Bpawn>().Nk();
    }
    public void Startbut()
    {
        SceneManager.LoadScene(1);

    }
    public void Exittbut()
    {
        SceneManager.LoadScene(0);
    }
    public void Trunck()
    {
        soundObj.GetComponent<SoundMain>().Tun.Play();
        trun.SetActive(true);
        trun.GetComponent<TweenScale>().PlayForward();
    }
    public void Trunckend()
    {
        trun.GetComponent<TweenScale>().ResetToBeginning();
        trun.SetActive(false);
    }
    public void Logui()
    {
        string wql = wqlog.ToString("N0");
        string wrl = wrlog.ToString("N0");
        string wbl = wblog.ToString("N0");
        string wnl = wnlog.ToString("N0");
        string wpl = wplog.ToString("N0");
        string bql = bqlog.ToString("N0");
        string brl = brlog.ToString("N0");
        string bbl = bblog.ToString("N0");
        string bnl = bnlog.ToString("N0");
        string bpl = bplog.ToString("N0");
        qlogl.text = "Q:" + wql;
        rlogl.text = "R:" + wrl;
        blogl.text = "B:" + wbl;
        nlogl.text = "N:" + wnl;
        plogl.text = "P:" + wpl;
        bqlogl.text = "Q:" + bql;
        brlogl.text = "R:" + brl;
        bblogl.text = "B:" + bbl;
        bnlogl.text = "N:" + bnl;
        bplogl.text = "P:" + bpl;
    }


}
