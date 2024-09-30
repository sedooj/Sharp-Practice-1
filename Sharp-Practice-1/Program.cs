using ConsoleApp5.file;
using Sharp_Practice_1.render;

List<FileObject> GetFiles()
{
    return new List<FileObject>() {
        new FileObject("kpsnfg", 18515, "true ", "15:17 "),
        new FileObject(";lkadsldsa", 9132, "false", "12:13 "),
        new FileObject("sidnfisnfpn", 15992, "true ", "10:10 "),
        new FileObject("13113           ", 95861, "false", "10:11 "),
        new FileObject("fdsdfdfsfsdfdsa", 19239, "false", "10:12 "),
        new FileObject("daaddasasdsdaasddsa", 1234, "false", "10:13 "),
    };
}

var files = GetFiles();
var viewRenderer = new ViewRenderer(files);
viewRenderer.Render();