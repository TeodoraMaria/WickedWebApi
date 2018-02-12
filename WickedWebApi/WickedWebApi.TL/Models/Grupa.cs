namespace WickedWebApi.BL.Models
{
    /// <summary>
    /// The group.
    /// </summary>
    public class Grupa
    {
        public Grupa(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
