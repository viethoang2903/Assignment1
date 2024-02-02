using System.Collections.Generic;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
         List<MemberObject> GetAllMembers();

        void AddNewMember(MemberObject NewMember);

        void UpdateMember(MemberObject UpdateMember);

        void DeleteMember(int MemberId);

        MemberObject GetMemberByEmailAndPassword(string email, string password);

        MemberObject GetMemberByID(int MemberId);

        MemberObject getMemberByIdAndName(int MemberId, string MemberName);

         List<MemberObject> FilterListByCityAndCountry(string city, string country);

        List<MemberObject> SortMemberListDescendingName();
    }
}
