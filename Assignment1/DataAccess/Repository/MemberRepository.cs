using System.Collections.Generic;
using BusinessObject;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private MemberDAo memberDao;

        public MemberRepository()
        {
            memberDao = MemberDAo.Instance;
        }

        public List<MemberObject> GetAllMembers() => memberDao.GetMemberList;

        public void AddNewMember(MemberObject NewMember) => memberDao.AddNewMember(NewMember);

        public void UpdateMember(MemberObject UpdateMember) => memberDao.UpdateMemberInfo(UpdateMember);

        public void DeleteMember(int MemberId) => memberDao.DeleteMemberById(MemberId);

        public MemberObject GetMemberByEmailAndPassword(string MemberEmail, string MemberPassword) =>
            memberDao.GetMemberByEmailAndPassword(MemberEmail, MemberPassword);


        public MemberObject GetMemberByID(int MemberId) => memberDao.GetMemberById(MemberId);
        public MemberObject getMemberByIdAndName(int MemberId, string MemberName) =>
            memberDao.GetMemberByIdAndName(MemberId, MemberName);


        public List<MemberObject> FilterListByCityAndCountry(string city, string country) =>
            memberDao.ListFilterByCityAndCountry(city, country);

        public List<MemberObject> SortMemberListDescendingName() => memberDao.SortMemberListDescendingByName();
    }
}