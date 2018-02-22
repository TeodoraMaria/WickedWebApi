namespace WickedWebApi.BL.Models
{
    /// <summary>
    /// The group.
    /// </summary>
    public class GroupDto
    {
        public GroupDto()
        {
        }

        public GroupDto(int id, string name) :this()
        {
            Id = id;
            Name = name;
        }

        public GroupDto(int id, string name, string semiGroup) : this(id, name)
        {
            SemiGroup = semiGroup;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SemiGroup { get; set; }
    }
}
