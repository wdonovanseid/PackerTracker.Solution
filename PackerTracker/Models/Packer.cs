using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Packer
  {
    public string Name { get; set; }
    public string Cost { get; set; }
    public bool Packed { get; set; }
    public int Id { get; }
    public static List<Packer> ListItems = new List<Packer> {};
    
    public Packer(string inputName, string inputCost)
    {
      Name = inputName;
      Cost = inputCost;
      Packed = false;
      ListItems.Add(this);
      Id = ListItems.Count;
    }

    public static List<Packer> GetAll()
    {
      return ListItems;
    }

    public static Packer Find(int searchId)
    {
      return ListItems[(searchId-1)];
    }
    
    public static void ClearAll()
    {
      ListItems.Clear();
    }

  }
}