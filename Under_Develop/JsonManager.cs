using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json; //"Project" -> "Manage NuGet packages" -> "Search for "newtonsoft json". -> click "install"





class NomalJson{
    private Dictionary<String, String> mDiction;
    public NomalJson(String json) {
        this.mDiction = JsonConvert.DeserializeObject<Dictionary<String, String>>(json);
    }
    public String getDataFromKey(string key) {
       return this.mDiction[key];
    }
  }

class ListJson : NomalJson{
    String[] list; 
    public ListJson(String json): base(json) {
    
    }

    public String[] getListFromKeyByNL(String Key) {
        this.list = this.getDataFromKey(Key).Split('\n');
        return this.list;
    }
}
/*
class TestPerson{
    static void Main(){
        String nomalJson = @"{""type"":""Login"",""ID"":""user"",""pw"":""1234""}";
        String friendJson = @"{""friendList"":""우진 친구 1000\n진혁 후배 50"",""Time"":""2018""}";
        NomalJson jm = new NomalJson(nomalJson);
        ListJson lm = new ListJson(friendJson);

        Console.WriteLine(jm.getDataFromKey("ID"));
        Console.WriteLine(jm.getDataFromKey("pw"));

        
        Console.WriteLine("\n\n");
        Console.WriteLine(lm.getDataFromKey("friendList"));
        Console.WriteLine(lm.getDataFromKey("Time"));
        Console.WriteLine(lm.getListFromKeyByNL("friendList")[0]);
        Console.WriteLine(lm.getListFromKeyByNL("friendList")[0].Split(' ')[0]);
    }
}
*/