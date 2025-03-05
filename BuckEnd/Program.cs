using BuckEnd.Controler;
using BuckEnd.Model;
using System.Net;
using System.Text;
using System.Text.Json;

HttpListener server = new HttpListener();
server.Prefixes.Add("http://127.0.0.1:8888/connection/");
server.Start();
while (true)
{
    var context = await server.GetContextAsync();
    var body = context.Request.InputStream;
    var method = context.Request.HttpMethod;
    var encoding = context.Request.ContentEncoding;
    var reader = new StreamReader(body, encoding);
    string quary = reader.ReadToEnd();
    string table = context.Request.Headers[0]!;
    Console.WriteLine(quary);
    Console.WriteLine(method);
    Console.WriteLine(table);
    if (method == "POST")
    {
        switch(table)
        {
            case "client": ClientController.AddClient(quary, context);break;
            //case ""
        }
    }
}
server.Stop();