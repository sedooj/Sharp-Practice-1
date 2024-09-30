namespace ConsoleApp5.file;

public class FileObject : IFile
{
    
    private int MaxNameLength { get => 7; }
    private int MaxSizeTextLength { get => 5; }
    public string Name { get; set; }

    public string Size { get; set; }
    public string IsDirectory { get; set; }
    public string Modification { get; set; }
    
    public FileObject(string name, int size, string isDirectory, string modification)
    {
        this.Name = CorrectFileName(name);
        this.Size = CorrectFileSize(size);
        this.IsDirectory = isDirectory;
        this.Modification = modification;
    }

    private string CorrectFileName(string name)
    {
        string _name = name;
        if (_name.Length >= MaxNameLength)
        {
            _name = _name.Substring(0, MaxNameLength-1) + "...";
        }
        else if (_name.Length < MaxNameLength)
        {
            _name = _name + String.Concat(Enumerable.Repeat(' ', (MaxNameLength - name.Length) + 2));
        }

        if (name.Length < 1)
        {
            _name = "No name";
        }

        return _name;
    }
    
    private string CorrectFileSize(int size)
    {
        string _size = size.ToString().Trim();
        if (_size.Length >= MaxSizeTextLength)
        {
            _size = ">" + _size.Substring(0, MaxSizeTextLength - 1);
        }

        if (_size.Length < MaxSizeTextLength)
        {
            _size = _size + String.Concat(Enumerable.Repeat(' ', MaxSizeTextLength - _size.Length));
        }
        
        return _size;
    }
}   