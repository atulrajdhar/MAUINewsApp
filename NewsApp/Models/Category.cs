namespace NewsApp.Models;
public class Category
{
    public Category(string name, string materialIcon)
    {
        Name = name;
        MaterialIcon = materialIcon;
    }

    public string Name { get; set; }
    public string MaterialIcon {  get; set; }

}
