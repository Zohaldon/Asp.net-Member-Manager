using A4.Models;
using A4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4.Repository
{
    public class MemberRepository : IMember
    {
        private AppDbContext db;

        public MemberRepository(AppDbContext _db)
        {
            db = _db;
        }
        public IEnumerable<Member> GetMembers => db.tblMembers;

        public void Add(Member _member)
        {
            db.tblMembers.Add(_member);
            db.SaveChanges();
        }

        public Member GetMember(int Id)
        {
            Member dbEntity = db.tblMembers.Find(Id);
            return dbEntity;
        }

        public void remove(int Id)
        {
            Member dbEntity = db.tblMembers.Find(Id);
            db.tblMembers.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
