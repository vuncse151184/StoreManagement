using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_03_Library.DataAccess;

namespace Assignment_03_Library.Repositories
{
    public interface IMemberRepository
    {
        public IEnumerable<Member> GetMembers();
        public Member CheckLogin(string email, string password);
        public Member GetMemberById(int id);
        public Member GetMemberByEmail(string email);
        public void Add(Member mem);
        public void Update(Member mem);
        public void Delete(int id);
    }
}
