using System.Reflection.Emit;

namespace ConsoleApp5.file;
public interface IFile
{

    public string Name {get; set;}
    public string Size { get; set; }
    public string IsDirectory { get; set; }
    public string Modification { get; set; }
}