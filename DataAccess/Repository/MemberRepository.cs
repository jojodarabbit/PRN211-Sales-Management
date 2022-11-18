using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public IEnumerable<MemberObject> GetListMember() => MemberDAO.Instance.GetListMembers();
        public MemberObject GetMemberByID(int memberId) => MemberDAO.Instance.GetMemberByID(memberId);
        public void AddMember(MemberObject member) => MemberDAO.Instance.AddMember(member);
        public void UpdateMember(MemberObject member) => MemberDAO.Instance.UpdateMember(member);
        public void DeleteMember(int memberId) => MemberDAO.Instance.RemoveMember(memberId);
    }
}
