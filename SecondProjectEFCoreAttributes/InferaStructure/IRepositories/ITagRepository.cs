using SecondProjectEFCoreAttributes.Models;
using System.Collections.Generic;

namespace SecondProjectEFCoreAttributes.InferaStructure.IRepositories
{
    public interface ITagRepository
    {
        List<Tag> GetAll();
        Tag GetById(int id);
        int Insert(Tag tag);
        int Update(Tag tag);
        int Delete(Tag tag);
        int DeleteById(int id);
    }
}
