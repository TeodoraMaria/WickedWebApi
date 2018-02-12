namespace WickedWebApi.BL.Models
{
    /// <summary>
    /// The group.
    /// </summary>
    public class Group
    {
        public Group(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
