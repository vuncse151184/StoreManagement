using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Library.DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        public static MemberDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MemberDAO();
                }
                return instance;
            }
        }
        public IEnumerable<Member> GetMembers()
        {
            using var context = new FStoreContext();
            return context.Members.ToList();
        }
        public Member CheckLogin(string email, string password)
        {
            var mem = new Member();
            try
            {
                using var context = new FStoreContext();
                mem = context.Members.Where(mem => mem.Email.Equals(email) && mem.Password.Equals(password)).SingleOrDefault();
                if (mem == null)
                {
                    throw new Exception("Email or Password Wrong!!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return mem;
        }
        public Member GetMemberById(int id)
        {
            Member mem = null;
            try
            {
                using var context = new FStoreContext();
                mem = context.Members.Where(mem => mem.MemberId == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return mem;
        }
        public Member GetMemberByEmail(string email)
        {
            Member mem = null;
            try
            {
                using var context = new FStoreContext();
                mem = context.Members.Where(mem => mem.Email.Equals(email)).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return mem;
        }
        public void Add(Member mem)
        {
            try
            {
                using var context = new FStoreContext();
                Member _mem = GetMemberById(mem.MemberId);
                if (_mem == null)
                {
                    _mem = GetMemberByEmail(mem.Email);
                    if (_mem == null)
                    {
                        context.Members.Add(mem);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("This member email already exist");
                    }
                }
                else
                {
                    throw new Exception("This member already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Member mem)
        {
            try
            {
                Member _member = GetMemberById(mem.MemberId);
                if (_member != null)
                {
                    using var context = new FStoreContext();
                    context.Members.Update(mem);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This member does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                Member _member = GetMemberById(id);
                if (_member != null)
                {
                    using var context = new FStoreContext();
                    context.Members.Remove(_member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This member does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
