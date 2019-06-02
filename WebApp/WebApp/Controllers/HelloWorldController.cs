using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        //URLが /HelloWorld を参照する
        //Indexはデフォルトを示すための予約関数なので予約語扱い
        /*public string Index()
        {
            return "This is default action";
        }*/

        public IActionResult Index()
        {
            //コントローラーのViewメソッドを呼ぶ
            return View();
        }


        //URLが /HelloWorld の中 /Welcome を参照する
        //考え方としてはHelloWorldクラスのメソッドを呼び出すオブジェクト指向型
        //実際は /コントローラ(クラス) /アクション名(メソッド) /パラメータ
        /*public string Welcome()
        {
            return "This is Welcome method";
        }*/

        //URL /HelloWorld/Welcome?name=Takunology&numtimes=300 を入力するとそれぞれ代入される
        //?は区切り記号、$はクエリ文字列を区切る
        /*public string Welcome(string name, int numTimes = 1)
        {
            //$ を付けると補完文字列になる
            //{変数名}を指定でき、連結する必要がない
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is : {numTimes}");
        }*/

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello, " + name;
            ViewData["NumTimes"] = numTimes;

            //処理内容をViewに返す
            return View();
        }
    }
}