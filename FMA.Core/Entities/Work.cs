using FMA.Core.Base;

namespace FMA.Core.Entities;

public class Work : EntityBase<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
}