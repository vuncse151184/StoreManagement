using Assignment_03_Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Library.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public void Add(Member mem) => MemberDAO.Instance.Add(mem);

        public Member CheckLogin(string email, string password) => MemberDAO.Instance.CheckLogin(email, password);

        public void Delete(int id) => MemberDAO.Instance.Delete(id);

        public Member GetMemberByEmail(string email) => MemberDAO.Instance.GetMemberByEmail(email);

        public Member GetMemberById(int id) => MemberDAO.Instance.GetMemberById(id);

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMembers();

        public void Update(Member mem) => MemberDAO.Instance.Update(mem);
    }
}
