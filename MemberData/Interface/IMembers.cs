using MemberData.Model;

namespace MemberData.Interface
{
    public interface IMembers
    {
        List<Members> GetAllMember();
        Members GetMember(int id);
    }
}
