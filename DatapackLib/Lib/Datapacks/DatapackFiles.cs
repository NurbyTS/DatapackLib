namespace DatapackLib.Lib.Datapacks;

public class DatapackFiles
{
    public class DatapackFile(string name, string content = "")
    {
        private string content = content;

        public string Name => name;
        
        public string Content
        {
            get => content;
            set => content = value;
        }
        
        public void Save(string basePath)
        {
            File.WriteAllText(Path.Combine(basePath, name), content);
        }
    }
    
    public class DatapackFolder(string name)
    {
        public string Name => name;
        private List<DatapackFile> children = new();
        private List<DatapackFolder> subfolders = new();
        
        public void AddFile(DatapackFile file)
        {
            children.Add(file);
        }
        
        public void AddFolder(DatapackFolder folder)
        {
            subfolders.Add(folder);
        }
        
        public DatapackFolder? FindDirectory(string path, string[]? parts = null)
        {
            if (parts == null) parts = path.Split('/');
            if (parts.Length == 0) return this;
            foreach (DatapackFolder folder in subfolders)
            {
                if (folder.Name == parts[0]) return folder.FindDirectory(path, parts[1..]);
            }
            return null;
        }
        
        public void Save(string basePath)
        {
            string currentPath = Path.Combine(basePath, name);
            Directory.CreateDirectory(currentPath);
            foreach (DatapackFile child in children) child.Save(currentPath);
            foreach (DatapackFolder child in subfolders) child.Save(currentPath);
        }
    }

    private DatapackFolder root;

    public DatapackFiles(string rootName)
    {
        root = new DatapackFolder(rootName);
    }
    
    public void AddFile(string directoryPath, string fileName, string content)
    {
        DatapackFolder? directory = root.FindDirectory(directoryPath);
        if (directoryPath == "" && directory == null)
        {
            directory = root;
        }
        
        if (directory != null)
        {
            directory.AddFile(new DatapackFile(fileName, content));
        }
        else
        {
            throw new InvalidOperationException("Directory not found.");
        }
    }
    
    public void AddFolder(string directoryPath, string folderName)
    {
        DatapackFolder? directory = root.FindDirectory(directoryPath);
        if (directoryPath == "" && directory == null)
        {
            directory = root;
        }
        
        if (directory != null)
        {
            directory.AddFolder(new DatapackFolder(folderName));
        }
        else
        {
            throw new InvalidOperationException("Directory not found.");
        }
    }
    
    public void Save(string basePath)
    {
        root.Save(basePath);
    }
}