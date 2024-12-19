using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Users
{
    public Users()
    {
        //預設建構子函式,會hide起來...除非你打出來.
        //但...在Java中,一定要打出來.
    }
    public Users(int Myid, string Myname)
    {
        Id = Myid;
        Name = Myname;
    }
    /*屬性宣告要加底線,設為private模式 */
    /*要存取屬性,要經由存取子函式*/
    /*目的:符合物件導向之物件封裝的特性 */
    private int _Id;
    private string _Name;
    /*
     * //存取子函式
     * 特色: 做為屬性的存取與設定之用.
     * 名字: 一般會跟屬性的名字一樣,但是屬性的宣告會加一個底線:_,
     * 而存取子函式把底線去除
     */
    public int Id //存取子函式
    {
        get { return _Id; }
        set { _Id = value; }
    }
    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

}


/*
 版本一 不封裝,都設public 
public class Users
{
    public Users()
    {
        //預設建構子函式,會hide起來...除非你打出來.
        //但...在Java中,一定要打出來.
    }
    public int Id { get; set; }
    public string Name { get; set; }

}
/*
namespace _20241219_OOP001
{
    internal class Users
    {
    }
}
*/