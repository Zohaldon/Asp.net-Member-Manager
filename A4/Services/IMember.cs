using A4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4.Services
{
    public interface IMember
    {
        IEnumerable<Member> GetMembers { get; }
        Member GetMember(int Id);
        void Add(Member _member);
        void remove(int Id);

    }
}
